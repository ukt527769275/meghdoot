using System.Collections.Generic;

namespace AGROMET.Models
{
    public class WeatherForecastDetails
    {
        public int WeatherForecastID { get; set; }
        public int ID { get; set; }
        public int StateID { get; set; }
        public int DistrictID { get; set; }
        public int BlockID { get; set; }
        public string Rainfall { get; set; }
        public string TempMax { get; set; }
        public string TempMin { get; set; }
        public string TempAvg { get; set; }
        public string HumidityI { get; set; }
        public string HumidityII { get; set; }
        public string WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public decimal WindDirections { get; set; }
        public string Cloud { get; set; }
        public decimal CloudCover { get; set; }
        public bool Flag { get; set; }
        public string Createddate { get; set; }
        public string ImgDirection { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string BlockName { get; set; }
        public string ForeCastDate { get; set; }
        public string ForeCastDate_Web { get; set; }
        public string ForeCastDate_Lang { get; set; }
        public string Updateddate { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
        public string LanguageType { get; set; }
        public string Type { get; set; }
    }
    public class WeatherForecastDetailsResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<WeatherForecastDetails> ObjWeatherForecastNextList { get; set; }
        public List<WeatherForecastDetails> ObjWeatherForecastPrevList { get; set; }
        public List<WeatherForecastDetails> ObjWeatherForecastList { get; set; }
        public WeatherForecastDetailsResponse()
        {
            ObjWeatherForecastNextList = new List<WeatherForecastDetails>();
            ObjWeatherForecastPrevList = new List<WeatherForecastDetails>();
            ObjWeatherForecastList = new List<WeatherForecastDetails>();
        }
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
        public CountDetails ObjCount { get; set; }
        public CountResponse()
        {
            this.ObjCount = new CountDetails();
        }
    }
}