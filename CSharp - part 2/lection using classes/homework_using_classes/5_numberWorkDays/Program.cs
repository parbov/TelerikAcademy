using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_numberWorkDays
{
    class Program
    {
        static bool CheckHolidays(int month, int day, int[,] holidays)
        {
            for (int m = month; m <= month; m++)
            {
                for (int d = day; d < holidays.GetLength(1); d++)
                {
                    if (month == m && day == d && holidays[m, d] == 1) return true;
                }

            }

            return false;
        }

        static bool CheckDayOfWeek(int year, int month, int day)
        {
            DateTime checkDay = new DateTime(year, month, day);

            int d = (int)checkDay.DayOfWeek;

            if (d > 0 && d < 6) return true;

            return false;
        }

        static int CalcWorkDays(DateTime from, DateTime to, int[,] holidays)
        {
            int workdays = 0;
            int day = from.Day;
            int month = from.Month;
            int year = from.Year;
            int stratDay = day;
            int dayTo = to.Day;
            int monthTo = to.Month;
            int yearTo = to.Year;
            bool endCalc = false;

            for (int m = month; m <= 12; m++)
            {
                int endDay = DateTime.DaysInMonth(year, m);
                for (int d = stratDay; d <= endDay; d++)
                {
                    if (CheckDayOfWeek(year, m, d) == true)
                    {
                        if (CheckHolidays(m, d, holidays) == false) workdays++;
                    }

                    if (d == dayTo && m == monthTo && year == yearTo)
                    {
                        endCalc = true;
                        break;
                    }
                }
                if (endCalc == true) break;
                stratDay = 1;
            }

            return workdays;
        }

        static void Main()
        {
            /*Write a method that calculates the number of workdays between today and given date, passed as parameter.
              Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified
              preliminary as array.*/

            int[,] holidays = new int[13, 32];
            holidays[1, 1] = 1;
            holidays[3, 3] = 1;
            holidays[5, 1] = 1;
            holidays[5, 2] = 1;
            holidays[5, 3] = 1;
            holidays[5, 6] = 1;
            holidays[5, 24] = 1;
            holidays[9, 6] = 1;
            holidays[12, 23] = 1;
            holidays[12, 24] = 1;
            holidays[12, 25] = 1;
            holidays[12, 31] = 1;

            DateTime today = DateTime.Today;
            Console.WriteLine("Workdays between today {0:d} and before 01.01.2014:", today);
            Console.Write("Enter Date to:");
            DateTime endDate = new DateTime(2013, 12, 31);
            DateTime toDate;

            if (DateTime.TryParse(Console.ReadLine(), out toDate) == false || toDate < today || toDate > endDate)
            {
                Console.WriteLine("Invalid date");
                return;
            }

            int day = toDate.Day;
            int month = toDate.Month;
            int year = toDate.Year;

            int workDays = CalcWorkDays(today, toDate, holidays);

            Console.WriteLine("Workdays between {0:d} and {1:d} are: {2}", today, toDate, workDays);
        }
        
    }
}

