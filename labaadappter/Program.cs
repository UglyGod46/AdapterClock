using System;


namespace labaadappter
{
    // Target (Целевой интерфейс)
    interface ITime 
    {
        void SetTime(string time);
    }

    // Adaptee (Адаптируемый класс - Часы со стрелками)
    class AnalogClock 
    {
        public void SetHandsRotation(double hourAngle, double minuteAngle) 
        {
            Console.WriteLine($"Установка поворота стрелок - Час: {hourAngle}, Минута: {minuteAngle}");
        }
    }

    // Adaptee (Адаптируемый класс - Цифровые часы)
    class DigitalClock 
    {
        public void DisplayTime(string time) 
        {
            Console.WriteLine($"Отображение времени - {time}");
        }   
    }

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

    // Client (Клиент)
    class Program 
    {
        static void Main() 
        {
            DigitalClock digitalClock = new DigitalClock();
            ClockAdapter adapter = new ClockAdapter(digitalClock);

            // Использование адаптера для установки времени
            adapter.SetTime("10:54");
        }
    }
}