using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex2H
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            
            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }


            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
                 DateTime date;
            DateTime.TryParse(strDate, out date);
                 result = date.ToShortDateString();
            
            


            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            
            try
            {

                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                TimeSpan timetilldue = (dateB - dateA);
                
                result = timetilldue;
            }
            catch { }


            return result;
        }
    }
}