using System;
using System.Linq;
/// <summary>
/// This class contains static method to be used to validate date
/// </summary>
public class DateValidator
{
	public DateValidator()
	{
	}

    public static bool validateInput(String y, String m, String d)
    {
        int year;
        int month;
        int date;
        int count = 0;                      //This value counts correct validations
        bool returnValue = false;           //Return purpose
        int[] months = { 2, 4, 6, 9, 11 };  //Array containing months that does not have 31 days

        Int32.TryParse(y, out year);
        Int32.TryParse(m, out month);
        Int32.TryParse(d, out date);
        
        //Year check
        if (year != 0)
        {
            if (year > 1899 && year < 10000)
            {
                count++;
            }
        }

        //Month and date check
        if (month != 0 && date != 0)
        {
            if (months.Contains(month) == false)
            {
                if (date > 0 && date < 32)
                {
                    count++;
                }
            }

            else
            {   
                if (month == 2)
                {
                    if (date > 0 && date < 29)
                    {
                        count++;
                    }
                }

                else
                {
                    if (date > 0 && date < 31)
                    {
                        count++;
                    }
                }
                
            }
        }

        //Only if year, month, date check is valid
        if (count == 2)
        {
            returnValue = true;
        }

        return returnValue;
    }
}
