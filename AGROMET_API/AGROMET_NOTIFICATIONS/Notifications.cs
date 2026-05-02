using AGROMET_COMMON;
using AGROMET_DAL;
using AGROMET_NOTIFICATIONS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static AGROMET_COMMON.Common;

namespace AGROMET_Notifications
{
    public class NotificationsDetails
    {
        public int NotificationsID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string PhoneNumber { get; set; }
        public string CompleteMessage { get; set; }
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public int StateID { get; set; }
        public int DistrictID { get; set; }
        public int BlockID { get; set; }
        public string CropName { get; set; }
        public int CropID { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public string BriefText { get; set; }
        public string BlocksList { get; set; }
        public string DistricsList { get; set; }
        public bool MobileApplication { get; set; }
        public bool SMSAlert { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedDateWeb { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public byte[] ImageBytes { get; set; }
        public string LanguageType { get; set; }
        public string SMSLanguage { get; set; }
        public string RefreshDateTime { get; set; }
        public List<NotificationsDistrict> ObjDistrictList { get; set; }
        public List<NotificationsBlock> ObjBlockList { get; set; }
        public List<NotificationsCrop> ObjCropList { get; set; }
    }
    public class NotificationsDistrict
    {
        public int NDMID { get; set; }
        public int NotificationsID { get; set; }
        public int DistrictID { get; set; }
        public string DistictName { get; set; }
        public int StateID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }

    }
    public class NotificationsBlock
    {
        public int NBMID { get; set; }
        public int NotificationsID { get; set; }
        public string BlockName { get; set; }
        public int BlockID { get; set; }
        public int DistrictID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class NotificationsCrop
    {
        public int NCMID { get; set; }
        public int NotificationsID { get; set; }
        public string CropName { get; set; }
        public int CropID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class DistrictWarnings
    {
        public string Date { get; set; }
        public string full_date { get; set; }
        public string Day { get; set; }

        public string District { get; set; }

        public string Day_1 { get; set; }

        public string Day_2 { get; set; }

        public string Day_3 { get; set; }

        public string Day_4 { get; set; }

        public string Day_5 { get; set; }

        public string Lat { get; set; }

        public string Lon { get; set; }

        public string Lat1 { get; set; }

        public string Lon1 { get; set; }

        public string Lat2 { get; set; }

        public string Lon2 { get; set; }

        public string Day1_Color { get; set; }

        public string Day2_Color { get; set; }

        public string Day3_Color { get; set; }

        public string Day4_Color { get; set; }

        public string Day5_Color { get; set; }

        public string Warning { get; set; }
        public string NotifyType { get; set; }

        public string Color { get; set; }
        public string UserID { get; set; }
        public string DistrictName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }

    }
    public class DistrictwiseNowcast
    {
        public string Date { get; set; }

        public string State_District { get; set; }

        public string Cat1 { get; set; }

        public string Cat2 { get; set; }

        public string Cat3 { get; set; }

        public string Cat4 { get; set; }

        public string Cat5 { get; set; }

        public string Cat6 { get; set; }

        public string Cat7 { get; set; }

        public string Cat8 { get; set; }

        public string Cat9 { get; set; }

        public string Cat10 { get; set; }

        public string Cat11 { get; set; }

        public string Cat12 { get; set; }

        public string Cat13 { get; set; }

        public string Cat14 { get; set; }

        public string Cat15 { get; set; }

        public string Cat16 { get; set; }

        public string Message { get; set; }

        public string TOI { get; set; }

        public string VUpTo { get; set; }
        public string WarningsDetails { get; set; }
        public string NotifyType { get; set; }
        public string UserID { get; set; }
        public string DistrictName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
        public string full_date { get; set; }
    }
    public class UserLocations
    {
        public int UALID { get; set; }
        public int UserProfileID { get; set; }
        public int StateID { get; set; }
        public int DistrictID { get; set; }
        public int BlockID { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string BlockName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
    }
    public class NotificationsResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<NotificationsDetails> ObjNotificationsDetailsList { get; set; }
        public List<NotificationsDistrict> ObjNotificationsDistMappList { get; set; }
        public List<NotificationsBlock> ObjNotificationsBlockMappList { get; set; }
        public List<NotificationsCrop> ObjNotificationsCropMappList { get; set; }
        public List<DistrictWarnings> ObjDistrictWarningsList { get; set; }
        public List<UserLocations> ObjUserLocationsList { get; set; }
        public List<DistrictwiseNowcast> ObjDistrictwiseNowcastList { get; set; }

        public NotificationsResponse()
        {
            this.ObjNotificationsDetailsList = new List<NotificationsDetails>();
            this.ObjNotificationsDistMappList = new List<NotificationsDistrict>();
            this.ObjNotificationsBlockMappList = new List<NotificationsBlock>();
            this.ObjNotificationsCropMappList = new List<NotificationsCrop>();
            this.ObjDistrictWarningsList = new List<DistrictWarnings>();
            this.ObjUserLocationsList = new List<UserLocations>();
            this.ObjDistrictwiseNowcastList = new List<DistrictwiseNowcast>();
        }
    }

    public class MobileTokens
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public int UserProfileId { get; set; }
    }

    public class Notification
    {
        public string Token { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int ColorCode { get; set; }
    }

    public class NowCastWarningNotification
    {
        public int NotificationId { get; set; }
        public string NotificationTitle { get; set; }
        public string NotificationMessage { get; set; }
        public int UserProfileId { get; set; }
        public bool Flag { get; set; }
        public string CreatedDate { get; set; }
        public string IssueDate { get; set; }
        public string UpdatedDate { get; set; }
        public string ColorCode { get; set; }
        public string TimeOfIssueMessage { get; set; }
        public string ValidUpToMessage { get; set; }
    }
    public class Message
    {
        public string To { get; set; }

        public IEnumerable<string> Registration_ids { get; set; }

        public Priority Priority { get; set; }

        public bool Content_available { get; set; }

        public NotificationContent Notification { get; set; }

        public StateData Data { get; set; }
    }
    public class NotificationContent
    {
        public string Title { get; set; }

        public string Body { get; set; }
        public string sound { get; set; }
    }
    public class StateData
    {
        public string Id { get; set; }
        public string ColorCode { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }
    }
    public class Notifications
    {
        public static string DistrictWarningURL = ConfigurationManager.AppSettings["DistrictWarning"].ToString();
        public static string DistrictNowCastURL = ConfigurationManager.AppSettings["DistrictNowCast"].ToString();
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #region Save Notifications

        #region SaveNotifications
        public static TransactionDetails SaveNotifications(NotificationsDetails ObjDetails)
        {
            TransactionDetails response = new TransactionDetails();
            NotificationsDistrict ObjDistrict = new NotificationsDistrict();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                                          new SqlParameter("@pNotificationDetailsID",ObjDetails.NotificationsID),
                                          new SqlParameter("@pCategoryID",ObjDetails.CategoryID),
                                        new SqlParameter("@pBriefText",ObjDetails.BriefText),
                                        new SqlParameter("@pTitle", ObjDetails.Title),
                                        new SqlParameter("@pMessageText",ObjDetails.CompleteMessage),
                                        new SqlParameter("@pStateID",ObjDetails.StateID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                                        new SqlParameter("@pMobileApplication",ObjDetails.MobileApplication),
                                        new SqlParameter("@pSMSAlert",ObjDetails.SMSAlert),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_NotificationDetails", arrParams);
                if (response.IsSuccessful == true)
                {
                    if (response.NewID > 0)
                    {
                        if (ObjDetails.ObjDistrictList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjDistrictList)
                            {
                                Item.NotificationsID = Convert.ToInt32(response.NewID);
                                SaveNotificationsDistrict(Item);
                            }
                        }
                        if (ObjDetails.ObjBlockList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjBlockList)
                            {
                                Item.NotificationsID = Convert.ToInt32(response.NewID);
                                SaveNotificationsBlock(Item);
                            }
                        }
                        if (ObjDetails.ObjCropList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjCropList)
                            {
                                Item.NotificationsID = Convert.ToInt32(response.NewID);
                                SaveNotificationsCrop(Item);
                            }
                        }
                        if (ObjDetails.SMSAlert)
                        {
                            SendNotificationsSMS(ObjDetails);
                        }
                    }
                }
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {

                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        #endregion

        #region SaveNotificationsDistrict
        public static TransactionDetails SaveNotificationsDistrict(NotificationsDistrict ObjDetails)
        {
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pNDMID",ObjDetails.NDMID),
                                        new SqlParameter("@pNotificationDetailsID", ObjDetails.NotificationsID),
                                        new SqlParameter("@pStateID",ObjDetails.StateID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_Notification_DistrictMapping", arrParams);
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {

                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        #endregion

        #region SaveNotificationsBlock
        public static TransactionDetails SaveNotificationsBlock(NotificationsBlock ObjDetails)
        {
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {

                                        new SqlParameter("@pNBMID",ObjDetails.NBMID),
                                        new SqlParameter("@pNotificationDetailsID", ObjDetails.NotificationsID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pBlockID",ObjDetails.BlockID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_Notification_BlockMapping", arrParams);
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {

                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        #endregion

        #region SaveNotificationsCrop
        public static TransactionDetails SaveNotificationsCrop(NotificationsCrop ObjDetails)
        {
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pNotificationDetailsID",ObjDetails.NotificationsID),
                   new SqlParameter("@pNCMID", ObjDetails.NCMID),
                   new SqlParameter("@pCropID",ObjDetails.CropID),
                   new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                   new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_Notification_CropMapping", arrParams);
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {

                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        #endregion

        #region SendNotificationsSMS
        public static NotificationsResponse SendNotificationsSMS(NotificationsDetails ObjDetails)
        {
            NotificationsResponse response = new NotificationsResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pBlockID",ObjDetails.BlocksList),
                   new SqlParameter("@pdistrictid",ObjDetails.DistricsList),
                   new SqlParameter("@planguagetype",ObjDetails.LanguageType),
                   new SqlParameter("@pRefreshdatetime","2016-12-12"),
                };
                dt = SQLHelper.Execute("spGet_PhoneNumbersForNotificationSending", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjNotificationsDetailsList =
                  (from DataRow dr in dt.Rows
                   select new NotificationsDetails
                   {
                       PhoneNumber = (dr["PhoneNumber"]) == DBNull.Value ? "" : Convert.ToString(dr["PhoneNumber"]),
                   }).ToList();
                    response.IsSuccessful = true;
                }
                if (response.ObjNotificationsDetailsList != null && response.ObjNotificationsDetailsList.Count > 0)
                {
                    StringBuilder PhoneNumber = new StringBuilder();
                    foreach (var item in response.ObjNotificationsDetailsList)
                    {
                        PhoneNumber.Append(item.PhoneNumber + ",");
                    }
                    string Message = ObjDetails.Title + " \n\n" + ObjDetails.BriefText;
                    if (ObjDetails.SMSLanguage == "English")
                    {
                        Utilities.SendSMS(Message, PhoneNumber.ToString());
                    }
                    else
                    {
                        Utilities.SendSMS_Lang(Message, PhoneNumber.ToString());
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
        #endregion


        #region SaveDistrictWiseNowcastNowFromFTP
        public static TransactionDetails SaveDistrictWarningNowFromFTP()
        {
            #region Log Start

            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            var transactionResponse = new TransactionDetails();
            try
            {
                // Get the object used to communicate with the server.
                var request = (FtpWebRequest)WebRequest.Create(DistrictWarningURL);
                request.Timeout = GlobalConstant.TimeOutValue;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                // This example assumes the FTP site uses logon.
                request.Credentials = new NetworkCredential("icrisat", "D4n%83nk226");
                _log.Info("Callid : " + callId + " connecting IMD Server in SaveDistrictWarningNowFromFTP in notification service");
                var response = (FtpWebResponse)request.GetResponse();
                _log.Info("Callid : " + callId + " connected IMD Service SaveDistrictWarningNowFromFTP in notification service");
                Stream responseStream = response.GetResponseStream();
                _log.Info("Callid : " + callId + " get response from IMD Server SaveDistrictWarningNowFromFTP in notification service");
                StreamReader reader = new StreamReader(responseStream);
                string[] allLines = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                _log.Info("Callid : " + callId + " read data from csv in SaveDistrictWarningNowFromFTP in notification service");
                foreach (var items in allLines)
                {
                    try
                    {
                        _log.Info("Callid : " + callId + " data optimization in SaveDistrictWarningNowFromFTP in notification service");
                        string[] values = Regex.Split(items, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                        //string[] values = items.Split(',');  
                        if (Convert.ToString(values[1]) == EmptyValue || Convert.ToString(values[1]) == ZeroValue) values[1] = "";
                        if (Convert.ToString(values[2]) == EmptyValue || Convert.ToString(values[2]) == ZeroValue) values[2] = "";
                        if (Convert.ToString(values[3]) == EmptyValue || Convert.ToString(values[3]) == ZeroValue) values[3] = "";                        
                        if (Convert.ToString(values[4]) == EmptyValue || Convert.ToString(values[4]) == ZeroValue) values[4] = "";
                        if (Convert.ToString(values[5]) == EmptyValue || Convert.ToString(values[5]) == ZeroValue) values[5] = "";
                        if (Convert.ToString(values[6]) == EmptyValue || Convert.ToString(values[6]) == ZeroValue) values[6] = "";
                        if (Convert.ToString(values[7]) == EmptyValue || Convert.ToString(values[7]) == ZeroValue) values[7] = "";
                        if (Convert.ToString(values[8]) == EmptyValue || Convert.ToString(values[8]) == ZeroValue) values[8] = "";
                        if (Convert.ToString(values[9]) == EmptyValue || Convert.ToString(values[9]) == ZeroValue) values[9] = "";
                        if (Convert.ToString(values[10]) == EmptyValue || Convert.ToString(values[10]) == ZeroValue) values[10] = "";
                        if (Convert.ToString(values[11]) == EmptyValue || Convert.ToString(values[11]) == ZeroValue) values[11] = "";
                        if (Convert.ToString(values[12]) == EmptyValue || Convert.ToString(values[12]) == ZeroValue) values[12] = "";
                        if (Convert.ToString(values[13]) == EmptyValue || Convert.ToString(values[13]) == ZeroValue) values[13] = "";
                        if (Convert.ToString(values[14]) == EmptyValue || Convert.ToString(values[14]) == ZeroValue) values[14] = "";
                        if (Convert.ToString(values[15]) == EmptyValue || Convert.ToString(values[15]) == ZeroValue) values[15] = "";
                        if (Convert.ToString(values[16]) == EmptyValue || Convert.ToString(values[16]) == ZeroValue) values[16] = "";
                        if (Convert.ToString(values[17]) == EmptyValue || Convert.ToString(values[17]) == ZeroValue) values[17] = "";
                        if (Convert.ToString(values[18]) == EmptyValue || Convert.ToString(values[18]) == ZeroValue) values[18] = "";
                        if (Convert.ToString(values[19]) == EmptyValue || Convert.ToString(values[19]) == ZeroValue) values[19] = "";
                        if (Convert.ToString(values[20]) == EmptyValue || Convert.ToString(values[20]) == ZeroValue) values[20] = "";
                        

                        var pobjId = string.IsNullOrEmpty(values[1]) == true ? "" : Convert.ToString(values[1]).Substring(1, (Convert.ToString(values[1]).Length - 2));
                        var pDate = string.IsNullOrEmpty(values[2]) == true ? "" : Convert.ToString(values[2]).Substring(1, (Convert.ToString(values[2]).Length - 2));
                        var pUTC = string.IsNullOrEmpty(values[3]) == true ? "" : Convert.ToString(values[3]).Substring(1, (Convert.ToString(values[3]).Length - 2));
                        var pDistrictName = string.IsNullOrEmpty(values[4]) == true ? "" : Convert.ToString(values[4]).Substring(1, (Convert.ToString(values[4]).Length - 2));
                        var pDay_1 = string.IsNullOrEmpty(values[5]) == true ? "" : Convert.ToString(values[5]).Substring(1, (Convert.ToString(values[5]).Length - 2));
                        var pDay_2 = string.IsNullOrEmpty(values[6]) == true ? "" : Convert.ToString(values[6]).Substring(1, (Convert.ToString(values[6]).Length - 2));
                        var pDay_3 = string.IsNullOrEmpty(values[7]) == true ? "" : Convert.ToString(values[7]).Substring(1, (Convert.ToString(values[7]).Length - 2));
                        var pDay_4 = string.IsNullOrEmpty(values[8]) == true ? "" : Convert.ToString(values[8]).Substring(1, (Convert.ToString(values[8]).Length - 2));
                        var pDay_5 = string.IsNullOrEmpty(values[9]) == true ? "" : Convert.ToString(values[9]).Substring(1, (Convert.ToString(values[9]).Length - 2));
                        var pLat = string.IsNullOrEmpty(values[10]) == true ? "" : Convert.ToString(values[10]).Substring(1, (Convert.ToString(values[10]).Length - 2));
                        var pLon = string.IsNullOrEmpty(values[11]) == true ? "" : Convert.ToString(values[11]).Substring(1, (Convert.ToString(values[11]).Length - 2));
                        var pLat1 = string.IsNullOrEmpty(values[12]) == true ? "" : Convert.ToString(values[12]).Substring(1, (Convert.ToString(values[12]).Length - 2));
                        var pLon1 = string.IsNullOrEmpty(values[13]) == true ? "" : Convert.ToString(values[13]).Substring(1, (Convert.ToString(values[13]).Length - 2));
                        var pLat2 = string.IsNullOrEmpty(values[14]) == true ? "" : Convert.ToString(values[14]).Substring(1, (Convert.ToString(values[14]).Length - 2));
                        var pLon2 = string.IsNullOrEmpty(values[15]) == true ? "" : Convert.ToString(values[15]).Substring(1, (Convert.ToString(values[15]).Length - 2));
                        var pDay1_Color = string.IsNullOrEmpty(values[16]) == true ? "" : Convert.ToString(values[16]).Substring(1, (Convert.ToString(values[16]).Length - 2));
                        var pDay2_Color = string.IsNullOrEmpty(values[17]) == true ? "" : Convert.ToString(values[17]).Substring(1, (Convert.ToString(values[17]).Length - 2));
                        var pDay3_Color = string.IsNullOrEmpty(values[18]) == true ? "" : Convert.ToString(values[18]).Substring(1, (Convert.ToString(values[18]).Length - 2));
                        var pDay4_Color = string.IsNullOrEmpty(values[19]) == true ? "" : Convert.ToString(values[19]).Substring(1, (Convert.ToString(values[19]).Length - 2));
                        var pDay5_Color = string.IsNullOrEmpty(values[20]) == true ? "" : Convert.ToString(values[20]).Substring(1, (Convert.ToString(values[20]).Length - 2));


                        SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pobjId", pobjId),
                                        new SqlParameter("@pDate", pDate),
                                        new SqlParameter("@pUTC", pUTC),
                                        new SqlParameter("@pDistrictName", pDistrictName),
                                        new SqlParameter("@pDay_1", pDay_1),
                                        new SqlParameter("@pDay_2", pDay_2),
                                        new SqlParameter("@pDay_3", pDay_3),
                                        new SqlParameter("@pDay_4", pDay_4),
                                        new SqlParameter("@pDay_5", pDay_5),
                                        new SqlParameter("@pLat", pLat),
                                        new SqlParameter("@pLon", pLon),
                                        new SqlParameter("@pLat1", pLat1),
                                        new SqlParameter("@pLon1", pLon1),
                                        new SqlParameter("@pLat2", pLat2),
                                        new SqlParameter("@pLon2", pLon2),
                                        new SqlParameter("@pDay1_Color", pDay1_Color),
                                        new SqlParameter("@pDay2_Color", pDay2_Color),
                                        new SqlParameter("@pDay3_Color", pDay3_Color),
                                        new SqlParameter("@pDay4_Color", pDay4_Color),
                                        new SqlParameter("@pDay5_Color", pDay5_Color)
                                };
                        _log.Info("Callid : " + callId + " calling ExecuteOutIDParameter in SaveDistrictWarningNowFromFTP in notification service");
                        transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_DistrictWarningDetails", arrParams);
                        _log.Info("Callid : " + callId + " called ExecuteOutIDParameter in SaveDistrictWarningNowFromFTP in notification service");
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in SaveDistrictWarningNowFromFTP in notification service :" + ex.Message);
                        transactionResponse.ErrorMessage = ex.Message.ToString();
                    }
                }
                reader.Close();
                response.Close();
                _log.Info("Callid : " + callId + " ended SaveDistrictWarningNowFromFTP in notification service");
                LogCallEnd(callId, methodName, DateTime.Now);
                return transactionResponse;
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in SaveDistrictWarningNowFromFTP in notification service : " + ex.Message);
                transactionResponse.ErrorMessage = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
                return transactionResponse;
            }

        }
        #endregion

        #region SaveDistrictWarningNowFromFTP
        public static TransactionDetails SaveDistrictWiseNowcastNowFromFTP()
        {
            #region Log Start

            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            string callId = Guid.NewGuid().ToString();
            DateTime starttime = DateTime.Now;

            LogCallStart(callId, methodName, starttime);

            #endregion Log Start

            var transactionResponse = new TransactionDetails();
            try
            {

                // Get the object used to communicate with the server.
                var request = (FtpWebRequest)WebRequest.Create(DistrictNowCastURL);
                request.Timeout = GlobalConstant.TimeOutValue;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                // This example assumes the FTP site uses logon.
                request.Credentials = new NetworkCredential("icrisat", "D4n%83nk226");
                _log.Info("Callid : " + callId + " connecting IMD Service in SaveDistrictWiseNowcastNowFromFTP in notification service");
                var response = (FtpWebResponse)request.GetResponse();
                _log.Info("Callid : " + callId + " connected IMDService SaveDistrictWiseNowcastNowFromFTP in notification service");
                var responseStream = response.GetResponseStream();
                var reader = new StreamReader(responseStream);
                _log.Info("Callid : " + callId + " reading data from csv file in SaveDistrictWiseNowcastNowFromFTP in notification service");
                var allLines = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                _log.Info("Callid : " + callId + " reading done data from csv in SaveDistrictWiseNowcastNowFromFTP in notification service");
                var dataSet = new DataSet();
                var nowcastTable = new DataTable();
                foreach (var items in allLines)
                {
                    try
                    {
                        _log.Info("Callid : " + callId + " optimizing response data in SaveDistrictWiseNowcastNowFromFTP in notification service");
                        //string[] values = items.Split(',');
                        var todayDate = DateTime.UtcNow.ToString("yyyy-MM-dd");
                        string[] values = Regex.Split(items, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                        var startTimeValue = Convert.ToString(values[26]) == EmptyValue ? 0 : Convert.ToInt32((values[26]).ToString().Substring(1, ((values[26]).ToString().Length - 2)));
                        var endTimeValue = Convert.ToString(values[27]) == EmptyValue ? 0 : Convert.ToInt32((values[27]).ToString().Substring(1, ((values[27]).ToString().Length - 2)));
                        var date = Convert.ToString(values[2]) == EmptyDate ? DateTime.UtcNow.ToString("yyyy-MM-dd") : (values[2]).ToString().Substring(1, ((values[2]).ToString().Length - 2));
                        var districtName = Convert.ToString(values[3]).Substring(1, ((values[3]).ToString().Length - 2));
                        var colorCode = Convert.ToString(values[28]).Substring(1, ((values[28]).ToString().Length - 2));

                        if (startTimeValue == 0 && endTimeValue == 0)
                        {
                            continue;
                        }
                        string category = "";
                        string otherWarning = "";
                        //if((values[10]).ToString() == ZeroValue) { continue; }
                        if (Convert.ToString(values[4]) != EmptyValue && Convert.ToString(values[4]) != ZeroValue) category += 1 + ",";
                        if (Convert.ToString(values[5]) != EmptyValue && Convert.ToString(values[5]) != ZeroValue) category += 2 + ",";
                        if (Convert.ToString(values[6]) != EmptyValue && Convert.ToString(values[6]) != ZeroValue) category += 3 + ",";
                        if (Convert.ToString(values[7]) != EmptyValue && Convert.ToString(values[7]) != ZeroValue) category += 4 + ",";
                        if (Convert.ToString(values[8]) != EmptyValue && Convert.ToString(values[8]) != ZeroValue) category += 5 + ",";
                        if (Convert.ToString(values[9]) != EmptyValue && Convert.ToString(values[9]) != ZeroValue) category += 6 + ",";
                        if (Convert.ToString(values[10]) != EmptyValue && Convert.ToString(values[10]) != ZeroValue) category += 7 + ",";
                        if (Convert.ToString(values[11]) != EmptyValue && Convert.ToString(values[11]) != ZeroValue) category += 8 + ",";
                        if (Convert.ToString(values[12]) != EmptyValue && Convert.ToString(values[12]) != ZeroValue) category += 9 + ",";
                        if (Convert.ToString(values[13]) != EmptyValue && Convert.ToString(values[13]) != ZeroValue) category += 10 + ",";
                        if (Convert.ToString(values[14]) != EmptyValue && Convert.ToString(values[14]) != ZeroValue) category += 11 + ",";
                        if (Convert.ToString(values[15]) != EmptyValue && Convert.ToString(values[15]) != ZeroValue) category += 12 + ",";
                        if (Convert.ToString(values[16]) != EmptyValue && Convert.ToString(values[16]) != ZeroValue) category += 13 + ",";
                        if (Convert.ToString(values[17]) != EmptyValue && Convert.ToString(values[17]) != ZeroValue) category += 14 + ",";
                        if (Convert.ToString(values[18]) != EmptyValue && Convert.ToString(values[18]) != ZeroValue) category += 15 + ",";
                        if (Convert.ToString(values[20]) != EmptyValue && Convert.ToString(values[20]) != ZeroValue) category += 17 + ",";
                        if (Convert.ToString(values[21]) != EmptyValue && Convert.ToString(values[21]) != ZeroValue) category += 18 + ",";
                        if (Convert.ToString(values[22]) != EmptyValue && Convert.ToString(values[22]) != ZeroValue) category += 19 + ",";
                        if (string.IsNullOrEmpty(category) && Convert.ToString(values[19]) != EmptyValue && Convert.ToString(values[19]) != ZeroValue)
                        {
                            category += 16 + ",";
                            otherWarning = Convert.ToString(values[19]).Substring(1, (Convert.ToString(values[19]).Length - 2));
                        }

                        if (Convert.ToString(values[4]) == EmptyValue || Convert.ToString(values[4]) == ZeroValue) values[4] = "";
                        if (Convert.ToString(values[5]) == EmptyValue || Convert.ToString(values[5]) == ZeroValue) values[5] = "";
                        if (Convert.ToString(values[6]) == EmptyValue || Convert.ToString(values[6]) == ZeroValue) values[6] = "";
                        if (Convert.ToString(values[7]) == EmptyValue || Convert.ToString(values[7]) == ZeroValue) values[7] = "";
                        if (Convert.ToString(values[8]) == EmptyValue || Convert.ToString(values[8]) == ZeroValue) values[8] = "";
                        if (Convert.ToString(values[9]) == EmptyValue || Convert.ToString(values[9]) == ZeroValue) values[9] = "";
                        if (Convert.ToString(values[10]) == EmptyValue || Convert.ToString(values[10]) == ZeroValue) values[10] = "";
                        if (Convert.ToString(values[11]) == EmptyValue || Convert.ToString(values[11]) == ZeroValue) values[11] = "";
                        if (Convert.ToString(values[12]) == EmptyValue || Convert.ToString(values[12]) == ZeroValue) values[12] = "";
                        if (Convert.ToString(values[13]) == EmptyValue || Convert.ToString(values[13]) == ZeroValue) values[13] = "";
                        if (Convert.ToString(values[14]) == EmptyValue || Convert.ToString(values[14]) == ZeroValue) values[14] = "";
                        if (Convert.ToString(values[15]) == EmptyValue || Convert.ToString(values[15]) == ZeroValue) values[15] = "";
                        if (Convert.ToString(values[16]) == EmptyValue || Convert.ToString(values[16]) == ZeroValue) values[16] = "";
                        if (Convert.ToString(values[17]) == EmptyValue || Convert.ToString(values[17]) == ZeroValue) values[17] = "";
                        if (Convert.ToString(values[18]) == EmptyValue || Convert.ToString(values[18]) == ZeroValue) values[18] = "";
                        if (Convert.ToString(values[19]) == EmptyValue || Convert.ToString(values[19]) == ZeroValue) values[19] = "";
                        if (Convert.ToString(values[20]) == EmptyValue || Convert.ToString(values[20]) == ZeroValue) values[20] = "";
                        if (Convert.ToString(values[21]) == EmptyValue || Convert.ToString(values[21]) == ZeroValue) values[21] = "";
                        if (Convert.ToString(values[22]) == EmptyValue || Convert.ToString(values[22]) == ZeroValue) values[22] = "";


                        var pobjId = string.IsNullOrEmpty(values[1]) == true ? "" : Convert.ToString(values[1]).Substring(1, (Convert.ToString(values[1]).Length - 2));
                        var pCat1 = string.IsNullOrEmpty(values[4]) == true ? "" : Convert.ToString(values[4]).Substring(1, (Convert.ToString(values[4]).Length - 2));
                        var pCat2 = string.IsNullOrEmpty(values[5]) == true ? "" : Convert.ToString(values[5]).Substring(1, (Convert.ToString(values[5]).Length - 2));
                        var pCat3 = string.IsNullOrEmpty(values[6]) == true ? "" : Convert.ToString(values[6]).Substring(1, (Convert.ToString(values[6]).Length - 2));
                        var pCat4 = string.IsNullOrEmpty(values[7]) == true ? "" : Convert.ToString(values[7]).Substring(1, (Convert.ToString(values[7]).Length - 2));
                        var pCat5 = string.IsNullOrEmpty(values[8]) == true ? "" : Convert.ToString(values[8]).Substring(1, (Convert.ToString(values[8]).Length - 2));
                        var pCat6 = string.IsNullOrEmpty(values[9]) == true ? "" : Convert.ToString(values[9]).Substring(1, (Convert.ToString(values[9]).Length - 2));
                        var pCat7 = string.IsNullOrEmpty(values[10]) == true ? "" : Convert.ToString(values[10]).Substring(1, (Convert.ToString(values[10]).Length - 2));
                        var pCat8 = string.IsNullOrEmpty(values[11]) == true ? "" : Convert.ToString(values[11]).Substring(1, (Convert.ToString(values[11]).Length - 2));
                        var pCat9 = string.IsNullOrEmpty(values[12]) == true ? "" : Convert.ToString(values[12]).Substring(1, (Convert.ToString(values[12]).Length - 2));
                        var pCat10 = string.IsNullOrEmpty(values[13]) == true ? "" : Convert.ToString(values[13]).Substring(1, (Convert.ToString(values[13]).Length - 2));
                        var pCat11 = string.IsNullOrEmpty(values[14]) == true ? "" : Convert.ToString(values[14]).Substring(1, (Convert.ToString(values[14]).Length - 2));
                        var pCat12 = string.IsNullOrEmpty(values[15]) == true ? "" : Convert.ToString(values[15]).Substring(1, (Convert.ToString(values[15]).Length - 2));
                        var pCat13 = string.IsNullOrEmpty(values[16]) == true ? "" : Convert.ToString(values[16]).Substring(1, (Convert.ToString(values[16]).Length - 2));
                        var pCat14 = string.IsNullOrEmpty(values[17]) == true ? "" : Convert.ToString(values[17]).Substring(1, (Convert.ToString(values[17]).Length - 2));
                        var pCat15 = string.IsNullOrEmpty(values[18]) == true ? "" : Convert.ToString(values[18]).Substring(1, (Convert.ToString(values[18]).Length - 2));
                        var pCat16 = string.IsNullOrEmpty(values[19]) == true ? "" : Convert.ToString(values[19]).Substring(1, (Convert.ToString(values[19]).Length - 2));
                        var pCat17 = string.IsNullOrEmpty(values[20]) == true ? "" : Convert.ToString(values[20]).Substring(1, (Convert.ToString(values[20]).Length - 2));
                        var pCat18 = string.IsNullOrEmpty(values[21]) == true ? "" : Convert.ToString(values[21]).Substring(1, (Convert.ToString(values[21]).Length - 2));
                        var pCat19 = string.IsNullOrEmpty(values[22]) == true ? "" : Convert.ToString(values[22]).Substring(1, (Convert.ToString(values[22]).Length - 2));
                        var pWarningsDetails = string.IsNullOrEmpty(values[23]) == true ? "" : Convert.ToString(values[23]).Substring(1, (Convert.ToString(values[23]).Length - 2));


                        var startTime = Common.TimeFormat(startTimeValue);
                        var endTime = Common.TimeFormat(endTimeValue);
                        SqlParameter[] arrParams = new SqlParameter[] {
                            new SqlParameter("@pobjId",pobjId),
                            new SqlParameter("@pDate",date),
                            new SqlParameter("@pDistrictName",districtName),
                            new SqlParameter("@pCat1",pCat1),
                            new SqlParameter("@pCat2",pCat2),
                            new SqlParameter("@pCat3",pCat3),
                            new SqlParameter("@pCat4",pCat4),
                            new SqlParameter("@pCat5",pCat5),
                            new SqlParameter("@pCat6",pCat6),
                            new SqlParameter("@pCat7",pCat7),
                            new SqlParameter("@pCat8",pCat8),
                            new SqlParameter("@pCat9",pCat9),
                            new SqlParameter("@pCat10",pCat10),
                            new SqlParameter("@pCat11",pCat11),
                            new SqlParameter("@pCat12",pCat12),
                            new SqlParameter("@pCat13",pCat13),
                            new SqlParameter("@pCat14",pCat14),
                            new SqlParameter("@pCat15",pCat15),
                            new SqlParameter("@pCat16",pCat16),
                            new SqlParameter("@pCat17",pCat17),
                            new SqlParameter("@pCat18",pCat18),
                            new SqlParameter("@pCat19",pCat19),
                            new SqlParameter("@pWarningsDetails",pWarningsDetails),
                            new SqlParameter("@pTOI", startTime),
                            new SqlParameter("@pVUpTo", endTime),
                            new SqlParameter("@pColorCode",colorCode)
                        };
                        _log.Info("Callid : " + callId + " calling ExecuteOutIDParameter SaveDistrictWiseNowcastNowFromFTP in notification service");
                        transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_DistrictWiseNowCastNowDetails", arrParams);
                        _log.Info("Callid : " + callId + " called ExecuteOutIDParameter SaveDistrictWiseNowcastNowFromFTP in notification service");
                        if (transactionResponse.IsSuccessful && date == todayDate)
                        {
                            // code for push notification                        
                            SqlParameter[] arrParam1 = new SqlParameter[] {
                            new SqlParameter("@pWarningDistrictName",districtName),
                            new SqlParameter("@CategoryId",category)
                            };

                            var destination = new List<string>();
                            _log.Info("Callid : " + callId + " called Execute SaveDistrictWiseNowcastNowFromFTP in notification service");
                            nowcastTable = SQLHelper.Execute("spGet_WarningNowCastDetails", arrParam1);
                            _log.Info("Callid : " + callId + " called Execute SaveDistrictWiseNowcastNowFromFTP in notification service");
                            if (nowcastTable.Rows.Count > 0)
                            {
                                foreach (DataRow row in nowcastTable.Rows)
                                {
                                    LanguageName language;
                                    Enum.TryParse(row["LanguageName"].ToString(), true, out language);
                                    //for test
                                    //destination.Add("ecpkn_wfYeE:APA91bFn_OSz7v3XiQl1MJ8sHhwkUTM1xoUMa9wg00ktVsqxMpLzna761l4BjVrceUkS9ohpvtEgX5pc1YFMNR1F7wneq3CNR8qHU_3zdJsKVHSOifohytylFaepRGvZslZ7JrPL4jff");
                                    var title = string.Concat(row["DistrictName"].ToString(), ",", row["WarningMessage"].ToString(), otherWarning);
                                    var body = string.Concat(Common.TimeOfIssue(language), " : ", todayDate, " ", startTime, ", ", Common.ValidUpTo(language), " : ", endTime);
                                    var timeOfIssueMsg = string.Concat(Common.TimeOfIssue(language), " : ");
                                    var validUpToMsg = string.Concat(Common.ValidUpTo(language), " : ");
                                    var issueDateMsg = string.Concat(Common.IssueDate(language), " : ");
                                    if (Convert.ToInt32(colorCode) < 1 || Convert.ToInt32(colorCode) > 4)
                                    {
                                        colorCode = row["ColorCode"].ToString();
                                    }

                                    SqlParameter[] savenotification = new SqlParameter[]
                                    {
                                    new SqlParameter("@pNotificationTitle",title),
                                    new SqlParameter("@pTimeOfIssueMsg",timeOfIssueMsg),
                                    new SqlParameter("@pValidUpToMsg",validUpToMsg),
                                    new SqlParameter("@pTimeOfIssue",startTime),
                                    new SqlParameter("@pIssueDateMsg",issueDateMsg),
                                    new SqlParameter("@pValidUpTo",endTime),
                                    new SqlParameter("@pIssuedate",todayDate),
                                    new SqlParameter("@pUserProfileId",Convert.ToInt32(row["UserProfileId"])),
                                    //new SqlParameter("@pColorCode", Convert.ToInt32(row["ColorCode"]))
                                    new SqlParameter("@pColorCode", Convert.ToInt32(colorCode)),
                                    new SqlParameter("@pCategoryId",category)
                                    };
                                    var time = DateTime.UtcNow.AddMinutes(330).TimeOfDay;
                                    var TOI = DateTime.ParseExact(startTime, "HH:mm", CultureInfo.InvariantCulture).AddMinutes(-10).TimeOfDay;
                                    var VUT = DateTime.ParseExact(endTime, "HH:mm", CultureInfo.InvariantCulture).TimeOfDay;
                                    var s = Math.Abs(TOI.Hours - VUT.Hours);
                                    if (s > 10) VUT = VUT.Add(TimeSpan.FromHours(24));
                                    _log.Info("Callid : " + callId + " calling ExecuteOutIDParameter for notification SaveDistrictWiseNowcastNowFromFTP in notification service");
                                    if (time >= TOI && time <= VUT)
                                        transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_NowCastNotificationDetails", savenotification);
                                    _log.Info("Callid : " + callId + " called ExecuteOutIDParameter for notification SaveDistrictWiseNowcastNowFromFTP in notification service");
                                    var param = new SqlParameter[] { new SqlParameter("@pUserProfileId", Convert.ToInt32(row["UserProfileId"])) };
                                    _log.Info("Callid : " + callId + " calling Execute for token SaveDistrictWiseNowcastNowFromFTP in notification service");
                                    var tokens = SQLHelper.Execute("spGet_TokenByUserId", param).AsEnumerable()
                                        .Select(r => r.Field<string>("Token")).ToList();
                                    _log.Info("Callid : " + callId + " called Execute for token SaveDistrictWiseNowcastNowFromFTP in notification service");
                                    if (tokens.Any())
                                    {
                                        //var testToken = "dHZJZZbQoTI:APA91bFk6l4SQ288iZjllEN5n2nsMiS4La3kWU7W9lwqyPqZEvChxFgBRWQEJbJe6fc2VpSq7g6UtudxKNt8RRottUTfdGjNjm5TuSn1joSuwcbY9CENR1p97RVTITHYFD8odIIDROej";
                                        //destination.Add(testToken);     
                                        _log.Info("Callid : " + callId + " sending notification SaveDistrictWiseNowcastNowFromFTP in notification service");
                                        if (time >= TOI && time <= VUT && transactionResponse.IsSuccessful == true && tokens.Any())
                                            NowCastNotification(title, body, Convert.ToInt32(colorCode), tokens);

                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in SaveDistrictWiseNowcastNowFromFTP in notification service :" + ex.Message);
                        transactionResponse.ErrorMessage = ex.Message.ToString();
                    }
                }
                reader.Close();
                response.Close();
                _log.Info("Callid : " + callId + " ending SaveDistrictWiseNowcastNowFromFTP in notification service");
                LogCallEnd(callId, methodName, DateTime.Now);
                return transactionResponse;
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in SaveDistrictWiseNowcastNowFromFTP in notification service : " + ex.Message);
                transactionResponse.ErrorMessage = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
                return transactionResponse;
            }

        }
        #endregion

        #region SaveDistrictWarningNowFromHTTP
        public static async Task<TransactionDetails> SaveDistrictWiseNowcastNowFromHTTPAsync()
        {
            #region Log Start

            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            string callId = Guid.NewGuid().ToString();
            DateTime starttime = DateTime.Now;

            LogCallStart(callId, methodName, starttime);

            #endregion Log Start

            var transactionResponse = new TransactionDetails();
            try
            {

                // Get the object used to communicate with the server.

                
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Version", "1");
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                HttpResponseMessage ResultFromIMD = null;
                var dataSet = new DataSet();
                var nowcastTable = new DataTable();
                try
                {
                    _log.Info("Callid : " + callId + " calling IMD Service for download District Now Cast");
                    ResultFromIMD = await client.GetAsync(DistrictNowCastURL);
                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No Data from District now cast URL");
                    }
                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    if (!string.IsNullOrEmpty(IMDResponse))
                    {
                        var objresponse = JsonConvert.DeserializeObject<List<AGROMET_NOTIFICATIONS.Models.DistrictWiseNowcast>>(IMDResponse);
                        foreach (var districtNowcast in objresponse)
                        {
                            try
                            {
                                _log.Info("Callid : " + callId + " optimizing response data in SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                //string[] values = items.Split(',');
                                var todayDate = DateTime.UtcNow.ToString("yyyy-MM-dd");
                                var startTimeValue = Convert.ToString(districtNowcast.toi) == EmptyValue ? 0 : Convert.ToInt32(districtNowcast.toi);
                                var endTimeValue = Convert.ToString(districtNowcast.vupto) == EmptyValue ? 0 : Convert.ToInt32(districtNowcast.vupto);
                                var date = Convert.ToString(districtNowcast.Date) == EmptyDate ? DateTime.UtcNow.ToString("yyyy-MM-dd") : districtNowcast.Date.ToString();
                                var districtName = districtNowcast.State_District;
                                var colorCode = districtNowcast.color;

                                if (startTimeValue == 0 && endTimeValue == 0)
                                {
                                    continue;
                                }
                                string category = "";
                                string otherWarning = "";

                                //if((values[10]).ToString() == ZeroValue) { continue; }
                                
                                var pobjId = string.IsNullOrEmpty(districtNowcast.Obj_id) == true ? "" : districtNowcast.Obj_id;
                                var pCat1 = string.IsNullOrEmpty(districtNowcast.cat1) == true ? "" : districtNowcast.cat1;
                                var pCat2 = string.IsNullOrEmpty(districtNowcast.cat2) == true ? "" : districtNowcast.cat2;
                                var pCat3 = string.IsNullOrEmpty(districtNowcast.cat3) == true ? "" : districtNowcast.cat3;
                                var pCat4 = string.IsNullOrEmpty(districtNowcast.cat4) == true ? "" : districtNowcast.cat4;
                                var pCat5 = string.IsNullOrEmpty(districtNowcast.cat5) == true ? "" : districtNowcast.cat5;
                                var pCat6 = string.IsNullOrEmpty(districtNowcast.cat6) == true ? "" : districtNowcast.cat6;
                                var pCat7 = string.IsNullOrEmpty(districtNowcast.cat7) == true ? "" : districtNowcast.cat7;
                                var pCat8 = string.IsNullOrEmpty(districtNowcast.cat8) == true ? "" : districtNowcast.cat8;
                                var pCat9 = string.IsNullOrEmpty(districtNowcast.cat9) == true ? "" : districtNowcast.cat9;
                                var pCat10 = string.IsNullOrEmpty(districtNowcast.cat10) == true ? "" : districtNowcast.cat10;
                                var pCat11 = string.IsNullOrEmpty(districtNowcast.cat11) == true ? "" : districtNowcast.cat11;
                                var pCat12 = string.IsNullOrEmpty(districtNowcast.cat12) == true ? "" : districtNowcast.cat12;
                                var pCat13 = string.IsNullOrEmpty(districtNowcast.cat13) == true ? "" : districtNowcast.cat13;
                                var pCat14 = string.IsNullOrEmpty(districtNowcast.cat14) == true ? "" : districtNowcast.cat14;
                                var pCat15 = string.IsNullOrEmpty(districtNowcast.cat15) == true ? "" : districtNowcast.cat15;
                                var pCat16 = string.IsNullOrEmpty(districtNowcast.cat16) == true ? "" : districtNowcast.cat16;
                                var pCat17 = string.IsNullOrEmpty(districtNowcast.cat17) == true ? "" : districtNowcast.cat17;
                                var pCat18 = string.IsNullOrEmpty(districtNowcast.cat18) == true ? "" : districtNowcast.cat18;
                                var pCat19 = string.IsNullOrEmpty(districtNowcast.cat19) == true ? "" : districtNowcast.cat19;
                                var pWarningsDetails = string.IsNullOrEmpty(districtNowcast.message) == true ? "" : districtNowcast.message;

                                if ((!string.IsNullOrEmpty(pCat1)) && pCat1 != ZeroValue) category += 1 + ",";
                                if ((!string.IsNullOrEmpty(pCat2)) && pCat2 != ZeroValue) category += 2 + ",";
                                if ((!string.IsNullOrEmpty(pCat3)) && pCat3 != ZeroValue) category += 3 + ",";
                                if ((!string.IsNullOrEmpty(pCat4)) && pCat4 != ZeroValue) category += 4 + ",";
                                if ((!string.IsNullOrEmpty(pCat5)) && pCat5 != ZeroValue) category += 5 + ",";
                                if ((!string.IsNullOrEmpty(pCat6)) && pCat6 != ZeroValue) category += 6 + ",";
                                if ((!string.IsNullOrEmpty(pCat7)) && pCat7 != ZeroValue) category += 7 + ",";
                                if ((!string.IsNullOrEmpty(pCat8)) && pCat8 != ZeroValue) category += 8 + ",";
                                if ((!string.IsNullOrEmpty(pCat9)) && pCat9 != ZeroValue) category += 9 + ",";
                                if ((!string.IsNullOrEmpty(pCat10)) && pCat10 != ZeroValue) category += 10 + ",";
                                if ((!string.IsNullOrEmpty(pCat11)) && pCat11 != ZeroValue) category += 11 + ",";
                                if ((!string.IsNullOrEmpty(pCat12)) && pCat12 != ZeroValue) category += 12 + ",";
                                if ((!string.IsNullOrEmpty(pCat13)) && pCat13 != ZeroValue) category += 13 + ",";
                                if ((!string.IsNullOrEmpty(pCat14)) && pCat14 != ZeroValue) category += 14 + ",";
                                if ((!string.IsNullOrEmpty(pCat15)) && pCat15 != ZeroValue) category += 15 + ",";
                                if ((!string.IsNullOrEmpty(pCat17)) && pCat17 != ZeroValue) category += 17 + ",";
                                if ((!string.IsNullOrEmpty(pCat18)) && pCat18 != ZeroValue) category += 18 + ",";
                                if ((!string.IsNullOrEmpty(pCat19)) && pCat19 != ZeroValue) category += 19 + ",";

                                if ((!string.IsNullOrEmpty(pCat16)) && pCat16 != ZeroValue)
                                {
                                    category += 16 + ",";
                                    otherWarning = pWarningsDetails;
                                }

                                var startTime = Common.TimeFormat(startTimeValue);
                                var endTime = Common.TimeFormat(endTimeValue);
                                SqlParameter[] arrParams = new SqlParameter[] {
                            new SqlParameter("@pobjId",pobjId),
                            new SqlParameter("@pDate",date),
                            new SqlParameter("@pDistrictName",districtName),
                            new SqlParameter("@pCat1",pCat1),
                            new SqlParameter("@pCat2",pCat2),
                            new SqlParameter("@pCat3",pCat3),
                            new SqlParameter("@pCat4",pCat4),
                            new SqlParameter("@pCat5",pCat5),
                            new SqlParameter("@pCat6",pCat6),
                            new SqlParameter("@pCat7",pCat7),
                            new SqlParameter("@pCat8",pCat8),
                            new SqlParameter("@pCat9",pCat9),
                            new SqlParameter("@pCat10",pCat10),
                            new SqlParameter("@pCat11",pCat11),
                            new SqlParameter("@pCat12",pCat12),
                            new SqlParameter("@pCat13",pCat13),
                            new SqlParameter("@pCat14",pCat14),
                            new SqlParameter("@pCat15",pCat15),
                            new SqlParameter("@pCat16",pCat16),
                            new SqlParameter("@pCat17",pCat17),
                            new SqlParameter("@pCat18",pCat18),
                            new SqlParameter("@pCat19",pCat19),
                            new SqlParameter("@pWarningsDetails",pWarningsDetails),
                            new SqlParameter("@pTOI", startTime),
                            new SqlParameter("@pVUpTo", endTime),
                            new SqlParameter("@pColorCode",colorCode)
                        };
                                _log.Info("Callid : " + callId + " calling ExecuteOutIDParameter SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_DistrictWiseNowCastNowDetails", arrParams);
                                _log.Info("Callid : " + callId + " called ExecuteOutIDParameter SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                if (transactionResponse.IsSuccessful && date == todayDate)
                                {
                                    // code for push notification                        
                                    SqlParameter[] arrParam1 = new SqlParameter[] {
                            new SqlParameter("@pWarningDistrictName",districtName),
                            new SqlParameter("@CategoryId",category)
                            };

                                    var destination = new List<string>();
                                    _log.Info("Callid : " + callId + " called Execute SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                    nowcastTable = SQLHelper.Execute("spGet_WarningNowCastDetails", arrParam1);
                                    _log.Info("Callid : " + callId + " called Execute SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                    if (nowcastTable.Rows.Count > 0)
                                    {
                                        foreach (DataRow row in nowcastTable.Rows)
                                        {
                                            LanguageName language;
                                            Enum.TryParse(row["LanguageName"].ToString(), true, out language);
                                            //for test
                                            //destination.Add("ecpkn_wfYeE:APA91bFn_OSz7v3XiQl1MJ8sHhwkUTM1xoUMa9wg00ktVsqxMpLzna761l4BjVrceUkS9ohpvtEgX5pc1YFMNR1F7wneq3CNR8qHU_3zdJsKVHSOifohytylFaepRGvZslZ7JrPL4jff");
                                            var title = string.Concat(row["DistrictName"].ToString(), ",", row["WarningMessage"].ToString(), otherWarning);
                                            var body = string.Concat(Common.TimeOfIssue(language), " : ", todayDate, " ", startTime, ", ", Common.ValidUpTo(language), " : ", endTime);
                                            var timeOfIssueMsg = string.Concat(Common.TimeOfIssue(language), " : ");
                                            var validUpToMsg = string.Concat(Common.ValidUpTo(language), " : ");
                                            var issueDateMsg = string.Concat(Common.IssueDate(language), " : ");
                                            if (Convert.ToInt32(colorCode) < 1 || Convert.ToInt32(colorCode) > 4)
                                            {
                                                colorCode = row["ColorCode"].ToString();
                                            }

                                            SqlParameter[] savenotification = new SqlParameter[]
                                            {
                                    new SqlParameter("@pNotificationTitle",title),
                                    new SqlParameter("@pTimeOfIssueMsg",timeOfIssueMsg),
                                    new SqlParameter("@pValidUpToMsg",validUpToMsg),
                                    new SqlParameter("@pTimeOfIssue",startTime),
                                    new SqlParameter("@pIssueDateMsg",issueDateMsg),
                                    new SqlParameter("@pValidUpTo",endTime),
                                    new SqlParameter("@pIssuedate",todayDate),
                                    new SqlParameter("@pUserProfileId",Convert.ToInt32(row["UserProfileId"])),
                                    new SqlParameter("@pColorCode", Convert.ToInt32(colorCode)),
                                    new SqlParameter("@pCategoryId",category)
                                            };
                                            var time = DateTime.UtcNow.AddMinutes(330).TimeOfDay;
                                            var TOI = DateTime.ParseExact(startTime, "HH:mm", CultureInfo.InvariantCulture).AddMinutes(-10).TimeOfDay;
                                            var VUT = DateTime.ParseExact(endTime, "HH:mm", CultureInfo.InvariantCulture).TimeOfDay;
                                            var s = Math.Abs(TOI.Hours - VUT.Hours);
                                            if (s > 10) VUT = VUT.Add(TimeSpan.FromHours(24));
                                            _log.Info("Callid : " + callId + " calling ExecuteOutIDParameter for notification SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                            if (time >= TOI && time <= VUT)
                                                transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_NowCastNotificationDetails", savenotification);
                                            _log.Info("Callid : " + callId + " called ExecuteOutIDParameter for notification SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                            var param = new SqlParameter[] { new SqlParameter("@pUserProfileId", Convert.ToInt32(row["UserProfileId"])) };
                                            _log.Info("Callid : " + callId + " calling Execute for token SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                            var tokens = SQLHelper.Execute("spGet_TokenByUserId", param).AsEnumerable()
                                                .Select(r => r.Field<string>("Token")).ToList();
                                            _log.Info("Callid : " + callId + " called Execute for token SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                            if (tokens.Any())
                                            {
                                                //var testToken = "dHZJZZbQoTI:APA91bFk6l4SQ288iZjllEN5n2nsMiS4La3kWU7W9lwqyPqZEvChxFgBRWQEJbJe6fc2VpSq7g6UtudxKNt8RRottUTfdGjNjm5TuSn1joSuwcbY9CENR1p97RVTITHYFD8odIIDROej";
                                                //destination.Add(testToken);     
                                                _log.Info("Callid : " + callId + " sending notification SaveDistrictWiseNowcastNowFromHTTP in notification service");
                                                if (time >= TOI && time <= VUT && transactionResponse.IsSuccessful == true && tokens.Any())
                                                    NowCastNotification(title, body, Convert.ToInt32(colorCode), tokens);

                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                _log.Error("Callid : " + callId + " exception in SaveDistrictWiseNowcastNowFromHTTP in notification service :" + ex.Message);
                                transactionResponse.ErrorMessage = ex.Message.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _log.Error("Callid : " + callId + " exception in " +DistrictNowCastURL+ " District now cast " + ex.Message);
                }
                _log.Info("Callid : " + callId + " ending SaveDistrictWiseNowcastNowFromHTTP in notification service");
                LogCallEnd(callId, methodName, DateTime.Now);
                return transactionResponse;
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in SaveDistrictWiseNowcastNowFromHTTP in notification service : " + ex.Message);
                transactionResponse.ErrorMessage = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
                return transactionResponse;
            }

        }
        #endregion

        #region SaveMobileTokens
        public static TransactionDetails AddOrUpdateMobileTokens(MobileTokens mobileTokens)
        {
            var transactionResponse = new TransactionDetails();
            if (!string.IsNullOrEmpty(mobileTokens.Token) && mobileTokens.UserProfileId > 0)
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                     new SqlParameter("@pToken",mobileTokens.Token),
                     new SqlParameter("@pUserProfileId",mobileTokens.UserProfileId),
                     new SqlParameter("@pid",mobileTokens.Id)
                };
                transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_MobileTokensDetails", arrParams);
            }
            return transactionResponse;
        }
        #endregion

        #region DeleteMobileTokens
        public static TransactionDetails DeleteMobileTokens(MobileTokens mobileTokens)
        {
            var transactionResponse = new TransactionDetails();
            if (!string.IsNullOrEmpty(mobileTokens.Token) && mobileTokens.UserProfileId > 0)
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                     new SqlParameter("@pToken",mobileTokens.Token),
                     new SqlParameter("@pUserProfileId",mobileTokens.UserProfileId)
                };
                transactionResponse = SQLHelper.ExecuteOutIDParameter("spDelete_MobileTokensDetails", arrParams);
            }
            return transactionResponse;
        }
        #endregion

        #region GetMobileTokensById
        public static List<MobileTokens> GetMobileTokensById(int id)
        {
            var tokentable = new DataTable();
            var tokenResult = new List<MobileTokens>();
            var transactionResponse = new TransactionDetails();
            if (id > 0)
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                     new SqlParameter("@pId",id)
                };
                tokentable = SQLHelper.Execute("spGet_MobileTokensDetails", arrParams);
                if (tokentable.Rows.Count > 0)
                {
                    tokenResult = (from DataRow dr in tokentable.Rows
                                   select new MobileTokens
                                   {
                                       Id = (dr["Id"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),
                                       UserProfileId = (dr["UserProfileId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["UserProfileId"]),
                                       Token = (dr["Token"]) == DBNull.Value ? null : Convert.ToString(dr["Token"])
                                   }).ToList();
                }
            }
            return tokenResult;
        }
        #endregion

        #region GetAllMobileTokens
        public static List<MobileTokens> GetAllMobileTokens()
        {
            var tokentable = new DataTable();
            var tokenResult = new List<MobileTokens>();
            var transactionResponse = new TransactionDetails();
            SqlParameter[] arrParams = new SqlParameter[] {
                     new SqlParameter("@pId",0)
                };
            tokentable = SQLHelper.Execute("spGet_MobileTokensDetails", arrParams);
            if (tokentable.Rows.Count > 0)
            {
                tokenResult = (from DataRow dr in tokentable.Rows
                               select new MobileTokens
                               {
                                   Id = (dr["Id"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),
                                   UserProfileId = (dr["UserProfileId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["UserProfileId"]),
                                   Token = (dr["Token"]) == DBNull.Value ? null : Convert.ToString(dr["Token"])
                               }).ToList();
            }
            return tokenResult;
        }
        #endregion

        #region UpdateSeenNotification
        public static TransactionDetails UpdateSeenNotification(int notificationId)
        {
            var transactionResponse = new TransactionDetails();
            if (notificationId > 0)
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                     new SqlParameter("@pNotificationId",notificationId)
                };
                transactionResponse = SQLHelper.ExecuteOutIDParameter("spUpdate_SeenNotification", arrParams);
            }
            return transactionResponse;
        }
        #endregion


        #region GetNotificationDetails
        public static List<NowCastWarningNotification> GetNotificationDetails(int userProfileId)
        {
            var notificationTable = new DataTable();
            var notificationResult = new List<NowCastWarningNotification>();
            var transactionResponse = new TransactionDetails();
            if (userProfileId > 0)
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                     new SqlParameter("@pUserProfileId",userProfileId)
                };
                notificationTable = SQLHelper.Execute("spGet_NotificationDetails", arrParams);
                if (notificationTable.Rows.Count > 0)
                {
                    notificationResult = (from DataRow dr in notificationTable.Rows
                                          select new NowCastWarningNotification
                                          {
                                              NotificationId = (dr["NotificationId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["NotificationId"]),
                                              UserProfileId = (dr["UserProfileId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["UserProfileId"]),
                                              NotificationTitle = (dr["NotificationTitle"]) == DBNull.Value ? null : Convert.ToString(dr["NotificationTitle"]),
                                              NotificationMessage = (dr["NotificationMessage"]) == DBNull.Value ? null : Convert.ToString(dr["NotificationMessage"]),
                                              CreatedDate = (dr["CreatedDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["CreatedDate"]).ToString(),
                                              UpdatedDate = (dr["UpdatedDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["UpdatedDate"]).ToString(),
                                              Flag = (dr["Flag"]) == DBNull.Value ? false : Convert.ToBoolean(dr["Flag"]),
                                              ColorCode = (dr["ColorCode"]) == DBNull.Value ? null : GetColorHashCodeForNowCast(Convert.ToInt32(dr["ColorCode"])),
                                              TimeOfIssueMessage = (dr["TimeOfIssueMessage"]) == DBNull.Value ? null : string.Concat(Convert.ToString(dr["TimeOfIssueMessage"]), Convert.ToString(dr["TimeOfIssue"])),
                                              ValidUpToMessage = (dr["ValidUpToMessage"]) == DBNull.Value ? null : string.Concat(Convert.ToString(dr["ValidUpToMessage"]), Convert.ToString(dr["ValidUpTo"])),
                                              IssueDate = (dr["IssueDateMessage"]) == DBNull.Value ? "" : string.Concat(Convert.ToString(dr["IssueDateMessage"]), Convert.ToString(dr["IssueDate"]))

                                          }).ToList();
                }
            }
            return notificationResult;
        }
        #endregion

        #region ClearNotification
        public static TransactionDetails ClearNotification(int userProfileId)
        {
            var transactionResponse = new TransactionDetails();
            if (userProfileId > 0)
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                     new SqlParameter("@pUserProfileId",userProfileId)
                };
                transactionResponse = SQLHelper.ExecuteOutIDParameter("spClear_Notification", arrParams);
            }
            return transactionResponse;
        }
        #endregion

        #region GetValidNowCastNowDetails
        public static List<NowCastWarningNotification> GetValidNowCastNowDetails(int userProfileId)
        {
            var notificationTable = new DataTable();
            var notificationResult = new List<NowCastWarningNotification>();
            var transactionResponse = new TransactionDetails();
            if (userProfileId > 0)
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                     new SqlParameter("@pUserProfileId",userProfileId)//,
                    // new SqlParameter("@pLanguageType",language)
                };
                notificationTable = SQLHelper.Execute("spGet_ValidNowCastNowDetails", arrParams);
                if (notificationTable.Rows.Count > 0)
                {
                    notificationResult = (from DataRow dr in notificationTable.Rows
                                          select new NowCastWarningNotification
                                          {
                                              NotificationId = (dr["NotificationId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["NotificationId"]),
                                              UserProfileId = (dr["UserProfileId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["UserProfileId"]),
                                              NotificationTitle = (dr["NotificationTitle"]) == DBNull.Value ? null : Convert.ToString(dr["NotificationTitle"]),
                                              NotificationMessage = (dr["NotificationMessage"]) == DBNull.Value ? null : Convert.ToString(dr["NotificationMessage"]),
                                              CreatedDate = (dr["CreatedDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["CreatedDate"]).ToString(),
                                              UpdatedDate = (dr["UpdatedDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["UpdatedDate"]).ToString(),
                                              Flag = (dr["Flag"]) == DBNull.Value ? false : Convert.ToBoolean(dr["Flag"]),
                                              ColorCode = (dr["ColorCode"]) == DBNull.Value ? null : GetColorHashCodeForNowCast(Convert.ToInt32(dr["ColorCode"])),
                                              TimeOfIssueMessage = (dr["TimeOfIssueMessage"]) == DBNull.Value ? null : string.Concat(Convert.ToString(dr["TimeOfIssueMessage"]), Convert.ToString(dr["TimeOfIssue"])),
                                              ValidUpToMessage = (dr["ValidUpToMessage"]) == DBNull.Value ? null : string.Concat(Convert.ToString(dr["ValidUpToMessage"]), Convert.ToString(dr["ValidUpTo"])),
                                              IssueDate = (dr["IssueDateMessage"]) == DBNull.Value ? null : string.Concat(Convert.ToString(dr["IssueDateMessage"]), Convert.ToString(dr["IssueDate"]))

                                          }).ToList();
                }
            }
            return notificationResult;
        }
        #endregion

        #endregion

        #region Get Notifications

        #region Get Notifications List
        public static NotificationsResponse GetNotifications(NotificationsDetails objNotifications)
        {
            DataTable dt = new DataTable();
            NotificationsResponse response = new NotificationsResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objNotifications.Id),
                new SqlParameter("@pType", objNotifications.Type),
                new SqlParameter("@planguagetype", objNotifications.LanguageType),
                new SqlParameter("@pRefreshdatetime", objNotifications.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_NotificationDetails", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjNotificationsDetailsList =
                   (from DataRow dr in dt.Rows
                    select new NotificationsDetails
                    {
                        NotificationsID = (dr["NotificationDetailsID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["NotificationDetailsID"]),
                        //CropID = (dr["CropID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropID"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        CompleteMessage = (dr["MessageText"]) == DBNull.Value ? "" : Convert.ToString(dr["MessageText"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString(),
                        CreatedDateWeb = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString(),
                    }).ToList();
                    response.IsSuccessful = true;
                    if (response.ObjNotificationsDetailsList.Count > 0)
                    {
                        foreach (var item in response.ObjNotificationsDetailsList)
                        {
                            NotificationsDetails objdetails = new NotificationsDetails();
                            NotificationsResponse responsecrop = new NotificationsResponse();
                            objdetails.NotificationsID = item.NotificationsID;
                            objdetails.LanguageType = objNotifications.LanguageType;
                            objdetails.RefreshDateTime = objNotifications.RefreshDateTime;
                            responsecrop = GetNotificationCropMapping(objdetails);

                            if (responsecrop.ObjNotificationsCropMappList.Count > 0)
                            {
                                response.ObjNotificationsCropMappList.AddRange(responsecrop.ObjNotificationsCropMappList);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Search Notifications List
        public static NotificationsResponse SearchNotifications(NotificationsDetails objNotifications)
        {
            DataTable dt = new DataTable();
            NotificationsResponse response = new NotificationsResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objNotifications.Id),
                new SqlParameter("@pDistrictid", objNotifications.DistrictID),
                new SqlParameter("@pcropid", objNotifications.CropID),
                new SqlParameter("@pBlockid", objNotifications.BlockID),
                new SqlParameter("@planguagetype", objNotifications.LanguageType),
                new SqlParameter("@pRefreshdatetime", objNotifications.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spSearch_NotificationDetails", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjNotificationsDetailsList =
                   (from DataRow dr in dt.Rows
                    select new NotificationsDetails
                    {
                        NotificationsID = (dr["NotificationDetailsID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["NotificationDetailsID"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        CompleteMessage = (dr["MessageText"]) == DBNull.Value ? "" : Convert.ToString(dr["MessageText"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString("dd-MM-yyyy"),
                    }).ToList();
                    response.IsSuccessful = true;
                    if (response.ObjNotificationsDetailsList.Count > 0)
                    {
                        foreach (var item in response.ObjNotificationsDetailsList)
                        {
                            NotificationsDetails objdetails = new NotificationsDetails();
                            NotificationsResponse responsecrop = new NotificationsResponse();
                            objdetails.NotificationsID = item.NotificationsID;
                            objdetails.LanguageType = objNotifications.LanguageType;
                            objdetails.RefreshDateTime = objNotifications.RefreshDateTime;
                            responsecrop = GetNotificationCropMapping(objdetails);

                            if (responsecrop.ObjNotificationsCropMappList.Count > 0)
                            {
                                response.ObjNotificationsCropMappList.AddRange(responsecrop.ObjNotificationsCropMappList);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region GetNotificationsByID
        public static NotificationsResponse GetNotificationsByID(NotificationsDetails objNotifications)
        {
            DataTable dt = new DataTable();
            NotificationsResponse response = new NotificationsResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pNotificationDetailsID", objNotifications.NotificationsID),
                new SqlParameter("@planguagetype", objNotifications.LanguageType),
                new SqlParameter("@pRefreshdatetime", objNotifications.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_NotificationsByNotificationDetailsID", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjNotificationsDetailsList =
                   (from DataRow dr in dt.Rows
                    select new NotificationsDetails
                    {
                        NotificationsID = (dr["NotificationDetailsID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["NotificationDetailsID"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        CompleteMessage = (dr["MessageText"]) == DBNull.Value ? "" : Convert.ToString(dr["MessageText"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString("dd-MM-yyyy"),
                    }).ToList();
                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Get Notifications by Distict Mapping

        public static NotificationsResponse GetNotificationDistMapping(NotificationsDetails objNotifications)
        {
            DataTable dt = new DataTable();
            NotificationsResponse response = new NotificationsResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pNotificationDetailsID", objNotifications.NotificationsID),
                new SqlParameter("@planguagetype", objNotifications.LanguageType),
                new SqlParameter("@pRefreshdatetime", objNotifications.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_NotificationDistrictMapping", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjNotificationsDistMappList =
                   (from DataRow dr in dt.Rows
                    select new NotificationsDistrict
                    {
                        NotificationsID = (dr["NotificationDetailsID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["NotificationDetailsID"]),
                        DistictName = (dr["DistrictName"] == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"])),
                        //DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString("dd-MM-yyyy"),
                    }).ToList();
                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Get  Notifications BlockMapping
        public static NotificationsResponse GetNotificationBlockMapping(NotificationsDetails objNotifications)
        {
            DataTable dt = new DataTable();
            NotificationsResponse response = new NotificationsResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pNotificationDetailsID", objNotifications.NotificationsID),
                new SqlParameter("@planguagetype", objNotifications.LanguageType),
                new SqlParameter("@pRefreshdatetime", objNotifications.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_NotificationBlockMapping", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjNotificationsBlockMappList =
                   (from DataRow dr in dt.Rows
                    select new NotificationsBlock
                    {
                        NotificationsID = (dr["NotificationDetailsID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["NotificationDetailsID"]),
                        BlockName = (dr["BlockName"] == DBNull.Value ? "" : Convert.ToString(dr["BlockName"])),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString("dd-MM-yyyy"),
                    }).ToList();
                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Get Notifications CropMapping

        public static NotificationsResponse GetNotificationCropMapping(NotificationsDetails objNotifications)
        {
            DataTable dt = new DataTable();
            NotificationsResponse response = new NotificationsResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                            new SqlParameter("@pNotificationDetailsID", objNotifications.NotificationsID),
                            new SqlParameter("@planguagetype", objNotifications.LanguageType),
                            new SqlParameter("@pRefreshdatetime", objNotifications.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_NotificationCropMapping", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjNotificationsCropMappList =
                   (from DataRow dr in dt.Rows
                    select new NotificationsCrop
                    {
                        NotificationsID = (dr["NotificationDetailsID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["NotificationDetailsID"]),
                        CropName = (dr["CropName"] == DBNull.Value ? "" : Convert.ToString(dr["CropName"])),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString("dd-MM-yyyy"),
                    }).ToList();
                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region GetDistrictWarnings
        public static NotificationsResponse GetDistrictWarnings(DistrictWarnings obj)
        {
            DataTable dt = new DataTable();
            NotificationsResponse response = new NotificationsResponse();
            NotificationsResponse LocationResponse = new NotificationsResponse();
            List<DistrictWarnings> objDistrictWarningList = new List<DistrictWarnings>();
            StringBuilder sb = new StringBuilder();
            try
            {
                UserLocations objLocation = new UserLocations
                {
                    UserProfileID = Convert.ToInt32(obj.UserID),
                    LanguageType = "English",
                    RefreshDateTime = obj.RefreshDateTime
                };

                LocationResponse = GetUserLocations(objLocation);
                if (LocationResponse.IsSuccessful)
                {
                    if (LocationResponse.ObjUserLocationsList.Count > 0)
                    {
                        foreach (var item in LocationResponse.ObjUserLocationsList)
                        {
                            SqlParameter[] arrParams = new SqlParameter[]
                {
                            new SqlParameter("@pDistrictName", item.DistrictName),
                            new SqlParameter("@planguagetype", obj.LanguageType),
                            new SqlParameter("@pRefreshdatetime", obj.RefreshDateTime),
                };
                            dt = SQLHelper.Execute("spGet_District_Warnings_NowDetails", arrParams);
                            if (dt.Rows.Count > 0)
                            {
                                objDistrictWarningList = new List<DistrictWarnings>();
                                objDistrictWarningList =
                               (from DataRow dr in dt.Rows
                                select new DistrictWarnings
                                {
                                    Color = (dr["Color"] == DBNull.Value ? "" : Convert.ToString(dr["Color"])),
                                    //Date = (dr["Date"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Date"]).ToString("dd-MM-yyyy"),
                                    //full_date = (dr["Date"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Date"]).ToString(),
                                    Date = (dr["IMDDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["IMDDate"]).ToString("dd-MM-yyyy"),
                                    full_date = (dr["IMDDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["IMDDate"]).ToString(),
                                    Day1_Color = (dr["Day1_Color"] == DBNull.Value ? "" : Convert.ToString(dr["Day1_Color"])),
                                    Day2_Color = (dr["Day2_Color"] == DBNull.Value ? "" : Convert.ToString(dr["Day2_Color"])),
                                    Day3_Color = (dr["Day3_Color"] == DBNull.Value ? "" : Convert.ToString(dr["Day3_Color"])),
                                    Day4_Color = (dr["Day4_Color"] == DBNull.Value ? "" : Convert.ToString(dr["Day4_Color"])),
                                    Day5_Color = (dr["Day5_Color"] == DBNull.Value ? "" : Convert.ToString(dr["Day5_Color"])),
                                    Day_1 = (dr["Day_1"] == DBNull.Value ? "" : Convert.ToString(dr["Day_1"])),
                                    Day_2 = (dr["Day_2"] == DBNull.Value ? "" : Convert.ToString(dr["Day_2"])),
                                    Day_3 = (dr["Day_3"] == DBNull.Value ? "" : Convert.ToString(dr["Day_3"])),
                                    Day_4 = (dr["Day_4"] == DBNull.Value ? "" : Convert.ToString(dr["Day_4"])),
                                    Day_5 = (dr["Day_5"] == DBNull.Value ? "" : Convert.ToString(dr["Day_5"])),
                                    District = (dr["District"] == DBNull.Value ? "" : Convert.ToString(dr["District"])),
                                    Lat = (dr["Lat"] == DBNull.Value ? "" : Convert.ToString(dr["Lat"])),
                                    Lat1 = (dr["Lat1"] == DBNull.Value ? "" : Convert.ToString(dr["Lat1"])),
                                    Lat2 = (dr["Lat2"] == DBNull.Value ? "" : Convert.ToString(dr["Lat2"])),
                                    Lon = (dr["Lon"] == DBNull.Value ? "" : Convert.ToString(dr["Lon"])),
                                    Lon1 = (dr["Lon1"] == DBNull.Value ? "" : Convert.ToString(dr["Lon1"])),
                                    Lon2 = (dr["Lon2"] == DBNull.Value ? "" : Convert.ToString(dr["Lon2"])),
                                    Warning = (dr["Warning"] == DBNull.Value ? "" : Convert.ToString(dr["Warning"])),
                                    RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),
                                    NotifyType = "Warnings",

                                }).ToList();

                                if (objDistrictWarningList.Count > 0)
                                {
                                    for (int i = 0; i < objDistrictWarningList.Count; i++)
                                    {
                                        objDistrictWarningList[i].Day = DateTime.Parse(objDistrictWarningList[i].full_date).DayOfWeek.ToString();
                                        objDistrictWarningList[i].Day = objDistrictWarningList[i].Day.Substring(0, 3);
                                    }
                                }
                                response.ObjDistrictWarningsList.AddRange(objDistrictWarningList);
                            }
                        }



                        response.IsSuccessful = true;
                    }
                }
                else
                {
                    response.ObjDistrictWarningsList = new List<DistrictWarnings>();
                    response.ErrorMessage = "No user location found!";
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region GetDistrictNowCast
        public static NotificationsResponse GetDistrictNowCast(DistrictwiseNowcast obj)
        {
            DataTable dt = new DataTable();
            NotificationsResponse response = new NotificationsResponse();
            NotificationsResponse LocationResponse = new NotificationsResponse();
            List<DistrictwiseNowcast> ObjDistrictwiseNowcastsList = new List<DistrictwiseNowcast>();

            try
            {
                UserLocations objLocation = new UserLocations
                {
                    UserProfileID = Convert.ToInt32(obj.UserID),
                    LanguageType = "English",
                    RefreshDateTime = obj.RefreshDateTime
                };

                LocationResponse = GetUserLocations(objLocation);
                if (LocationResponse.IsSuccessful)
                {
                    if (LocationResponse.ObjUserLocationsList.Count > 0)
                    {
                        foreach (var item in LocationResponse.ObjUserLocationsList)
                        {
                            ObjDistrictwiseNowcastsList = new List<DistrictwiseNowcast>();
                            SqlParameter[] arrParams = new SqlParameter[]
                            {
                            new SqlParameter("@pDistrictName", item.DistrictName),
                            new SqlParameter("@planguagetype", obj.LanguageType),
                            new SqlParameter("@pRefreshdatetime", obj.RefreshDateTime),
                            };
                            dt = SQLHelper.Execute("spGet_Districtwise_Nowcast_NowDetails", arrParams);
                            if (dt.Rows.Count > 0)
                            {
                                ObjDistrictwiseNowcastsList =
                               (from DataRow dr in dt.Rows
                                select new DistrictwiseNowcast
                                {
                                    Cat1 = (dr["Cat1"] == DBNull.Value ? "" : Convert.ToString(dr["Cat1"])),
                                    Cat2 = (dr["Cat2"] == DBNull.Value ? "" : Convert.ToString(dr["Cat2"])),
                                    Cat3 = (dr["Cat3"] == DBNull.Value ? "" : Convert.ToString(dr["Cat3"])),
                                    Cat4 = (dr["Cat4"] == DBNull.Value ? "" : Convert.ToString(dr["Cat4"])),
                                    Cat5 = (dr["Cat5"] == DBNull.Value ? "" : Convert.ToString(dr["Cat5"])),
                                    Cat6 = (dr["Cat6"] == DBNull.Value ? "" : Convert.ToString(dr["Cat6"])),
                                    Cat7 = (dr["Cat7"] == DBNull.Value ? "" : Convert.ToString(dr["Cat7"])),
                                    Cat8 = (dr["Cat8"] == DBNull.Value ? "" : Convert.ToString(dr["Cat8"])),
                                    Cat9 = (dr["Cat9"] == DBNull.Value ? "" : Convert.ToString(dr["Cat9"])),
                                    Cat10 = (dr["Cat10"] == DBNull.Value ? "" : Convert.ToString(dr["Cat10"])),
                                    Cat11 = (dr["Cat11"] == DBNull.Value ? "" : Convert.ToString(dr["Cat11"])),
                                    Cat12 = (dr["Cat12"] == DBNull.Value ? "" : Convert.ToString(dr["Cat12"])),
                                    Cat13 = (dr["Cat13"] == DBNull.Value ? "" : Convert.ToString(dr["Cat13"])),
                                    Cat14 = (dr["Cat14"] == DBNull.Value ? "" : Convert.ToString(dr["Cat14"])),
                                    Cat15 = (dr["Cat15"] == DBNull.Value ? "" : Convert.ToString(dr["Cat15"])),
                                    Cat16 = (dr["Cat16"] == DBNull.Value ? "" : Convert.ToString(dr["Cat16"])),
                                    NotifyType = "Nowcast",
                                    RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"])),
                                    full_date = (dr["Date"] == DBNull.Value ? "" : Convert.ToString(dr["Date"])),
                                    Message = (dr["Message"] == DBNull.Value ? "" : Convert.ToString(dr["Message"])),
                                    State_District = (dr["State_District"] == DBNull.Value ? "" : Convert.ToString(dr["State_District"])),
                                    TOI = (dr["TOI"] == DBNull.Value ? "" : Convert.ToString(dr["TOI"])),
                                    VUpTo = (dr["VUpTo"] == DBNull.Value ? "" : Convert.ToString(dr["VUpTo"])),
                                    WarningsDetails = (dr["WarningsDetails"] == DBNull.Value ? "" : Convert.ToString(dr["WarningsDetails"])),
                                    Date = (dr["Date"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Date"]).ToString("dd-MM-yyyy"),
                                }).ToList();
                                response.ObjDistrictwiseNowcastList.AddRange(ObjDistrictwiseNowcastsList);
                            }
                        }
                        response.IsSuccessful = true;
                    }

                }
                else
                {
                    response.ObjDistrictwiseNowcastList = new List<DistrictwiseNowcast>();
                    response.ErrorMessage = "No user location found!";
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region GetUserLocations
        public static NotificationsResponse GetUserLocations(UserLocations objLocation)
        {
            DataTable dt = new DataTable();
            NotificationsResponse response = new NotificationsResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objLocation.UserProfileID),
                new SqlParameter("@planguagetype", objLocation.LanguageType),
                new SqlParameter("@pRefreshdatetime", objLocation.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_UserLocationDetails", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjUserLocationsList =
                   (from DataRow dr in dt.Rows
                    select new UserLocations
                    {
                        StateID = (dr["stateid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["stateid"]),
                        StateName = (dr["StateName"] == DBNull.Value ? "" : Convert.ToString(dr["StateName"])),
                        DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                        DistrictName = (dr["DistrictName"] == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"])),
                        BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                        BlockName = (dr["BlockName"] == DBNull.Value ? "" : Convert.ToString(dr["BlockName"])),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString("dd-MM-yyyy"),
                    }).ToList();
                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #endregion

        #region Notification

        public static TransactionDetails SendNotification(Notification notification)
        {
            var transactionResponse = new TransactionDetails();
            transactionResponse.IsSuccessful = NowCastNotification(notification.Title, notification.Message, notification.ColorCode, new List<string> { notification.Token });
            return transactionResponse;
        }

        public static bool NowCastNotification(string title, string body, int colorCode, IEnumerable<string> destinationIds)
        {
            if (title == null || body == null)
            {
                throw new ArgumentNullException(nameof(title), "title or body == null");
            }
            if (destinationIds == null || destinationIds.Count() == 0)
            {
                throw new ArgumentNullException(nameof(destinationIds), "destinationIds == null || destinationIds.Count() == 0");
            }
            Message message = new Message()
            {
                Registration_ids = destinationIds,
                Priority = Priority.High,
                Content_available = true,
                Notification = new NotificationContent()
                {
                    Title = title,
                    Body = body,
                    sound = "default"
                },
                Data = new StateData()
                {
                    Id = "",
                    ColorCode = GetColorHashCodeForNowCast(colorCode),
                    Type = NotificationTypeConstants.NowCast_received,
                    Body = body,
                    Title = title
                }
            };
            if (SendNotification(message))
            {
                return true;
            }
            return false;

        }
        public static bool SendNotification(Message messageBody)
        {
            var notificationUrl = ConfigurationManager.AppSettings["NotificationUrl"];
            WebRequest tRequest = WebRequest.Create(notificationUrl);
            string AuthKey = ConfigurationManager.AppSettings.Get("AuthorizationKey");
            string senderKey = ConfigurationManager.AppSettings.Get("SenderKey");
            tRequest.Method = "POST";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", ConfigurationManager.AppSettings.Get("AuthorizationKey")));
            tRequest.Headers.Add(string.Format("Sender: id={0}", ConfigurationManager.AppSettings.Get("SenderKey")));
            //tRequest.Headers.Add("Content-Type:application/json");
            tRequest.ContentType = "application/json";
            try
            {
                string postbody = JsonConvert.SerializeObject(messageBody, new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                Byte[] byteArray = Encoding.UTF8.GetBytes(postbody);
                tRequest.ContentLength = byteArray.Length;
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            if (dataStreamResponse != null) using (StreamReader tReader = new StreamReader(dataStreamResponse))
                                {
                                    var sResponseFromServer = tReader.ReadToEnd();
                                }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        #endregion

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