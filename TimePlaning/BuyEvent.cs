using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    class BuyEvent : EventComponent
    {
        private readonly int planedTime;
        private readonly Pool sender;
        private readonly Pool reciver;
        private readonly Pool bankPool;

        public BuyEvent(int planedTime, Pool sender, Pool reciver, Pool bankPool)
        {
            this.planedTime = planedTime;
            this.sender = sender;
            this.reciver = reciver;
            this.bankPool = bankPool;
        }

        public string getDiscription()
        {
            return "Купить";
        }

        public Pool GetReciver()
        {
            return reciver;
        }

        public Pool GetSender()
        {
            return sender;
        }

        public int GetTime()
        {
            return planedTime;
        }

        public string Invoke(Context state, List<EventComponent> outEvents)
        {
            outEvents.Add(
                new GetLoanEvent(
                    GetTime() + 1,
                    reciver,
                    bankPool
                    ));
            return "попыска взять кредит на покупку";
        }
    }
}
