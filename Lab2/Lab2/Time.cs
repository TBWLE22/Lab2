using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    public class Time
    {
        public int hr, min, sec;

        public Time Sum(Time t1, Time t2 )
        {
            Time sum = new Time();
            sum.sec = t1.sec + t2.sec;
            sum.min = t1.min + t2.min + sum.sec/60;
            sum.sec %= 60;
            sum.hr = t1.hr + t2.hr + sum.min/60;
            sum.min %= 60;
            sum.hr %= 24;
            return sum;
        }
        public override string ToString()
        {
            return $"{hr:D2}:{min:D2}:{sec:D2}";
        }
    }
}
