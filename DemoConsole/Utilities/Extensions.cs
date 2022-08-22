using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Utilities
{
    public static class Extensions
    {
        /// <summary>
        /// Format Date Time
        /// </summary>
        /// <param name="date"></param>
        /// <param name="dateFormat"></param>
        /// <returns></returns>
        public static string ToCustomDateFormat(this DateTime date, string dateFormat)
        {
            return date.ToString(dateFormat);
        }

        public static string ToMonthString(this DateTime date)
        {
            return date.ToString("MMMM");
        }
        public static int ToMonth(this DateTime date)
        {
            return date.Month;
        }
        public static int ToYear(this DateTime date)
        {
            int year = date.Year;

            return year;
        }
        public static string ToDayName(this DateTime date)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;

            return dayOfWeek.ToString();
        }

        public static DateTime FirstDayOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }

        public static int DaysInMonth(this DateTime value)
        {
            return DateTime.DaysInMonth(value.Year, value.Month);
        }

        public static DateTime LastDayOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.DaysInMonth());
        }

        
    }
}
