using System;
using System.Globalization;

namespace ConsoleApp37
{
    class Program
    {

        static void Main(string[] args)
        {

            Int16 theYear = 0;
            Int16 theMonth = 0;

            switch (args.Length)
            {
                case 0:
                    displayCalendar();
                    break;
                case 1:
                    // show help
                    if (args[0] == "-?" || args[0] == "/?" || args[0] == "?" || args[0] == "-h")
                    {
                        displayUsage();
                    }
                    break;
                case 2:
                    // see if Year is the first parameter
                    if (args[0].Length > 2)
                    {
                        theYear = Convert.ToInt16(args[0]);
                    }
                    else
                    {
                        theYear = Convert.ToInt16(args[1]);
                    }
                    // be realistic
                    if (theYear < 1900 || theYear > 3000)
                    {
                        displayUsage();
                        return;
                    }
                    if (args[0].Length <= 2)
                    {
                        theMonth = Convert.ToInt16(args[0]);
                    }
                    else
                    {
                        theMonth = Convert.ToInt16(args[1]);
                    }
                    // only allow valid months
                    if (theMonth < 1 || theMonth > 12)
                    {
                        displayUsage();
                        return;
                    }
                    displayCalendar(theYear, theMonth);
                    break;
                default:
                    displayUsage();
                    break;
            }
        }

        // help
        private static void displayUsage()
        {
            Console.WriteLine("Console Calendar (c) Copyright 2002 Michael Eaton");
            Console.WriteLine("usage: calendar <year> <month>");
            Console.WriteLine();
            Console.WriteLine("Year must be a 4-digit year.");
            Console.WriteLine("Month must be a number between 1 and 12.");
        }

        // the guts (overloaded methods)
        // default to the current month
        private static void displayCalendar()
        {
            int CurrentYear = DateTime.Today.Year;
            int CurrentMonth = DateTime.Today.Month;
            int CurrentDay = DateTime.Today.Day;
            displayCalendar(CurrentYear, CurrentMonth, CurrentDay);
        }

        private static void displayCalendar(int TheYear, int TheMonth)
        {
            displayCalendar(TheYear, TheMonth, 1);
        }

        private static void displayCalendar(int TheYear, int TheMonth, int TheDay)
        {
            // default to the first of the month
            Int16 FirstDayOfMonth = 1;
            Int32 NumberOfDaysInMonth = DateTime.DaysInMonth(TheYear, TheMonth);
            DateTime FullDateToUse = new DateTime(TheYear, TheMonth, FirstDayOfMonth);

            // this is the day of week we're gonna start with (0-6)
            Int32 StartDay = Convert.ToInt32(FullDateToUse.DayOfWeek);

            // this indicates how much padding we need for
            // the first day of the month.
            Int32 NumberOfTabs = StartDay;

            // this will display the month name and
            // the headings for the days of the week.
            displayHeader(getMonthName(TheMonth), TheYear.ToString(), true);

            // accumulator used so we'll know when to wrap 
            // to the next week.
            //-------------------------------------------------
            int DayOfWeek = StartDay;
            for (int Counter = 2; Counter <= NumberOfDaysInMonth; Counter++)// Ändrade till 2 ist för 1
            {
                string DayString = "";
                // if it's the first day of the month, we'll need
                // padding so we start on the correct "day"
                if (Counter == 2) // Ändrade till 2 ist för 1
                {
                    String Padding = new String('\t', NumberOfTabs);
                    DayString = String.Concat(Padding, Counter.ToString());
                }
                else
                {
                    DayString = Counter.ToString();
                }

                // highlight todays date (using *)
                if (TheDay != 1 && Counter == TheDay)
                {
                    DayString = String.Concat("*", DayString);
                }

                // start a new line only if this isn't the first day
                if (DayOfWeek % 7 == 0 && Counter > 1)
                {
                    DayString = String.Concat("\n", Counter.ToString());
                }

                // separate each day with a tab
                Console.Write("{0}\t", DayString);

                DayOfWeek++;
            }
            // blank line after the calendar has been printed
            Console.WriteLine();
        }
        // ÄNDRA HÄR---------------------------------------------------
        // header for the calendar display
        private static void displayHeader(string theMonthName, string theYear, bool ShowCurrentDate)
        {
            // the Month, year
            string Header = String.Concat(theMonthName, ", ");
            Header = String.Concat(Header, theYear);
            String Days = "M\tT\tW\tTh\tF\tS\tS"; // flttade om här-
            String Divider = new String('-', 55);

            if (ShowCurrentDate)
            {
                Console.WriteLine();
                Console.WriteLine("\t\tToday is {1}/{0}/{2}.", DateTime.Today.Month, DateTime.Today.Day, DateTime.Today.Year);
            }

            Console.WriteLine();
            Console.WriteLine(String.Concat("\t\t", Header));
            Console.WriteLine(Days);
            Console.WriteLine(Divider);
        }

        private static string getMonthName(int theMonth)
        {
            // changes suggested by Brandon Croft.  Much shorter than
            // using the arraylist!
            DateTimeFormatInfo info = new DateTimeFormatInfo();
            string month = info.MonthNames[theMonth - 1];
            return month;
        }
    
    }
}
