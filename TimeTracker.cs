using System;

namespace TimeTracker
{
    public class TimeTracker
    {

        public Boolean CheckValid(TimeSpan inputTime)
        {
            TimeSpan timeStart = new TimeSpan(8,0,0);
            TimeSpan timeEnd = new TimeSpan(17,0,0);

            if(inputTime >= timeStart) {
                return true;
            }

            if(inputTime <= timeEnd) {
                return true;
            }

            return false;
        }
    }
}
