using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_6
{   /* 2.	Develop a Class to represent the Hiring Date Data: 
⮚	consisting of fields to hold the day, month and Years.
    */
    internal class HiringDate
    {
        private int _day;
        private int _month;
        private int _year;

        public int Day
        {
            get { return _day; }
            set
            {
                if ((value<1)||value>31)
                    throw new ArgumentOutOfRangeException(nameof(Day), "Day must be between 1 and 31.");
                _day= value;

            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if ((value < 1) || value > 12)
                    throw new ArgumentOutOfRangeException(nameof(Month), "Month must be between 1 and 12.");
                _month = value;

            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if ((value < 1980) || value >DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException(nameof(Year), "Year must be between 1980 and DateTime.Now.Year.");
                _year = value;

            }
        }

        public HiringDate()
        {
            _day = DateTime.Now.Day;
            _month = DateTime.Now.Month;
            _year = DateTime.Now.Year;
        }
       
        

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
}
