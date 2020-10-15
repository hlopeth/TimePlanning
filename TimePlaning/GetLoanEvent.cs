using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    class GetLoanEvent : EventComponent
    {
        private readonly int time;
        private readonly Pool sender;
        private readonly Pool reciver;

        public GetLoanEvent(int time, Pool sender, Pool reciver)
        {
            this.time = time;
            this.sender = sender;
            this.reciver = reciver;
        }
        public string getDiscription()
        {
            return "Взять кредит";
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
            return time;
        }

        public string Invoke(Context state, List<EventComponent> outEvents)
        {
            int moneyAmount = 500;
            int loans = state.Get("loans");
            state.Set("loans", loans + 1);

            int money = state.Get("money");
            if (money >= moneyAmount)
            {
                state.Set("money", money - moneyAmount);
                outEvents.Add(new ResponseEvent(time + 1, "успешно снял " + moneyAmount + "$ со счета в кредит", reciver, sender));
                return "снял " + moneyAmount + "$ со счета в кредит";
            }
            else
            {
                outEvents.Add(new ResponseEvent(time + 1, "не смог снять " + moneyAmount + "$ со счета в кредит", reciver, sender));
                return "не смог снять " + moneyAmount + "$ со счета в кредит";
            }

            //return "Получен кредит";
        }
    }
}
