/* Title:           Return Time String Class
 * Date:            3-13-17
 * Author:          Terry Holmes
 * 
 * Description:     This class will return the string in the correct time format of hours minutes
 *                  and seconds as a string */

 /* Notes:          Time must be sent in as double for seconds */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTimeStringDLL
{
    public class ReturnTimeStringClass
    {
        public string ReturnTime(double douTime)
        {
            int intHours;
            int intMinutes;
            int intSeconds;
            string strHours;
            string strMinutes;
            string strSeconds;

            string strTime = "";

            if (douTime > 3600)
            {
                intHours = Convert.ToInt32(douTime / 3600);

                if (intHours == 0)
                {
                    strHours = "00";
                }
                else if (intHours < 10)
                {
                    strHours = "0" + Convert.ToString(intHours);

                    douTime = douTime - (intHours * 3600);
                }
                else
                {
                    strHours = Convert.ToString(intHours);

                    douTime = douTime - (intHours * 3600);
                }
            }
            else
            {
                strHours = "00";
            }

            intMinutes = Convert.ToInt32(douTime / 60);

            if (intMinutes == 0)
            {
                strMinutes = "00";
            }
            else if (intMinutes < 10)
            {
                strMinutes = "0" + Convert.ToString(intMinutes);

                douTime = douTime - (intMinutes * 60);
            }
            else
            {
                strMinutes = Convert.ToString(intMinutes);

                douTime = douTime - (intMinutes * 60);
            }

            intSeconds = Convert.ToInt32(douTime);

            if (intSeconds < 1)
            {
                strSeconds = "00";
            }
            else if (intSeconds < 10)
            {
                strSeconds = "0" + Convert.ToString(intSeconds);
            }
            else
            {
                strSeconds = Convert.ToString(intSeconds);
            }

            strTime = strHours + ":" + strMinutes + ":" + strSeconds;

            return strTime;
        }
    }
}
