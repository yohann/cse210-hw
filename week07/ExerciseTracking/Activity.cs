using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _minutes;

        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        protected DateTime GetDate()
        {
            return _date;
        }

        protected int GetMinutes()
        {
            return _minutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}
