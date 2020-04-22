using System;

namespace DateLib
{
    public static class DateUtils
    {
        public static TimeSpan intervalBetweenDateTime(DateTime start, DateTime end)
        {
            if(start > end) {
              throw new ArgumentException("Start Date should be inferior");
            }

            return end.Subtract(start);
        }

        public static string formatWords(TimeSpan timeSpan) {
            int seconds = timeSpan.Seconds;
            int minutes = timeSpan.Minutes;
            int hours = timeSpan.Hours;
            int jours = timeSpan.Days;

            if (jours > 0) {
                return jours + " Days";
            } else if (hours > 0) {
                return hours + " Hours";
            } else if (minutes > 0) {
                return minutes + " Minutes";
            } else {
                return seconds + " Secondes";
            }
        }
    }
}
