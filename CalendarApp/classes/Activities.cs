using System;

namespace CalendarApp.classes
{
    // Супер класс для всех видов события.
    public abstract class Activity
    {
        protected Activity(string title, DateTime dateTime)
        {
            Title = title;
            Date = dateTime;
        }

        public abstract string Print(); // Метод для отображения всех переменных события.

        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
    
    //В классе описывается событие-напоминание
    class Remider : Activity
    {
        private TimeSpan time;

        public Remider(string title, DateTime dateTime, TimeSpan time) : base (title, dateTime)
        {
            Time = time;
        }

        public TimeSpan Time
        {
            get { return time; }
            set
            {
                time = value;
                Date = Date.Date + time;
            }
        }

        override public string Print()
        {
            return $@"(Напоминание)         {Date:d}  {Time:hh\:mm}       {Title}";
        }
    }

    //В классе описывается событие-праздник
    class Holiday : Activity
    {
        public Holiday(string title, DateTime dateTime) : base(title, dateTime)
        {

        }

        override public string Print()
        {
            return $@"(Праздник)                {Date:dd.MM}                           {Title}";
        }
    }
}
