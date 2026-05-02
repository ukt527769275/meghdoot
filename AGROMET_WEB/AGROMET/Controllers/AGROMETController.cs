using System;
using System.Web;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using AGROMET.MasterModels;
using AGROMET.Models;
using AGROMET.Domain;
using System.IO;

namespace AGROMET.Controllers
{
    public class AGROMETController : Controller
    {
        #region Object
        List<TitleMaster> ObjTitleMasterList = new List<TitleMaster>();
        List<StateMaster> ObjStateMasterList = new List<StateMaster>();
        List<DistrictMaster> ObjDistrictMasterList = new List<DistrictMaster>();
        List<BlockMaster> ObjBlockMasterList = new List<BlockMaster>();
        List<CropMaster> ObjCropMasterList = new List<CropMaster>();
        List<GenderMaster> ObjGenderMasterList = new List<GenderMaster>();
        List<UserProfile> ModelList = new List<UserProfile>();
        List<LanguageMaster> ObjLanguageTypeMasterList = new List<LanguageMaster>();
        List<DepartmentMaster> ObjDepartmentMasterList = new List<DepartmentMaster>();
        List<CropAdvisoryCategoryMaster> ObjAdvisoryCategoryMasterList = new List<CropAdvisoryCategoryMaster>();
        static List<BlobMaster> ObjBlobMasterList = new List<BlobMaster>();
        CropAdvisoryResponse ObjCropAdvisoryResponse = new CropAdvisoryResponse();
        NotificationsResponse ObjNotificationsResponse = new NotificationsResponse();
        WeatherForecastDetailsResponse ObjWeatherForecastResponse = new WeatherForecastDetailsResponse();
        CountResponse ObjCountResponse = new CountResponse();
        GetUsersResponse ObjUsersResponse = new GetUsersResponse();
        #endregion

        #region Constants
        public static string APIURL = ConfigurationManager.AppSettings["API"].ToString();
        public string Language = "English";
        public string DateTimeNow = DateTime.Now.ToString("yyyy-MM-dd");
        public string Date = "2019-02-09";
        #endregion

        #region culture
        public void ApplyCulture()
        {
            //if (Request.Cookies["CultureCode"].Value != null && Request.Cookies["CultureCode"].Value != "")
            //{

            //    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Request.Cookies["CultureCode"].Value.ToString());
            //    Thread.CurrentThread.CurrentUICulture = new CultureInfo(Request.Cookies["CultureCode"].Value.ToString());
            //}
            //else
            //{
            //    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en");
            //    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            //}
        }
        #endregion

        #region wind direction
        public string GetWindDirection(decimal WindDegrees)
        {
            string[] caridnals = { "N", "NE", "E", "SE", "S", "SW", "W", "NW", "N" };
            string a = caridnals[(int)Math.Round(((double)WindDegrees % 360) / 45)];
            string b = "";
            if (a == "N")
            {
                b = string.Format("n.png");
            }
            else if (a == "NE")
            {
               b = string.Format("ne.png");
            }
            else if (a == "E")
            {
                b = string.Format("e.png");
            }
            else if (a == "SE")
            {
                b = string.Format("se.png");
            }
            else if (a == "S")
            {
               b = string.Format("e.png");
            }
            else if (a == "SW")
            {
                b = string.Format("sw.png");
            }
            else if (a == "W")
            {
               b = string.Format("w.png");
            }
            else if (a == "NW")
            {
                b = string.Format("nw.png");
            }
            return b;
        }
        #endregion

        #region json result

