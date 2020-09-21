using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    class GetMoneyEvent : EventComponent
    {
        public GetMoneyEvent(int planedTime, int moneyAmount)
        {
            this.planedTime = planedTime;
            this.moneyAmount = moneyAmount;
        }
        private readonly int planedTime;
        private readonly int moneyAmount;
        public string getDiscription()
        {
            return "снять " + moneyAmount + "$ со счета";
        }

        public int GetTime()
        {
            return planedTime;
        }

        public string Invoke(Context state)
        {
            int money = state.Get("money");
            if (money >= moneyAmount)
            {
                state.Set("money", money - moneyAmount);
                return "снял " + moneyAmount +"$ со счета";
            }
            else
            {
                return "не смог снять " + moneyAmount +"$ со счета";
            }
        }
    }
}
