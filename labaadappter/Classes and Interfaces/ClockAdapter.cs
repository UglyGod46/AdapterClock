using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaadappter
{
    // Adapter (Адаптер)
    class ClockAdapter : ITime
    {
        private DigitalClock digitalClock;

        public ClockAdapter(DigitalClock clock)
        {
            this.digitalClock = clock;
        }

        public void SetTime(string time)
        {
            // Преобразование времени в углы поворота стрелок
            string[] parts = time.Split(':');
            int hours = int.Parse(parts[0]);
            int minutes = int.Parse(parts[1]);

            // 30 градусов на час
            double hourAngle = hours * 30;
            // 6 градусов на минуту
            double minuteAngle = minutes * 6;

            // Отображение времени на цифровых часах
            digitalClock.DisplayTime(time);

            // Установка поворота стрелок на часах
            AnalogClock analogClock = new AnalogClock();
            analogClock.SetHandsRotation(hourAngle, minuteAngle);
        }
    }
}
