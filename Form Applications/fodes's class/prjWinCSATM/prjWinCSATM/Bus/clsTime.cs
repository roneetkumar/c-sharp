using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCSATM.Bus
{
    class clsTime
    {
        // Declaration of private fields that will store the real value 
        // of our properties.

        private Int16 vHour;
        private Int16 vMinute;
        private Int16 vSecond;

        // Declaration of public "property methods" (getters and setters)
        
        public Int16 Hour
        {
            // Access for reading
            get{
                return vHour;
            }
            // Access for writting
            set{
                if (value < 0 || value > 23)
                {
                    vHour = (Int16)DateTime.Now.Hour;
                } else
                {
                    vHour = value;
                }
            }
        }

        public Int16 Minute
        {
            // Access for reading
            get
            {
                return vMinute;
            }
            // Access for writting
            set
            {
                vMinute = (value >= 0 && value <= 59) ? value : (Int16)DateTime.Now.Minute;
            }


        }

        public Int16 Second
        {
            // Access for reading
            get
            {
                return vSecond;
            }
            // Access for writting
            set
            {
                vSecond = (value >= 0 && value <= 59) ? value : (Int16)DateTime.Now.Second;
            }
        }

        public clsTime()
        {
            this.Hour = -1;
            this.Minute = -1;
            this.Second = -1;
            // Created but not initialized
        }

        public clsTime(Int16 hour, Int16 minute, Int16 second )
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public clsTime(Int16 hour, Int16 minute)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = (Int16)DateTime.Now.Second;
        }

        public clsTime(Int16 hour)
        {
            this.Hour = hour;
            this.Minute = (Int16)DateTime.Now.Minute;
            this.Second = (Int16)DateTime.Now.Second;
        }

        public void SetTime( Int16 hour, Int16 minute, Int16 second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public string ToUniversal()
        {
            return Hour + ":" + Minute + ":" + Second;
        }

        public string ToStandard()
        {
            string ampm;
            Int16 hour;

            ampm = "AM";
            hour = this.Hour;

//            return (hour > 12) ? (hour - 12) + ":" + Minute + ":" + Second + "PM" : (hour) + ":" + Minute + ":" + Second + "AM";
//            return ((hour > 12) ? (hour - 12) : hour ) + ":" + Minute + ":" + Second + ((hour > 12) ? "PM" : "AM" );

            if (hour >= 12)
            {
                ampm = "PM";
                if (hour > 12)
                {
                    hour = (Int16)(hour - 12);
                }
            } else
            {
                if (hour == 0)
                {
                    hour = 12;
                }

            }

            return hour + ":" + Minute + ":" + Second + ampm;
        }


    }
}
