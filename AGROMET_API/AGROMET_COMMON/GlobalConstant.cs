using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROMET_COMMON
{
    public class GlobalConstant
    {
        public static bool IsDistrictWeather = true;
        public static bool IsBlockWeather = true;
        public static int TimeOutValue = Convert.ToInt32(ConfigurationManager.AppSettings["TimeOutValue"])*60000;//  1800000; // in ms  1000*60*30
        public static int IMDServiceTimeOut = Convert.ToInt32(ConfigurationManager.AppSettings["TimeOutValue"]); //30; // in minutes
        public static bool IsReRunFlow = Convert.ToBoolean(ConfigurationManager.AppSettings["IsReRunFlow"]);
        public static string ReRunDate = Convert.ToString(ConfigurationManager.AppSettings["ReRunDate"]); // yyyy-mm-dd
        public static bool IsEnabledASDCrop = Convert.ToBoolean(ConfigurationManager.AppSettings["IsEnabledASDCrop"]);
        public static bool IsEnabledASDWeather = Convert.ToBoolean(ConfigurationManager.AppSettings["IsEnabledASDWeather"]);
        public static bool IsEnabledVAWeather = Convert.ToBoolean(ConfigurationManager.AppSettings["IsEnabledVAWeather"]);

    }
}
