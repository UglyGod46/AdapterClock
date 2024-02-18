using System;


namespace labaadappter
{
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