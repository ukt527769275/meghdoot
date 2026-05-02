using System.Collections.Generic;

namespace AGROMET.Models
{
    public class NotificationsModel
    {
        public string Title { get; set; }
        public string BriefText { get; set; }
        public string CompleteMessage { get; set; }
        public string ScientistId { get; set; }
        public int CACID { get; set; }
        public string CropName { get; set; }
        public int CropID { get; set; }
        public int StateId { get; set; }
        public string DistrictList { get; set; }
        public string BlockList { get; set; }
        public string CropList { get; set; }
        public string LanguageList { get; set; }
        public string LanguageType { get; set; }
        public string SMSLanguage { get; set; }
        public bool MobileApplication { get; set; }
        public bool SMSAlert { get; set; }
    }
    public class NotificationsDetails
    {
        public int NotificationsID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string CropNames { get; set; }
        public string CompleteMessage { get; set; }
        public int Id { get; set; }
        public string CropName { get; set; }
        public int CropID { get; set; }
        public int StateID { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public string BriefText { get; set; }
        public string CreatedDateWeb { get; set; }
        public string CreatedDate { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public byte[] ImageBytes { get; set; }
        public string LanguageType { get; set; }
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
   
    public class NotificationsResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<NotificationsDetails> ObjNotificationsDetailsList { get; set; }
        public List<NotificationsDistrict> ObjNotificationsDistMappList { get; set; }
        public List<NotificationsBlock> ObjNotificationsBlockMappList { get; set; }
        public List<NotificationsCrop> ObjNotificationsCropMappList { get; set; }

        public NotificationsResponse()
        {
            this.ObjNotificationsDetailsList = new List<NotificationsDetails>();
            this.ObjNotificationsDistMappList = new List<NotificationsDistrict>();
            this.ObjNotificationsBlockMappList = new List<NotificationsBlock>();
            this.ObjNotificationsCropMappList = new List<NotificationsCrop>();
        }
    }
}