        #region Master json
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetStateList(string TypeOfRole, string LanguageName, string StateID)
        {
            string urlState = APIURL + "Masters/GetStateMasterList";
            JObject jobjState = new JObject
            {
                { "ScientistID", TypeOfRole },
                { "StateID", StateID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjStateMasterList = APIResponse.GetStates(jobjState, urlState);
            return Json(ObjStateMasterList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetDistrictList(string TypeOfRole, string LanguageName, string StateID)
        {
            string urlDistrict = APIURL + "Masters/GetDistrictMasterList";
            JObject jobjDistrict = new JObject
            {
                { "ScientistID", TypeOfRole },
                { "StateID", StateID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjDistrictMasterList = APIResponse.GetDistricts(jobjDistrict, urlDistrict);
            return Json(ObjDistrictMasterList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetBlockList(string TypeOfRole, string LanguageName, string DistrictID)
        {
            string urlBlock = APIURL + "Masters/GetBlockMasterList";
            JObject jobjBlock = new JObject
            {
                { "ScientistID", TypeOfRole },
                { "DistrictID", DistrictID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjBlockMasterList = APIResponse.GetBlocks(jobjBlock, urlBlock);
            return Json(ObjBlockMasterList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCropList(string TypeOfRole, string LanguageName)
        {
            string urlCrop = APIURL + "Masters/GetCropMasterList";
            JObject jobjCrop = new JObject
            {
                { "CropID", 0 },
                { "ScientistID", TypeOfRole },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropMasterList = APIResponse.GetCrops(jobjCrop, urlCrop);
            return Json(ObjCropMasterList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetGenderList(string TypeOfRole, string LanguageName)
        {
            string urlGender = APIURL + "Masters/GetGenderMasterList";
            JObject jobjGender = new JObject
            {
               { "GenderID", 0 },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjGenderMasterList = APIResponse.GetGender(jobjGender, urlGender);
            return Json(ObjGenderMasterList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCategoryList(string TypeOfRole, string LanguageName)
        {
            string urlCropAdvisoryCategory = APIURL + "Masters/GetCropAdvisoryCategoryMaster";
            JObject jobjCropAdvisoryCategory = new JObject
            {
                { "CACID", 0 },
                 { "CropID",0 },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjAdvisoryCategoryMasterList = APIResponse.GetCropAdvisoryCategory(jobjCropAdvisoryCategory, urlCropAdvisoryCategory);
            return Json(ObjAdvisoryCategoryMasterList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetLanguageList(string LanguageTypeId, string LanguageTypeName)
        {
            string urlLanguage = APIURL + "Masters/GetLanguageMasterList";
            JObject jobjLangauge = new JObject
            {
                { "LanguageTypeId", LanguageTypeId },
                { "LanguageType", LanguageTypeName },
                { "RefreshDateTime", Date}
            };
            ObjLanguageTypeMasterList = APIResponse.GetLanguages(jobjLangauge, urlLanguage);
            return Json(ObjLanguageTypeMasterList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCategoryByCropName(string CropID, string LanguageName)
        {
            CropMaster ObjGetCategoryNamesfromApi = new CropMaster();
            if (CropID != null && CropID != "")
            {
                string urlCropAdvisoryCategory = APIURL + "Masters/GetCropAdvisoryCategoryMaster";
                JObject jobjCropAdvisoryCategory = new JObject
            {
                { "CACID", 0 },
                { "CropID",CropID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
                ObjAdvisoryCategoryMasterList = APIResponse.GetCropAdvisoryCategory(jobjCropAdvisoryCategory, urlCropAdvisoryCategory);
            }
            var cropcollection = GetCropAdvisoryCategoryMaster(ObjAdvisoryCategoryMasterList);
            return Json(cropcollection, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Home Json
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetWeatherList(string StateID, string DistrictID, string BlockID, string LanguageType, string WeatherDate)
        {
            string url = APIURL + "Weather/GetWeatherForecastDetails";
            string WeatherDates = "";
            if (WeatherDate != "")
            {
                WeatherDates = WeatherDate;
            }
            //if (WeatherDate != null && WeatherDate != "" && WeatherDate.Contains('/'))
            //{
            //    string[] datearray = WeatherDate.Split('/');
            //     WeatherDates = datearray[2] + "-"+ datearray[0] + "-" + datearray[1];
            //}
            else
            {
                WeatherDates = DateTime.Now.ToString("yyyy-MM-dd");
            }
            JObject jobj = new JObject
            {
              { "StateID",StateID },
              { "DistrictID",DistrictID },
              { "BlockID",BlockID },
              { "LanguageType", LanguageType },
              { "RefreshDateTime",WeatherDates }
            };
            ObjWeatherForecastResponse = APIResponse.GetWeatherForecastResponse(jobj, url);
            //ObjWeatherForecastResponse.ObjWeatherForecastList.AddRange(ObjWeatherForecastResponse.ObjWeatherForecastPrevList);
            //ObjWeatherForecastResponse.ObjWeatherForecastList.AddRange(ObjWeatherForecastResponse.ObjWeatherForecastNextList);
            //for(int i=0;i< ObjWeatherForecastResponse.ObjWeatherForecastList.Count;i++)
            //{
            //    ObjWeatherForecastResponse.ObjWeatherForecastList[i].WeatherForecastID = i;
            //    ObjWeatherForecastResponse.ObjWeatherForecastList[i].ID = ObjWeatherForecastResponse.ObjWeatherForecastPrevList.Count;
            //}
            if(ObjWeatherForecastResponse.ObjWeatherForecastNextList != null && ObjWeatherForecastResponse.ObjWeatherForecastNextList.Count > 0)
            {
                for (int i = 0; i < ObjWeatherForecastResponse.ObjWeatherForecastNextList.Count; i++)
                {
                    ObjWeatherForecastResponse.ObjWeatherForecastNextList[i].ImgDirection = GetWindDirection(ObjWeatherForecastResponse.ObjWeatherForecastNextList[i].WindDirections);
                }
                string var_date = (Convert.ToDateTime(WeatherDates)).ToString("dd-MM-yyyy");
                if (Convert.ToDateTime(ObjWeatherForecastResponse.ObjWeatherForecastNextList[0].ForeCastDate).ToString("dd-MM-yyyy") != var_date)
                {
                    ObjWeatherForecastResponse.ObjWeatherForecastNextList = new List<WeatherForecastDetails>();
                }

            }
            return Json(ObjWeatherForecastResponse.ObjWeatherForecastNextList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCount(string ScientistId)
        {
            string urlCount = APIURL + "Weather/GetCountDetails";
            JObject jobjCount = new JObject
            {
                { "Id", ScientistId },
                { "LanguageType", Language },
                { "RefreshDateTime", Date}
            };
            ObjCountResponse = APIResponse.GetCountResponse(jobjCount, urlCount);
            return Json(ObjCountResponse.ObjCount, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Advisory Json 
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCAMList(string ScientistID, string LanguageName)
        {
            string urlCAM = APIURL + "CropAdvisory/GetCropAdvisoryCategory";
            JObject jobjCAM = new JObject
            {
                { "ScientistID", ScientistID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCAM, urlCAM);
           
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult SearchCAMList(string ScientistId, string DistrictID, string BlockID, string CropID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/SearchCamList";
            JObject jobjCropAdvisory = new JObject
            {
                { "Id", ScientistId },
                { "DistrictID", DistrictID },
                { "BlockID", BlockID },
                { "CropID", CropID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
           
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCropAdvOfCAMList(string CAMID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCropAdvisoryofCropAdvisoryCategory";
            JObject jobjCropAdvisory = new JObject
            {
                { "CAMID", CAMID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCropAdvisoryList(string ScientistId, string LanguageName)
        {
          
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCropAdvisory";
            JObject jobjCropAdvisory = new JObject
            {
                { "Id", ScientistId },
                { "Type", "Scientist" },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            //if(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList.Count >0 && ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList.Count > 0)
            //{

            //    for (int i = 0; i < ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList.Count; i++)
            //    {
            //        for (int j = 0; j < ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList.Count; j++)
            //        {
            //            if(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList[i].CropAdvisoryID == ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList[j].CropAdvisoryID)
            //            { 
            //            if (ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList[i].CropNames != null)
            //            {
            //                ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList[i].CropNames += ", " + ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList[j].CropName;
            //            }
            //            else
            //            {
            //                ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList[i].CropNames += ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList[j].CropName;
            //            }
            //            }
            //        }
            //    }
            //}
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult SearchCropAdvisoryList(string ScientistId, string CategoryID, string DistrictID, string BlockID, string CropID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/SearchCropAdvisory";
            JObject jobjCropAdvisory = new JObject
            {
                { "Id", ScientistId },
                { "CategoryID", CategoryID },
                { "DistrictID", DistrictID },
                { "BlockID", BlockID },
                { "CropID", CropID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            if (ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList.Count > 0 && ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList.Count > 0)
            {
                for (int i= 0;i < ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList.Count;i++)
                {
                    for(int j = 0; j < ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList.Count;j++ )
                    {
                        if (ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList[i].CropAdvisoryID == ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList[j].CropAdvisoryID)
                        {
                            if (ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList[i].CropNames != null)
                            {
                                ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList[i].CropNames += ", " + ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList[j].CropName;
                            }
                            else
                            {
                                ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList[i].CropNames += ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList[j].CropName;
                            }
                        }
                    }
                }
            }
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCAMById(int CAMID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCropAdvisoryCategoryByID";
            JObject jobjCropAdvisory = new JObject
            {
                { "CAMID", CAMID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCropAdvisoryById(string CropAdvisoryID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCropAdvisoryByID";
            JObject jobjCropAdvisory = new JObject
            {
                { "CropAdvisoryID", CropAdvisoryID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCAMDistrictMapping(string CropAdvisoryID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCAMDistrictMapping";
            JObject jobjCropAdvisory = new JObject
            {
                { "CropAdvisoryID", CropAdvisoryID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDistMappList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCAMBlockMapping(string CropAdvisoryID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCAMBlockMapping";
            JObject jobjCropAdvisory = new JObject
            {
                { "CropAdvisoryID", CropAdvisoryID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryBlockMappList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCropAdvisoryDistrictMapping(string CropAdvisoryID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCropAdvyDistMapping";
            JObject jobjCropAdvisory = new JObject
            {
                { "CropAdvisoryID", CropAdvisoryID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDistMappList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCropAdvisoryBlockMapping(string CropAdvisoryID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCropAdvyBlockMapping";
            JObject jobjCropAdvisory = new JObject
            {
                { "CropAdvisoryID", CropAdvisoryID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryBlockMappList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCropAdvisoryCropMapping(string CropAdvisoryID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCropAdvyCropMapping";
            JObject jobjCropAdvisory = new JObject
            {
                { "CropAdvisoryID", CropAdvisoryID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryCropMappList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetCropAdvisoryAttachmentMapping(string CropAdvisoryID, string LanguageName,string Type)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCropAdvisoryAttachments";
            JObject jobjCropAdvisory = new JObject
            {
                { "CropAdvisoryID", CropAdvisoryID },
                { "Type", Type },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryImageList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetRatingList(string CropID, string StateID, string DistrictID, string ScientistID, string LanguageName)
        {
            if(CropID == null)
            {
                CropID = "0";
            }
            if (StateID == null)
            {
                StateID = "0";
            }
            if (DistrictID == null)
            {
                DistrictID = "0";
            }
            string urlCAM = APIURL + "CropAdvisory/GetRatingList";
            JObject jobjCAM = new JObject
            {
                { "CropID", CropID },
                { "StateID", StateID },
                { "DistrictID", DistrictID },
                { "ScientistID", ScientistID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCAM, urlCAM);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetFeedbackById(string CropAdvisoryID, string LanguageName, string UserProfileID)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetFeedbackById";
            JObject jobjCropAdvisory = new JObject
            {
                { "CropAdvisoryID", CropAdvisoryID },
                { "UserProfileID", UserProfileID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return Json(ObjCropAdvisoryResponse.ObjCropAdvisoryFeedbackList, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Notification json
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetNotificationsList(string ScientistId, string LanguageName)
        {
            string urlNotifications = APIURL + "Notifications/GetNotifications";
            JObject jobjNotifications = new JObject
            {
                { "Id", ScientistId },
                { "Type", "Scientist" },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjNotificationsResponse = APIResponse.GetNotificationsResponse(jobjNotifications, urlNotifications);
            if (ObjNotificationsResponse.ObjNotificationsDetailsList.Count > 0 && ObjNotificationsResponse.ObjNotificationsCropMappList.Count > 0)
            {

                for (int i = 0; i < ObjNotificationsResponse.ObjNotificationsDetailsList.Count; i++)
                {
                    for (int j = 0; j < ObjNotificationsResponse.ObjNotificationsCropMappList.Count; j++)
                    {
                        if (ObjNotificationsResponse.ObjNotificationsDetailsList[i].NotificationsID == ObjNotificationsResponse.ObjNotificationsCropMappList[j].NotificationsID)
                        {
                            if (ObjNotificationsResponse.ObjNotificationsDetailsList[i].CropNames != null)
                            {
                                ObjNotificationsResponse.ObjNotificationsDetailsList[i].CropNames += ", " + ObjNotificationsResponse.ObjNotificationsCropMappList[j].CropName;
                            }
                            else
                            {
                                ObjNotificationsResponse.ObjNotificationsDetailsList[i].CropNames += ObjNotificationsResponse.ObjNotificationsCropMappList[j].CropName;
                            }
                        }
                    }
                }
            }
            return Json(ObjNotificationsResponse.ObjNotificationsDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult SearchNotificationsList(string ScientistId, string CategoryID, string DistrictID, string BlockID, string CropID, string LanguageName)
        {
            string urlNotifications = APIURL + "Notifications/SearchNotifications";
            JObject jobjNotifications = new JObject
            {
                { "Id", ScientistId },
                { "DistrictID", DistrictID },
                { "BlockID", BlockID },
                { "CropID", CropID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjNotificationsResponse = APIResponse.GetNotificationsResponse(jobjNotifications, urlNotifications);
            if (ObjNotificationsResponse.ObjNotificationsDetailsList.Count > 0 && ObjNotificationsResponse.ObjNotificationsCropMappList.Count > 0)
            {

                for (int i = 0; i < ObjNotificationsResponse.ObjNotificationsDetailsList.Count; i++)
                {
                    for (int j = 0; j < ObjNotificationsResponse.ObjNotificationsCropMappList.Count; j++)
                    {
                        if (ObjNotificationsResponse.ObjNotificationsDetailsList[i].NotificationsID == ObjNotificationsResponse.ObjNotificationsCropMappList[j].NotificationsID)
                        {
                            if (ObjNotificationsResponse.ObjNotificationsDetailsList[i].CropNames != null)
                            {
                                ObjNotificationsResponse.ObjNotificationsDetailsList[i].CropNames += ", " + ObjNotificationsResponse.ObjNotificationsCropMappList[j].CropName;
                            }
                            else
                            {
                                ObjNotificationsResponse.ObjNotificationsDetailsList[i].CropNames += ObjNotificationsResponse.ObjNotificationsCropMappList[j].CropName;
                            }
                        }
                    }
                }
            }
            return Json(ObjNotificationsResponse.ObjNotificationsDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetNotificationsById(string NotificationsID, string LanguageName)
        {
            string urlNotifications = APIURL + "Notifications/GetNotificationsByID";
            JObject jobjNotifications = new JObject
            {
                { "NotificationsID", NotificationsID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjNotificationsResponse = APIResponse.GetNotificationsResponse(jobjNotifications, urlNotifications);
            return Json(ObjNotificationsResponse.ObjNotificationsDetailsList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetNotificationDistMapping(string NotificationsID, string LanguageName)
        {
            string urlNotifications = APIURL + "Notifications/GetNotificationDistMapping";
            JObject jobjNotifications = new JObject
            {
                { "NotificationsID", NotificationsID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjNotificationsResponse = APIResponse.GetNotificationsResponse(jobjNotifications, urlNotifications);
            return Json(ObjNotificationsResponse.ObjNotificationsDistMappList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetNotificationBlockMapping(string NotificationsID, string LanguageName)
        {
            string urlNotifications = APIURL + "Notifications/GetNotificationBlockMapping";
            JObject jobjNotifications = new JObject
            {
                { "NotificationsID", NotificationsID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjNotificationsResponse = APIResponse.GetNotificationsResponse(jobjNotifications, urlNotifications);
            return Json(ObjNotificationsResponse.ObjNotificationsBlockMappList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetNotificationCropMapping(string NotificationsID, string LanguageName)
        {
            string urlNotifications = APIURL + "Notifications/GetNotificationCropMapping";
            JObject jobjNotifications = new JObject
            {
                { "NotificationsID", NotificationsID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjNotificationsResponse = APIResponse.GetNotificationsResponse(jobjNotifications, urlNotifications);
            return Json(ObjNotificationsResponse.ObjNotificationsCropMappList, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Users json
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetUsers(string UsersID)
        {
            string urlUsers = APIURL + "Users/GetUsersList";
            JObject jobjUsers = new JObject
            {
                { "UserId", UsersID },
                { "LanguageType", Language },
                { "RefreshDateTime", Date}
            };
            ObjUsersResponse = APIResponse.GetUsersResponse(jobjUsers, urlUsers);
            return Json(ObjUsersResponse.ObjUserList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult SearchUsers(string UsersID, string BlockID, string LogInId)
        {
            string urlUsers = APIURL + "Users/SearchUsersList";
            JObject jobjUsers = new JObject
            {
                { "UserId", UsersID },
                { "BlockID", BlockID },
                { "LogInId", LogInId },
                { "LanguageType", Language },
                { "RefreshDateTime", Date}
            };
            ObjUsersResponse = APIResponse.GetUsersResponse(jobjUsers, urlUsers);
            return Json(ObjUsersResponse.ObjUserList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetUserBlocks(string UserID)
        {
            string urlBlocks = APIURL + "Users/GetUserBlocks";
            JObject jobjBlocks = new JObject
            {
                { "UserID", UserID },
                { "LanguageType", Language },
                { "RefreshDateTime", Date}
            };
            ObjUsersResponse = APIResponse.GetUsersResponse(jobjBlocks, urlBlocks);
            return Json(ObjUsersResponse.ObjBlockList, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #endregion

        #region masters api calling from actionresult
        public void FillDDL(string LanguageName,string ScientistId)
        {
            //string urlCropAdvisoryCategory = APIURL + "Masters/GetCropAdvisoryCategoryMaster";
            //JObject jobjCropAdvisoryCategory = new JObject
            //{
            //    { "CACID", 0 },
            //    { "LanguageType", LanguageName },
            //    { "RefreshDateTime", Date}
            //};
            //ObjAdvisoryCategoryMasterList = APIResponse.GetCropAdvisoryCategory(jobjCropAdvisoryCategory, urlCropAdvisoryCategory);
            //if (ObjAdvisoryCategoryMasterList.Count > 0)
            //{
            //    ViewBag.CropAdvisoryCategoryList = GetCropAdvisoryCategoryMaster(ObjAdvisoryCategoryMasterList);
            //}
            string urlCrop = APIURL + "Masters/GetCropMasterList";
            JObject jobjCrop = new JObject
            {
                { "CropID", 0 },
                { "ScientistID", ScientistId },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropMasterList = APIResponse.GetCrops(jobjCrop, urlCrop);
            if (ObjCropMasterList.Count > 0)
            {
                ViewBag.CropList = GetCropMasters(ObjCropMasterList);
            }
        }
        public void FillDDLAlert(string LanguageName, string ScientistId)
        {
            string urlCropAdvisoryCategory = APIURL + "Masters/GetCropAdvisoryCategoryMaster";
            JObject jobjCropAdvisoryCategory = new JObject
            {
                { "CACID", 0 },
                 { "CropID",0 },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjAdvisoryCategoryMasterList = APIResponse.GetCropAdvisoryCategory(jobjCropAdvisoryCategory, urlCropAdvisoryCategory);
            if (ObjAdvisoryCategoryMasterList.Count > 0)
            {
                ViewBag.CropAdvisoryCategoryList = GetCropAdvisoryCategoryMaster(ObjAdvisoryCategoryMasterList);
            }
            string urlCrop = APIURL + "Masters/GetCropMasterList";
            JObject jobjCrop = new JObject
            {
                { "CropID", 0 },
                { "ScientistID", ScientistId },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjCropMasterList = APIResponse.GetCrops(jobjCrop, urlCrop);
            if (ObjCropMasterList.Count > 0)
            {
                ViewBag.CropList = GetCropMasters(ObjCropMasterList);
            }
        }
        public void FillUsersDDL(string LanguageName)
        {
            string urlTitle = APIURL + "Masters/GetTitleMasterList";
            JObject jobjTitle = new JObject
            {
                { "TitleID", 0 },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjTitleMasterList = APIResponse.GetTitles(jobjTitle, urlTitle);
            if (ObjTitleMasterList.Count > 0)
            {
                ViewBag.TitleList = GetTitleMaster(ObjTitleMasterList);
            }
            string urlLanguage = APIURL + "Masters/GetLanguageMasterList";
            JObject jobjLanguage = new JObject
            {
                { "LanguageTypeId", 0 },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjLanguageTypeMasterList = APIResponse.GetLanguages(jobjLanguage, urlLanguage);
            if (ObjLanguageTypeMasterList.Count > 0)
            {
                ViewBag.LanguageList = GetLanguageMaster(ObjLanguageTypeMasterList);
            }
            string urlDepartment = APIURL + "Masters/GetDepartmentMasterList";
            JObject jobjDepartment = new JObject
            {
                { "DepartmentId", 0 },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjDepartmentMasterList = APIResponse.GetDepartments(jobjDepartment, urlDepartment);
            if (ObjDepartmentMasterList.Count > 0)
            {
                ViewBag.DepartmentList = GetDepartmentMaster(ObjDepartmentMasterList);
            }
            string urlGender = APIURL + "Masters/GetGenderMasterList";
            JObject jobjGender = new JObject
            {
                { "GenderID", 0 },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
            ObjGenderMasterList = APIResponse.GetGender(jobjGender, urlGender);
            if (ObjGenderMasterList.Count > 0)
            {
                ViewBag.GenderList = GetGenderMaster(ObjGenderMasterList);
            }
        }
        public static BlobMaster GetBlobReference()
        {
            BlobMaster blob = new BlobMaster();
            string urlBlob = APIURL + "Masters/GetBlobMaster";
            JObject jobjBlob = new JObject
            {
                { "Type", "Audio" }
            };
            ObjBlobMasterList = APIResponse.GetBlob(jobjBlob, urlBlob);
            if(ObjBlobMasterList.Count > 0)
            {
                return blob = ObjBlobMasterList[0];
            }
            else
            {
                return blob = new BlobMaster();
            }
        }
        #endregion

        #region DDL
        public SelectList GetCropAdvisoryCategoryMaster(List<CropAdvisoryCategoryMaster> masterinfocollection)
        {
            IEnumerable<SelectListItem> masterlist = (from m in masterinfocollection select m).AsEnumerable().Select(m => new SelectListItem() { Text = m.CropAdvisoryCategory, Value = m.CACID.ToString() });
            return new SelectList(masterlist, "Value", "Text");
        }
        public SelectList GetCropMasters(List<CropMaster> masterinfocollection)
        {
            IEnumerable<SelectListItem> masterlist = (from m in masterinfocollection select m).AsEnumerable().Select(m => new SelectListItem() { Text = m.CropName, Value = m.CropID.ToString() });
            return new SelectList(masterlist, "Value", "Text");
        }
        public SelectList GetTitleMaster(List<TitleMaster> masterinfocollection)
        {
            IEnumerable<SelectListItem> masterlist = (from m in masterinfocollection select m).AsEnumerable().Select(m => new SelectListItem() { Text = m.TitleName, Value = m.TitleID.ToString() });
            return new SelectList(masterlist, "Value", "Text");
        }
        public SelectList GetLanguageMaster(List<LanguageMaster> masterinfocollection)
        {
            IEnumerable<SelectListItem> masterlist = (from m in masterinfocollection select m).AsEnumerable().Select(m => new SelectListItem() { Text = m.LanguageTypeName, Value = m.LanguageTypeId.ToString() });
            return new SelectList(masterlist, "Value", "Text");
        }
        public SelectList GetDepartmentMaster(List<DepartmentMaster> masterinfocollection)
        {
            IEnumerable<SelectListItem> masterlist = (from m in masterinfocollection select m).AsEnumerable().Select(m => new SelectListItem() { Text = m.DepartmentName, Value = m.DepartmentID.ToString() });
            return new SelectList(masterlist, "Value", "Text");
        }
        public SelectList GetGenderMaster(List<GenderMaster> masterinfocollection)
        {
            IEnumerable<SelectListItem> masterlist = (from m in masterinfocollection select m).AsEnumerable().Select(m => new SelectListItem() { Text = m.GenderName, Value = m.GenderID.ToString() });
            return new SelectList(masterlist, "Value", "Text");
        }
        #endregion

        #region api calling object from action result
        public WeatherForecastDetailsResponse GetWeatherForecastDetails(int StateID, int DistrictID,int BlockID)
        {
            string url = APIURL + "Weather/GetWeatherForecastDetails";
            JObject jobj = new JObject
            {
              { "StateID",StateID },
              { "DistrictID",DistrictID },
              { "BlockID",BlockID },
              { "LanguageType", Language },
              { "RefreshDateTime",DateTimeNow }
            };
            return APIResponse.GetWeatherForecastResponse(jobj, url);
        }
        public UserProfileResponse GetUserProfile(string UserProfileID, string RoleType,string LanguageType)
        {
            string url = APIURL + "Users/GetUserProfileDetails";
            JObject jobj = new JObject
            {
              { "UserProfileID",UserProfileID },
              { "RoleType",RoleType },
              { "LanguageType", LanguageType },
              { "RefreshDateTime","2019-01-01" }
            };
            return APIResponse.GetUserProfileResponse(jobj, url);
        }
        public CropAdvisoryResponse GetCropAdvisoryCategoryById(int CAMID, string LanguageName)
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetCropAdvisoryCategoryByID";
            JObject jobjCropAdvisory = new JObject
            {
                { "CAMID", CAMID },
                { "LanguageType", LanguageName },
                { "RefreshDateTime", Date}
            };
           ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return ObjCropAdvisoryResponse;
        }
        public CropAdvisoryResponse GetAgrometLanguages()
        {
            string urlCropAdvisory = APIURL + "CropAdvisory/GetLanguageList";
            JObject jobjCropAdvisory = new JObject
            {
                { "ID", 0 },
                { "LanguageType", Language },
                { "RefreshDateTime", Date}
            };
            ObjCropAdvisoryResponse = APIResponse.GetCropAdvisoryResponse(jobjCropAdvisory, urlCropAdvisory);
            return ObjCropAdvisoryResponse;
        }
        #endregion

        #region file Upload to blob
        static void UploadBlob(string blobConianer, string AccountName, string AccountKey, string paths,string Type,string uniqueBlobName)
        {
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName="+ AccountName + ";AccountKey="+ AccountKey + ";EndpointSuffix=core.windows.net");
            MemoryStream objMemeory = new MemoryStream();
            byte[] buffer = System.IO.File.ReadAllBytes(@paths);
            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            // Retrieve reference to a previously created container.
            CloudBlobContainer container = blobClient.GetContainerReference(blobConianer);
            // Retrieve reference to a blob named "myblob".
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(uniqueBlobName);
            // Create or overwrite the "myblob" blob with contents from a local file.
            using (var InputStream = new MemoryStream(buffer))
            {
                blockBlob.UploadFromStream(InputStream);
            }
            blockBlob.Properties.ContentType = @Type;
            blockBlob.SetProperties();
        }
        public static string SaveAudio(HttpPostedFileBase AudioFile)
        {
            BlobMaster blob = new BlobMaster();
            blob = GetBlobReference();
            string uniqueBlobName = "";
            if (blob != null)
            {
                try { 
             uniqueBlobName =string.Format("audio_{0}{1}",Guid.NewGuid().ToString(),Path.GetExtension(AudioFile.FileName));
            string paths = System.Web.Hosting.HostingEnvironment.MapPath(Path.Combine("~/App_Data/", uniqueBlobName));
            AudioFile.SaveAs(@paths);
             UploadBlob(blob.ContainerName, blob.AccountName, blob.AccountKey, paths, AudioFile.ContentType, uniqueBlobName);
             System.IO.File.Delete(@paths);
                }
                catch (Exception ex)
                {
                    string Error = ex.Message.ToString();
                }
            }
            return uniqueBlobName;
        }
        #endregion

        #region Save Data
        public TransactionDetails SaveCropAdvisoryMasters(CropAdvisoryModel model)
        {
            string PostURL = APIURL + "CropAdvisory/SaveCropAdvisoryMasters";
            TransactionDetails Response = new TransactionDetails();
            int i = 0;
            string DistricsList = "";
            string BlocksList = "";
            string BlockList = "";
            string DistrictList = "";
            JArray CropAdvisoryImageJArray = new JArray();
            JArray DistrictsJArray = new JArray();
            JArray BlocksJArray = new JArray();
            JArray CropsJArray = new JArray();
            JObject objCropAdvisoryImage = new JObject();
            JObject objCropAdvisoryAudio = new JObject();
            JObject objCropAdvisory = new JObject();
            JObject objDistrict = new JObject();
            JObject objBlock = new JObject();
            JObject objCrop = new JObject();
            JObject Results = new JObject();
            try
            {
                if (model.DistrictList != null && model.DistrictList != "")
                {
                    DistrictList = model.DistrictList;
                    string Districts = model.DistrictList.Substring(1, model.DistrictList.Length - 1);
                    DistricsList = Districts;
                    string[] DistrictsArray = Districts.Split(',');
                    foreach (var District in DistrictsArray)
                    {
                        objDistrict = new JObject
                        {
                            { "CADMID", i },
                            { "CropAdvisoryID", i },
                            { "StateID", model.StateId },
                            { "DistrictID", District },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        DistrictsJArray.Add(objDistrict);
                    }
                }
                else
                {
                    DistrictList = "";
                }
                if (model.BlockList != null && model.BlockList != "")
                {
                    BlockList = model.BlockList;
                    string Blocks = model.BlockList.Substring(1, model.BlockList.Length - 1);
                    BlocksList = Blocks;
                    string[] BlocksArray = Blocks.Split(',');
                    foreach (var Block in BlocksArray)
                    {
                        objBlock = new JObject
                        {
                            { "CABMID", i },
                            { "CropAdvisoryID", i },
                            { "BlockID", Block },
                            { "DistrictID", i },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        BlocksJArray.Add(objBlock);
                    }
                }
                else
                {
                    BlocksList = "0";
                    BlockList = "";
                }
                if(model.PeriodStartDate == null)
                {
                    model.PeriodStartDate = "";
                }
                if (model.PeriodEndDate == null)
                {
                    model.PeriodEndDate = "";
                }
                if(model.WeatherCondition == null)
                {
                    model.WeatherCondition = "";
                }
                if(model.AgroAdvisoryDetails == null)
                {
                    model.AgroAdvisoryDetails = "";
                }
                if(model.DistrictList == null)
                {
                    model.DistrictList = "";
                }
                if(model.BlockList == null)
                {
                    model.BlockList = "";
                }
                objCropAdvisory.Add("CAMID", i);
                objCropAdvisory.Add("StateId", model.StateId);
                objCropAdvisory.Add("Title", model.Title);
                objCropAdvisory.Add("PeriodStartDate", model.PeriodStartDate);
                objCropAdvisory.Add("PeriodEndDate", model.PeriodEndDate);
                objCropAdvisory.Add("WeatherCondition", model.WeatherCondition);
                objCropAdvisory.Add("AgroAdvisoryDetails", model.AgroAdvisoryDetails);
                objCropAdvisory.Add("DistrictList", DistrictList);
                objCropAdvisory.Add("BlockList", BlockList);
                objCropAdvisory.Add("LanguageId", model.LanguageId);
                objCropAdvisory.Add("D1", model.D1);
                objCropAdvisory.Add("D2", model.D2);
                objCropAdvisory.Add("D3", model.D3);
                objCropAdvisory.Add("D4", model.D4);
                objCropAdvisory.Add("D5", model.D5);
                objCropAdvisory.Add("Createdby", model.ScientistId);
                objCropAdvisory.Add("Updatedby", i);
                objCropAdvisory.Add("ObjDistrictList", DistrictsJArray);
                objCropAdvisory.Add("ObjBlockList", BlocksJArray);
                Response = APIResponse.SaveDetails(objCropAdvisory, PostURL);
                DistrictsJArray.Remove(objDistrict);
                BlocksJArray.Remove(objBlock);

            }
            catch (Exception Exception)
            {
                Response.ErrorMessage = Exception.Message.ToString();
            }
            return Response;
        }
        public TransactionDetails SaveCropAdvisory(CropAdvisoryModel model)
        {
            string PostURL = APIURL + "CropAdvisory/SaveCropAdvisory";
            TransactionDetails Response = new TransactionDetails();
            int i = 0;
            string DistricsList = "";
            string BlocksList = "";
            JArray CropAdvisoryImageJArray = new JArray();
            JArray DistrictsJArray = new JArray();
            JArray BlocksJArray = new JArray();
            JArray CropsJArray = new JArray();
            JObject objCropAdvisoryImage = new JObject();
            JObject objCropAdvisoryAudio = new JObject();
            JObject objCropAdvisory = new JObject();
            JObject objDistrict = new JObject();
            JObject objBlock = new JObject();
            JObject objCrop = new JObject();
            JObject Results = new JObject();
            try
            {
                if(model.AudioFile != null)
                {
                    string FileName = SaveAudio(model.AudioFile);
                    objCropAdvisoryAudio.Add("CAAID", 0);
                    objCropAdvisoryAudio.Add("CropAdvisoryID", 0);
                    objCropAdvisoryAudio.Add("Type", "Audio");
                    objCropAdvisoryAudio.Add("FileName", FileName);
                    objCropAdvisoryAudio.Add("Createdby", model.ScientistId);
                    objCropAdvisoryAudio.Add("Updatedby", i);
                }
                if (model.Files != null)
                {
                    if (model.Files.Length > 0)
                    {
                        foreach (HttpPostedFileBase file in model.Files)
                        {
                            if (file != null)
                            {
                                if (file.ContentType.Contains("image"))
                                {
                                    objCropAdvisoryImage = new JObject();
                                    if (file != null)
                                    {
                                        var streamLength = file.InputStream.Length;
                                        var imageBytes = new byte[streamLength];
                                        string Base64String = Convert.ToBase64String(imageBytes);
                                        file.InputStream.Read(imageBytes, 0, imageBytes.Length);
                                        objCropAdvisoryImage.Add("CAAID", 0);
                                        objCropAdvisoryImage.Add("CropAdvisoryID", 0);
                                        objCropAdvisoryImage.Add("Type", "Image");
                                        objCropAdvisoryImage.Add("ByteStream", imageBytes);
                                        objCropAdvisoryImage.Add("Createdby", model.ScientistId);
                                        objCropAdvisoryImage.Add("Updatedby", i);
                                        CropAdvisoryImageJArray.Add(objCropAdvisoryImage);
                                    }
                                }
                            }
                        }
                    }
                }
                if (model.DistrictList != null && model.DistrictList != "")
                {
                    string Districts = model.DistrictList.Substring(1, model.DistrictList.Length - 1);
                    DistricsList = Districts;
                    string[] DistrictsArray = Districts.Split(',');
                    foreach (var District in DistrictsArray)
                    {
                        objDistrict = new JObject
                        {
                            { "CADMID", i },
                            { "CropAdvisoryID", i },
                            { "StateID", model.StateId },
                            { "DistrictID", District },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        DistrictsJArray.Add(objDistrict);
                    }
                }
                if (model.BlockList != null && model.BlockList != "")
                {
                    string Blocks = model.BlockList.Substring(1, model.BlockList.Length - 1);
                    BlocksList = Blocks;
                    string[] BlocksArray = Blocks.Split(',');
                    foreach (var Block in BlocksArray)
                    {
                        objBlock = new JObject
                        {
                            { "CABMID", i },
                            { "CropAdvisoryID", i },
                            { "BlockID", Block },
                            { "DistrictID", i },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        BlocksJArray.Add(objBlock);
                    }
                }
                else
                {
                    BlocksList = "0";
                }
                if (model.CropList != null && model.CropList != "")
                {
                    string Crops = model.CropList.Substring(1, model.CropList.Length - 1);
                    string[] CropsArray = Crops.Split(',');
                    foreach (var Crop in CropsArray)
                    {
                        objCrop = new JObject
                        {
                            { "CACMID", i },
                            { "CropAdvisoryID", i },
                            { "CropID", Crop },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        CropsJArray.Add(objCrop);
                    }
                }
                if(model.BriefText == null)
                {
                    model.BriefText = "";
                }
                if(model.Title == null)
                {
                    model.Title = "";
                }
                if(model.Recommendation == null)
                {
                    model.Recommendation = "";
                }
                if(model.YouTubeLink == null)
                {
                    model.YouTubeLink = "";
                }
                objCropAdvisory.Add("CropAdvisoryID", i);
                objCropAdvisory.Add("CAMID", model.CAMID);
                objCropAdvisory.Add("CropID", model.CropID);
                objCropAdvisory.Add("CategoryID", model.CACID);
                objCropAdvisory.Add("Title", model.Title);
                objCropAdvisory.Add("BriefText", model.BriefText);
                objCropAdvisory.Add("ScientistID", model.ScientistId);
                objCropAdvisory.Add("StateID", model.StateId);
                objCropAdvisory.Add("Recommendations", model.Recommendation);
                objCropAdvisory.Add("YouTubeLink", model.YouTubeLink);
                objCropAdvisory.Add("SMSAlert", model.SMSAlert);
                objCropAdvisory.Add("SMSLanguage", model.SMSLanguage);
                objCropAdvisory.Add("LanguageType", model.LanguageType);
                objCropAdvisory.Add("Createdby", model.ScientistId);
                objCropAdvisory.Add("Updatedby", i);
                objCropAdvisory.Add("DistricsList", DistricsList);
                objCropAdvisory.Add("BlocksList", BlocksList);
                objCropAdvisory.Add("ObjDistrictList", DistrictsJArray);
                objCropAdvisory.Add("ObjBlockList", BlocksJArray);
                objCropAdvisory.Add("ObjCropList", CropsJArray);
                objCropAdvisory.Add("ObjCropAdvisoryImageList", CropAdvisoryImageJArray);
                objCropAdvisory.Add("ObjCropAdvisoryAudio", objCropAdvisoryAudio);
                Response =  APIResponse.SaveDetails(objCropAdvisory, PostURL);
                CropAdvisoryImageJArray.Remove(objCropAdvisoryImage);
                DistrictsJArray.Remove(objDistrict);
                BlocksJArray.Remove(objBlock);
                CropsJArray.Remove(objCrop);
                 
            }
            catch (Exception Exception)
            {
                Response.ErrorMessage = Exception.Message.ToString();
            }
            return Response;
        }
        public TransactionDetails SaveNotification(NotificationsModel model)
        {
            string PostURL = APIURL + "Notifications/SaveNotifications";
            int i = 0;
            TransactionDetails Response = new TransactionDetails();
            string DistricsList = "";
            string BlocksList = "";
            JArray DistrictsJArray = new JArray();
            JArray BlocksJArray = new JArray();
            JArray CropsJArray = new JArray();
            JObject objNotifications = new JObject();
            JObject objDistrict = new JObject();
            JObject objBlock = new JObject();
            JObject objCrop = new JObject();
            JObject Results = new JObject();
            try
            {
                if (model.DistrictList != null && model.DistrictList != "")
                {
                    string Districts = model.DistrictList.Substring(1, model.DistrictList.Length - 1);
                    DistricsList = Districts;
                    string[] DistrictsArray = Districts.Split(',');
                    foreach (var District in DistrictsArray)
                    {
                        objDistrict = new JObject
                        {
                            { "CADMID", i },
                            { "CropAdvisoryID", i },
                            { "StateID", model.StateId },
                            { "DistrictID", District },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        DistrictsJArray.Add(objDistrict);
                    }
                }
                if (model.BlockList != null && model.BlockList != "")
                {
                    string Blocks = model.BlockList.Substring(1, model.BlockList.Length - 1);
                    BlocksList = Blocks;
                    string[] BlocksArray = Blocks.Split(',');
                    foreach (var Block in BlocksArray)
                    {
                        objBlock = new JObject
                        {
                            { "CABMID", i },
                            { "CropAdvisoryID", i },
                            { "BlockID", Block },
                            { "DistrictID", i },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        BlocksJArray.Add(objBlock);
                    }
                }
                else
                {
                    BlocksList = "0";
                }
                if (model.CropList != null && model.CropList != "")
                {
                    string Crops = model.CropList.Substring(1, model.CropList.Length - 1);
                    string[] CropsArray = Crops.Split(',');
                    foreach (var Crop in CropsArray)
                    {
                        objCrop = new JObject
                        {
                            { "CACMID", i },
                            { "CropAdvisoryID", i },
                            { "CropID", Crop },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        CropsJArray.Add(objCrop);
                    }
                }
                objNotifications.Add("CropAdvisoryID", i);
                objNotifications.Add("Title", model.Title);
                objNotifications.Add("StateID", model.StateId);
                objNotifications.Add("CategoryID", model.CACID);
                objNotifications.Add("BriefText", model.BriefText);
                objNotifications.Add("CompleteMessage", model.CompleteMessage);
                objNotifications.Add("MobileApplication", model.MobileApplication);
                objNotifications.Add("SMSAlert", model.SMSAlert);
                objNotifications.Add("SMSLanguage", model.SMSLanguage);
                objNotifications.Add("LanguageType", model.LanguageType);
                objNotifications.Add("Createdby", model.ScientistId);
                objNotifications.Add("Updatedby", i);
                objNotifications.Add("DistricsList", DistricsList);
                objNotifications.Add("BlocksList", BlocksList);
                objNotifications.Add("ObjDistrictList", DistrictsJArray);
                objNotifications.Add("ObjBlockList", BlocksJArray);
                objNotifications.Add("ObjCropList", CropsJArray);
                Response = APIResponse.SaveDetails(objNotifications, PostURL);
                DistrictsJArray.Remove(objDistrict);
                BlocksJArray.Remove(objBlock);
                CropsJArray.Remove(objCrop);

            }
            catch (Exception Exception)
            {
                Response.ErrorMessage = Exception.Message.ToString();
            }
            return Response;
        }
        public TransactionDetails SaveSurveys(SurveysModel model)
        {
            string PostURL = APIURL + "Surveys/SaveSurveys";
            int i = 0;
            TransactionDetails Response = new TransactionDetails();
            JArray DistrictsJArray = new JArray();
            JArray BlocksJArray = new JArray();
            JArray CropsJArray = new JArray();
            JArray LanguagesJArray = new JArray();
            JObject objSurveys = new JObject();
            JObject objDistrict = new JObject();
            JObject objBlock = new JObject();
            JObject objCrop = new JObject();
            JObject objLanguage = new JObject();
            JObject Results = new JObject();
            try
            {
                if (model.DistrictList != null && model.DistrictList != "")
                {
                    string Districts = model.DistrictList.Substring(1, model.DistrictList.Length - 1);
                    string[] DistrictsArray = Districts.Split(',');
                    foreach (var District in DistrictsArray)
                    {
                        objDistrict = new JObject
                        {
                            { "CADMID", i },
                            { "CropAdvisoryID", i },
                            { "StateID", model.StateId },
                            { "DistrictID", District },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        DistrictsJArray.Add(objDistrict);
                    }
                }
                if (model.BlockList != null && model.BlockList != "")
                {
                    string Blocks = model.BlockList.Substring(1, model.BlockList.Length - 1);
                    string[] BlocksArray = Blocks.Split(',');
                    foreach (var Block in BlocksArray)
                    {
                        objBlock = new JObject
                        {
                            { "CABMID", i },
                            { "CropAdvisoryID", i },
                            { "BlockID", Block },
                            { "DistrictID", i },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        BlocksJArray.Add(objBlock);
                    }
                }
                if (model.CropList != null && model.CropList != "")
                {
                    string Crops = model.CropList.Substring(1, model.CropList.Length - 1);
                    string[] CropsArray = Crops.Split(',');
                    foreach (var Crop in CropsArray)
                    {
                        objCrop = new JObject
                        {
                            { "CACMID", i },
                            { "CropAdvisoryID", i },
                            { "CropID", Crop },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        CropsJArray.Add(objCrop);
                    }
                }
                if (model.LanguageList != null && model.LanguageList != "")
                {
                    string Languages = model.LanguageList.Substring(1, model.LanguageList.Length - 1);
                    string[] LanguagesArray = Languages.Split(',');
                    foreach (var Language in LanguagesArray)
                    {
                        objLanguage = new JObject
                        {
                            { "CALMID", i },
                            { "CropAdvisoryID", i },
                            { "LanguageID", Language },
                            { "CreatedBy", model.ScientistId },
                            { "UpdatedBy", i }
                        };
                        LanguagesJArray.Add(objLanguage);
                    }
                }
                objSurveys.Add("CropAdvisoryID", i);
                objSurveys.Add("Title", model.Title);
                objSurveys.Add("ScientistID", model.ScientistId);
                objSurveys.Add("StateID", model.StateId);
                objSurveys.Add("Question", model.Question);
                objSurveys.Add("OptionOneTitle", model.OptionOneTitle);
                objSurveys.Add("OptionTwoTitle", model.OptionTwoTitle);
                objSurveys.Add("Createdby", model.ScientistId);
                objSurveys.Add("Updatedby", i);
                objSurveys.Add("ObjDistrictList", DistrictsJArray);
                objSurveys.Add("ObjBlockList", BlocksJArray);
                objSurveys.Add("ObjCropList", CropsJArray);
                //objSurveys.Add("objLanguageList", LanguagesJArray);
                Response = APIResponse.SaveDetails(objSurveys, PostURL);
                DistrictsJArray.Remove(objDistrict);
                BlocksJArray.Remove(objBlock);
                CropsJArray.Remove(objCrop);

            }
            catch (Exception Exception)
            {
                Response.ErrorMessage = Exception.Message.ToString();
            }
            return Response;

        }
        public TransactionDetails SaveUser(UsersModel model)
        {
            string PostURL = APIURL + "Users/SaveScientist";
            int i = 0;
            TransactionDetails Response = new TransactionDetails();
            JArray BlocksJArray = new JArray();
            JArray CropsJArray = new JArray();
            JArray LanguagesJArray = new JArray();
            JObject objUsers = new JObject();
            JObject objUserImage = new JObject();
            JObject objBlock = new JObject();
            JObject objCrop = new JObject();
            JObject Results = new JObject();
            try
            {
                if (model.File != null)
                {
                    var streamLength = model.File.InputStream.Length;
                    var imageBytes = new byte[streamLength];
                    string Base64String = Convert.ToBase64String(imageBytes);
                    model.File.InputStream.Read(imageBytes, 0, imageBytes.Length);
                    objUserImage.Add("ByteStream", imageBytes);
                }
                if (model.BlockList != null && model.BlockList != "")
                {
                    string Blocks = model.BlockList.Substring(1, model.BlockList.Length - 1);
                    string[] BlocksArray = Blocks.Split(',');
                    foreach (var Block in BlocksArray)
                    {
                        objBlock = new JObject
                        {
                            { "ID", i },
                            { "UserID", i },
                            { "BlockID", Block },
                            { "DistrictID", i },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        BlocksJArray.Add(objBlock);
                    }
                }
                if (model.CropList != null && model.CropList != "")
                {
                    string Crops = model.CropList.Substring(1, model.CropList.Length - 1);
                    string[] CropsArray = Crops.Split(',');
                    foreach (var Crop in CropsArray)
                    {
                        objCrop = new JObject
                        {
                            { "ID", i },
                            { "UserID", i },
                            { "CropID", Crop },
                            { "Createdby", model.ScientistId },
                            { "Updatedby", i }
                        };
                        CropsJArray.Add(objCrop);
                    }
                }
                if (model.FirstName == null)
                {
                    model.FirstName = "";
                }
                if (model.LastName == null)
                {
                    model.LastName = "";
                }
                if (model.Institution == null)
                {
                    model.Institution = "";
                }
                if (model.Designation == null)
                {
                    model.Designation = "";
                }
                if (model.Location == null)
                {
                    model.Location = "";
                }
                if (model.PinCode == null)
                {
                    model.PinCode = "";
                }
                if (model.Email == null)
                {
                    model.Email = "";
                }
                objUsers.Add("UserId", i);
                objUsers.Add("TitleID", model.TitleId);
                objUsers.Add("GenderID",model.GenderId);
                objUsers.Add("DepartmentId", model.DepartmentId);
                objUsers.Add("LanguageId", model.LanguageId);
                objUsers.Add("StateID", model.StateId);
                objUsers.Add("DistrictID", model.DistrictID);
                objUsers.Add("FirstName", model.FirstName);
                objUsers.Add("LastName", model.LastName);
                objUsers.Add("MobileNumber", model.MobileNumber);
                objUsers.Add("Institution", model.Institution);
                objUsers.Add("Designation", model.Designation);
                objUsers.Add("Location", model.Location);
                objUsers.Add("PinCode", model.PinCode);
                objUsers.Add("Email", model.Email);
                objUsers.Add("Createdby", model.ScientistId);
                objUsers.Add("Updatedby", i);
                objUsers.Add("ObjUserImage", objUserImage);
                objUsers.Add("ObjBlockList", BlocksJArray);
                objUsers.Add("ObjCropList", CropsJArray);
                Response = APIResponse.SaveDetails(objUsers, PostURL);
            }
            catch (Exception Exception)
            {
                Response.ErrorMessage = Exception.Message.ToString();
            }
            return Response;

        }
        public TransactionDetails SaveLanguages(Languages model)
        {
            string PostURL = APIURL + "CropAdvisory/SaveLanguageList";
            int i = 0;
            TransactionDetails Response = new TransactionDetails();
            JObject objUsers = new JObject();
            try
            {
               
                if (model.Assamese == null)
                {
                    model.Assamese = "";
                }
                if (model.Bengali == null)
                {
                    model.Bengali = "";
                }
                if (model.Bhili == null)
                {
                    model.Bhili = "";
                }
                if (model.Bodo == null)
                {
                    model.Bodo = "";
                }
                if (model.Dogri == null)
                {
                    model.Dogri = "";
                }
                if (model.English == null)
                {
                    model.English = "";
                }
                if (model.Gondi == null)
                {
                    model.Gondi = "";
                }
                if (model.Gujarati == null)
                {
                    model.Gujarati = "";
                }
                if (model.Hindi == null)
                {
                    model.Hindi = "";
                }
                if (model.Ho == null)
                {
                    model.Ho = "";
                }
                if (model.Kannada == null)
                {
                    model.Kannada = "";
                }
                if (model.Kashmiri == null)
                {
                    model.Kashmiri = "";
                }
                if (model.Khandeshi == null)
                {
                    model.Khandeshi = "";
                }
                if (model.Khasi == null)
                {
                    model.Khasi = "";
                }
                if (model.Konkani == null)
                {
                    model.Konkani = "";
                }
                if (model.Kurukh == null)
                {
                    model.Kurukh = "";
                }
                if (model.Maithili == null)
                {
                    model.Maithili = "";
                }
                if (model.Malayalam == null)
                {
                    model.Malayalam = "";
                }
                if (model.Manipuri == null)
                {
                    model.Manipuri = "";
                }
                if (model.Marati == null)
                {
                    model.Marati = "";
                }
                if (model.Mundari == null)
                {
                    model.Mundari = "";
                }
                if (model.Nepali == null)
                {
                    model.Nepali = "";
                }
                if (model.Oriya == null)
                {
                    model.Oriya = "";
                }
                if (model.Punjabi == null)
                {
                    model.Punjabi = "";
                }
                if (model.Santali == null)
                {
                    model.Santali = "";
                }
                if (model.Sindhi == null)
                {
                    model.Sindhi = "";
                }
                if (model.Tamil == null)
                {
                    model.Tamil = "";
                }
                if (model.Telugu == null)
                {
                    model.Telugu = "";
                }
                if (model.Tulu == null)
                {
                    model.Tulu = "";
                }
                if (model.Urdu == null)
                {
                    model.Urdu = "";
                }
                objUsers.Add("ID", i);
                objUsers.Add("Assamese", model.Assamese);
                objUsers.Add("Bengali", model.Bengali);
                objUsers.Add("Bhili", model.Bhili);
                objUsers.Add("Bodo", model.Bodo);
                objUsers.Add("Dogri", model.Dogri);
                objUsers.Add("English", model.English);
                objUsers.Add("Gondi", model.Gondi);
                objUsers.Add("Gujarati", model.Gujarati);
                objUsers.Add("Hindi", model.Hindi);
                objUsers.Add("Ho", model.Ho);
                objUsers.Add("Kannada", model.Kannada);
                objUsers.Add("Kashmiri", model.Kashmiri);
                objUsers.Add("Khandeshi", model.Khandeshi);
                objUsers.Add("Khasi", model.Khasi);
                objUsers.Add("Konkani", model.Konkani);
                objUsers.Add("Kurukh", model.Kurukh);
                objUsers.Add("Maithili", model.Maithili);
                objUsers.Add("Malayalam", model.Malayalam);
                objUsers.Add("Manipuri", model.Manipuri);
                objUsers.Add("Marati", model.Marati);
                objUsers.Add("Mundari", model.Mundari);
                objUsers.Add("Nepali", model.Nepali);
                objUsers.Add("Oriya", model.Oriya);
                objUsers.Add("Punjabi", model.Punjabi);
                objUsers.Add("Santali", model.Santali);
                objUsers.Add("Sindhi", model.Sindhi);
                objUsers.Add("Tamil", model.Tamil);
                objUsers.Add("Telugu", model.Telugu);
                objUsers.Add("Tulu", model.Tulu);
                objUsers.Add("Urdu", model.Urdu);
               
                Response = APIResponse.SaveDetails(objUsers, PostURL);
            }
            catch (Exception Exception)
            {
                Response.ErrorMessage = Exception.Message.ToString();
            }
            return Response;

        }
        #endregion

        #region Action result
        [Authorize]
        [HttpGet]
        public ActionResult Weather()
        {
            ApplyCulture();
            return View();
        }
        [Authorize]
        [HttpGet]
        public ActionResult CropAdvisory()
        {
            ApplyCulture();
            return View();
        }
        [HttpPost]
        public ActionResult CropAdvisory(CropAdvisoryModel model)
        {
            return RedirectToAction("CropAdvisory");
        }
        [Authorize]
        [HttpGet]
        public ActionResult AdvisoryCategory(int CAMID)
        {
            CropAdvisoryDetails model = new CropAdvisoryDetails();
            CropAdvisoryResponse Response = new CropAdvisoryResponse();
            ApplyCulture();
            string LanguageType = "";
            if (Request.Cookies["LanguageName"].Value != null || Request.Cookies["LanguageName"].Value.ToString() != "")
            {
                LanguageType = Request.Cookies["LanguageName"].Value.ToString();
            }
            else
            {
                LanguageType = "English";
            }
            Response = GetCropAdvisoryCategoryById(CAMID, LanguageType);
            if(Response.IsSuccessful)
            {
                if(Response.ObjCropAdvisoryDetailsList.Count >0)
                {
                    model = Response.ObjCropAdvisoryDetailsList[0];
                    model.CAMID = CAMID;
                }
            }
            
            return View(model);
        }
        [Authorize]
        [HttpGet]
        public ActionResult AddAdvisoryCategory()
        {
            CropAdvisoryModel model = new CropAdvisoryModel();
            ApplyCulture();
            string LanguageType = "";
            if (Request.Cookies["LanguageName"].Value != null || Request.Cookies["LanguageName"].Value.ToString() != "")
            {
                LanguageType = Request.Cookies["LanguageName"].Value.ToString();
            }
            else
            {
                LanguageType = "English";
            }
            string ScientistId = "";
            if (Request.Cookies["TypeOfRole"].Value != null || Request.Cookies["TypeOfRole"].Value.ToString() != "")
            {
                ScientistId = Request.Cookies["TypeOfRole"].Value.ToString();
            }
            else
            {
                ScientistId = "0";
            }
            FillDDL(LanguageType, ScientistId);
            model.MobileApplication = true;
            model.SMSAlert = true;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAdvisoryCategory(CropAdvisoryModel model)
        {
            TransactionDetails Response = new TransactionDetails();
            TransactionDetails ResponseCrop = new TransactionDetails();
            Response = SaveCropAdvisoryMasters(model);
            if(Response.IsSuccessful && Response.NewID >0)
            {
                model.CAMID = Convert.ToInt32(Response.NewID);
                ResponseCrop = SaveCropAdvisory(model);
                return RedirectToAction("CropAdvisory");
            }
            else
            {
                return View(model);
            }
        }
        [Authorize]
        [HttpGet]
        public ActionResult AddAdvisory(int CAMID)
        {
            CropAdvisoryResponse Response = new CropAdvisoryResponse();
            CropAdvisoryModel model = new CropAdvisoryModel();
            ApplyCulture();
            string LanguageType = "";
            if (Request.Cookies["LanguageName"].Value != null || Request.Cookies["LanguageName"].Value.ToString() != "")
            {
                LanguageType = Request.Cookies["LanguageName"].Value.ToString();
            }
            else
            {
                LanguageType = "English";
            }
            string ScientistId = "";
            if (Request.Cookies["TypeOfRole"].Value != null || Request.Cookies["TypeOfRole"].Value.ToString() != "")
            {
                ScientistId = Request.Cookies["TypeOfRole"].Value.ToString();
            }
            else
            {
                ScientistId = "0";
            }
            FillDDL(LanguageType, ScientistId);
            Response = GetCropAdvisoryCategoryById(CAMID, LanguageType);
            if (Response.IsSuccessful)
            {
                if (Response.ObjCropAdvisoryDetailsList.Count > 0)
                {
                    model.DistrictList = Response.ObjCropAdvisoryDetailsList[0].DistrictList;
                    model.BlockList = Response.ObjCropAdvisoryDetailsList[0].BlockList;
                    model.StateId = Response.ObjCropAdvisoryDetailsList[0].StateID;
                    model.Title= Response.ObjCropAdvisoryDetailsList[0].Title;
                    model.SMSLanguage= Response.ObjCropAdvisoryDetailsList[0].SMSLanguage;
                    model.MobileApplication = true;
                    model.SMSAlert = true;
                }
            }
            model.CAMID = CAMID;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAdvisory(CropAdvisoryModel model)
        {
            TransactionDetails Response = new TransactionDetails();
            Response = SaveCropAdvisory(model);
            if(Response.IsSuccessful)
            {
                return RedirectToAction("CropAdvisory");
            }
            else
            {
                return RedirectToAction("AddAdvisory", new { model.CAMID });
            }
        }
        [Authorize]
        [HttpGet]
        public ActionResult Notifications()
        {
            ApplyCulture();
            return View();
        }
        [HttpPost]
        public ActionResult Notifications(NotificationsModel model)
        {
            return RedirectToAction("Notifications");
        }
        [Authorize]
        [HttpGet]
        public ActionResult SendNotification()
        {
            ApplyCulture();
            string LanguageType = "";
            if (Request.Cookies["LanguageName"].Value != null || Request.Cookies["LanguageName"].Value.ToString() != "")
            {
                LanguageType = Request.Cookies["LanguageName"].Value.ToString();
            }
            else
            {
                LanguageType = "English";
            }
            FillDDLAlert(LanguageType,"0");
            return View();
        }
        [HttpPost]
        public ActionResult SendNotification(NotificationsModel model)
        {
            TransactionDetails Response = new TransactionDetails();
            Response = SaveNotification(model);
            return RedirectToAction("Notifications");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Surveys()
        {
            ApplyCulture();
            return View();
        }
        [HttpPost]
        public ActionResult Surveys(SurveysModel model)
        {
            //string result = SaveSurveys(model);
            return RedirectToAction("Surveys");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Users()
        {
            ApplyCulture();
            string LanguageName = "";
            if (Request.Cookies["LanguageName"].Value != null && Request.Cookies["LanguageName"].Value != "")
            {
                LanguageName =  Request.Cookies["LanguageName"].Value.ToString();
            }
            else
            {
                LanguageName = "English";
            }
            FillUsersDDL(LanguageName);
            return View();
        }
        [HttpPost]
        public ActionResult Users(UsersModel model)
        {
            SaveUser(model);
            return RedirectToAction("Users");
        }
        [Authorize]
        [HttpGet]
        public ActionResult UserProfile()
        {
            ApplyCulture();
            string UserProfileID = "", RoleType = "", LanguageType="";
            if (Request.Cookies["TypeOfRole"].Value != null || Request.Cookies["TypeOfRole"].Value.ToString() != "")
            {
                UserProfileID = Request.Cookies["TypeOfRole"].Value.ToString();
            }
            if (Request.Cookies["LanguageName"].Value != null || Request.Cookies["LanguageName"].Value.ToString() != "")
            {
                LanguageType = Request.Cookies["LanguageName"].Value.ToString();
            }
            if (Request.Cookies["RoleType"].Value != null || Request.Cookies["RoleType"].Value.ToString() != "")
            {
                RoleType = Request.Cookies["RoleType"].Value.ToString();
                ModelList = GetUserProfile(UserProfileID, RoleType, LanguageType).ObjUserProfileList;
            }
            else
            {
                ModelList = new List<UserProfile>();
            }
            return View(ModelList);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Languages()
        {
           List<Languages> modelList = new List<Languages>();
            modelList = GetAgrometLanguages().ObjLanguagesList;
            Languages model = new Languages();
            ApplyCulture();
            string UserProfileID = "", RoleType = "", LanguageType = "";
            if (Request.Cookies["TypeOfRole"].Value != null || Request.Cookies["TypeOfRole"].Value.ToString() != "")
            {
                UserProfileID = Request.Cookies["TypeOfRole"].Value.ToString();
            }
            if (Request.Cookies["LanguageName"].Value != null || Request.Cookies["LanguageName"].Value.ToString() != "")
            {
                LanguageType = Request.Cookies["LanguageName"].Value.ToString();
            }
            if (Request.Cookies["RoleType"].Value != null || Request.Cookies["RoleType"].Value.ToString() != "")
            {
                RoleType = Request.Cookies["RoleType"].Value.ToString();
            }
            if(modelList.Count == 0)
            {
                model = new Languages();
                return View(model);
            }
            else
            {
                model = modelList[modelList.Count-1];
                return View(model);
            }
           
        }
        [Authorize]
        [HttpGet]
        public ActionResult AddLanguages()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLanguages(Languages model)
        {
            TransactionDetails Response = new TransactionDetails();
            Response = SaveLanguages(model);
            return RedirectToAction("Languages");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Dashboard()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public ActionResult FarmerDetails(int CAMID,string CropAdvisoryID,string LogInId)
        {
            ViewBag.CAMID = CAMID;
            ViewBag.CropAdvisoryID = CropAdvisoryID;
            ViewBag.LogInId = LogInId;
            return View();
        }
        #endregion
    }
}