using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimePlaning
{
    public class Pool
    {
        private List<EventComponent>[] eventQueues;
        public readonly int endModelTime;
        public Context context;
        public Semaphore semaphore;
        private int maxPools;
        public bool shouldClose = false;
        private List<string> log = new List<string>();

        private int _time;
        public int Time { 
            get
            {
                semaphore.WaitOne();
                int res = _time;
                semaphore.Release();
                return res;
            }
            set
            {
                semaphore.WaitOne();
                _time = value;
                semaphore.Release();
            }
        }
        public Pool(int endModelTime, int maxPools, Context context)
        {
            this.semaphore = new Semaphore(1, 1);
            this.endModelTime = endModelTime;
            this.context = context;
            this.maxPools = maxPools;
            this.Time = 0;

            eventQueues = new List<EventComponent>[maxPools];
            for(int i = 0; i < maxPools; i++)
            {
                eventQueues[i] = new List<EventComponent>();
            }
        }

        public bool HasEventOnEachLine()
        {
            bool everioneHasEvents = true;
            semaphore.WaitOne();
            foreach (var eventQueue in eventQueues)
            {
                if (eventQueue.Count() == 0)
                    everioneHasEvents = false;
            }
            semaphore.Release();
            return everioneHasEvents;
        }

        public void RemoveEvent(int queueIndex, EventComponent evt)
        {
            semaphore.WaitOne();
            eventQueues[queueIndex].Remove(evt);
            semaphore.Release();
        }

        public void AddEvent(int queueIndex, EventComponent evt)
        {
            semaphore.WaitOne();
            eventQueues[queueIndex].Add(evt);
            semaphore.Release();
        }

        public List<EventComponent>[] getEventQueues()
        {
            semaphore.WaitOne();
            List<EventComponent>[] result = new List<EventComponent>[maxPools];
            for (int i = 0; i < maxPools; i++)
            {
                result[i] = new List<EventComponent>();
                foreach (var evt in eventQueues[i])
                {
                    result[i].Add(evt);
                }
            }

            semaphore.Release();
            return result;
        }

        public void ClosestEvent(List<EventComponent> oClosestEvents, List<int> oClosestQueueIndices)
        {
            oClosestEvents.Clear();
            oClosestQueueIndices.Clear();
            semaphore.WaitOne();
            EventComponent closestEvent = null;
            //находим ближайший по времени ивент
            for (int i = 0; i < eventQueues.Length; i++)
            {
                if(eventQueues[i].Count == 0)
                {
                    continue;
                }

                EventComponent minEvent = getMinEvent(eventQueues[i]);
                if (closestEvent == null || minEvent.GetTime() < closestEvent.GetTime())
                {
                    closestEvent = minEvent;
                    continue;
                }
            }

            if (closestEvent != null)
            {
                //добавляем ивенты с временен как у ближайшего
                for (int i = 0; i < eventQueues.Length; i++)
                {
                    if (eventQueues[i].Count == 0)
                    {
                        continue;
                    }
                    for (int j = 0; j < eventQueues[i].Count; j++)
                    {
                        if (eventQueues[i][j].GetTime() == closestEvent.GetTime())
                        {
                            oClosestEvents.Add(eventQueues[i][j]);
                            oClosestQueueIndices.Add(i);
                        }
                    }
                }
            }
            semaphore.Release();
        }

        public void DoEvent(EventComponent closestEvent, List<EventComponent> outEvents)
        {
            semaphore.WaitOne();
            var message = closestEvent.Invoke(context, outEvents);
            if(!(closestEvent is NullEvent))
            {
                log.Add(message);
            }
            semaphore.Release();
        }

        public List<String> DumpLog()
        {
            List<String> result = new List<string>();
            semaphore.WaitOne();
            foreach(var line in log)
            {
                result.Add(line);
            }
            log.Clear();
            semaphore.Release();
            return result;
        }

        //гарантируется что arr имеет хотя бы 1 элемент
        private EventComponent getMinEvent(List<EventComponent> arr)
        {
            EventComponent minEvent = arr[0];
            for (int i = 1; i < arr.Count(); i++)
            {
                if (arr[i].GetTime() < minEvent.GetTime())
                {
                    minEvent = arr[i];
                }
            }
            return minEvent;
        }
    }
}
