using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    public interface EventComponent
    {
        Pool GetSender();
        Pool GetReciver();
        //через какой промежуток времени запланировать событие.
        int GetTime();
        string getDiscription();
        // выполняет событие, возвращает сообщение для лога
        string Invoke(Context state, List<EventComponent> outEvents);
    }
}
