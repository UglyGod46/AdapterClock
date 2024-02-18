using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaadappter
{
    // Adaptee (Адаптируемый класс - Цифровые часы)
    class DigitalClock
    {
        public void DisplayTime(string time)
        {
            Console.WriteLine($"Отображение времени - {time}");
        }
    }
}
