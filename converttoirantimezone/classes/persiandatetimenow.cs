using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
    public static class persiandatetimenow
    {
        public static DateTime persiatime(this DateTime value)
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
            //Set the time zone information to iran  Standard Time 
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Iran Standard Time");
            //Get date and time in iran  Standard Time 
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            return dateTime;
        }
    
    }
