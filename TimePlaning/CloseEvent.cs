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

        public int GetTime()
        {
            throw new NotImplementedException();
        }

        public string Invoke(Context state)
        {
            throw new NotImplementedException();
        }
    }
}
