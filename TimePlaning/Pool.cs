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
        private List<EventComponent> eventQueue;
        public readonly int endModelTime;
        public Context context;
        public Semaphore semaphore;
        private int maxPools;
        public bool shouldClose = false;
        private List<string> log = new List<string>();
        private Dictionary<int, Context> savedContexts = new Dictionary<int, Context>();
        private List<EventToTime> eventBacklog = new List<EventToTime>();

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

            eventQueue = new List<EventComponent>();
        }
        
        public void RemoveEvent(EventComponent evt)
        {
            semaphore.WaitOne();
            eventQueue.Remove(evt);
            semaphore.Release();
        }

        public void AddEvent(EventComponent evt)
        {
            semaphore.WaitOne();
            eventQueue.Add(evt);
            semaphore.Release();
        }

        public List<EventComponent> getEventQueue()
        {
            semaphore.WaitOne();
            List<EventComponent> result = new List<EventComponent>();
            foreach (var evt in eventQueue)
            {
                result.Add(evt);
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
            closestEvent = getMinEvent(eventQueue);

            if (closestEvent != null)
            {
                //добавляем ивенты с временен как у ближайшего
                for (int i = 0; i < eventQueue.Count; i++)
                {
                    if (eventQueue[i].GetTime() == closestEvent.GetTime())
                    {
                        oClosestEvents.Add(eventQueue[i]);
                        oClosestQueueIndices.Add(i);
                    }
                 
                }
            }
            semaphore.Release();
        }

        internal void SaveState()
        {
            savedContexts[Time] = context.Clone();
        }

        internal void RevertToState(int time)
        {
            log.Add($"Откат ко временни {time}");
            //восстанавливаем контекст
            int maxTime = 0;
            foreach(var row in savedContexts)
            {
                if(row.Key > maxTime && row.Key <= time)
                {
                    maxTime = row.Key;
                }
            }
            context = savedContexts[maxTime];

            int n = savedContexts.Keys.Max();
            for(int i = maxTime + 1; i <= n; i++)
            {
                if(savedContexts.ContainsKey(i))
                    savedContexts.Remove(i);
            }

            //восстанавливаем сообщения
            List<EventToTime> revertedEvents = new List<EventToTime>();
            foreach(var evtToTime in eventBacklog)
            {
                if (evtToTime.time > time)
                    revertedEvents.Add(evtToTime);
            }
            foreach(var revertedEvent in revertedEvents)
            {
                eventBacklog.Remove(revertedEvent);
                AddEvent(revertedEvent.evt);
            }

        }

        public void DoEvent(EventComponent evt, List<EventComponent> outEvents)
        {
            semaphore.WaitOne();
            var message = evt.Invoke(context, outEvents);
            if(!(evt is NullEvent))
            {
                log.Add(message);
            }
            eventBacklog.Add(new EventToTime(_time, evt));
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
            if(arr.Count == 0)
            {
                return null;
            }
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

        private class EventToTime
        {
            public int time;
            public EventComponent evt;

            public EventToTime(int time, EventComponent evt)
            {
                this.time = time;
                this.evt = evt;
            }
        }
    }
}
