using System.Security.Claims;

namespace Demo
{
    //2.Develop a Class to represent the Hiring Date Data:

    public class HirringDate
    {
        #region Attributes
        public int day;
        public int month;
        public int year; 
        #endregion

        #region Properties
        public int Day
        {
            get { return day; }
            set 
            { 
                day = value > 0 && value <= 31 ? value : 1; 
            }
        }

        public int Month
        {
            get { return month; }
            set 
            { 
                month = value >= 1 && value <= 12 ? value : 1; 
            }
        }

        public int Year
        {
            get { return year; }
            set 
            { 
                year = value >= 2000 && value <= DateTime.Now.Year ? value : 2010; 
            }
        }
        #endregion


        #region Constructor
        public HirringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public HirringDate()
        {
        }
        #endregion

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}