using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    class GetMoneyEvent : EventComponent
    {
        public GetMoneyEvent(int planedTime, int moneyAmount, Pool sender, Pool reciver)
        {
            this.planedTime = planedTime;
            this.moneyAmount = moneyAmount;
            this.sender = sender;
            this.reciver = reciver;
        }
        private readonly int planedTime;
        private readonly int moneyAmount;
        private readonly Pool sender;
        private readonly Pool reciver;
        public string getDiscription()
        {
            return "снять " + moneyAmount + "$ со счета";
        }

        public int GetTime()
        {
            return planedTime;
        }
        
        public Pool GetSender()
        {
            return sender;
        }

        public Pool GetReciver()
        {
            return reciver;
        }

        public string Invoke(Context state, List<EventComponent> outEvents)
        {
            int money = state.Get("money");
            if (money >= moneyAmount)
            {
                state.Set("money", money - moneyAmount);
                outEvents.Add(new ResponseEvent(planedTime + 1, "успешно снял " + moneyAmount + "$ со счета в кредит", reciver, sender));
                return "снял " + moneyAmount + "$ со счета";
            }
            else
            {
                outEvents.Add(new ResponseEvent(planedTime + 1, "не смог снять " + moneyAmount + "$ со счета в кредит", reciver, sender));
                return "не смог снять " + moneyAmount + "$ со счета";
            }
        }
    }
}
