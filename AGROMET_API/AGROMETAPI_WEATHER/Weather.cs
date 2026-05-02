using AGROMET_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using AGROMET_COMMON;
using System.Configuration;
using AGROMET_MASTERS;

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static AGROMET_COMMON.Common;

namespace AGROMET_WEATHER
{
    public class WeatherForecastDetails
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; } 
        public int WeatherForecastID { get; set; }
        public int StateID { get; set; }
        public int DistrictID { get; set; }
        public int BlockID { get; set; }
        public int AsdID { get; set; }
        public string Rainfall { get; set; }
        public string TempMax { get; set; }
        public string TempMin { get; set; }
        public string TempAvg { get; set; }
        public string HumidityI { get; set; }
        public string HumidityII { get; set; }
        public string WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public decimal WindDirections { get; set; }
        public decimal? CloudCover { get; set; }
        public string Cloud { get; set; }
        public bool Flag { get; set; }
        public string Createddate { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string BlockName { get; set; }
        public string AsdName { get; set; }
        public string ForeCastDate { get; set; }
        public string KisanDate { get; set; }
        public string ForeCastDate_Web { get; set; }
        public string ForeCastDate_Lang { get; set; }
        public string KisanDate_Lang { get; set; }
        public string Updateddate { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
        public string LanguageType { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsCurrentLocation { get; set; } = false ;
        public bool IsDistrict { get; set; }
        public IEnumerable<AlertDetails> WarningAlert { get; set; }
    }
    public class CountDetails
    {
        public int ID { get; set; }
        public string LanguageType { get; set; }
        public int CropAdvisoryCount { get; set; }
        public int NotificationCount { get; set; }
        public int SurveyCount { get; set; }
        public int UsersCount { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CountResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<CountDetails> ObjCounttwo { get; set; }
        public List<CountDetails> ObjCountone { get; set; }
        public CountDetails ObjCount { get; set; }
        public CountResponse()
        {
            this.ObjCounttwo = new List<CountDetails>();
            this.ObjCountone = new List<CountDetails>();
            this.ObjCount = new CountDetails();
        }
    }

    public class StateMaster
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
        public int ScientistID { get; set; }

    }
    public class GetCurrentLocationResponse
    {
        public int DistrictId { get; set; }
        public int StateId { get; set; }
        public int BlockId { get; set; }
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class WeatherForecast
    {
        public string forecast_date { get; set; }
        public string state_id { get; set; }
        public string state_name { get; set; }
        public string district_id { get; set; }
        public string district_name { get; set; }
        public string block_id { get; set; }
        public string block_name { get; set; }
        public string asd_id { get; set; }
        public string asd_name { get; set; }
        public string rainfall { get; set; }
        public string humidity { get; set; }
        public string humidity2 { get; set; }
        public string temperature_max { get; set; }
        public string temperature_min { get; set; }
        public string wind_speed { get; set; }
        public string wind_direction { get; set; }
        public string cloud_cover { get; set; }
    }

    public class DailyWeather
    {
        public string ForecastDate { get; set; }
        public string STATE_ID { get; set; }
        public string STATE_NAME { get; set; }
        public string DIST_ID { get; set; }
        public string DIST_NAME { get; set; }
        public string BLOCK_ID { get; set; }
        public string BLOCK_NAME { get; set; }
        public string Rainfall { get; set; }
        public string TempMax { get; set; }
        public string TempMin { get; set; }
        public string HumidityI { get; set; }
        public string HumidityII { get; set; }
        public string WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public string CloudCover { get; set; }

        public static DailyWeather FromCsv(string csvLine)
        {
            DailyWeather dailyValues = new DailyWeather();

            try
            {
                string[] values = csvLine.Split(',');
                dailyValues = new DailyWeather
                {
                    ForecastDate = Convert.ToString(values[0]),
                    STATE_ID = Convert.ToString(values[1]),
                    STATE_NAME = Convert.ToString(values[2]),
                    DIST_ID = Convert.ToString(values[3]),
                    DIST_NAME = Convert.ToString(values[4]),
                    BLOCK_ID = Convert.ToString(values[5]),
                    BLOCK_NAME = Convert.ToString(values[6]),
                    Rainfall = Convert.ToString(values[7]),
                    TempMax = Convert.ToString(values[8]),
                    TempMin = Convert.ToString(values[9]),
                    HumidityI = Convert.ToString(values[10]),
                    HumidityII = Convert.ToString(values[11]),
                    WindSpeed = Convert.ToString(values[12]),
                    WindDirection = Convert.ToString(values[13]),
                    CloudCover = Convert.ToString(values[14])
                };
            }
            catch (Exception ex)
            {
                string str = ex.Message.ToString();
            }

            return dailyValues;
        }
    }
    public class DailyWeatherForecast
    {
        public string ForecastDate { get; set; }
        public string ForecastValidity { get; set; }
        public string STATE_ID { get; set; }
        public string STATE_NAME { get; set; }
        public string DIST_ID { get; set; }
        public string DIST_NAME { get; set; }
        public string BLOCK_ID { get; set; }
        public string BLOCK_NAME { get; set; }
        public string Rainfall { get; set; }
        public string TempMax { get; set; }
        public string TempMin { get; set; }
        public string HumidityI { get; set; }
        public string HumidityII { get; set; }
        public string WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public string CloudCover { get; set; }
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static DailyWeatherForecast FromCsvForecast(string csvLine)
        {
            _log.Info("starting FromCsvForecast in weather service");
            DailyWeatherForecast dailyValues = new DailyWeatherForecast();
            try
            {
                string[] values = csvLine.Split(',');
                if (values.Length == 14)
                {
                    dailyValues = new DailyWeatherForecast
                    {
                        ForecastDate = Convert.ToString(values[0]),
                        ForecastValidity = Convert.ToString(values[1]),
                        STATE_ID = Convert.ToString(values[2]),
                        STATE_NAME = Convert.ToString(values[3]),
                        DIST_ID = Convert.ToString(values[4]),
                        DIST_NAME = Convert.ToString(values[5]),
                        Rainfall = Convert.ToString(values[6]),
                        TempMax = Convert.ToString(values[7]),
                        TempMin = Convert.ToString(values[8]),
                        HumidityI = Convert.ToString(values[9]),
                        HumidityII = Convert.ToString(values[10]),
                        WindSpeed = Convert.ToString(values[11]),
                        WindDirection = Convert.ToString(values[12]),
                        CloudCover = Convert.ToString(values[13])
                    };
                }

            }
            catch (Exception ex)
            {
                _log.Error("exception in  FromCsvForecast in weather service : "+ ex.Message);
                string str = ex.Message.ToString();
            }
            _log.Info("ending FromCsvForecast in weather service");
            return dailyValues;
        }
    }

    public class ObservedWeatherDetails
    {
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public string KisanDate { get; set; }
        public string Rainfall { get; set; }
        public string TempMax { get; set; }
        public string TempMin { get; set; }
        public string HumidityMax { get; set; }
        public string HumidityMin { get; set; }
        public string WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public string CloudCover { get; set; }
        public bool Flag { get; set; }
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public string Createddate { get; set; }
    }
    public class AlertDetails
    {
        public string WarningMessage { get; set; }
        public string ColorCode { get; set; }
        public string RecordDate { get; set; }
        public int DistrictId { get; set; }
    }
    public class WeatherForecastDetailsResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<WeatherForecastDetails> ObjWeatherForecastNextList { get; set; }
        public List<WeatherForecastDetails> ObjWeatherForecastPrevList { get; set; }
        public List<WeatherForecastDetails> ObjObservedWeatherList { get; set; }
        public List<WeatherForecast> ObjWeatherForecast { get; set; }
        public List<StateMaster> ObjStateMasterList { get; set; }
        public List<DailyWeather> ObjDailyWeatherList { get; set; }
        public List<DailyWeatherForecast> ObjDailyWeatherForecastList { get; set; }

        public WeatherForecastDetailsResponse()
        {
            ObjWeatherForecastNextList = new List<WeatherForecastDetails>();
            ObjWeatherForecastPrevList = new List<WeatherForecastDetails>();
            ObjDailyWeatherList = new List<DailyWeather>();
            ObjDailyWeatherForecastList = new List<DailyWeatherForecast>();
            ObjObservedWeatherList = new List<WeatherForecastDetails>();
            ObjWeatherForecast = new List<WeatherForecast>();
        }
    }

    public class IMDWeatherResponse
    {
        public string Error { get; set; }
        public string IMDResponse { get; set; }
        public bool IsSuccess { get; set; }
    }
    public class Weather
    {
        public static string storageAccountName = ConfigurationManager.AppSettings["AccountName"].ToString();
        public static string storageAccountKey = ConfigurationManager.AppSettings["AccountKey"].ToString();
        public static string AudioContainerName = ConfigurationManager.AppSettings["AudioContainerName"].ToString();
        public static string GoogleTransalateKey = ConfigurationManager.AppSettings["GoogleTransalateKey"].ToString();

        public static string FORCAST_KEY = ConfigurationManager.AppSettings["FORCAST_KEY"].ToString();
        public static string FORECAST_VA_KEY = ConfigurationManager.AppSettings["FORECAST_VA_KEY"].ToString();
        public static string DW = ConfigurationManager.AppSettings["DW"].ToString();
        public static string BW = ConfigurationManager.AppSettings["BW"].ToString();
        public static string PastWeather = ConfigurationManager.AppSettings["PastWeather"].ToString();
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static WeatherForecastDetailsResponse GetWeatherForecastDetails(WeatherForecastDetails ObjDetails)
        {
            WeatherForecastDetailsResponse response = new WeatherForecastDetailsResponse();
            DataTable dt = new DataTable();
            DataTable dttwo = new DataTable();
            var alertTable = new DataTable();
            DataSet ds = new DataSet();
            LanguageName language;
            Enum.TryParse(ObjDetails.LanguageType, true, out language);
            string code = Common.GetLanguageCode(language);
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {

                new SqlParameter("@pStateID",ObjDetails.StateID),
                new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                new SqlParameter("@pBlockID",ObjDetails.BlockID),
                new SqlParameter("@planguagetype",ObjDetails.LanguageType),
                new SqlParameter("@pAsdID",ObjDetails.AsdID),
                new SqlParameter("@pRefreshdatetime",ObjDetails.RefreshDateTime),

                };

                //dt = SQLHelper.Execute("spGet_WeatherForecastDetails", arrParams);
                ds = SQLHelper.ExecuteMulti("spGet_WeatherForecastDetails", arrParams);
                alertTable = ds.Tables[2];
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    response.ObjWeatherForecastNextList = (from DataRow dr in dt.Rows
                                                           select new WeatherForecastDetails
                                                           {
                                                               StateID = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                                                               StateName = ((dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"])).ToUpper(),
                                                               DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                                                               DistrictName = ((dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"])).ToUpper(),
                                                               BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                                                               BlockName = ((dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"])).ToUpper(),
                                                               AsdID = (dr["AsdID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["AsdID"]),
                                                               AsdName = ((dr["AsdName"]) == DBNull.Value ? "" : Convert.ToString(dr["AsdName"])).ToUpper(),
                                                               Rainfall = ((dr["Rainfall"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Rainfall"])).ToString() + " " + Common.MM(language),// " mm",
                                                               TempMax = ((dr["TempMax"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMax"])).ToString() + "°C",
                                                               TempMin = ((dr["TempMin"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMin"])).ToString() + "°C",
                                                               TempAvg = ((((dr["TempMax"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMax"])) + ((dr["TempMin"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMin"]))) / 2).ToString() + "°C",
                                                               HumidityI = ((dr["HumidityI"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["HumidityI"])).ToString() + "%",
                                                               HumidityII = ((dr["HumidityII"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["HumidityII"])).ToString() + "%",
                                                               WindDirection = ((dr["WindDirection"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["WindDirection"])).ToString() + " deg",
                                                               WindDirections = (dr["WindDirection"]) == DBNull.Value ? 0 : Convert.ToDecimal(dr["WindDirection"]),
                                                               WindSpeed = ((dr["WindSpeed"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["WindSpeed"])).ToString() + " " + Common.KMPH(language),// " kmph",
                                                               CloudCover = (dr["CloudCover"]) == DBNull.Value ? 0 : Convert.ToDecimal(dr["CloudCover"]),
                                                               ForeCastDate = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("yyyy-MM-dd"),
                                                               ForeCastDate_Web = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("ddd dd, MMM"),
                                                               Createddate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Createddate"]),
                                                               Updateddate = (dr["Updateddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Updateddate"]),
                                                               RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),
                                                               ForeCastDate_Lang = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("ddd, dd MMM", new System.Globalization.CultureInfo(code)),
                                                               WarningAlert = (from DataRow dr1 in alertTable.Rows
                                                                               select new AlertDetails
                                                                               {
                                                                                   WarningMessage = ((dr1["WarningMessage"]) == DBNull.Value ? "" : Convert.ToString(dr1["WarningMessage"])),
                                                                                   ColorCode = ((dr1["ColorCode"]) == DBNull.Value ? "" : GetColorHashCode(Convert.ToInt32(dr1["ColorCode"]))),
                                                                                   RecordDate = ((dr1["RecordDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr1["RecordDate"]).ToString("yyyy-MM-dd")),
                                                                               }).Where(e => Convert.ToDateTime(e.RecordDate).ToString("yyyy-MM-dd") == (Convert.ToDateTime(dr["ForeCastDate"]).ToString("yyyy-MM-dd")))//.ToList()

                                                           }).ToList();
                    response.IsSuccessful = true;
                }
                dttwo = ds.Tables[1];
                if (dttwo.Rows.Count > 0)
                {
                    response.ObjWeatherForecastPrevList =
                  (from DataRow dr in dttwo.Rows
                   select new WeatherForecastDetails
                   {
                       StateID = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                       StateName = ((dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"])).ToUpper(),
                       DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                       DistrictName = ((dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"])).ToUpper(),
                       BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                       BlockName = ((dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"])).ToUpper(),
                       Rainfall = (dr["Rainfall"]) == DBNull.Value ? "" : Convert.ToString(dr["Rainfall"]) + " " + Common.MM(language),//" mm",
                       TempMax = ((dr["TempMax"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMax"])).ToString() + " C",
                       TempMin = ((dr["TempMin"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMin"])).ToString() + " C",
                       TempAvg = ((((dr["TempMax"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMax"])) + ((dr["TempMin"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMin"]))) / 2).ToString() + " C",
                       HumidityI = ((dr["HumidityI"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["HumidityI"])).ToString() + "%",
                       HumidityII = ((dr["HumidityII"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["HumidityII"])).ToString() + "%",
                       WindDirection = (dr["WindDirection"]) == DBNull.Value ? "" : Convert.ToString(dr["WindDirection"]) + " deg",
                       WindDirections = (dr["WindDirection"]) == DBNull.Value ? 0 : Convert.ToDecimal(dr["WindDirection"]),
                       WindSpeed = (dr["WindSpeed"]) == DBNull.Value ? "" : Convert.ToString(dr["WindSpeed"]) + " " + Common.KMPH(language),//" kmph",
                       CloudCover = (dr["CloudCover"]) == DBNull.Value ? 0 : Convert.ToDecimal(dr["CloudCover"]),
                       ForeCastDate = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("yyyy-MM-dd"),
                       ForeCastDate_Web = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("ddd dd, MMM"),
                       Createddate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Createddate"]),
                       Updateddate = (dr["Updateddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Updateddate"]),
                       RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),
                       ForeCastDate_Lang = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("dddd, dd MMM", new System.Globalization.CultureInfo(code)),

                   }).ToList();
                    response.IsSuccessful = true;
                }
                //response.ObjWeatherForecastPrevList.Reverse();
                if (response.ObjWeatherForecastNextList.Count > 0)
                {
                    for (int i = 0; i < response.ObjWeatherForecastNextList.Count; i++)
                    {
                        if (response.ObjWeatherForecastNextList[i].CloudCover == 0)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.ClearSky(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover >= 1 && response.ObjWeatherForecastNextList[i].CloudCover <= 2)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.MainlyClear(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover >= 3 && response.ObjWeatherForecastNextList[i].CloudCover <= 4)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.PartlyCloudy(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover >= 5 && response.ObjWeatherForecastNextList[i].CloudCover <= 7)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.GenerallyCloudy(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover > 7)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.Cloudy(language);
                    }
                }
                if (response.ObjWeatherForecastPrevList.Count > 0)
                {
                    for (int i = 0; i < response.ObjWeatherForecastPrevList.Count; i++)
                    {
                        if (response.ObjWeatherForecastPrevList[i].CloudCover == 0)
                            response.ObjWeatherForecastPrevList[i].Cloud = Common.ClearSky(language);
                        if (response.ObjWeatherForecastPrevList[i].CloudCover >= 1 && response.ObjWeatherForecastPrevList[i].CloudCover <= 2)
                            response.ObjWeatherForecastPrevList[i].Cloud = Common.MainlyClear(language);
                        if (response.ObjWeatherForecastPrevList[i].CloudCover >= 3 && response.ObjWeatherForecastPrevList[i].CloudCover <= 4)
                            response.ObjWeatherForecastPrevList[i].Cloud = Common.PartlyCloudy(language);
                        if (response.ObjWeatherForecastPrevList[i].CloudCover >= 5 && response.ObjWeatherForecastPrevList[i].CloudCover <= 7)
                            response.ObjWeatherForecastPrevList[i].Cloud = Common.GenerallyCloudy(language);
                        if (response.ObjWeatherForecastPrevList[i].CloudCover > 7)
                            response.ObjWeatherForecastPrevList[i].Cloud = Common.Cloudy(language);
                    }
                }
                //if (response.ObjWeatherForecastPrevList.Count > 0)
                //{
                //    for (int i = 0; i < response.ObjWeatherForecastPrevList.Count; i++)
                //    {
                //        response.ObjWeatherForecastPrevList[i].TempAvg = (response.ObjWeatherForecastPrevList[i].TempMax + response.ObjWeatherForecastPrevList[i].TempMin) / 2;
                //        response.ObjWeatherForecastPrevList[i].ForeCastDate_Lang = Convert.ToDateTime(response.ObjWeatherForecastPrevList[i].ForeCastDate).ToString("ddd, dd MMM", new System.Globalization.CultureInfo(code));
                //    }
                //}
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public static WeatherForecastDetailsResponse GetWeatherForecastDetailsByLocation(WeatherForecastDetails ObjDetails)
        {
            WeatherForecastDetailsResponse response = new WeatherForecastDetailsResponse();
            var weatherTable = new DataTable();
            var alertTable = new DataTable();
            DataSet ds = new DataSet();
            LanguageName language;
            Enum.TryParse(ObjDetails.LanguageType, true, out language);
            string code = Common.GetLanguageCode(language);

            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {

                new SqlParameter("@pUserProfileID",ObjDetails.Id),
                new SqlParameter("@planguagetype",ObjDetails.LanguageType),
                new SqlParameter("@pRefreshdatetime",ObjDetails.RefreshDateTime),

                };

                ds = SQLHelper.ExecuteMulti("spGet_WeatherForecastDetailsForMobile", arrParams);
                weatherTable = ds.Tables[0];
                //alertTable = ds.Tables[1];
                if (weatherTable.Rows.Count > 0)
                {
                    List<WeatherForecastDetails> weatherForecastDetails = new List<WeatherForecastDetails>();
                    weatherForecastDetails = (from DataRow dr in weatherTable.Rows
                                                           select new WeatherForecastDetails
                                                           {
                                                               WeatherForecastID = (dr["WeatherForecastID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["WeatherForecastID"]),
                                                               StateID = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                                                               StateName = ((dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"])).ToUpper(),
                                                               DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                                                               DistrictName = ((dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"])).ToUpper(),
                                                               BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                                                               BlockName = ((dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"])).ToUpper(),
                                                               AsdID = (dr["AsdID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["AsdID"]),
                                                               AsdName = ((dr["AsdName"]) == DBNull.Value ? "" : Convert.ToString(dr["AsdName"])).ToUpper(),
                                                               Rainfall = ((dr["Rainfall"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Rainfall"])).ToString() + " " + Common.MM(language),//" mm",
                                                               TempMax = ((dr["TempMax"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMax"])).ToString() + "°C",
                                                               TempMin = ((dr["TempMin"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMin"])).ToString() + "°C",
                                                               TempAvg = ((((dr["TempMax"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMax"])) + ((dr["TempMin"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMin"]))) / 2).ToString() + "°C",
                                                               HumidityI = ((dr["HumidityI"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["HumidityI"])).ToString() + "%",
                                                               HumidityII = ((dr["HumidityII"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["HumidityII"])).ToString() + "%",
                                                               WindDirection = ((dr["WindDirection"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["WindDirection"])).ToString() + " deg",
                                                               WindDirections = (dr["WindDirection"]) == DBNull.Value ? 0 : Convert.ToDecimal(dr["WindDirection"]),
                                                               WindSpeed = ((dr["WindSpeed"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["WindSpeed"])).ToString() + " " + Common.KMPH(language),//" kmph",
                                                               CloudCover = (dr["CloudCover"]) == DBNull.Value ? 0 : Convert.ToDecimal(dr["CloudCover"]),
                                                               ForeCastDate = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("yyyy-MM-dd"),
                                                               ForeCastDate_Web = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("ddd dd, MMM"),
                                                               Createddate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Createddate"]),
                                                               Updateddate = (dr["Updateddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Updateddate"]),
                                                               RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),                                                               
                                                               ForeCastDate_Lang = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("ddd, dd MMM", new System.Globalization.CultureInfo(code)),
                                                               IsDistrict = (dr["IsDistrict"]) == DBNull.Value ? false : Convert.ToBoolean(dr["IsDistrict"])
                                                               //WarningAlert = (from DataRow dr1 in alertTable.Rows
                                                               //                select new AlertDetails
                                                               //                {
                                                               //                    WarningMessage = ((dr1["WarningMessage"]) == DBNull.Value ? "" : Convert.ToString(dr1["WarningMessage"])),
                                                               //                    ColorCode = ((dr1["ColorCode"]) == DBNull.Value ? "" : GetColorHashCode(Convert.ToInt32(dr1["ColorCode"]))),
                                                               //                    DistrictId = ((dr1["DistrictId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr1["DistrictId"])),
                                                               //                    RecordDate = ((dr1["RecordDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr1["RecordDate"]).ToString("yyyy-MM-dd")),
                                                               //                }).Where(e => e.DistrictId == Convert.ToInt32(dr["DistrictID"]))//.ToList()

                                                           }).ToList();

                    if (!string.IsNullOrEmpty(ObjDetails.Longitude) && !String.IsNullOrEmpty(ObjDetails.Latitude))
                    {
                        var currentLocationDetails = GetCurrentLocationDetails(ObjDetails.Latitude, ObjDetails.Longitude);
                        if (currentLocationDetails.StateId != 0 && currentLocationDetails.StateId != 0)
                        {
                            WeatherForecastDetails details = new WeatherForecastDetails()
                            {
                                StateID = currentLocationDetails.StateId,
                                DistrictID = currentLocationDetails.DistrictId,
                                BlockID = currentLocationDetails.BlockId,
                                LanguageType = ObjDetails.LanguageType,
                                RefreshDateTime = ObjDetails.RefreshDateTime
                            };

                            var currentlocationForecaseDetails = GetTodayWeather(details);
                            if (currentlocationForecaseDetails.ObjWeatherForecastNextList != null && currentlocationForecaseDetails.ObjWeatherForecastNextList.Count() > 0)
                            {
                                currentlocationForecaseDetails.ObjWeatherForecastNextList.ForEach(s => { s.IsCurrentLocation = true; });
                                weatherForecastDetails.AddRange(currentlocationForecaseDetails.ObjWeatherForecastNextList);
                            }
                        }
                    }
                    response.ObjWeatherForecastNextList = weatherForecastDetails.OrderByDescending(w => w.IsCurrentLocation).ToList();

                    response.IsSuccessful = true;
                }
                if (response.ObjWeatherForecastNextList.Count > 0)
                {
                    for (int i = 0; i < response.ObjWeatherForecastNextList.Count; i++)
                    {
                        if (response.ObjWeatherForecastNextList[i].CloudCover == 0)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.ClearSky(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover >= 1 && response.ObjWeatherForecastNextList[i].CloudCover <= 2)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.MainlyClear(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover >= 3 && response.ObjWeatherForecastNextList[i].CloudCover <= 4)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.PartlyCloudy(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover >= 5 && response.ObjWeatherForecastNextList[i].CloudCover <= 7)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.GenerallyCloudy(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover > 7)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.Cloudy(language);
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public static WeatherForecastDetailsResponse GetTodayWeather(WeatherForecastDetails ObjDetails)
        {
            WeatherForecastDetailsResponse response = new WeatherForecastDetailsResponse();
            var weatherTable = new DataTable();
            var alertTable = new DataTable();
            DataSet ds = new DataSet();
            LanguageName language;
            Enum.TryParse(ObjDetails.LanguageType, true, out language);
            string code = Common.GetLanguageCode(language);
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pStateName",ObjDetails.StateName),
                    new SqlParameter("@pDistrictName",ObjDetails.DistrictName),
                    new SqlParameter("@pBlockName",""),
                    new SqlParameter("@pStateID",ObjDetails.StateID),
                    new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                    new SqlParameter("@pBlockID",ObjDetails.BlockID),
                    new SqlParameter("@pAsdID",ObjDetails.AsdID),
                    new SqlParameter("@pAsdName",ObjDetails.AsdName),
                    new SqlParameter("@planguagetype",ObjDetails.LanguageType),
                    new SqlParameter("@pRefreshdatetime",ObjDetails.RefreshDateTime),
                };

                ds = SQLHelper.ExecuteMulti("spGet_WeatherDetailsForTodayDate", arrParams);
                weatherTable = ds.Tables[0];
                alertTable = ds.Tables[1];
                if (weatherTable.Rows.Count > 0)
                {
                    response.ObjWeatherForecastNextList = (from DataRow dr in weatherTable.Rows
                                                           select new WeatherForecastDetails
                                                           {
                                                               //WeatherForecastID = (dr["WeatherForecastID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["WeatherForecastID"]),
                                                               StateID = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                                                               StateName = ((dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"])).ToUpper(),
                                                               DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                                                               DistrictName = ((dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"])).ToUpper(),
                                                               BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                                                               BlockName = ((dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"])).ToUpper(),
                                                               AsdID = (dr["AsdID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["AsdID"]),
                                                               AsdName = ((dr["AsdName"]) == DBNull.Value ? "" : Convert.ToString(dr["AsdName"])).ToUpper(),
                                                               Rainfall = ((dr["Rainfall"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Rainfall"])).ToString() + " " + Common.MM(language),// " mm",
                                                               TempMax = ((dr["TempMax"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMax"])).ToString() + "°C",
                                                               TempMin = ((dr["TempMin"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMin"])).ToString() + "°C",
                                                               TempAvg = ((((dr["TempMax"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMax"])) + ((dr["TempMin"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMin"]))) / 2).ToString() + "°C",
                                                               HumidityI = ((dr["HumidityI"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["HumidityI"])).ToString() + "%",
                                                               HumidityII = ((dr["HumidityII"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["HumidityII"])).ToString() + "%",
                                                               WindDirection = ((dr["WindDirection"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["WindDirection"])).ToString() + " deg",
                                                               WindDirections = (dr["WindDirection"]) == DBNull.Value ? 0 : Convert.ToDecimal(dr["WindDirection"]),
                                                               WindSpeed = ((dr["WindSpeed"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["WindSpeed"])).ToString() + " " + Common.KMPH(language), // " kmph",
                                                               CloudCover = (dr["CloudCover"]) == DBNull.Value ? 0 : Convert.ToDecimal(dr["CloudCover"]),
                                                               ForeCastDate = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("yyyy-MM-dd"),
                                                               ForeCastDate_Web = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("ddd dd, MMM"),
                                                               Createddate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Createddate"]),
                                                               Updateddate = (dr["Updateddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Updateddate"]),
                                                               RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),                                                               
                                                               ForeCastDate_Lang = (dr["ForeCastDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["ForeCastDate"]).ToString("dddd, dd MMM", new System.Globalization.CultureInfo(code)),
                                                               WarningAlert = (from DataRow dr1 in alertTable.Rows
                                                                               select new AlertDetails
                                                                               {
                                                                                   WarningMessage = ((dr1["WarningMessage"]) == DBNull.Value ? "" : Convert.ToString(dr1["WarningMessage"])),
                                                                                   ColorCode = ((dr1["ColorCode"]) == DBNull.Value ? "" : GetColorHashCode(Convert.ToInt32(dr1["ColorCode"]))),
                                                                                   DistrictId = ((dr1["DistrictId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr1["DistrictId"])),
                                                                                   RecordDate = ((dr1["RecordDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr1["RecordDate"]).ToString("yyyy-MM-dd")),
                                                                               }).Where(e => e.DistrictId == Convert.ToInt32(dr["DistrictID"]))//.ToList()

                                                           }).ToList();
                    response.IsSuccessful = true;
                }
                if (response.ObjWeatherForecastNextList.Count > 0)
                {
                    for (int i = 0; i < response.ObjWeatherForecastNextList.Count; i++)
                    {
                        if (response.ObjWeatherForecastNextList[i].CloudCover == 0)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.ClearSky(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover >= 1 && response.ObjWeatherForecastNextList[i].CloudCover <= 2)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.MainlyClear(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover >= 3 && response.ObjWeatherForecastNextList[i].CloudCover <= 4)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.PartlyCloudy(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover >= 5 && response.ObjWeatherForecastNextList[i].CloudCover <= 7)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.GenerallyCloudy(language);
                        if (response.ObjWeatherForecastNextList[i].CloudCover > 7)
                            response.ObjWeatherForecastNextList[i].Cloud = Common.Cloudy(language);
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public static CountResponse GetCountDetails(CountDetails objCount)
        {
            DataTable dt = new DataTable();
            DataTable dttwo = new DataTable();
            DataTable dtthree = new DataTable();
            DataSet ds = new DataSet();
            CountResponse response = new CountResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pID", objCount.ID),
                new SqlParameter("@planguagetype", objCount.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCount.RefreshDateTime),
                };
                ds = SQLHelper.ExecuteMulti("spGet_CountDetails", arrParams);
                dt = ds.Tables[0];
                dttwo = ds.Tables[1];
                dtthree = ds.Tables[2];
                if (dt.Rows.Count > 0)
                {
                    response.ObjCount.CropAdvisoryCount = Convert.ToInt32(dt.Rows[0][0]);
                }
                if (dttwo.Rows.Count > 0)
                {
                    response.ObjCount.NotificationCount = Convert.ToInt32(dttwo.Rows[0][0]);
                }
                if (dtthree.Rows.Count > 0)
                {
                    response.ObjCount.UsersCount = Convert.ToInt32(dtthree.Rows[0][0]);
                }
                response.ObjCount.SurveyCount = 0;
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }

        public static WeatherForecastDetailsResponse GetWeatherFromIMD()
        {
            #region Log Start

            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            WeatherForecastDetailsResponse response = new WeatherForecastDetailsResponse();
            WebClient client = new WebClient();
            TransactionDetails transactionResponse = new TransactionDetails();
            string uniqueFileName = "";
            string paths = "";
            string uniqueForecastFileName = "";
            string ForecastPaths = "";
            try
            {
                if (GlobalConstant.IsBlockWeather)
                {
                    _log.Info("Callid : " + callId + " started execution of block weather section in GetWeatherFromIMD in weather service");
                    uniqueFileName = string.Format("{0}{1}{2}{3}", DateTime.Parse(DateTime.Now.ToString()).Year.ToString(), DateTime.Now.Month.ToString().PadLeft(2, '0'), DateTime.Now.Day.ToString().PadLeft(2, '0'), ".csv");
                    paths = System.Web.HttpContext.Current.Server.MapPath(Path.Combine("~/App_Data/", uniqueFileName));
                    client = new WebClient();
                    client.DownloadFile(BW, @paths);
                    List<DailyWeather> objDailyWeatherList = File.ReadAllLines(@paths).Skip(1).Select(v => DailyWeather.FromCsv(v)).ToList();
                    File.Delete(@paths);
                    response.ObjDailyWeatherList = objDailyWeatherList;
                    if (response.ObjDailyWeatherList.Count > 0)
                    {
                        foreach (DailyWeather item in response.ObjDailyWeatherList)
                        {
                            if (item.BLOCK_ID != null)
                            {
                                SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pForecastDate",item.ForecastDate),
                                        new SqlParameter("@pForecastValidity",""),
                                        new SqlParameter("@pSTATE_ID",item.STATE_ID),
                                        new SqlParameter("@pDIST_ID", item.DIST_ID),
                                        new SqlParameter("@pBLOCK_ID", item.BLOCK_ID),
                                        new SqlParameter("@pRainfall_mm",item.Rainfall),
                                        new SqlParameter("@pTempMax_degC",item.TempMax),
                                        new SqlParameter("@pTempMin_degC",item.TempMin),
                                        new SqlParameter("@pHumidityI",item.HumidityI),
                                        new SqlParameter("@pHumidityII",item.HumidityII),
                                        new SqlParameter("@pWindSpeed_ms",item.WindSpeed),
                                        new SqlParameter("@pWindDirection_deg",item.WindDirection),
                                        new SqlParameter("@pCloudCover_octa",item.CloudCover),
                                        };
                                transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_BlockWiseWeatherForecasteDetails", arrParams);
                            }


                        }

                    }
                    _log.Info("Callid : " + callId + " ended execution of block weather section in GetWeatherFromIMD in weather service");
                }
                if (GlobalConstant.IsDistrictWeather)
                {
                    _log.Info("Callid : " + callId + " started execution of district weather section in GetWeatherFromIMD in weather service");
                    uniqueForecastFileName = string.Format("{0}{1}{2}{3}", DateTime.Parse(DateTime.Now.ToString()).Year.ToString(), DateTime.Now.Month.ToString().PadLeft(2, '0'), DateTime.Now.Day.ToString().PadLeft(2, '0'), ".csv");
                    ForecastPaths = System.Web.HttpContext.Current.Server.MapPath(Path.Combine("~/App_Data/", uniqueForecastFileName));
                    client = new WebClient();
                    var objDailyWeatherForecastList = new List<DailyWeatherForecast>();
                    try
                    {
                        _log.Info("Callid : " + callId + " downloading file from DW in GetWeatherFromIMD in weather service");
                        client.DownloadFile(DW, @ForecastPaths);
                        _log.Info("Callid : " + callId + " downloading complete file from DW in GetWeatherFromIMD in weather service");
                        _log.Info("Callid : " + callId + " reading csv file from DW in GetWeatherFromIMD in weather service");
                        objDailyWeatherForecastList = File.ReadAllLines(@ForecastPaths).Skip(1).Select(d => DailyWeatherForecast.FromCsvForecast(d)).ToList();
                        _log.Info("Callid : " + callId + " reading done from csv file from DW in GetWeatherFromIMD in weather service");
                        File.Delete(@ForecastPaths);
                        _log.Info("Callid : " + callId + " deleted file from DW in GetWeatherFromIMD in weather service");
                    }
                    catch(Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in GetWeatherFromIMD in weather service : " + ex.Message);
                        response.ErrorMessage = Convert.ToString(ex.Message);
                    }
                    
                    response.ObjDailyWeatherForecastList = objDailyWeatherForecastList;
                    if (response.ObjDailyWeatherForecastList.Count > 0)
                    {
                        foreach (DailyWeatherForecast item in response.ObjDailyWeatherForecastList)
                        {
                            if (!string.IsNullOrEmpty(item.DIST_ID))
                            {
                                SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pForecastDate",item.ForecastDate),
                                        new SqlParameter("@pForecastValidity",item.ForecastDate),
                                        new SqlParameter("@pSTATE_ID",item.STATE_ID),
                                        new SqlParameter("@pDIST_ID", item.DIST_ID),
                                        new SqlParameter("@pRainfall_mm",item.Rainfall),
                                        new SqlParameter("@pTempMax_degC",item.TempMax),
                                        new SqlParameter("@pTempMin_degC",item.TempMin),
                                        new SqlParameter("@pHumidityI",item.HumidityI),
                                        new SqlParameter("@pHumidityII",item.HumidityII),
                                        new SqlParameter("@pWindSpeed_ms",item.WindSpeed),
                                        new SqlParameter("@pWindDirection_deg",item.WindDirection),
                                        new SqlParameter("@pCloudCover_octa",item.CloudCover),
                                };
                                _log.Info("Callid : " + callId + " calling ExecuteOutIDParameter in GetWeatherFromIMD in weather service");
                                transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_DistrictWiseWeatherForecasteDetails", arrParams);
                                _log.Info("Callid : " + callId + " called ExecuteOutIDParameter in GetWeatherFromIMD in weather service");
                                //SqlParameter[] arrParamsForDistrict = new SqlParameter[]
                                //{
                                //        new SqlParameter("@pState_Id",item.STATE_ID),
                                //        new SqlParameter("@pDist_Id", item.DIST_ID),
                                //        new SqlParameter("@pDistrict_Name",item.DIST_NAME)
                                //};
                                //transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_DistrictInMaster", arrParamsForDistrict);
                            }
                        }
                    }
                }

                response.IsSuccessful = true;


            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetWeatherFromIMD in weather service : " + ex.Message);
                response.ErrorMessage = ex.Message.ToString();
                response.SuccessMessage = uniqueFileName + "  " + paths;
            }
            response.ObjDailyWeatherList = new List<DailyWeather>();
            response.ObjDailyWeatherForecastList = new List<DailyWeatherForecast>();
            _log.Info("Callid : " + callId + " ending GetWeatherFromIMD in weather service");
            return response;
        }

        public static string GetObservedWeatherFromIMD()
        {
            #region Log Start

            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            _log.Info("Callid : " + callId + " started GetObservedWeatherFromIMD in weather service");
            ObservedWeatherDetails response = new ObservedWeatherDetails();
            WebClient client = new WebClient();
            TransactionDetails transactionResponse = new TransactionDetails();
            string uniqueFileName = "";
            string ObservedWeatherPath = "";
            try
            {
                uniqueFileName = string.Format("{0}{1}{2}{3}", DateTime.Parse(DateTime.Now.ToString()).Year.ToString(), DateTime.Now.Month.ToString().PadLeft(2, '0'), DateTime.Now.Day.ToString().PadLeft(2, '0'), ".csv");
                ObservedWeatherPath = System.Web.HttpContext.Current.Server.MapPath(Path.Combine("~/App_Data/", uniqueFileName));
                client = new WebClient();
                var objDailyWeatherForecastList = new List<ObservedWeatherDetails>();
                var todayDate = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
                PastWeather += GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                try
                {
                    _log.Info("Callid : " + callId + " downloading csv file from PastWeather URL GetObservedWeatherFromIMD in weather service");
                    client.DownloadFile(PastWeather, @ObservedWeatherPath);
                    _log.Info("Callid : " + callId + " downloading done from PastWeather URL GetObservedWeatherFromIMD in weather service");
                    _log.Info("Callid : " + callId + " reading data from csv file GetObservedWeatherFromIMD in weather service");
                    objDailyWeatherForecastList = File.ReadAllLines(@ObservedWeatherPath).Skip(3).Select(d => FromCsv(d)).ToList();
                    _log.Info("Callid : " + callId + " reading data done from csv file GetObservedWeatherFromIMD in weather service");
                    File.Delete(@ObservedWeatherPath);
                    _log.Info("Callid : " + callId + " deleting file GetObservedWeatherFromIMD in weather service");
                }
                catch(Exception ex)
                {
                    _log.Error("Callid : " + callId + " exception in GetObservedWeatherFromIMD in weather service : " + ex.Message);
                    response.ErrorMessage = Convert.ToString(ex.Message);
                }
                
                PastWeather = PastWeather.Replace(todayDate, string.Empty);
                if (objDailyWeatherForecastList.Any())
                {
                    foreach (ObservedWeatherDetails item in objDailyWeatherForecastList)
                    {
                        if (string.IsNullOrEmpty(item.Rainfall)) item.Rainfall = null;
                        if (string.IsNullOrEmpty(item.TempMax)) item.TempMax = null;
                        if (string.IsNullOrEmpty(item.TempMin)) item.TempMin = null;
                        if (string.IsNullOrEmpty(item.HumidityMax)) item.HumidityMax = null;
                        if (string.IsNullOrEmpty(item.HumidityMin)) item.HumidityMin = null;
                        if (string.IsNullOrEmpty(item.WindSpeed)) item.WindSpeed = null;
                        if (string.IsNullOrEmpty(item.WindDirection)) item.WindDirection = null;
                        if (string.IsNullOrWhiteSpace(item.CloudCover)) item.CloudCover = null;

                        SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pStateName",item.StateName),
                                        new SqlParameter("@pDistrictName",item.DistrictName),
                                        new SqlParameter("@pKisanDate",item.KisanDate),
                                        new SqlParameter("@pRainfall", item.Rainfall),
                                        new SqlParameter("@pTempMax_degC",item.TempMax),
                                        new SqlParameter("@pTempMin_degC",item.TempMin),
                                        new SqlParameter("@pHumidityMax",item.HumidityMax),
                                        new SqlParameter("@pHumidityMin",item.HumidityMin),
                                        new SqlParameter("@pWindSpeed",item.WindSpeed),
                                        new SqlParameter("@pWindDirection",item.WindDirection),
                                        new SqlParameter("@pCloudCover",item.CloudCover),
                        };
                        _log.Info("Callid : " + callId + " calling  ExecuteOutIDParameter in GetObservedWeatherFromIMD in weather service");
                        transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_ObservedWeatherDetails", arrParams);
                        _log.Info("Callid : " + callId + " called ExecuteOutIDParameter in GetObservedWeatherFromIMD in weather service");
                    }
                    if (transactionResponse.IsSuccessful)
                        return transactionResponse.SuccessMessage;
                    else
                        response.ErrorMessage = transactionResponse.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetObservedWeatherFromIMD in weather service : " + ex.Message);
                response.ErrorMessage = Convert.ToString(ex.Message);
            }
            _log.Info("Callid : " + callId + " ended GetObservedWeatherFromIMD in weather service");
            return response.ErrorMessage;
        }

        public static WeatherForecastDetailsResponse GetStateMasterList(StateMaster objStateMaster)
        {
            WeatherForecastDetailsResponse response = new WeatherForecastDetailsResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pstateid",objStateMaster.StateID),
                    new SqlParameter("@planguagetype", objStateMaster.LanguageType),
                    new SqlParameter("@pscientistid", objStateMaster.ScientistID),
                    new SqlParameter("@pRefreshdatetime",objStateMaster.RefreshDateTime)
            };
                dt = SQLHelper.Execute("spGet_StateMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjStateMasterList = (from DataRow dr in dt.Rows
                                                   select new StateMaster
                                                   {
                                                       StateID = (dr["stateid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["stateid"]),
                                                       StateName = (dr["statename"]) == DBNull.Value ? "" : Convert.ToString(dr["statename"]),
                                                       RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

                                                   }).ToList();
                    response.IsSuccessful = true;
                }


            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public static async Task<WeatherForecastDetailsResponse> GetWeatherFromIMDApiAsync()
        {
            #region Log Start

            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            WeatherForecastDetailsResponse response = new WeatherForecastDetailsResponse();
            //WebClient client = new WebClient();
            TransactionDetails transactionResponse = new TransactionDetails();
            string str = "";
            var todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var states = Weather.GetStateMasterList(new StateMaster()
                {
                    LanguageType = "English",
                    RefreshDateTime = todayDate
                });
                foreach (StateMaster st in states.ObjStateMasterList.OrderBy(s => s.StateID))
                {
                    appendInURL = string.Concat(todayDate, '/', st.StateID);
                    FORCAST_KEY = string.Concat(FORCAST_KEY, appendInURL);
                    FORECAST_VA_KEY = string.Concat(FORECAST_VA_KEY, appendInURL);
                    bool IsForecastVADataAvailable = false;
                    IMDWeatherResponse WeatherIMDResponse;
                    string IMDResponse = null;
                    List<WeatherForecast> objDailyWeatherList = new List<WeatherForecast>();
                    if (GlobalConstant.IsEnabledVAWeather)
                    {
                        WeatherIMDResponse = await GetWeatherInfoFromIMD(FORECAST_VA_KEY, callId, appendInURL);
                        
                        if (WeatherIMDResponse.IsSuccess)
                        {
                            IMDResponse = WeatherIMDResponse.IMDResponse;
                            FORECAST_VA_KEY = FORECAST_VA_KEY.Replace(appendInURL, string.Empty);
                        }
                        else
                        {
                            FORECAST_VA_KEY = FORECAST_VA_KEY.Replace(appendInURL, string.Empty);

                        }
                        if (IMDResponse != null)
                        {
                            string[] arr = IMDResponse.Split('[');
                            string temp = "[";
                            for (int j = 1; j < arr.Length; j++)
                            {
                                temp += arr[j];
                            }

                            objDailyWeatherList = JsonConvert.DeserializeObject<List<WeatherForecast>>(temp);

                            response.ObjWeatherForecast = objDailyWeatherList;
                            if (objDailyWeatherList.Count > 0)
                            {
                                IsForecastVADataAvailable = true;
                            }
                        }
                    }
                    if (!IsForecastVADataAvailable)
                    {
                        WeatherIMDResponse = await GetWeatherInfoFromIMD(FORCAST_KEY, callId, appendInURL);
                        IMDResponse = null;
                        if (WeatherIMDResponse.IsSuccess)
                        {
                            IMDResponse = WeatherIMDResponse.IMDResponse;
                            FORCAST_KEY = FORCAST_KEY.Replace(appendInURL, string.Empty);

                        }
                        else
                        {
                            FORCAST_KEY = FORCAST_KEY.Replace(appendInURL, string.Empty);
                            str += WeatherIMDResponse.Error;
                            continue;
                            
                        }
                    }

                    if (IMDResponse != null)
                    {
                        if (IMDResponse != null)
                        {
                            string[] arr = IMDResponse.Split('[');
                            string temp = "[";
                            for (int j = 1; j < arr.Length; j++)
                            {
                                temp += arr[j];
                            }

                            objDailyWeatherList = JsonConvert.DeserializeObject<List<WeatherForecast>>(temp);

                            response.ObjWeatherForecast = objDailyWeatherList;
                            if (objDailyWeatherList.Count > 0)
                            {
                                IsForecastVADataAvailable = true;
                            }
                        }

                        if (response.ObjWeatherForecast.Count > 0)
                        {
                            foreach (WeatherForecast item in response.ObjWeatherForecast)
                            {
                                if (item.state_id == "28" || item.state_id == "36" )
                                {
                                    if (GlobalConstant.IsEnabledASDWeather)
                                    {
                                        if (item.asd_id != null)
                                        {
                                            SqlParameter[] arrParams = new SqlParameter[] {
                                                new SqlParameter("@pForecastDate",item.forecast_date),
                                                new SqlParameter("@pForecastValidity",item.forecast_date),
                                                new SqlParameter("@pSTATE_ID",item.state_id),
                                                new SqlParameter("@pDIST_ID", item.district_id),
                                                new SqlParameter("@pAsd_ID", item.asd_id),
                                                new SqlParameter("@pRainfall_mm",item.rainfall),
                                                new SqlParameter("@pTempMax_degC",item.temperature_max),
                                                new SqlParameter("@pTempMin_degC",item.temperature_min),
                                                new SqlParameter("@pHumidityI",item.humidity),
                                                new SqlParameter("@pHumidityII",item.humidity2),
                                                new SqlParameter("@pWindSpeed_ms",item.wind_speed),
                                                new SqlParameter("@pWindDirection_deg",item.wind_direction),
                                                new SqlParameter("@pCloudCover_octa",item.cloud_cover),
                                            };
                                            transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_AsdWiseWeatherForecasteDetails", arrParams);
                                        }
                                    }
                                }
                                else
                                {
                                    if (item.block_id != null)
                                    {
                                        SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pForecastDate",item.forecast_date),
                                        new SqlParameter("@pForecastValidity",item.forecast_date),
                                        new SqlParameter("@pSTATE_ID",item.state_id),
                                        new SqlParameter("@pDIST_ID", item.district_id),
                                        new SqlParameter("@pBLOCK_ID", item.block_id),
                                        new SqlParameter("@pRainfall_mm",item.rainfall),
                                        new SqlParameter("@pTempMax_degC",item.temperature_max),
                                        new SqlParameter("@pTempMin_degC",item.temperature_min),
                                        new SqlParameter("@pHumidityI",item.humidity),
                                        new SqlParameter("@pHumidityII",item.humidity2),
                                        new SqlParameter("@pWindSpeed_ms",item.wind_speed),
                                        new SqlParameter("@pWindDirection_deg",item.wind_direction),
                                        new SqlParameter("@pCloudCover_octa",item.cloud_cover),
                                        };
                                        transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_BlockWiseWeatherForecasteDetails", arrParams);
                                    }
                                }
                            }
                        }
                    }
                    _log.Info("Callid : " + callId + " ended execution of block weather section in GetWeatherFromIMD in weather service");
                    _log.Info("Callid : " + callId + " started execution of district weather section in GetWeatherFromIMD in weather service");                    
                }
                response.IsSuccessful = true; 


            }

            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " Exception in GetWeatherForcastByStateIdFromIMD Service cropadvisory service : " + ex.Message);
                FORCAST_KEY = FORCAST_KEY.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            response.ObjDailyWeatherList = new List<DailyWeather>();
            response.ObjDailyWeatherForecastList = new List<DailyWeatherForecast>();
            _log.Info("Callid : " + callId + " ending GetWeatherFromIMDApi in weather service");
            return response;
        }

        public static async Task<IMDWeatherResponse> GetWeatherInfoFromIMD(string FORCAST_KEY, string callId, string appendInURL)
        {
            string str = "";
            IMDWeatherResponse objIMDWeatherResponse = new IMDWeatherResponse();
            HttpClient htclient = new HttpClient();
            htclient.DefaultRequestHeaders.Add("X-Version", "1");
            htclient.DefaultRequestHeaders.Add("Accept", "*/*");
            htclient.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
            HttpResponseMessage ResultFromIMDApi = null;
            try
            {
                _log.Info("Callid : " + callId + " calling IMD Service of GetWeatherFromIMDApi WeatherForcast for station id");
                ResultFromIMDApi = await htclient.GetAsync(FORCAST_KEY);
                _log.Info("Callid : " + callId + " called IMD Service of GetWeatherFromIMDApi Weather Forcast for station id");
                FORCAST_KEY = FORCAST_KEY.Replace(appendInURL, string.Empty);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetWeatherFromIMDApi Weather Forcast for station id : " + ex.Message);
                FORCAST_KEY = FORCAST_KEY.Replace(appendInURL, string.Empty);
                str += ex.Message;
                objIMDWeatherResponse.Error = str;
                objIMDWeatherResponse.IsSuccess = false;
            }
            if (ResultFromIMDApi == null || !ResultFromIMDApi.IsSuccessStatusCode)
            {
                _log.Info("Callid : " + callId + " No date from IMD Service of GetWeatherFromIMDApi Weather Forcast for station id");
                FORCAST_KEY = FORCAST_KEY.Replace(appendInURL, string.Empty);
                str += "No data found!";
                objIMDWeatherResponse.Error = str;
                objIMDWeatherResponse.IsSuccess = false;
            }
            else
            {
                var IMDResponse = ResultFromIMDApi.Content.ReadAsStringAsync().Result;
                _log.Info("Callid : " + callId + " started execution of block weather section in GetWeatherFromIMDApi in weather service");

                objIMDWeatherResponse.IMDResponse = IMDResponse;
                objIMDWeatherResponse.IsSuccess = true;
            }
            return objIMDWeatherResponse;
        }
        public static ObservedWeatherDetails FromCsv(string csvLine)
        {
            _log.Info("started FromCsv in GetObservedWeatherFromIMD in weather service");
            ObservedWeatherDetails observedWeather = new ObservedWeatherDetails();
            try
            {
                string[] values = csvLine.Split(',');
                observedWeather = new ObservedWeatherDetails
                {
                    StateName = string.IsNullOrEmpty(values[0]) == true ? "" : Convert.ToString(values[0]).Substring(1, (Convert.ToString(values[0]).Length - 2)),
                    DistrictName = string.IsNullOrEmpty(values[1]) == true ? "" : Convert.ToString(values[1]).Substring(1, (Convert.ToString(values[1]).Length - 2)),
                    KisanDate = string.IsNullOrEmpty(values[2]) == true ? "" : Convert.ToString(values[2]).Substring(1, (Convert.ToString(values[2]).Length - 2)),
                    Rainfall = string.IsNullOrEmpty(values[3]) == true ? "" : Convert.ToString(values[3]).Substring(1, (Convert.ToString(values[3]).Length - 2)),
                    TempMax = string.IsNullOrEmpty(values[4]) == true ? "" : Convert.ToString(values[4]).Substring(1, (Convert.ToString(values[4]).Length - 2)),
                    TempMin = string.IsNullOrEmpty(values[5]) == true ? "" : Convert.ToString(values[5]).Substring(1, (Convert.ToString(values[5]).Length - 2)),
                    HumidityMax = string.IsNullOrEmpty(values[6]) == true ? "" : Convert.ToString(values[6]).Substring(1, (Convert.ToString(values[6]).Length - 2)),
                    HumidityMin = string.IsNullOrEmpty(values[7]) == true ? "" : Convert.ToString(values[7]).Substring(1, (Convert.ToString(values[7]).Length - 2)),
                    WindSpeed = string.IsNullOrEmpty(values[8]) == true ? "" : Convert.ToString(values[8]).Substring(1, (Convert.ToString(values[8]).Length - 2)),
                    WindDirection = string.IsNullOrEmpty(values[9]) == true ? "" : Convert.ToString(values[9]).Substring(1, (Convert.ToString(values[9]).Length - 2)),
                    CloudCover = string.IsNullOrEmpty(values[10]) == true ? "" : Convert.ToString(values[10]).Substring(1, (Convert.ToString(values[10]).Length - 2)),
                    Flag = false,
                    Createddate = Convert.ToString(DateTime.Now),
                };
                _log.Info("mapping done in FromCsv in GetObservedWeatherFromIMD in weather service");
            }
            catch (Exception ex)
            {
                _log.Error("exception in FromCsv in GetObservedWeatherFromIMD in weather service : "+ ex.Message);
                string str = Convert.ToString(ex.Message);
            }
            _log.Info("ended FromCsv in GetObservedWeatherFromIMD in weather service");
            return observedWeather;
        }

        public static WeatherForecastDetailsResponse GetObservedWeather(WeatherForecastDetails ObjDetails)
        {
            var response = new WeatherForecastDetailsResponse();
            var dataTable = new DataTable();
            LanguageName language;
            Enum.TryParse(ObjDetails.LanguageType, true, out language);
            string code = Common.GetLanguageCode(language);
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pStateID",ObjDetails.StateID),
                    new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                    new SqlParameter("@planguagetype",ObjDetails.LanguageType),
                    new SqlParameter("@pRefreshdatetime",ObjDetails.RefreshDateTime),
                };
                dataTable = SQLHelper.Execute("spGet_ObservedWeatherDetails", arrParams);
                if (dataTable.Rows.Count > 0)
                {
                    response.ObjObservedWeatherList = (from DataRow dr in dataTable.Rows
                                                       select new WeatherForecastDetails
                                                       {
                                                           StateID = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                                                           StateName = ((dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"])).ToUpper(),
                                                           DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                                                           DistrictName = ((dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"])).ToUpper(),
                                                           Rainfall = ((dr["Rainfall"]) == DBNull.Value ? null : Convert.ToString(dr["Rainfall"]) + " " + Common.MM(language)),// " mm",
                                                           TempMax = ((dr["TempMax"]) == DBNull.Value ? null : Convert.ToString(dr["TempMax"]) + "°C"),
                                                           TempMin = ((dr["TempMin"]) == DBNull.Value ? null : Convert.ToString(dr["TempMin"]) + "°C"),
                                                           TempAvg = ((((dr["TempMax"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMax"])) + ((dr["TempMin"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["TempMin"]))) / 2).ToString() +"°C",
                                                           HumidityI = ((dr["HumidityMax"]) == DBNull.Value ? null : Convert.ToString(dr["HumidityMax"]) + "%"),
                                                           HumidityII = ((dr["HumidityMin"]) == DBNull.Value ? null : Convert.ToString(dr["HumidityMin"]) + "%"),
                                                           WindDirection = ((dr["WindDirection"]) == DBNull.Value ? null : Convert.ToString(dr["WindDirection"]) + " deg"),
                                                           WindSpeed = ((dr["WindSpeed"]) == DBNull.Value ? null : Convert.ToString(dr["WindSpeed"]) + " " + Common.KMPH(language)),// " kmph",
                                                           CloudCover = (dr["CloudCover"]) == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["CloudCover"]),
                                                           KisanDate = (dr["KisanDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["KisanDate"]).ToString("yyyy-MM-dd"),
                                                           Createddate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Createddate"]),
                                                           Updateddate = (dr["Updateddate"]) == DBNull.Value ? "" : Convert.ToString(dr["Updateddate"]),
                                                           RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),
                                                           KisanDate_Lang = (dr["KisanDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["KisanDate"]).ToString("ddd, dd MMM", new System.Globalization.CultureInfo(code))
                                                       }).ToList();
                    response.IsSuccessful = true;
                }
                if (response.ObjObservedWeatherList.Count > 0)
                {
                    for (int i = 0; i < response.ObjObservedWeatherList.Count; i++)
                    {
                        if (response.ObjObservedWeatherList[i].CloudCover == 0)
                            response.ObjObservedWeatherList[i].Cloud = Common.ClearSky(language);
                        if (response.ObjObservedWeatherList[i].CloudCover >= 1 && response.ObjObservedWeatherList[i].CloudCover <= 2)
                            response.ObjObservedWeatherList[i].Cloud = Common.MainlyClear(language);
                        if (response.ObjObservedWeatherList[i].CloudCover >= 3 && response.ObjObservedWeatherList[i].CloudCover <= 4)
                            response.ObjObservedWeatherList[i].Cloud = Common.PartlyCloudy(language);
                        if (response.ObjObservedWeatherList[i].CloudCover >= 5 && response.ObjObservedWeatherList[i].CloudCover <= 7)
                            response.ObjObservedWeatherList[i].Cloud = Common.GenerallyCloudy(language);
                        if (response.ObjObservedWeatherList[i].CloudCover > 7)
                            response.ObjObservedWeatherList[i].Cloud = Common.Cloudy(language);
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public static GetCurrentLocationResponse GetCurrentLocationDetails(string latitude, string longitude)
        {
            GetCurrentLocationResponse response = new GetCurrentLocationResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pLatitude",latitude),
                    new SqlParameter("@pLongitude", longitude)
                };
                dt = SQLHelper.Execute("spGet_CurrentLocationDetails", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response = (from DataRow dr in dt.Rows
                                select new GetCurrentLocationResponse
                                {
                                    StateId = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                                    DistrictId = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                                    BlockId = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"])
                                }).FirstOrDefault();
                    response.IsSuccessful = true;
                }


            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }


        #region Private methods

        /// <summary>
        /// Implementaton of Log Call Start
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="methodName"></param>
        /// <param name="message"></param>
        /// <param name="rootCallId"></param>
        private static void LogCallStart(string callId, string methodName, DateTime startTime, string message = null, string rootCallId = null)
        {
            try
            {
                WriteLog(string.Format("Call Start Method name: {0} callId: {1} message: {2} at {3}", methodName, callId, message, startTime.ToString()), null);
            }
            catch { }
        }

        /// <summary>
        /// Implementaton of Log Call End
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="methodName"></param>
        /// <param name="assembly"></param>
        /// <param name="resultType"></param>
        /// <param name="startTime"></param>
        /// <param name="errorMessage"></param>
        /// <param name="numberInfo"></param>
        /// <param name="ex"></param>
        /// <param name="rootCallId"></param>
        private static void LogCallEnd(string callId, string methodName, DateTime endTime, string errorMessage = null, Exception ex = null)
        {
            try
            {
                System.Threading.Tasks.Task.Run(() =>
                {
                    WriteLog(string.Format("Call Ended Method name: {0} callId: {1} message: {2} at {3}", methodName, callId, errorMessage, endTime.ToString()), ex);
                });
            }
            catch { }
        }

        /// <summary>
        /// Implementation of WriteLog
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        private static void WriteLog(string message, Exception exception)
        {
            try
            {
                if (exception == null)
                {
                    _log.Info(message);
                }
                else
                {
                    _log.Error(message, exception);
                }
            }
            catch { }
        }

        #endregion Private methods
    }
}
