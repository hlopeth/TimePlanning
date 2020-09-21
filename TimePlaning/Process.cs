using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    interface Process
    {
        void SendMessage(EventComponent evt);
    }
}
