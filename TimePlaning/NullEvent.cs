﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    class NullEvent : EventComponent
    {
        private readonly int time;

        public NullEvent(int time)
        {
            this.time = time;
        }

        public string getDiscription()
        {
            return "null event";
        }

        public int GetTime()
        {
            return time;
        }

        public string Invoke(Context state)
        {
            return null;
        }
    }
}
