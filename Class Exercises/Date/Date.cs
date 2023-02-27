using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatePro
{
    internal class Date
    {
        private int Day; // יום 
        private int Month; // חודש
        private int Year; // שנה

        // פעולה בונה
        public Date(int day, int month, int year)
        {
            if (day < 0 || day > 31)
                throw new ArgumentException("Error, day need to be from 1 to 31");
            this.Day = day;

            if (month < 0 || month > 12)
                throw new ArgumentException("Error, month need to be from 1 to 12");
            this.Month = month;

            if (year < 0 || year.ToString().Length != 4)
                throw new ArgumentException("Error, year need to be positive number and 4 numbers");
            this.Year = year;
        }

        // פעולות מאחזרות
        public int GetYear() { return this.Year; }
        public int GetMonth() { return this.Month; }
        public int GetDay() { return this.Day; }

        // פעולות קובעות
        // note : values need to be checked for valid date values
        public void SetYear(int yearToSet) 
        { 
            if (yearToSet > 0 && yearToSet.ToString().Length == 4)
                this.Year = yearToSet; 
        } 
        public void SetMonth(int monthToSet) 
        { 
            if (monthToSet > 0 && monthToSet <= 12)
                this.Month = monthToSet; 
        } 
        public void SetDay(int dayToSet) 
        { 
            if (dayToSet > 0 && dayToSet <= 31)
                this.Day = dayToSet; 
        }

        public bool Before(Date Other)
        {
            int NowDay = this.Day;
            int NowMonth = this.Month;
            int NowYear = this.Year;

            int NewDay = Other.Day;
            int NewMonth = Other.Month;
            int NewYear = Other.Year;


            // check year
            if (NowYear < NewYear)
                return true;

            if (NowMonth < NewMonth) 
                return true;

            if (NowDay < NewDay) 
                return true;

            return false;
        }

        public override string ToString()
        {
            return String.Format("{0} / {1} / {2}", this.Day, this.Month, this.Year);
        }


    }
}
