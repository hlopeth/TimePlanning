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

        public GetLoanEvent(int time)
        {
            this.time = time;
        }
        public string getDiscription()
        {
            return "Взять кредит";
        }

        public int GetTime()
        {
            return time;
        }

        public string Invoke(Context state)
        {
            int loans = state.Get("loans");
            state.Set("loans", loans + 1);
            return "Получен кредит";
        }
    }
}
