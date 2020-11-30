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
        const string PROBABILITY_GET_MONEY = "probabilityGetMoney";
        const string PROBABILITY_BUY_CLOCK = "probabilityBuyClock";
        const string PROBABILITY_BUY_CAR = "probabilityBuyCar";
        public Form1()
        {
            InitializeComponent();

            Pool buierPool = new Pool(500, 3, new Context());
            Pool clockShopPool = new Pool(500, 3, new Context());
            Pool carShopPool = new Pool(500, 3, new Context());
            Pool bankPool = new Pool(500, 3, new Context());

            pools = new Pool[] { buierPool, clockShopPool, bankPool, carShopPool };

            bankPool.context.Set("money", 1000);
            bankPool.context.Set("loans", 0);

            buierPool.context.Set(PROBABILITY_GET_MONEY, 33);
            buierPool.context.Set(PROBABILITY_BUY_CLOCK, 33);
            buierPool.context.Set(PROBABILITY_BUY_CAR, 33);
            probabilityGetMoney.Value = 33;
            probabilityBuyClock.Value = 33;
            probabilityBuyCar.Value = 33;



            Thread buierThread = new Thread(new ParameterizedThreadStart(processThread));
            Thread clockShopThread = new Thread(new ParameterizedThreadStart(processThread));
            Thread carShopThread = new Thread(new ParameterizedThreadStart(processThread));
            Thread bankThread = new Thread(new ParameterizedThreadStart(processThread));

            timerUI.Interval = 100;
            timerUI.Tick += updateUI;
            timerUI.Start();

            buierThread.Start(buierPool);
            clockShopThread.Start(clockShopPool);
            carShopThread.Start(carShopPool);
            bankThread.Start(bankPool);
        }

        private void updateUI(object sender, EventArgs e)
        { 
            labelBuierTime.Text = BuierPool().Time.ToString();
            labelClockShopTime.Text = ClockShopPool().Time.ToString();
            labelCarShopTime.Text = CarShopPool().Time.ToString();
            labelBankTime.Text = BankPool().Time.ToString();

            BankPool().semaphore.WaitOne();
            labelBankMoney.Text = BankPool().context.Get("money").ToString() + "$";
            labelHasLoan.Text = BankPool().context.Get("loans").ToString();
            BankPool().semaphore.Release();

            showMessages(listBoxBuierMessages, BuierPool());
            showMessages(listBoxClockShopMessages, ClockShopPool());
            showMessages(listBoxCarShopMessages, CarShopPool());
            showMessages(listBoxBankMessages, BankPool());
            showLog(listBoxBuierLog, BuierPool());
            showLog(listBoxClockShopLog, ClockShopPool());
            showLog(listBoxCarShopLog, CarShopPool());
            showLog(listBoxBankLog, BankPool());

            //labelBuierTime.Text = BuierPool().Time.ToString();
            //labelClockShopTime.Text = ClockShopPool().Time.ToString();
            //labelBankTime.Text = BankPool().Time.ToString();
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
            var queue = pool.getEventQueue();
            listBox.Items.Clear();
            foreach(var evt in queue)
            {
                listBox.Items.Add(evt.GetTime().ToString() + " : " + evt.getDiscription());
            }
        }

        private void processThread(object obj)
        {
            Pool pool = obj as Pool;
            int poolIndex = Array.IndexOf<Pool>(pools, pool);

            List<EventComponent> closestEvents = new List<EventComponent>();
            List<int> closestEventsQueueIndices = new List<int>();

            Random rnd = new Random();

            //сохраняем начальное состояние
            pool.SaveState();

            while (pool.Time < pool.endModelTime && !pool.shouldClose)
            {
                if(pool == BuierPool())
                {
                    int probGetMoney = pool.context.Get(PROBABILITY_GET_MONEY);
                    bool getMoney = (rnd.NextDouble() * 100) < probGetMoney;
                    if(getMoney)
                    {
                        sendEvent(
                            pool, 
                            BankPool(), 
                            new GetMoneyEvent(pool.Time + 3, 100, pool, BankPool())
                            );
                    }

                    int probByuClock = pool.context.Get(PROBABILITY_BUY_CLOCK);
                    bool buyClock = (rnd.NextDouble() * 100) < probByuClock;
                    if(buyClock)
                    {
                        sendEvent(
                            pool,
                            ClockShopPool(),
                            new BuyEvent(pool.Time + 5, pool, ClockShopPool(), BankPool())
                            );
                    }

                    int probBuyCar = pool.context.Get(PROBABILITY_BUY_CAR);
                    bool buyCar = (rnd.NextDouble() * 100) < probBuyCar;
                    if(buyCar)
                    {
                        sendEvent(
                            pool,
                            CarShopPool(),
                            new BuyEvent(pool.Time + 5, pool, CarShopPool(), BankPool())
                            );
                    }
                }

                //отрабатываетм текущие сообщения
                pool.ClosestEvent(closestEvents, closestEventsQueueIndices);

                if(closestEvents.Count > 0)
                {
                    pool.SaveState();
                }

                for (int i = 0; i < closestEvents.Count; i++)
                {
                    int queueIndex = closestEventsQueueIndices[i];
                    var closestEvent = closestEvents[i];
                    pool.RemoveEvent(closestEvent);

                    if(pool.Time > closestEvent.GetTime())
                    {
                        pool.RevertToState(closestEvent.GetTime());
                    }
                    pool.Time = closestEvent.GetTime();
                    List<EventComponent> newEvents = new List<EventComponent>();
                    pool.DoEvent(closestEvent, newEvents);
                    foreach(var newEvent in newEvents)
                    {
                        sendEvent(newEvent.GetSender(), newEvent.GetReciver(), newEvent);
                    }
                }
                
                int sleepTime = Convert.ToInt32(rnd.NextDouble() * 1000) + 500;
                Thread.Sleep(sleepTime);
                pool.Time += 1;
            }
        }

        private Pool BuierPool()
        {
            return pools[0];
        }

        private Pool ClockShopPool()
        {
            return pools[1];
        }

        private Pool CarShopPool()
        {
            return pools[3];
        }

        private Pool BankPool()
        {
            return pools[2];
        }

        public static void sendEvent(Pool sender, Pool reciver, EventComponent evt)
        {
            int queueIndex = Array.IndexOf<Pool>(pools, sender);
            reciver.AddEvent(evt);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var pool in pools)
                pool.shouldClose = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var buierPool = BuierPool();
            var bankPool = BankPool();
            int moneyToGet = Convert.ToInt32(probabilityGetMoney.Value);
            int planedTime = buierPool.Time + 2;
            sendEvent(buierPool, bankPool, new GetMoneyEvent(planedTime, moneyToGet, buierPool, bankPool));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int planedTime = ClockShopPool().Time + 10;
            sendEvent(ClockShopPool(), BankPool(), new GetLoanEvent(planedTime, ClockShopPool(), BankPool()));
        }

        private void probabilityGetMoney_ValueChanged(object sender, EventArgs e)
        {
            BuierPool().context.Set(
                PROBABILITY_GET_MONEY,
                Convert.ToInt32(probabilityGetMoney.Value)
                );
        }

        private void probabilityBuyClock_ValueChanged(object sender, EventArgs e)
        {
            BuierPool().context.Set(
                PROBABILITY_BUY_CLOCK,
                Convert.ToInt32(probabilityBuyClock.Value)
                );
        }

        private void probabilityBuyCar_ValueChanged(object sender, EventArgs e)
        {
            BuierPool().context.Set(
                PROBABILITY_BUY_CAR,
                Convert.ToInt32(probabilityBuyCar.Value)
                );
        }
    }
}
