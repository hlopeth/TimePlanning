using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimePlaning
{
    public partial class Form1 : Form
    {
        Pool[] pools;
        public Form1()
        {
            InitializeComponent();

            Pool buierPool = new Pool(500, 3, new Context());
            Pool shopPool = new Pool(500, 3, new Context());
            Pool bankPool = new Pool(500, 3, new Context());

            bankPool.context.Set("money", 1000);
            bankPool.context.Set("loans", 0);

            pools = new Pool[] { buierPool, shopPool, bankPool};

            Thread buierThread = new Thread(new ParameterizedThreadStart(processThread));
            Thread shopThread = new Thread(new ParameterizedThreadStart(processThread));
            Thread bankThread = new Thread(new ParameterizedThreadStart(processThread));

            timerUI.Interval = 100;
            timerUI.Tick += updateUI;
            timerUI.Start();

            buierThread.Start(buierPool);
            shopThread.Start(shopPool);
            bankThread.Start(bankPool);
        }

        private void updateUI(object sender, EventArgs e)
        { 
            labelBuierTime.Text = pools[0].Time.ToString();
            labelShopTime.Text = pools[1].Time.ToString();
            labelBankTime.Text = pools[2].Time.ToString();

            pools[2].semaphore.WaitOne();
            labelBankMoney.Text = pools[2].context.Get("money").ToString() + "$";
            labelHasLoan.Text = pools[2].context.Get("loans").ToString();
            pools[2].semaphore.Release();

            showMessages(listBoxBuierMessages, pools[0]);
            showMessages(listBoxShopMessages, pools[1]);
            showMessages(listBoxBankMessages, pools[2]);
            showLog(listBoxBankLog, pools[2]);
        }

        private void showLog(ListBox listBox, Pool pool)
        {
            var log = pool.DumpLog();
            foreach (var line in log)
            {
                listBox.Items.Add(line);
            }
        }

        private void showMessages(ListBox listBox, Pool pool)
        {
            var queues = pool.getEventQueues();
            listBox.Items.Clear();
            foreach (var queue in queues)
            {
                foreach(var evt in queue)
                {
                    listBox.Items.Add(evt.GetTime().ToString() + " : " + evt.getDiscription());
                }
            }
        }

        private void processThread(object obj)
        {
            Pool pool = obj as Pool;
            int poolIndex = Array.IndexOf<Pool>(pools, pool);
            Context context = pool.context;
            const int lookahead = 1;

            List<EventComponent> closestEvents = new List<EventComponent>();
            List<int> closestEventsQueueIndices = new List<int>();

            //отправляем нулевые сообщения что бы показать что мы готовы
            foreach (var otherPool in pools)
            {
                sendEvent(pool, otherPool, new NullEvent(lookahead));
            }

            while (pool.Time < pool.endModelTime && !pool.shouldClose)
            {
                if(!pool.HasEventOnEachLine())
                {
                    continue;
                }

                //отрабатываетм текущие сообщения
                pool.ClosestEvent(closestEvents, closestEventsQueueIndices);
                for (int i = 0; i < closestEvents.Count; i++)
                {
                    int queueIndex = closestEventsQueueIndices[i];
                    var closestEvent = closestEvents[i];
                    pool.RemoveEvent(queueIndex, closestEvent);
                    pool.Time = closestEvent.GetTime();
                    pool.DoEvent(closestEvent);
                }

                //рассылаем нулевые сообщения
                foreach(var otherPool in pools)
                {
                    sendEvent(pool, otherPool, new NullEvent(pool.Time + lookahead));
                }
                Thread.Sleep(1000);
            }
        }

        private void sendEvent(Pool sender, Pool reciver, EventComponent evt)
        {
            int queueIndex = Array.IndexOf<Pool>(pools, sender);
            reciver.AddEvent(queueIndex, evt);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var pool in pools)
                pool.shouldClose = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var buierPool = pools[0];
            var bankPool = pools[2];
            int moneyToGet = Convert.ToInt32(nudMoneyToGet.Value);
            int planedTime = bankPool.Time + 10;
            sendEvent(buierPool, bankPool, new GetMoneyEvent(planedTime, moneyToGet));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var shopPool = pools[1];
            var bankPool = pools[2];
            int planedTime = bankPool.Time + 5;
            sendEvent(shopPool, bankPool, new GetLoanEvent(planedTime));
        }
    }
}
