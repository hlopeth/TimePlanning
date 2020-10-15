using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    class ResponseEvent : EventComponent
    {
        private readonly int time;
        private readonly string message;
        private readonly Pool sender;
        private readonly Pool reciver;
        public ResponseEvent(int time, string message, Pool sender, Pool reciver)
        {
            this.time = time;
            this.message = message;
            this.sender = sender;
            this.reciver = reciver;
        }
        public string getDiscription()
        {
            return "Ответ банка";
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
            return message;
        }
    }
}
