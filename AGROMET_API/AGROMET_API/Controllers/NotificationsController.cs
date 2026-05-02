using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using AGROMET_COMMON;
using AGROMET_Notifications;

namespace AGROMET_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/Notifications")]
    public class NotificationsController : ApiController
    {
        public static int TimeOutValue = Convert.ToInt32(ConfigurationManager.AppSettings["TimeOutValue"]);
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveNotifications")]
        [ActionName("SaveNotifications")]
        public TransactionDetails SaveNotifications(NotificationsDetails ObjDetails)
        {
            TransactionDetails response = Notifications.SaveNotifications(ObjDetails);
            return response;
        }

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("SendNotifications")]
        //[ActionName("SendNotifications")]
        //public TransactionDetails SendNotifications(Notification notification)
        //{
        //    TransactionDetails response = Notifications.SendNotification(notification);
        //    return response;
        //}

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveNotificationsDistrict")]
        [ActionName("SaveNotificationsDistrict")]
        public TransactionDetails SaveNotificationsDistrict(NotificationsDistrict ObjDetails)
        {
            TransactionDetails response = Notifications.SaveNotificationsDistrict(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveNotificationsBlock")]
        [ActionName("SaveNotificationsBlock")]
        public TransactionDetails SaveNotificationsBlock(NotificationsBlock ObjDetails)
        {
            TransactionDetails response = Notifications.SaveNotificationsBlock(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveNotificationsCrop")]
        [ActionName("SaveNotificationsCrop")]
        public TransactionDetails SaveNotificationsCrop(NotificationsCrop ObjDetails)
        {
            TransactionDetails response = Notifications.SaveNotificationsCrop(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetNotifications")]
        [ActionName("GetNotifications")]
        public NotificationsResponse GetNotifications(NotificationsDetails ObjDetails)
        {
            NotificationsResponse response = Notifications.GetNotifications(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("SearchNotifications")]
        [ActionName("SearchNotifications")]
        public NotificationsResponse SearchNotifications(NotificationsDetails ObjDetails)
        {
            NotificationsResponse response = Notifications.SearchNotifications(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetNotificationDistMapping")]
        [ActionName("GetNotificationDistMapping")]
        public NotificationsResponse GetNotificationDistMapping(NotificationsDetails objNotifications)
        {
            NotificationsResponse response = Notifications.GetNotificationDistMapping(objNotifications);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetNotificationBlockMapping")]
        [ActionName("GetNotificationBlockMapping")]
        public NotificationsResponse GetNotificationBlockMapping(NotificationsDetails objNotifications)
        {
            NotificationsResponse response = Notifications.GetNotificationBlockMapping(objNotifications);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetNotificationCropMapping")]
        [ActionName("GetNotificationCropMapping")]
        public NotificationsResponse GetNotificationCropMapping(NotificationsDetails objNotifications)
        {
            NotificationsResponse response = Notifications.GetNotificationCropMapping(objNotifications);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetDistrictWarnings")]
        [ActionName("GetDistrictWarnings")]
        public NotificationsResponse GetDistrictWarnings(DistrictWarnings obj)
        {
            NotificationsResponse response = Notifications.GetDistrictWarnings(obj);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetDistrictNowCast")]
        [ActionName("GetDistrictNowCast")]
        public NotificationsResponse GetDistrictNowCast(DistrictwiseNowcast obj)
        {
            NotificationsResponse response = Notifications.GetDistrictNowCast(obj);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetNotificationsByID")]
        [ActionName("GetNotificationsByID")]
        public NotificationsResponse GetNotificationsByID(NotificationsDetails objNotifications)
        {
            NotificationsResponse response = Notifications.GetNotificationsByID(objNotifications);
            return response;
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("SaveDistrictWiseNowcastNowFromHTTPAsync")]
        [ActionName("SaveDistrictWiseNowcastNowFromHTTP")]
        public async Task<TransactionDetails> SaveDistrictWiseNowcastNowFromHTTPAsync()
        {
            _log.Info("starting SaveDistrictWiseNowcastNowFromFTP in notification controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            TransactionDetails response = await Notifications.SaveDistrictWiseNowcastNowFromHTTPAsync();
            _log.Info("ending SaveDistrictWiseNowcastNowFromFTP in notification controller service");
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveDistrictWarningNowFromFTP")]
        [ActionName("SaveDistrictWarningNowFromFTP")]
        public TransactionDetails SaveDistrictWarningNowFromFTP()
        {
            _log.Info("starting SaveDistrictWarningNowFromFTP in notification controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            TransactionDetails response = Notifications.SaveDistrictWarningNowFromFTP();
            _log.Info("ending SaveDistrictWarningNowFromFTP in notification controller service");
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("AddOrUpdateMobileTokens")]
        [ActionName("AddOrUpdateMobileTokens")]
        public TransactionDetails AddOrUpdateMobileTokens(MobileTokens mobileTokens)
        {
            return Notifications.AddOrUpdateMobileTokens(mobileTokens);            
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("DeleteMobileTokens")]
        [ActionName("DeleteMobileTokens")] 
        public TransactionDetails DeleteMobileTokens(MobileTokens mobileTokens)
        {
            return Notifications.DeleteMobileTokens(mobileTokens);
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetMobileTokens")]
        [ActionName("GetMobileTokens")]
        public List<MobileTokens> GetMobileTokens()
        {
            return Notifications.GetAllMobileTokens();
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetMobileTokensById")]
        [ActionName("GetMobileTokensById")]
        public List<MobileTokens> GetMobileTokensById(int id)
        {
            return Notifications.GetMobileTokensById(id);
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("GetNotificationDetails")]
        [ActionName("GetNotificationDetails")]
        public List<NowCastWarningNotification> GetNotificationDetails(int userProfileId)
        {
            return Notifications.GetNotificationDetails(userProfileId);
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("UpdateSeenNotification")]
        [ActionName("UpdateSeenNotification")]
        public TransactionDetails UpdateSeenNotification(int notificationId)
        {
            return Notifications.UpdateSeenNotification(notificationId);
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("GetValidNowCastNowDetails")]
        [ActionName("GetValidNowCastNowDetails")]
        public List<NowCastWarningNotification> GetValidNowCastNowDetails(int userProfileId)
        {
            return Notifications.GetValidNowCastNowDetails(userProfileId);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("ClearNotificationDetails")]
        [ActionName("ClearNotificationDetails")]
        public TransactionDetails ClearNotificationDetails(int userProfileId)
        {
            return Notifications.ClearNotification(userProfileId);
        }
    }
}