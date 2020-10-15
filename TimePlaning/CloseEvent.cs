using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    class CloseEvent : EventComponent
    {
        public string getDiscription()
        {
            return "close event";
        }

        public Pool GetReciver()
        {
            throw new NotImplementedException();
        }

        public Pool GetSender()
        {
            throw new NotImplementedException();
        }

        public int GetTime()
        {
            throw new NotImplementedException();
        }

        public string Invoke(Context state, List<EventComponent> outEvents)
        {
            throw new NotImplementedException();
        }
    }
}
