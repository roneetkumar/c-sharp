using System;

namespace fodesClass
{
    class clsTime
    {
        private Int16 hour;
        private Int16 second;
        private Int16 minute;


        public short Hour
        {
            get => hour;
            set => hour = (Int16)(value <= 23 && value >= 0 ? value : DateTime.Now.Hour);
        }
        public short Minute
        {
            get => minute;
            set => minute = (Int16)(value <= 59 && value >= 0 ? value : DateTime.Now.Minute);
        }
        public short Second
        {
            get => second;
            set => second = (Int16)(value <= 59 && value >= 0 ? value : DateTime.Now.Second);
        }

        public string ToUniversal()
        {
            return Hour + ":" + Minute + ":" + Second;
        }

        public clsTime(Int16 hour, Int16 minute, Int16 second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public clsTime(Int16 hour, Int16 minute)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public clsTime(Int16 hour)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public clsTime() { }
    }
}
