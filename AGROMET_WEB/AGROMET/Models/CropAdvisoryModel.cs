using System.Collections.Generic;
using System.Web;

namespace AGROMET.Models
{
    public class CropAdvisoryModel
    {
        public int CACID { get; set; }
        public string BriefText { get; set; }
        public string Title { get; set; }
        public string Recommendation { get; set; }
        public string ScientistId { get; set; }
        public int StateId { get; set; }
        public int CropID { get; set; }
        public int LanguageId { get; set; }
        public string DistrictList { get; set; }
        public string BlockList { get; set; }
        public string CropList { get; set; }
        public string LanguageType { get; set; }
        public string LanguageList { get; set; }
        public string SMSLanguage { get; set; }
        public bool MobileApplication { get; set; }
        public bool SMSAlert { get; set; }
        public string Institution { get; set; }
        public string PeriodStartDate { get; set; }
        public string PeriodEndDate { get; set; }
        public string WeatherCondition { get; set; }
        public string AgroAdvisoryDetails { get; set; }
        public int CAMID { get; set; }
        public bool D1 { get; set; }
        public bool D2 { get; set; }
        public bool D3 { get; set; }
        public bool D4 { get; set; }
        public bool D5 { get; set; }
        public string YouTubeLink { get; set; }
        public HttpPostedFileBase[] Files { get; set; }
        public HttpPostedFileBase AudioFile { get; set; }
    }
    public class CropAdvisoryDetails
    {
        public int CropAdvisoryID { get; set; }
        public int CategoryID { get; set; }
        public int DistrictID { get; set; }
        public int BlockID { get; set; }
        public int CropID { get; set; }
        public string BriefText { get; set; }
        public string Title { get; set; }
        public int ScientistID { get; set; }
        public int Id { get; set; }
        public int StateID { get; set; }
        public string Recommendations { get; set; }
        public string State { get; set; }
        public string DistrictList { get; set; }
        public string BlockList { get; set; }
        public string Category { get; set; }
        public string CropName { get; set; }
        public string CropNames { get; set; }
        public string LogInId { get; set; }
        public string FarmerName { get; set; }
        public string District { get; set; }
        public int Rating { get; set; }
        public string CreatedDate { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public byte[] ImageBytes { get; set; }
        public string PeriodStartDate { get; set; }
        public string PeriodEndDate { get; set; }
        public string WeatherCondition { get; set; }
        public string AgroAdvisoryDetails { get; set; }
        public string SMSLanguage { get; set; }
        public int CAMID { get; set; }
        public bool D1 { get; set; }
        public bool D2 { get; set; }
        public bool D3 { get; set; }
        public bool D4 { get; set; }
        public bool D5 { get; set; }
        public string YouTubeLink { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CropAdvisoryDistrict
    {
        public int CADMID { get; set; }
        public int CropAdvisoryID { get; set; }
        public int DistrictID { get; set; }
        public string DistictName { get; set; }
        public int StateID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }

    }
    public class CropAdvisoryBlock
    {
        public int CropAdvisoryID { get; set; }
        public string BlockName { get; set; }
        public int CABMID { get; set; }
        public int BlockID { get; set; }
        public int DistrictID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CropAdvisoryCrop
    {
        public int CACMID { get; set; }
        public int CropAdvisoryID { get; set; }
        public string CropName { get; set; }
        public int CropID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CropAdvisoryImage
    {
        public int CAAID { get; set; }
        public int CropAdvisoryID { get; set; }
        public string Type { get; set; }
        public string ImagePath { get; set; }
        public string ThumbNailImageName { get; set; }
        public byte[] ByteStream { set; get; }
        public byte[] ThumbnailBytes { set; get; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
        public string CreatedDate { get; set; }
    }
    public class Languages
    {
        public int ID { get; set; }
        public string English { get; set; }
        public string Telugu { get; set; }
        public string Tamil { get; set; }
        public string Malayalam { get; set; }
        public string Kannada { get; set; }
        public string Urdu { get; set; }
        public string Hindi { get; set; }
        public string Oriya { get; set; }
        public string Punjabi { get; set; }
        public string Gujarati { get; set; }
        public string Marati { get; set; }
        public string Bengali { get; set; }
        public string Sindhi { get; set; }
        public string Assamese { get; set; }
        public string Kashmiri { get; set; }
        public string Konkani { get; set; }
        public string Manipuri { get; set; }
        public string Maithili { get; set; }
        public string Bhili { get; set; }
        public string Santali { get; set; }
        public string Nepali { get; set; }
        public string Gondi { get; set; }
        public string Dogri { get; set; }
        public string Khandeshi { get; set; }
        public string Kurukh { get; set; }
        public string Tulu { get; set; }
        public string Bodo { get; set; }
        public string Khasi { get; set; }
        public string Mundari { get; set; }
        public string Ho { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CropAdvisoryFeedback
    {
        public int FeedbackID { get; set; }
        public int CropAdvisoryID { get; set; }
        public int UserProfileID { get; set; }
        public int Rating { get; set; }
        public bool isFeedback { get; set; }
        public bool Q1 { get; set; }
        public bool Q2 { get; set; }
        public string Comments { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CropAdvisoryResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<CropAdvisoryDetails> ObjCropAdvisoryDetailsList { get; set; }
        public List<CropAdvisoryDistrict> ObjCropAdvisoryDistMappList { get; set; }
        public List<CropAdvisoryBlock> ObjCropAdvisoryBlockMappList { get; set; }
        public List<CropAdvisoryCrop> ObjCropAdvisoryCropMappList { get; set; }
        public List<CropAdvisoryImage> ObjCropAdvisoryImageList { get; set; }
        public List<CropAdvisoryFeedback> ObjCropAdvisoryFeedbackList { get; set; }
        public List<Languages> ObjLanguagesList { get; set; }

        public CropAdvisoryResponse()
        {
            this.ObjCropAdvisoryDetailsList = new List<CropAdvisoryDetails>();
            this.ObjCropAdvisoryDistMappList = new List<CropAdvisoryDistrict>();
            this.ObjCropAdvisoryBlockMappList = new List<CropAdvisoryBlock>();
            this.ObjCropAdvisoryCropMappList = new List<CropAdvisoryCrop>();
            this.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
            this.ObjCropAdvisoryFeedbackList = new List<CropAdvisoryFeedback>();
            this.ObjLanguagesList = new List<Languages>();
        }
    }
}