namespace DemoConsole.Utilities
{
    public class Helper
    {
        public string GetDayName(DateTime date)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;

            return dayOfWeek.ToString();
        }

        public int GetYear(DateTime date)
        {
            int year = date.Year;

            return year;
        }

        public string GetMonthName(DateTime date)
        {
            return date.ToString("MMMM");
        }

        public IEnumerable<DateTime> GetAllDayOfWeekPerMonth(int month, int year, DayOfWeek dayOfWeek)
        {
            var date = new DateTime(year, month, 1);

            if (date.DayOfWeek != dayOfWeek)
            {
                int daysUntilDayOfWeek = ((int)dayOfWeek - (int)date.DayOfWeek + 7) % 7;
                date = date.AddDays(daysUntilDayOfWeek);
            }

            List<DateTime> days = new List<DateTime>();

            while (date.Month == month)
            {
                days.Add(date);
                date = date.AddDays(7);
            }

            return days;
        }
    }
}
