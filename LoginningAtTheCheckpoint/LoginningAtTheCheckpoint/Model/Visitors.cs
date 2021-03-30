using LoggingAtTheCheckpoint.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingAtTheCheckpoint.Model
{
    public static class Visitors        //Класс для хранение списка прошедших через проходную завода
    {
        public static int RecorderNumber = 1;      //Порядковый номер записи в журнале
        public static List<Visitor> visitors = new List<Visitor>();   // список проходящих
    }
}
