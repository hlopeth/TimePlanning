using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    class Pool
    {
        public List<EventComponent>[] eventQueues;
        public readonly int endModelTime;
        public Pool(int endModelTime, int maxPools)
        {
            this.endModelTime = endModelTime;
            eventQueues = new List<EventComponent>[maxPools];
            for(int i = 0; i < maxPools; i++)
            {
                eventQueues[i] = new List<EventComponent>();
            }
        }

        public void ClosestEvent(List<EventComponent> oClosestEvents, List<int> oClosestQueueIndices)
        {
            oClosestEvents.Clear();
            oClosestQueueIndices.Clear();
            EventComponent closestEvent = null;
            //находим ближайший по времени ивент
            for (int i = 0; i < eventQueues.Length; i++)
            {
                if(eventQueues[i].Count < 0)
                {
                    continue;
                }

                EventComponent minEvent = getMinEvent(eventQueues[i]);
                if (closestEvent == null || minEvent.getTime() < closestEvent.getTime())
                {
                    closestEvent = minEvent;
                    continue;
                }
            }

            //добавляем ивенты с временен как у ближайшего
            for(int i = 0; i < eventQueues.Length; i++)
            {
                if (eventQueues[i].Count < 0)
                {
                    continue;
                }
                EventComponent minEvent = getMinEvent(eventQueues[i]);
                if (minEvent.getTime() == closestEvent.getTime())
                {
                    oClosestEvents.Add(minEvent);
                    oClosestQueueIndices.Add(i);
                }
            }
        }

        //гарантируется что arr имеет хотя бы 1 элемент
        private EventComponent getMinEvent(List<EventComponent> arr)
        {
            EventComponent minEvent = arr[0];
            for (int i = 1; i < arr.Count(); i++)
            {
                if (arr[i].getTime() < minEvent.getTime())
                {
                    minEvent = arr[i];
                }
            }
            return minEvent;
        }
    }
}
