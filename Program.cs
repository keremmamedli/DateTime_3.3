using System;

namespace DateTime_3._3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2000, 2, 30); // YYYY/MM/DD 

            int days = DateTime.DaysInMonth(date.Year, date.Month);

            if ((date.Year > 9999) || (date.Year < 1))
            {
                throw new WrongYearException("Year cannot be greater than 9999 or less than 1");
            }

            if ((date.Month > 12) || (date.Month < 1))
            {
                throw new WrongMonthException("Month must be greater than 0 and less than 13");
            }

            if (days == 31)
            {
                if ((date.Day > 31) || (date.Day <= 0))
                {
                    throw new WrongDayException("There are 31 days in this month, and the day must be a positive number");
                }
            }
            else if (days == 30)
            {
                if ((date.Day > 30) || (date.Day <= 0))
                {
                    throw new WrongDayException("There are 30 days in this month, and the day must be a positive number");
                }
            }
            else if (days == 28)
            {
                if ((date.Day > 28) || (date.Day <= 0))
                {
                    throw new WrongDayException("This month is February, and this year has 28 days. The day must be greater than zero and less than 29");
                }
            }
            else if (days == 29)
            {
                if ((date.Day > 29) || (date.Day <= 0))
                {
                    throw new WrongDayException("This month is February, and this year is a leap year with 29 days. The day must be greater than zero and less than 30");
                }
            }

            Console.WriteLine(date);
        }
    }

    public class WrongYearException : Exception
    {
        public WrongYearException(string message) : base(message)
        {
        }
    }

    public class WrongDayException : Exception
    {
        public WrongDayException(string message) : base(message)
        {
        }
    }

    public class WrongMonthException : Exception
    {
        public WrongMonthException(string message) : base(message)
        {
        }
    }
}
