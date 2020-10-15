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
        static Pool[] pools;
        public Form1()
        {
            InitializeComponent();

            Pool buierPool = new Pool(500, 3, new Context());
            Pool shopPool = new Pool(500, 3, new Context());
            Pool bankPool = new Pool(500, 3, new Context());

            bankPool.context.Set("money", 1000);
            bankPool.context.Set("loans", 0);
            buierPool.context.Set("quants", 0);
            shopPool.context.Set("quants", 0);
            bankPool.context.Set("quants", 0);

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
            labelBuierTime.Text = BuierPool().Time.ToString();
            labelShopTime.Text = ShopPool().Time.ToString();
            labelBankTime.Text = BankPool().Time.ToString();

            BankPool().semaphore.WaitOne();
            labelBankMoney.Text = BankPool().context.Get("money").ToString() + "$";
            labelHasLoan.Text = BankPool().context.Get("loans").ToString();
            BankPool().semaphore.Release();

            showMessages(listBoxBuierMessages, BuierPool());
            showMessages(listBoxShopMessages, ShopPool());
            showMessages(listBoxBankMessages, BankPool());
            showLog(listBoxBuierLog, BuierPool());
            showLog(listBoxShopLog, ShopPool());
            showLog(listBoxBankLog, BankPool());
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

            Random rnd = new Random();

            //отправляем нулевые сообщения что бы показать что мы готовы
            foreach (var otherPool in pools)
            {
                sendEvent(pool, otherPool, new NullEvent(lookahead));
            }

            while (pool.Time < pool.endModelTime && !pool.shouldClose)
            {
                var quants = context.Get("quants");
                if (quants == 0)
                {
                    continue;
                }
                context.Set("quants", quants - 1);


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
                    List<EventComponent> newEvents = new List<EventComponent>();
                    pool.DoEvent(closestEvent, newEvents);
                    foreach(var newEvent in newEvents)
                    {
                        sendEvent(newEvent.GetSender(), newEvent.GetReciver(), newEvent);
                    }
                }
                
                //рассылаем нулевые сообщения
                foreach (var otherPool in pools)
                {
                    sendEvent(pool, otherPool, new NullEvent(pool.Time + lookahead));
                }
                int sleepTime = Convert.ToInt32(rnd.NextDouble() * 1000) + 500;
                Thread.Sleep(sleepTime);
            }
        }

        private Pool BuierPool()
        {
            return pools[0];
        }

        private Pool ShopPool()
        {
            return pools[1];
        }

        private Pool BankPool()
        {
            return pools[2];
        }

        public static void sendEvent(Pool sender, Pool reciver, EventComponent evt)
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
            int planedTime = bankPool.Time + 5;
            sendEvent(buierPool, bankPool, new GetMoneyEvent(planedTime, moneyToGet, buierPool, bankPool));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int planedTime = ShopPool().Time + 2;
            sendEvent(ShopPool(), BankPool(), new GetLoanEvent(planedTime, ShopPool(), BankPool()));
        }

        private void button_AddTimeBuier_Click(object sender, EventArgs e)
        {
            var quants = BuierPool().context.Get("quants");
            BuierPool().context.Set("quants", quants + 1);
        }

        private void button_AddTimeShop_Click(object sender, EventArgs e)
        {
            var quants = ShopPool().context.Get("quants");
            ShopPool().context.Set("quants", quants + 1);
        }

        private void button_AddTimeBank_Click(object sender, EventArgs e)
        {

            var quants = BankPool().context.Get("quants");
            BankPool().context.Set("quants", quants + 1);
        }
    }
}
