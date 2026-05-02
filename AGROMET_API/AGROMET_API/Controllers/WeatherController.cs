using AGROMET_COMMON;
using AGROMET_WEATHER;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace AGROMET_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/Weather")]
    public class WeatherController : ApiController
    {
        public static int TimeOutValue = Convert.ToInt32(ConfigurationManager.AppSettings["TimeOutValue"]);
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [AllowAnonymous]
        [HttpPost]
        [Route("GetWeatherForecastDetails")]
        [ActionName("GetWeatherForecastDetails")]
        public WeatherForecastDetailsResponse GetWeatherForecastDetails(WeatherForecastDetails ObjDetails)
        {
            WeatherForecastDetailsResponse response = Weather.GetWeatherForecastDetails(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetWeatherForecastDetailsByLocation")]
        [ActionName("GetWeatherForecastDetailsByLocation")]
        public WeatherForecastDetailsResponse GetWeatherForecastDetailsByLocation(WeatherForecastDetails ObjDetails)
        {
            WeatherForecastDetailsResponse response = Weather.GetWeatherForecastDetailsByLocation(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetTodayWeather")]
        [ActionName("GetTodayWeather")]
        public WeatherForecastDetailsResponse GetTodayWeather(WeatherForecastDetails ObjDetails)
        {
            WeatherForecastDetailsResponse response = Weather.GetTodayWeather(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetWeatherFromIMD")]
        [ActionName("GetWeatherFromIMD")]
        public WeatherForecastDetailsResponse GetWeatherFromIMD()
        {
            _log.Info("started GetWeatherFromIMD in weather controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            WeatherForecastDetailsResponse response = Weather.GetWeatherFromIMD();
            _log.Info("ended GetWeatherFromIMD in weather controller service");
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetWeatherFromIMDApi")]
        [ActionName("GetWeatherFromIMDApi")]
        public async Task<WeatherForecastDetailsResponse> GetWeatherFromIMDApiAsync()
        {
            _log.Info("started GetWeatherFromIMD in weather controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            WeatherForecastDetailsResponse response = await Weather.GetWeatherFromIMDApiAsync();
            _log.Info("ended GetWeatherFromIMDApi in weather controller service");
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetCountDetails")]
        [ActionName("GetCountDetails")]
        public CountResponse GetCountDetails(CountDetails objCount)
        {
            CountResponse response = Weather.GetCountDetails(objCount);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveObservedWeatherFromIMD")]
        [ActionName("SaveObservedWeatherFromIMD")]
        public string SaveObservedWeatherFromIMD()
        {
            _log.Info("started SaveObservedWeatherFromIMD in weather controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = Weather.GetObservedWeatherFromIMD();
            _log.Info("started SaveObservedWeatherFromIMD in weather controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetObservedWeather")]
        [ActionName("GetObservedWeather")]
        public WeatherForecastDetailsResponse GetObservedWeather(WeatherForecastDetails ObjDetails)
        {
            return Weather.GetObservedWeather(ObjDetails); 
        }

    }
}

