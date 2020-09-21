using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    interface EventComponent
    {
        //через какой промежуток времени запланировать событие.
        int getTime();
        string getDiscription();
        // выполняет событие, возвращает сообщение для лога
        string invoke(State state);
    }
}
