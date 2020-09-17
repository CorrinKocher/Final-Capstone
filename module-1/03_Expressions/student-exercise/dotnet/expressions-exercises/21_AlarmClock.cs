using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {

        /*
         Given a day of the week encoded as 0=Sun, 1=Mon, 2=Tue, ...6=Sat, and a bool indicating if we are
         on vacation, return a string of the form "7:00" indicating when the alarm clock should ring. Weekdays,
         the alarm should be "7:00" and on the weekend it should be "10:00". Unless we are on vacation -- then
         on weekdays it should be "10:00" and weekends it should be "off".
         AlarmClock(1, false) → "7:00"
         AlarmClock(5, false) → "7:00"
         AlarmClock(0, false) → "10:00"
         */
        public string AlarmClock(int day, bool vacation)
        {
            int sun = 0;
            int mon = 1;
            int tue = 2;
            int wed = 3;
            int thurs = 4;
            int fri = 5;
            int sat = 6;
           

            if(vacation)
            {
                if (day == sat || day == sun)
                {
                    return "off";
                }
                if (day == mon || day == tue || day == wed || day == thurs || day == fri)
                {
                    return "10:00";
                }
            }
            else if (day == sat || day == sun)
            {
                return "10:00";
            }
            if (day == mon || day == tue || day == wed || day == thurs || day == fri)
            {
                return "7:00";
            }
            return "";
        }
        

    }
}
