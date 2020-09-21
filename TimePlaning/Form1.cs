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
        public int time = 0;
        List<EventComponent> eventQueue = new List<EventComponent>();
        Pool[] pools;
        public Form1()
        {
            InitializeComponent();

            Pool buierPool = new Pool(500, 3);
            Pool shopPool = new Pool(500, 3);
            Pool bankPool = new Pool(500, 3);

            pools = new Pool[] { buierPool, shopPool, bankPool};

            Thread buierThread = new Thread(new ParameterizedThreadStart(processThread));
            Thread shopThread = new Thread(new ParameterizedThreadStart(processThread));
            Thread bankThread = new Thread(new ParameterizedThreadStart(processThread));
            buierThread.Start(buierPool);
            shopThread.Start(shopPool);
            bankThread.Start(bankPool);

        }

        

        private void processThread(object obj)
        {
            Pool pool = obj as Pool;
            State state = new State(1000);
            int time = 0;
            const int lookahead = 1;

            List<EventComponent> closestEvents = new List<EventComponent>();
            List<int> closestEventsQueueIndices = new List<int>();

            //отправляем нулевые сообщения что бы показать что мы готовы
            foreach (var otherPool in pools)
            {
                if (otherPool != pool)
                {
                    sendEvent(pool, otherPool, new NullEvent(lookahead));
                }
            }

            while (time < pool.endModelTime)
            {
                bool everioneHasEvents = true;
                foreach(var eventQueue in pool.eventQueues)
                {
                    if (eventQueue.Count() == 0)
                        everioneHasEvents = false;
                }

                if(!everioneHasEvents)
                {
                    continue;
                }

                pool.ClosestEvent(closestEvents, closestEventsQueueIndices);
                for (int i = 0; i < closestEvents.Count; i++)
                {
                    var closestEvent = closestEvents[i];
                    int queueIndex = closestEventsQueueIndices[i];
                    pool.eventQueues[queueIndex].Remove(closestEvent);
                    time = closestEvent.getTime();
                    closestEvent.invoke(state);
                }

                pool.ClosestEvent(closestEvents, closestEventsQueueIndices);

                int nullEventTime = closestEvents.Count() == 0 ? time + lookahead: closestEvents[0].getTime();
                foreach(var otherPool in pools)
                {
                    if(otherPool != pool)
                    {
                        sendEvent(pool, otherPool, new NullEvent(nullEventTime));
                    }
                }
            }
        }

        private void sendEvent(Pool sender, Pool reciver, EventComponent evt)
        {
            int queueIndex = Array.IndexOf<Pool>(pools, sender);
            reciver.eventQueues[queueIndex].Add(evt);
        }


        private void buttonGetMoney_Click(object sender, EventArgs e)
        {
        }

    }

    public class GetMoneyEvent : EventComponent
    {
        public GetMoneyEvent(int planedTime)
        {
            this.planedTime = planedTime;
        }
        private readonly int planedTime;
        public string getDiscription()
        {
            return "снимает деньги";
        }

        public int getTime()
        {
            return planedTime;
        }

        public string invoke(State state)
        {
            if (state.money >= 100)
            {
                state.money -= 100;
                return "снял деньги";
            } else
            {
                return "не смог снять деньги";
            }
        }
    }


}
