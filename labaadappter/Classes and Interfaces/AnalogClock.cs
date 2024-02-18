using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaadappter
{
    // Adaptee (Адаптируемый класс - Часы со стрелками)
    class AnalogClock
    {
        public void SetHandsRotation(double hourAngle, double minuteAngle)
        {
            Console.WriteLine($"Установка поворота стрелок - Час: {hourAngle}, Минута: {minuteAngle}");
        }
    }
}
