using AGROMET_COMMON;
using AGROMET_DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using AGROMET_MASTERS;

namespace AGROMET_CROPADVISORY
{

    public class CropAdvisoryDetails
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int CropAdvisoryID { get; set; }
        public int CategoryID { get; set; }
        public int DistrictID { get; set; }
        public int BlockID { get; set; }
        public int AsdID { get; set; }
        public string AsdName { get; set; }
        public int CropID { get; set; }
        public string Title { get; set; }
        public string VarietyName { get; set; }
        public int VarietyId { get; set; }
        public string CropName { get; set; }
        public string FarmerName { get; set; }
        public string LogInId { get; set; }
        public int ScientistID { get; set; }
        public int Id { get; set; }
        public int StateID { get; set; }
        public string Recommendations { get; set; }
        public string YouTubeLink { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Block { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string CategoryIcon { get; set; }
        public string CreatedDate { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public byte[] ImageBytes { get; set; }
        public string CropImageURL { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
        public int FeedbackID { get; set; }
        public int Rating { get; set; }
        public int LanguageId { get; set; }
        public string BriefText { get; set; }
        public string BriefTextRegional { get; set; }
        public string RecommendationsRegional { get; set; }
        public string WeatherConditionRegional { get; set; }
        public string AgroAdvisoryDetailsRegional { get; set; }
        public string RegionalLanguage { get; set; }
        public string SMSLanguage { get; set; }
        public string BlocksList { get; set; }
        public string DistricsList { get; set; }
        public string BlockList { get; set; }
        public string AsdList { get; set; }
        public string DistrictList { get; set; }
        public bool SMSAlert { get; set; }
        public string PhoneNumber { get; set; }
        public string Institution { get; set; }
        public string PeriodStartDate { get; set; }
        public string PeriodEndDate { get; set; }
        public string WeatherCondition { get; set; }
        public string AgroAdvisoryDetails { get; set; }
        public int FavouriteID { get; set; }
        public int CAMID { get; set; }
        public int AvgFeedback { get; set; }
        public bool D1 { get; set; }
        public bool D2 { get; set; }
        public bool D3 { get; set; }
        public bool D4 { get; set; }
        public bool D5 { get; set; }
        public bool Q1 { get; set; }
        public bool Q2 { get; set; }
        public string Comments { get; set; }
        public string RecordDate { get; set; }
        public bool IsCurrentLocation { get; set; } = false;
        public List<CropAdvisoryDistrict> ObjDistrictList { get; set; }
        public List<CropAdvisoryBlock> ObjBlockList { get; set; }
        public List<CropAdvisoryAsd> ObjAsdList { get; set; }
        public List<CropAdvisoryCrop> ObjCropList { get; set; }
        public List<CropAdvisoryImage> ObjCropAdvisoryImageList { get; set; }
        public CropAdvisoryAudio ObjCropAdvisoryAudio {get;set;}
        public CropAdvisoryDetails()
        {
            this.ObjDistrictList = new List<CropAdvisoryDistrict>();
            this.ObjBlockList = new List<CropAdvisoryBlock>();
            this.ObjAsdList = new List<CropAdvisoryAsd>();
            this.ObjCropList = new List<CropAdvisoryCrop>();
            this.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
            this.ObjCropAdvisoryAudio = new CropAdvisoryAudio();
        }

    }
    public class CropDetailsMaster
    {
        //public int Id  { get; set; }
        public int CropCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CropName { get; set; }
        public string Hindi { get; set; }
        public string Telugu { get; set; }
        public string Kannada { get; set; }
        public string Marathi { get; set; }
        public string Punjabi { get; set; }
        public bool Flag { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public int? Createdby { get; set; }
        public string CropCode { get; set; }
        public string Assamese { get; set; }
        public string Gujarati { get; set; }
        public string Malayalam { get; set; }
        public string Oriya { get; set; }
        public string Tamil { get; set; }
        public int CropID { get; set; }
        public string VarietyName { get; set; }
        public string VarietyId { get; set; }
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
        public int AsdID { get; set; }
        public string AsdName { get; set; }
        public int DistrictID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
    }

    public class CropAdvisoryAsd
    {
        public int CropAdvisoryID { get; set; }
        public int CABMID { get; set; }
        public int AsdID { get; set; }
        public string AsdName { get; set; }
        public int DistrictID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CropAdvisoryCropCategory
    {
        public int CropAdvisoryID { get; set; }
        public string CropCategory { get; set; }
        public int CropCategoryID { get; set; }
        public int ID { get; set; }
        public string Type { get; set; }
        public byte[] ThumbNailBytes { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CropAdvisoryCrop
    {
        public int CACMID { get; set; }
        public int CropAdvisoryID { get; set; }
        public string Type { get; set; }
        public string CropName { get; set; }
        public int CropID { get; set; }
        public int ID { get; set; }
        public int CropCategoryID { get; set; }
        public byte[] ThumbNailBytes { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
        public string CropImageURL { get; set; }
        public string VarietyName { get; set; }
        public int VarietyId { get; set; }
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
    public class CropImageForMasterTable
    {        
        public int CropID { get; set; }
        public string Type { get; set; }
        public string ImagePath { get; set; }       
        public byte[] ByteStream { set; get; }               
    }
    public class CropAdvisoryAudio
    {
        public int CAAID { get; set; }
        public int CropAdvisoryID { get; set; }
        public string Type { get; set; }
        public string FileName { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
    }
    public class CropAdvisoryFavourites
    {
        public int CAFLID { get; set; }
        public int CropAdvisoryID { get; set; }
        public int UserProfileID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
    }
    public class CropAdvisoryFeedback
    {
        public int FeedbackID { get; set; }
        public int CropAdvisoryID { get; set; }
        public int UserProfileID { get; set; }
        public int Rating { get; set; }
        public bool isFeedback { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Comments { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string FarmerName { get; set; }

        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
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
    public class AdvisoryFromIMD
    {
        public string custom_date { get; set; }
        public string cat_id { get; set; }
        public string category_name { get; set; }
        public string state_id { get; set; }
        public string state_name { get; set; }
        public string district_id { get; set; }
        public string district_name { get; set; }
        public string block_id { get; set; }
        public string block_name { get; set; }
        public object weather_summary_eng { get; set; }
        public object weather_summary_reg { get; set; }
        public object general_advisory_eng { get; set; }
        public object general_advisory_reg { get; set; }
        public object sms_eng { get; set; }
        public object sms_reg { get; set; }
        public string type_id { get; set; }
        public string crop_name { get; set; }
        public string advisory_eng { get; set; }
        public string advisory_reg { get; set; } 
        public string variety_id { get; set; }
        public string variety_name { get; set; }
        public string reg_lang_name { get; set; }
        public int asd_id { get; set; }
        public string asd_name { get; set; }
    }
    public class CropsNameFromIMD
    { 
        public string cat_id { get; set; }
        public string category_name { get; set; }
        public string crop_id { get; set; }
        public string crop_name { get; set; }
        public string variety_id { get; set; }
        public string variety_name { get; set; }        
    }
    public class CropAdvisoryResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<CropAdvisoryDetails> ObjCropAdvisoryDetailsList { get; set; }
        public List<CropAdvisoryDetails> ObjCropAdvisoryFavList { get; set; }
        public List<CropAdvisoryDistrict> ObjCropAdvisoryDistMappList { get; set; }
        public List<CropAdvisoryBlock> ObjCropAdvisoryBlockMappList { get; set; }
        public List<CropAdvisoryCrop> ObjCropAdvisoryCropMappList { get; set; }
        public List<CropAdvisoryImage> ObjCropAdvisoryImageList { get; set; }
        public List<CropAdvisoryCropCategory> ObjCropAdvisoryCropCategoryList { get; set; }
        public List<CropAdvisoryFeedback> ObjCropAdvisoryFeedbackList { get; set; }
        public List<CropAdvisoryFavourites> ObjCropAdvisoryFavouritesList { get; set; }
        public List<Languages> ObjLanguagesList { get; set; }

        public CropAdvisoryResponse()
        {
            this.ObjCropAdvisoryDetailsList = new List<CropAdvisoryDetails>();
            this.ObjCropAdvisoryFavList = new List<CropAdvisoryDetails>();
            this.ObjCropAdvisoryDistMappList = new List<CropAdvisoryDistrict>();
            this.ObjCropAdvisoryBlockMappList = new List<CropAdvisoryBlock>();
            this.ObjCropAdvisoryCropMappList = new List<CropAdvisoryCrop>();
            this.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
            this.ObjCropAdvisoryCropCategoryList = new List<CropAdvisoryCropCategory>();
            this.ObjCropAdvisoryFeedbackList = new List<CropAdvisoryFeedback>();
            this.ObjCropAdvisoryFavouritesList = new List<CropAdvisoryFavourites>();
            this.ObjLanguagesList = new List<Languages>();
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
    
    public class CropAdvisory
    {
        public static string AD = ConfigurationManager.AppSettings["AD"].ToString();
        public static string AD_NEWDistrict = ConfigurationManager.AppSettings["AD_NEWDistrict"].ToString();        
        public static string AD_NEW = ConfigurationManager.AppSettings["AD_NEW"].ToString();
        public static string AD_NEWASD = ConfigurationManager.AppSettings["AD_NEWASD"].ToString();
        public static string MasterCrops = ConfigurationManager.AppSettings["MasterCrops"].ToString();
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #region Save Crop Advisory Masters

        #region SaveCropAdvisoryMasters
        public static TransactionDetails SaveCropAdvisoryMasters(CropAdvisoryDetails ObjDetails, bool IsBlockLevel = false)
        {
            _log.Info("starting SaveCropAdvisoryMasters Service cropadvisory service");
            TransactionDetails response = new TransactionDetails();
            CropAdvisoryDistrict ObjDistrict = new CropAdvisoryDistrict();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pCAMID",ObjDetails.CAMID),
                                        new SqlParameter("@pScientistID",ObjDetails.Createdby),
                                        new SqlParameter("@pStateID", ObjDetails.StateID),
                                        new SqlParameter("@pDistrictID", ObjDetails.DistrictID),
                                        new SqlParameter("@pBlockID", ObjDetails.BlockID),
                                        new SqlParameter("@pAsdID", ObjDetails.AsdID),
                                        new SqlParameter("@pVarietyId", ObjDetails.VarietyId),
                                        new SqlParameter("@pTitle", ObjDetails.Title),
                                        new SqlParameter("@pPeriodStartDate",ObjDetails.PeriodStartDate),
                                        new SqlParameter("@pPeriodEndDate",ObjDetails.PeriodEndDate),
                                        new SqlParameter("@pWeatherCondition",ObjDetails.WeatherCondition),
                                        new SqlParameter("@pAgroAdvisoryDetails",ObjDetails.AgroAdvisoryDetails),
                                        new SqlParameter("@pWeatherConditionRegional",ObjDetails.WeatherConditionRegional),
                                        new SqlParameter("@pAgroAdvisoryDetailsRegional",ObjDetails.AgroAdvisoryDetailsRegional),
                                        new SqlParameter("@pRegionalLanguage",ObjDetails.RegionalLanguage),
                                        new SqlParameter("@pRecordDate",ObjDetails.RecordDate),
                                        new SqlParameter("@pDistrictList",ObjDetails.DistrictList),
                                        new SqlParameter("@pBlockList",ObjDetails.BlockList),
                                        new SqlParameter("@pAsdList",ObjDetails.AsdList),
                                        new SqlParameter("@pLanguageId",ObjDetails.LanguageId),
                                        new SqlParameter("@pD1",ObjDetails.D1),
                                        new SqlParameter("@pD2",ObjDetails.D2),
                                        new SqlParameter("@pD3",ObjDetails.D3),
                                        new SqlParameter("@pD4",ObjDetails.D4),
                                        new SqlParameter("@pD5",ObjDetails.D5),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                _log.Info("starting ExecuteOutIDParameter in SaveCropAdvisoryMasters  Service cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisoryDetailsMaster", arrParams);
                _log.Info("complete ExecuteOutIDParameter in SaveCropAdvisoryMasters  Service cropadvisory service");
                if (response.IsSuccessful == true)
                {
                    if (response.NewID > 0)
                    {
                        if (ObjDetails.ObjDistrictList.Count > 0 && ! IsBlockLevel)
                        {
                            foreach (var Item in ObjDetails.ObjDistrictList)
                            {
                                Item.CropAdvisoryID = Convert.ToInt32(response.NewID);
                                _log.Info("starting SaveCropAdvisoryDistrictMaster in SaveCropAdvisoryMasters  Service cropadvisory service");
                                SaveCropAdvisoryDistrictMaster(Item);
                                _log.Info("starting SaveCropAdvisoryDistrictMaster in SaveCropAdvisoryMasters  Service cropadvisory service");
                            }
                        }
                        if (ObjDetails.ObjBlockList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjBlockList)
                            {
                                Item.CropAdvisoryID = Convert.ToInt32(response.NewID);
                                _log.Info("starting SaveCropAdvisoryBlockMaster in SaveCropAdvisoryMasters  Service cropadvisory service");
                                SaveCropAdvisoryBlockMaster(Item);
                                _log.Info("starting SaveCropAdvisoryBlockMaster in SaveCropAdvisoryMasters  Service cropadvisory service");
                            }
                        }
                        if (ObjDetails.ObjAsdList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjAsdList)
                            {
                                Item.CropAdvisoryID = Convert.ToInt32(response.NewID);
                                _log.Info("starting SaveCropAdvisoryAsdMaster in SaveCropAdvisoryMasters  Service cropadvisory service");
                                SaveCropAdvisoryAsdMaster(Item);
                                _log.Info("starting SaveCropAdvisoryAsdMaster in SaveCropAdvisoryMasters  Service cropadvisory service");
                            }
                        }
                        response.IsSuccessful = true;
                    }
                }                
            }
            catch (Exception ex)
            {
                _log.Error("exception in  SaveCropAdvisoryMasters  Service cropadvisory service : "+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ending SaveCropAdvisoryMasters  Service cropadvisory service");
            return response;
        }
        #endregion

        #region SaveCropAdvisory
        public static TransactionDetails SaveCropAdvisory(CropAdvisoryDetails ObjDetails)
        {
            _log.Info("starting SaveCropAdvisory Service cropadvisory service");
            TransactionDetails response = new TransactionDetails();
            CropAdvisoryDistrict ObjDistrict = new CropAdvisoryDistrict();
           if(ObjDetails.CreatedDate == null)
            {
                ObjDetails.CreatedDate = DateTime.Now.ToString();
            }
            try
            {                
                SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pCropAdvisoryID",ObjDetails.CropAdvisoryID),
                                        new SqlParameter("@pCAMID",ObjDetails.CAMID),
                                        new SqlParameter("@pCategoryID",ObjDetails.CategoryID),
                                        new SqlParameter("@pCropID",ObjDetails.CropID),
                                        new SqlParameter("@pTitle", ObjDetails.Title),
                                        new SqlParameter("@pBriefText", ObjDetails.BriefText),
                                        new SqlParameter("@pScientistID",ObjDetails.ScientistID),
                                        new SqlParameter("@pStateID",ObjDetails.StateID),
                                        new SqlParameter("@pRecommendations",ObjDetails.Recommendations),
                                        new SqlParameter("@pRecommendationsRegional",ObjDetails.RecommendationsRegional),
                                        new SqlParameter("@pBriefTextRegional",ObjDetails.BriefTextRegional),
                                        new SqlParameter("@pRegionalLanguage",ObjDetails.RegionalLanguage),
                                        new SqlParameter("@pVarietyId",ObjDetails.VarietyId),
                                        new SqlParameter("@pVarietyName",ObjDetails.VarietyName),
                                        new SqlParameter("@pRecordDate",ObjDetails.RecordDate),
                                        new SqlParameter("@pyoutubelink",ObjDetails.YouTubeLink),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                                        new SqlParameter("@pCreatedDate",ObjDetails.CreatedDate),
                };
                _log.Info("calling ExecuteOutIDParameter in SaveCropAdvisory Service cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisory", arrParams);
                _log.Info("called ExecuteOutIDParameter in SaveCropAdvisory Service cropadvisory service");
                if (response.IsSuccessful == true)
                {
                    if (response.NewID > 0)
                    {
                        if (ObjDetails.ObjDistrictList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjDistrictList)
                            {
                                Item.CropAdvisoryID = Convert.ToInt32(response.NewID);
                                _log.Info("calling SaveCropAdvisoryDistrict in SaveCropAdvisory Service cropadvisory service");
                                SaveCropAdvisoryDistrict(Item);
                                _log.Info("called SaveCropAdvisoryDistrict in SaveCropAdvisory Service cropadvisory service");
                            }
                        }
                        if (ObjDetails.ObjBlockList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjBlockList)
                            {
                                Item.CropAdvisoryID = Convert.ToInt32(response.NewID);
                                _log.Info("calling SaveCropAdvisoryBlock in SaveCropAdvisory Service cropadvisory service");
                                SaveCropAdvisoryBlock(Item);
                                _log.Info("called SaveCropAdvisoryBlock in SaveCropAdvisory Service cropadvisory service");
                            }
                        }
                        if (ObjDetails.ObjAsdList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjAsdList)
                            {
                                Item.CropAdvisoryID = Convert.ToInt32(response.NewID);
                                _log.Info("calling SaveCropAdvisoryAsd in SaveCropAdvisory Service cropadvisory service");
                                SaveCropAdvisoryAsd(Item);
                                _log.Info("called SaveCropAdvisoryAsd in SaveCropAdvisory Service cropadvisory service");
                            }
                        }
                        if (ObjDetails.ObjCropList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjCropList)
                            {
                                Item.CropAdvisoryID = Convert.ToInt32(response.NewID);
                                _log.Info("calling SaveCropAdvisoryCrop in SaveCropAdvisory Service cropadvisory service");
                                SaveCropAdvisoryCrop(Item);
                                _log.Info("called SaveCropAdvisoryCrop in SaveCropAdvisory Service cropadvisory service");
                            }
                        }
                        if (ObjDetails.ObjCropAdvisoryImageList.Count > 0)
                        {
                            foreach (var Item in ObjDetails.ObjCropAdvisoryImageList)
                            {
                                Item.CropAdvisoryID = Convert.ToInt32(response.NewID);
                                _log.Info("calling SaveCropAdvisoryImage in SaveCropAdvisory Service cropadvisory service");
                                SaveCropAdvisoryImage(Item);
                                _log.Info("called SaveCropAdvisoryImage in SaveCropAdvisory Service cropadvisory service");
                            }
                        }
                        if (ObjDetails.ObjCropAdvisoryAudio != null && ObjDetails.ObjCropAdvisoryAudio.CAAID != 0)
                        {

                            ObjDetails.ObjCropAdvisoryAudio.CropAdvisoryID = Convert.ToInt32(response.NewID);
                            _log.Info("calling SaveCropAdvisoryAudio in SaveCropAdvisory Service cropadvisory service");
                            SaveCropAdvisoryAudio(ObjDetails.ObjCropAdvisoryAudio);
                            _log.Info("called SaveCropAdvisoryAudio in SaveCropAdvisory Service cropadvisory service");

                        }
                        if (ObjDetails.SMSAlert)
                        {
                            _log.Info("calling SendCropAdvisorySMS in SaveCropAdvisory Service cropadvisory service");
                            SendCropAdvisorySMS(ObjDetails);
                            _log.Info("called SendCropAdvisorySMS in SaveCropAdvisory Service cropadvisory service");
                        }

                    }
                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                _log.Error("exception in SaveCropAdvisory Service cropadvisory service : "+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ended SaveCropAdvisory Service cropadvisory service");
            return response;
        }
        #endregion

        #region SaveCropAdvisoryDistrictMaster
        public static TransactionDetails SaveCropAdvisoryDistrictMaster(CropAdvisoryDistrict ObjDetails)
        {
            _log.Info("starting SaveCropAdvisoryDistrictMaster ");
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pCADMID",ObjDetails.CADMID),
                                        new SqlParameter("@pCropAdvisoryID", ObjDetails.CropAdvisoryID),
                                        new SqlParameter("@pStateID",ObjDetails.StateID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                _log.Info("calling ExecuteOutIDParameter in SaveCropAdvisoryDistrictMaster ");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisoryMasterDetails_DistrictMapping", arrParams);
                _log.Info("called ExecuteOutIDParameter in SaveCropAdvisoryDistrictMaster ");
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _log.Error("exception in SaveCropAdvisoryDistrictMaster :"+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ending  SaveCropAdvisoryDistrictMaster ");
            return response;
        }
        #endregion

        #region SaveCropAdvisoryBlockMaster
        public static TransactionDetails SaveCropAdvisoryBlockMaster(CropAdvisoryBlock ObjDetails)
        {
            _log.Info("starting SaveCropAdvisoryBlockMaster cropadvisory service");
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {

                                        new SqlParameter("@pCABMID",ObjDetails.CABMID),
                                        new SqlParameter("@pCropAdvisoryID", ObjDetails.CropAdvisoryID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pBlockID",ObjDetails.BlockID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                _log.Info("calling ExecuteOutIDParameter in SaveCropAdvisoryBlockMaster cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisoryMasterDetails_BlockMapping", arrParams);
                _log.Info("called ExecuteOutIDParameter in SaveCropAdvisoryBlockMaster cropadvisory service");
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _log.Error("exception in  SaveCropAdvisoryBlockMaster cropadvisory service : "+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ending SaveCropAdvisoryBlockMaster cropadvisory service");
            return response;
        }
        #endregion

        #region SaveCropAdvisoryAsdMaster
        public static TransactionDetails SaveCropAdvisoryAsdMaster(CropAdvisoryAsd ObjDetails)
        {
            _log.Info("starting SaveCropAdvisoryAsdMaster cropadvisory service");
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {

                                        new SqlParameter("@pCABMID",ObjDetails.CABMID),
                                        new SqlParameter("@pCropAdvisoryID", ObjDetails.CropAdvisoryID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pAsdID",ObjDetails.AsdID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                _log.Info("calling ExecuteOutIDParameter in SaveCropAdvisoryAsdMaster cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisoryMasterDetails_AsdMapping", arrParams);
                _log.Info("called ExecuteOutIDParameter in SaveCropAdvisoryAsdMaster cropadvisory service");
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _log.Error("exception in  SaveCropAdvisoryAsdMaster cropadvisory service : " + ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ending SaveCropAdvisoryAsdMaster cropadvisory service");
            return response;
        }
        #endregion

        #region SaveCropAdvisoryDistrict
        public static TransactionDetails SaveCropAdvisoryDistrict(CropAdvisoryDistrict ObjDetails)
        {
            _log.Info("calling SaveCropAdvisoryDistrict in SaveCropAdvisory Service cropadvisory service");
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {
                                        new SqlParameter("@pCADMID",ObjDetails.CADMID),
                                        new SqlParameter("@pCropAdvisoryID", ObjDetails.CropAdvisoryID),
                                        new SqlParameter("@pStateID",ObjDetails.StateID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                _log.Info("calling ExecuteOutIDParameter in SaveCropAdvisoryDistrict in SaveCropAdvisory Service cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisory_DistrictMapping", arrParams);
                _log.Info("called ExecuteOutIDParameter in SaveCropAdvisoryDistrict in SaveCropAdvisory Service cropadvisory service");
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _log.Error("exception in SaveCropAdvisoryDistrict in SaveCropAdvisory Service cropadvisory service : "+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ended  SaveCropAdvisoryDistrict in SaveCropAdvisory Service cropadvisory service");
            return response;
        }
        #endregion

        #region SaveCropAdvisoryBlock
        public static TransactionDetails SaveCropAdvisoryBlock(CropAdvisoryBlock ObjDetails)
        {
            _log.Info("starting SaveCropAdvisoryBlock in SaveCropAdvisory Service cropadvisory service");
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {

                                        new SqlParameter("@pCABMID",ObjDetails.CABMID),
                                        new SqlParameter("@pCropAdvisoryID", ObjDetails.CropAdvisoryID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pBlockID",ObjDetails.BlockID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                _log.Info("calling ExecuteOutIDParameter in SaveCropAdvisoryBlock in SaveCropAdvisory Service cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisory_BlockMapping", arrParams);
                _log.Info("called  ExecuteOutIDParameter in SaveCropAdvisoryBlock in SaveCropAdvisory Service cropadvisory service");
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _log.Error("exception in  SaveCropAdvisoryBlock in SaveCropAdvisory Service cropadvisory service : "+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ending SaveCropAdvisoryBlock in SaveCropAdvisory Service cropadvisory service");
            return response;
        }

        public static TransactionDetails SaveCropAdvisoryAsd(CropAdvisoryAsd ObjDetails)
        {
            _log.Info("starting SaveCropAdvisoryAsd in SaveCropAdvisory Service cropadvisory service");
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {

                                        new SqlParameter("@pCABMID",ObjDetails.CABMID),
                                        new SqlParameter("@pCropAdvisoryID", ObjDetails.CropAdvisoryID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pAsdID",ObjDetails.AsdID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                _log.Info("calling ExecuteOutIDParameter in SaveCropAdvisoryAsd in SaveCropAdvisory Service cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisory_AsdMapping", arrParams);
                _log.Info("called  ExecuteOutIDParameter in SaveCropAdvisoryAsd in SaveCropAdvisory Service cropadvisory service");
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _log.Error("exception in  SaveCropAdvisoryAsd in SaveCropAdvisory Service cropadvisory service : " + ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ending SaveCropAdvisoryAsd in SaveCropAdvisory Service cropadvisory service");
            return response;
        }
        #endregion

        #region SaveCropAdvisoryCrop
        public static TransactionDetails SaveCropAdvisoryCrop(CropAdvisoryCrop ObjDetails)
        {
            _log.Info("starting SaveCropAdvisoryCrop in SaveCropAdvisory Service cropadvisory service");
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pCropAdvisoryID",ObjDetails.CropAdvisoryID),
                   new SqlParameter("@pCACMID", ObjDetails.CACMID),
                   new SqlParameter("@pCropID",ObjDetails.CropID),
                   new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                   new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                _log.Info("calling ExecuteOutIDParameter in SaveCropAdvisoryCrop in SaveCropAdvisory Service cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisory_CropMapping", arrParams);
                _log.Info("called ExecuteOutIDParameter in SaveCropAdvisoryCrop in SaveCropAdvisory Service cropadvisory service");
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _log.Error("exception SaveCropAdvisoryCrop in SaveCropAdvisory Service cropadvisory service : "+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("calling SaveCropAdvisoryCrop in SaveCropAdvisory Service cropadvisory service");
            return response;
        }
        #endregion

        #region Save CropAdvisory Images
        public static TransactionDetails SaveCropAdvisoryImage(CropAdvisoryImage objImage)
        {
            _log.Info("starting SaveCropAdvisoryImage in SaveCropAdvisory Service cropadvisory service");
            TransactionDetails response = new TransactionDetails();
            DocumentInfo objDocumentInfo = new DocumentInfo();
            GetDocumentResponse objDocumentResponse = new GetDocumentResponse();

            if (objImage.ByteStream != null && objImage.ByteStream.Length > 0)
            {
                objDocumentInfo.ByteStream = objImage.ByteStream;
                objDocumentResponse = Utilities.SaveImageUpload(objDocumentInfo);
                objImage.ImagePath = objDocumentResponse.LargeImgBlobFileName;
                objImage.ThumbNailImageName = objDocumentResponse.ThumbnailImgBlobFileName;
                objImage.ThumbnailBytes = objDocumentResponse.ImageURl_bytes;
            }
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pCAAID",objImage.CAAID),
                   new SqlParameter("@pCropAdvisoryID",objImage.CropAdvisoryID),
                   new SqlParameter("@pType",objImage.Type),
                   new SqlParameter("@pImagePath",objImage.ImagePath),
                   new SqlParameter("@pThumbnailBytes",objImage.ThumbnailBytes),
                   new SqlParameter("@pcreatedby",objImage.Createdby),
                   new SqlParameter("@pupdatedby",objImage.Updatedby),
                };
                _log.Info("calling ExecuteOutIDParameter in SaveCropAdvisoryImage in SaveCropAdvisory Service cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisoryAttachments", arrParams);
                _log.Info("called ExecuteOutIDParameter in SaveCropAdvisoryImage in SaveCropAdvisory Service cropadvisory service");
            }
            catch (Exception ex)
            {
                _log.Error("exception in SaveCropAdvisoryImage in SaveCropAdvisory Service cropadvisory service : "+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ended SaveCropAdvisoryImage in SaveCropAdvisory Service cropadvisory service");
            return response;
        }
        #endregion

        #region Save CropAdvisory Audio
        public static TransactionDetails SaveCropAdvisoryAudio(CropAdvisoryAudio objAudio)
        {
            _log.Info("starting SaveCropAdvisoryAudio in SaveCropAdvisory Service cropadvisory service");
            TransactionDetails response = new TransactionDetails();
            byte[] bytes = new byte[0];
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pCAAID",objAudio.CAAID),
                   new SqlParameter("@pCropAdvisoryID",objAudio.CropAdvisoryID),
                   new SqlParameter("@pType",objAudio.Type),
                   new SqlParameter("@pImagePath",objAudio.FileName),
                   new SqlParameter("@pThumbnailBytes",bytes),
                   new SqlParameter("@pcreatedby",objAudio.Createdby),
                   new SqlParameter("@pupdatedby",objAudio.Updatedby),
                };
                _log.Info("calling ExecuteOutIDParameter SaveCropAdvisoryAudio in SaveCropAdvisory Service cropadvisory service");
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisoryAttachments", arrParams);
                _log.Info("called ExecuteOutIDParameter SaveCropAdvisoryAudio in SaveCropAdvisory Service cropadvisory service");
            }
            catch (Exception ex)
            {
                _log.Error("exception in  SaveCropAdvisoryAudio in SaveCropAdvisory Service cropadvisory service : "+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ended SaveCropAdvisoryAudio in SaveCropAdvisory Service cropadvisory service");
            return response;
        }
        #endregion

        #region SendNotificationsSMS
        public static CropAdvisoryResponse SendCropAdvisorySMS(CropAdvisoryDetails ObjDetails)
        {
            _log.Info("starting SendCropAdvisorySMS in SaveCropAdvisory Service cropadvisory service");
            CropAdvisoryResponse response = new CropAdvisoryResponse();
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
                _log.Info("calling execute SendCropAdvisorySMS in SaveCropAdvisory Service cropadvisory service");
                dt = SQLHelper.Execute("spGet_PhoneNumbersForNotificationSending", arrParams);
                _log.Info("called execute SendCropAdvisorySMS in SaveCropAdvisory Service cropadvisory service");
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                  (from DataRow dr in dt.Rows
                   select new CropAdvisoryDetails
                   {
                       PhoneNumber = (dr["PhoneNumber"]) == DBNull.Value ? "" : Convert.ToString(dr["PhoneNumber"]),
                   }).ToList();
                    response.IsSuccessful = true;
                }
                if (response.ObjCropAdvisoryDetailsList != null && response.ObjCropAdvisoryDetailsList.Count > 0)
                {
                    StringBuilder PhoneNumber = new StringBuilder();
                    foreach (var item in response.ObjCropAdvisoryDetailsList)
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
                _log.Error("exception in SendCropAdvisorySMS in SaveCropAdvisory Service cropadvisory service : "+ ex.Message);
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            _log.Info("ended SendCropAdvisorySMS in SaveCropAdvisory Service cropadvisory service");
            return response;
        }
        #endregion

        #region Save CropAdvisory FavouriteList
        public static TransactionDetails SaveCropAdvisoryFavouriteList(CropAdvisoryFavourites objFavourites)
        {
            TransactionDetails response = new TransactionDetails();
            byte[] bytes = new byte[0];
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pCAFLID",objFavourites.CAFLID),
                   new SqlParameter("@pCropAdvisoryID",objFavourites.CropAdvisoryID),
                   new SqlParameter("@pUserProfileID",objFavourites.UserProfileID),
                   new SqlParameter("@pcreatedby",objFavourites.Createdby),
                   new SqlParameter("@pupdatedby",objFavourites.Updatedby),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisoryFavouriteList", arrParams);
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        #endregion

        #region Save CropAdvisory FeedbackList
        public static TransactionDetails SaveCropAdvisoryFeedbackList(CropAdvisoryFeedback objFeedback)
        {
            TransactionDetails response = new TransactionDetails();
            if(objFeedback !=null)
            {
                if(objFeedback.Rating > 3)
                {
                    objFeedback.isFeedback = false;
                    objFeedback.Comments = "";
                }
                else
                {
                    objFeedback.isFeedback = true;
                }
            }
            byte[] bytes = new byte[0];
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pFeedbackID",objFeedback.FeedbackID),
                   new SqlParameter("@pCropAdvisoryID",objFeedback.CropAdvisoryID),
                   new SqlParameter("@pUserProfileID",objFeedback.UserProfileID),
                   new SqlParameter("@pRating",objFeedback.Rating),
                   new SqlParameter("@pisFeedback",objFeedback.isFeedback),
                   new SqlParameter("@pQ1",objFeedback.Q1),
                   new SqlParameter("@pQ2",objFeedback.Q2),
                   new SqlParameter("@pQ3",objFeedback.Comments),
                   new SqlParameter("@pcreatedby",objFeedback.Createdby),
                   new SqlParameter("@pupdatedby",objFeedback.Updatedby),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropAdvisoryFeedbackList", arrParams);
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        #endregion

        #region Save Language List
        public static TransactionDetails SaveLanguageList(Languages objLanguage)
        {
            TransactionDetails response = new TransactionDetails();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pALID",objLanguage.ID),
                   new SqlParameter("@pTelugu",objLanguage.Telugu),
                   new SqlParameter("@pTamil",objLanguage.Tamil),
                   new SqlParameter("@pMalayalam",objLanguage.Malayalam),
                   new SqlParameter("@pUrdu",objLanguage.Urdu),
                   new SqlParameter("@pHindi",objLanguage.Hindi),
                   new SqlParameter("@pGujarati",objLanguage.Gujarati),
                   new SqlParameter("@pMarathi",objLanguage.Marati),
                   new SqlParameter("@pKonkani",objLanguage.Konkani),
                   new SqlParameter("@pPunjabi",objLanguage.Punjabi),
                   new SqlParameter("@pBengali",objLanguage.Bengali),
                   new SqlParameter("@pAssamese",objLanguage.Assamese),
                   new SqlParameter("@pKashmiri",objLanguage.Kashmiri),
                   new SqlParameter("@pKannada",objLanguage.Kannada),
                   new SqlParameter("@pManipuri",objLanguage.Manipuri),
                   new SqlParameter("@pSindhi",objLanguage.Sindhi),
                   new SqlParameter("@pOriya",objLanguage.Oriya),
                   new SqlParameter("@pMaithili",objLanguage.Maithili),
                   new SqlParameter("@pBhili",objLanguage.Bhili),
                   new SqlParameter("@pSantali",objLanguage.Santali),
                   new SqlParameter("@pNepali",objLanguage.Nepali),
                   new SqlParameter("@pGondi",objLanguage.Gondi),
                   new SqlParameter("@pDogri",objLanguage.Dogri),
                   new SqlParameter("@pKhandeshi",objLanguage.Khandeshi),
                   new SqlParameter("@pKurukh",objLanguage.Kurukh),
                   new SqlParameter("@pTulu",objLanguage.Tulu),
                   new SqlParameter("@pBodo",objLanguage.Bodo),
                   new SqlParameter("@pKhasi",objLanguage.Khasi),
                   new SqlParameter("@pMundari",objLanguage.Mundari),
                   new SqlParameter("@pHo",objLanguage.Ho),
                   new SqlParameter("@pcreatedby",objLanguage.Createdby),
                   new SqlParameter("@pupdatedby",objLanguage.Updatedby),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_AgrometLanguages", arrParams);
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        #endregion

        #endregion

        #region Get Crop Advisory

        #region Get cropadvisory category List   CAMlist
        public static CropAdvisoryResponse GetCropAdvisoryCategory(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pScientistID", objCropAdvisory.ScientistID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryDetailsMasterList", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CAMID = (dr["CAMID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CAMID"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                       
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

        #region search cropadvisory category List   CAMlist
        public static CropAdvisoryResponse SearchCamList(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            objCropAdvisory.CategoryID = 0;
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objCropAdvisory.Id),
                new SqlParameter("@pCategoryID", objCropAdvisory.CategoryID),
                new SqlParameter("@pDistrictid", objCropAdvisory.DistrictID),
                new SqlParameter("@pcropid", objCropAdvisory.CropID),
                new SqlParameter("@pBlockid", objCropAdvisory.BlockID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spSearch_CropAdvisoryDetails", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CAMID = (dr["CAMID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CAMID"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),

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

        #region Get cropadvisory category List   cropadv of CAM list
        public static CropAdvisoryResponse GetCropAdvisoryofCropAdvisoryCategory(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCAMID", objCropAdvisory.CAMID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryDetailsofCAM", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        Recommendations = (dr["Recommendations"]) == DBNull.Value ? "" : Convert.ToString(dr["Recommendations"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        District = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                        CropName = (dr["CropName"]) == DBNull.Value ? "" : Convert.ToString(dr["CropName"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString(),
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

        #region Get cropadvisory List
        public static CropAdvisoryResponse GetCropAdvisory(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objCropAdvisory.Id),
                new SqlParameter("@pCropid", objCropAdvisory.CropID.ToString()),
                new SqlParameter("@pType", objCropAdvisory.Type),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryDetails", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        Recommendations = (dr["Recommendations"]) == DBNull.Value ? "" : Convert.ToString(dr["Recommendations"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        District = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                        Block = (dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString(),
                    }).ToList();
                    response.IsSuccessful = true;
                    //if (response.ObjCropAdvisoryDetailsList.Count > 0)
                    //{
                    //    foreach (var item in response.ObjCropAdvisoryDetailsList)
                    //    {
                    //        CropAdvisoryDetails objdetails = new CropAdvisoryDetails();
                    //        CropAdvisoryResponse responsecrop = new CropAdvisoryResponse();
                    //        objdetails.CropAdvisoryID = item.CropAdvisoryID;
                    //        objdetails.LanguageType = objCropAdvisory.LanguageType;
                    //        objdetails.RefreshDateTime = objCropAdvisory.RefreshDateTime;
                    //        responsecrop = GetCropAdvyCropMapping(objdetails);

                    //        if (responsecrop.ObjCropAdvisoryCropMappList.Count > 0)
                    //        {
                    //            response.ObjCropAdvisoryCropMappList.AddRange(responsecrop.ObjCropAdvisoryCropMappList);
                    //        }
                    //    }
                    //    if(objCropAdvisory.Type == "Farmer")
                    //    {
                    //        for (int i = 0; i < response.ObjCropAdvisoryDetailsList.Count; i++)
                    //        {
                    //            if (response.ObjCropAdvisoryDetailsList[i].Block != null || response.ObjCropAdvisoryDetailsList[i].Block != "")
                    //            {
                    //                response.ObjCropAdvisoryDetailsList[i].Location = response.ObjCropAdvisoryDetailsList[i].Block;
                    //            }
                    //            else if (response.ObjCropAdvisoryDetailsList[i].District != null || response.ObjCropAdvisoryDetailsList[i].District != "")
                    //            {
                    //                response.ObjCropAdvisoryDetailsList[i].Location = response.ObjCropAdvisoryDetailsList[i].District;
                    //            }
                    //            else
                    //            {
                    //                response.ObjCropAdvisoryDetailsList[i].Location = response.ObjCropAdvisoryDetailsList[i].State;
                    //            }
                    //        }
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Get GetCropAdvisoryFavouriteRating List
        public static CropAdvisoryResponse GetCropAdvisoryFavouriteRatingList(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            DataTable dtone = new DataTable();
            DataTable dttwo = new DataTable();
            DataSet ds = new DataSet();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            CropAdvisoryResponse responseone = new CropAdvisoryResponse();
            CropAdvisoryDetails objCropAdvisoryone = new CropAdvisoryDetails();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objCropAdvisory.Id),
                new SqlParameter("@pCropid", objCropAdvisory.CropID.ToString()),
                new SqlParameter("@pType", objCropAdvisory.Type),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                ds = SQLHelper.ExecuteMulti("spGet_CropAdvisoryDetails", arrParams);
                dt = ds.Tables[0];
                dtone = ds.Tables[1];
                

                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        CategoryID = (dr["CategoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CategoryID"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        VarietyId = (dr["VarietyId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["VarietyId"]),
                        VarietyName = (dr["VarietyName"] == DBNull.Value ? "" : Convert.ToString(dr["VarietyName"])),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        BriefTextRegional = (dr["BriefTextRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefTextRegional"]),
                        Recommendations = (dr["Recommendations"]) == DBNull.Value ? "" : Convert.ToString(dr["Recommendations"]),
                        RecommendationsRegional = (dr["RecommendationsRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["RecommendationsRegional"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        District = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                        Block = (dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"]),
                        AsdName = (dr["AsdName"]) == DBNull.Value ? "" : Convert.ToString(dr["AsdName"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        CategoryIcon = (dr["Icon"]) == DBNull.Value ? "" : Convert.ToString(dr["Icon"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString(),
                        //ImageBytes = (dr["ThumbnailBytes"]) == DBNull.Value ? null : ((byte[])(dr["ThumbnailBytes"])),
                        CropImageURL = (dr["CropImageURL"] == DBNull.Value ? "" : Convert.ToString(dr["CropImageURL"])),
                        PeriodStartDate = (dr["PeriodStartDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodStartDate"]).ToString("dd-MM-yyyy"),
                        PeriodEndDate = (dr["PeriodEndDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodEndDate"]).ToString("dd-MM-yyyy"),
                        WeatherCondition = (dr["WeatherCondition"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherCondition"]).ToString(),
                        WeatherConditionRegional = (dr["WeatherConditionRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherConditionRegional"]).ToString(),
                        AgroAdvisoryDetails = (dr["AgroAdvisoryDetails"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetails"]).ToString(),
                        AgroAdvisoryDetailsRegional = (dr["AgroAdvisoryDetailsRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetailsRegional"]).ToString(),
                        RegionalLanguage = (dr["RegionalLanguage"]) == DBNull.Value ? "" : Convert.ToString(dr["RegionalLanguage"]).ToString(),
                        StateID = (dr["Stateid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Stateid"]),
                        DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                        BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                        AsdID = (dr["AsdID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["AsdID"]),
                        YouTubeLink = (dr["youtubelink"]) == DBNull.Value ? "" : Convert.ToString(dr["youtubelink"]),
                        CropID = (dr["CropID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropID"]),
                    }).ToList();
                    response.IsSuccessful = true;
                }
                if (dtone.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryFavouritesList =
                   (from DataRow dr in dtone.Rows
                    select new CropAdvisoryFavourites
                    {
                        UserProfileID = (dr["UserProfileID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["UserProfileID"]),
                        CropAdvisoryID = (dr["cropadvisoryid"] == DBNull.Value ? 0 : Convert.ToInt32(dr["cropadvisoryid"])),
                        CAFLID = (dr["CAFLID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CAFLID"]))
                    }).ToList();
                    response.IsSuccessful = true;
                }
               
                if (response.ObjCropAdvisoryDetailsList.Count > 0 )
                {
                    for (int j = 0; j < response.ObjCropAdvisoryDetailsList.Count; j++)
                    {
                        
                        if (response.ObjCropAdvisoryDetailsList[j].Block != null && response.ObjCropAdvisoryDetailsList[j].Block != "")
                        {
                            response.ObjCropAdvisoryDetailsList[j].Location = response.ObjCropAdvisoryDetailsList[j].Block;
                        }
                        else if (response.ObjCropAdvisoryDetailsList[j].District != null && response.ObjCropAdvisoryDetailsList[j].District != "")
                        {
                            response.ObjCropAdvisoryDetailsList[j].Location = response.ObjCropAdvisoryDetailsList[j].District;
                        }
                        else
                        {
                            response.ObjCropAdvisoryDetailsList[j].Location = response.ObjCropAdvisoryDetailsList[j].State;
                        }
                        objCropAdvisoryone.Id = objCropAdvisory.Id;
                        objCropAdvisoryone.CropAdvisoryID = response.ObjCropAdvisoryDetailsList[j].CropAdvisoryID;
                        objCropAdvisoryone.LanguageType = objCropAdvisory.LanguageType;
                        objCropAdvisoryone.RefreshDateTime = objCropAdvisory.RefreshDateTime;
                        responseone = GetAvgRating(objCropAdvisoryone);
                        if(responseone.IsSuccessful && responseone.ObjCropAdvisoryDetailsList.Count >0)
                        {
                            response.ObjCropAdvisoryDetailsList[j].AvgFeedback = responseone.ObjCropAdvisoryDetailsList[0].AvgFeedback;
                            response.ObjCropAdvisoryDetailsList[j].FeedbackID = responseone.ObjCropAdvisoryDetailsList[0].FeedbackID;
                            //response.ObjCropAdvisoryDetailsList[j].Q1 = responseone.ObjCropAdvisoryDetailsList[0].Q1;
                            //response.ObjCropAdvisoryDetailsList[j].Q2 = responseone.ObjCropAdvisoryDetailsList[0].Q2;
                           // response.ObjCropAdvisoryDetailsList[j].Comments = responseone.ObjCropAdvisoryDetailsList[0].Comments;
                        }
                    }
                }
                if (response.ObjCropAdvisoryDetailsList.Count > 0 && response.ObjCropAdvisoryFavouritesList.Count > 0)
                {
                    for (int j = 0; j < response.ObjCropAdvisoryDetailsList.Count; j++)
                    {
                        for (int i = 0; i < response.ObjCropAdvisoryFavouritesList.Count; i++)
                        {
                            if (response.ObjCropAdvisoryDetailsList[j].CropAdvisoryID == response.ObjCropAdvisoryFavouritesList[i].CropAdvisoryID)
                            {
                                response.ObjCropAdvisoryDetailsList[j].FavouriteID = response.ObjCropAdvisoryFavouritesList[i].CAFLID;
                            }
                        }
                    }
                }
                if(response.ObjCropAdvisoryFeedbackList.Count() == 0)
                    response.ObjCropAdvisoryFeedbackList = new List<CropAdvisoryFeedback>();
                if (response.ObjCropAdvisoryFavouritesList.Count() == 0)
                    response.ObjCropAdvisoryFavouritesList = new List<CropAdvisoryFavourites>();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Get cropadvisory TopValues
        public static CropAdvisoryResponse GetCropAdvisoryTopValues(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();

            DataTable dtone = new DataTable();
            DataSet ds = new DataSet();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            CropAdvisoryResponse responseone = new CropAdvisoryResponse();
            CropAdvisoryDetails objCropAdvisoryone = new CropAdvisoryDetails();
            // send notofication for update app to old users for azure build
            //try
            //{
            //    //if(DateTime.UtcNow <= Convert.ToDateTime("2020-10-10"))
            //    //{
            //        // save notofication for handling send one time in a day 
            //        var title = "Update Meghdoot app";
            //        var body = "Please update app before oct 10th after that app services will stop working, If you updated the app then ignore this message";
            //        var todayDate = DateTime.UtcNow.ToString("yyyy-MM-dd");
            //        var startTime = DateTime.ParseExact("00:01", "HH:mm", CultureInfo.InvariantCulture).TimeOfDay.ToString();
            //        var endTime = DateTime.ParseExact("23:59", "HH:mm", CultureInfo.InvariantCulture).TimeOfDay.ToString();

            //        SqlParameter[] savenotification = new SqlParameter[]
            //                            {
            //                        new SqlParameter("@pNotificationTitle",body),
            //                        new SqlParameter("@pTimeOfIssueMsg","Time of issue : "),
            //                        new SqlParameter("@pValidUpToMsg","Valid up to : "),
            //                        new SqlParameter("@pTimeOfIssue",startTime),
            //                        new SqlParameter("@pIssueDateMsg","Issue date : "),
            //                        new SqlParameter("@pValidUpTo",endTime),
            //                        new SqlParameter("@pIssuedate",todayDate),
            //                        new SqlParameter("@pUserProfileId",objCropAdvisory.Id),
            //                        new SqlParameter("@pColorCode", 1),
            //                        new SqlParameter("@pCategoryId","0")
            //                            };
            //        var transactionResponse = SQLHelper.ExecuteOutIDParameter("spSave_NowCastNotificationDetails", savenotification);
            //        if (transactionResponse.IsSuccessful)
            //        {
            //            var param = new SqlParameter[] { new SqlParameter("@pUserProfileId", objCropAdvisory.Id) };
            //            var tokens = SQLHelper.Execute("spGet_TokenByUserId", param).AsEnumerable()
            //                .Select(r => r.Field<string>("Token")).ToList();
            //            if (tokens.Any())
            //                Notifications.NowCastNotification(title, body, 1, tokens);
            //        }

            //    //}
            //}
            //catch
            //{
            //    response.ErrorMessage = "something wrong in notification";
            //}
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objCropAdvisory.Id),
                new SqlParameter("@pType", objCropAdvisory.Type),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                ds = SQLHelper.ExecuteMulti("spGet_CropAdvisoryDetailsByTopValues", arrParams);
                dt = ds.Tables[0];
                dtone = ds.Tables[1];
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        CategoryID = (dr["CategoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CategoryID"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        VarietyId = (dr["VarietyId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["VarietyId"]),
                        VarietyName = (dr["VarietyName"] == DBNull.Value ? "" : Convert.ToString(dr["VarietyName"])),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        BriefTextRegional = (dr["BriefTextRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefTextRegional"]),
                        Recommendations = (dr["Recommendations"]) == DBNull.Value ? "" : Convert.ToString(dr["Recommendations"]),
                        RecommendationsRegional = (dr["RecommendationsRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["RecommendationsRegional"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        District = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                        Block = (dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"]),
                        AsdName = (dr["AsdName"]) == DBNull.Value ? "" : Convert.ToString(dr["AsdName"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        CategoryIcon = (dr["Icon"]) == DBNull.Value ? "" : Convert.ToString(dr["Icon"]),
                        Rating = (dr["Rating"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Rating"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString(),
                        //ImageBytes = (dr["ThumbnailBytes"]) == DBNull.Value ? null : ((byte[])(dr["ThumbnailBytes"])),
                        CropImageURL = (dr["CropImageURL"] == DBNull.Value ? "" : Convert.ToString(dr["CropImageURL"])),
                        PeriodStartDate = (dr["PeriodStartDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodStartDate"]).ToString("dd-MM-yyyy"),
                        PeriodEndDate = (dr["PeriodEndDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodEndDate"]).ToString("dd-MM-yyyy"),
                        WeatherCondition = (dr["WeatherCondition"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherCondition"]).ToString(),
                        WeatherConditionRegional = (dr["WeatherConditionRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherConditionRegional"]).ToString(),
                        AgroAdvisoryDetails = (dr["AgroAdvisoryDetails"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetails"]).ToString(),
                        AgroAdvisoryDetailsRegional = (dr["AgroAdvisoryDetailsRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetailsRegional"]).ToString(),
                        RegionalLanguage = (dr["RegionalLanguage"]) == DBNull.Value ? "" : Convert.ToString(dr["RegionalLanguage"]).ToString(),
                        StateID = (dr["Stateid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Stateid"]),
                        DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                        BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                        AsdID = (dr["AsdID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["AsdID"]),
                        YouTubeLink = (dr["youtubelink"]) == DBNull.Value ? "" : Convert.ToString(dr["youtubelink"]),
                        CropID = (dr["CropID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropID"]),
                    }).ToList();
                    if (dtone.Rows.Count > 0)
                    {
                        response.ObjCropAdvisoryFavouritesList =
                       (from DataRow dr in dtone.Rows
                        select new CropAdvisoryFavourites
                        {
                            UserProfileID = (dr["UserProfileID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["UserProfileID"]),
                            CropAdvisoryID = (dr["cropadvisoryid"] == DBNull.Value ? 0 : Convert.ToInt32(dr["cropadvisoryid"])),
                            CAFLID = (dr["CAFLID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CAFLID"]))
                        }).ToList();
                        response.IsSuccessful = true;
                    }

                    if (!string.IsNullOrEmpty(objCropAdvisory.Longitude) && !String.IsNullOrEmpty(objCropAdvisory.Latitude))
                    {
                        var currentLocationDetails = GetCurrentLocationDetails(objCropAdvisory.Latitude, objCropAdvisory.Longitude);
                        if (currentLocationDetails.StateId != 0 && currentLocationDetails.StateId != 0)
                        {
                            CropAdvisoryDetails details = new CropAdvisoryDetails()
                            {
                                StateID = currentLocationDetails.StateId,
                                DistrictID = currentLocationDetails.DistrictId,
                                BlockID = currentLocationDetails.BlockId,
                                LanguageType = objCropAdvisory.LanguageType
                            };

                            var currentlocationCropAdvisoryDetails = GetGPSCropAdvisoryTopValues(details);
                            if (currentlocationCropAdvisoryDetails.ObjCropAdvisoryDetailsList != null && currentlocationCropAdvisoryDetails.ObjCropAdvisoryDetailsList.Count() > 0)
                            {
                                currentlocationCropAdvisoryDetails.ObjCropAdvisoryDetailsList.ForEach(s => { s.IsCurrentLocation = true; });
                                response.ObjCropAdvisoryDetailsList.AddRange(currentlocationCropAdvisoryDetails.ObjCropAdvisoryDetailsList);
                            }
                            if (currentlocationCropAdvisoryDetails.ObjCropAdvisoryFavouritesList != null && currentlocationCropAdvisoryDetails.ObjCropAdvisoryFavouritesList.Count() > 0)
                            {
                                response.ObjCropAdvisoryFavouritesList.AddRange(currentlocationCropAdvisoryDetails.ObjCropAdvisoryFavouritesList);
                            }
                        }
                    }

                    response.IsSuccessful = true;
                    if(response.ObjCropAdvisoryDetailsList.Count > 0)
                    {
                        for (int i = 0; i < response.ObjCropAdvisoryDetailsList.Count; i++)
                        {
                            //var yesterday = DateTime.Today.AddDays(-1);

                            //if (response.ObjCropAdvisoryDetailsList[i].CreatedDate == DateTime.Today.ToString("dd-MM-yyyy"))
                            //{
                            //    response.ObjCropAdvisoryDetailsList[i].CreatedDate = "Today";
                            //}
                            //else if (response.ObjCropAdvisoryDetailsList[i].CreatedDate == yesterday.ToString("dd-MM-yyyy"))
                            //{
                            //    response.ObjCropAdvisoryDetailsList[i].CreatedDate = "Yesterday";
                            //}
                            if (response.ObjCropAdvisoryDetailsList[i].Block != null && response.ObjCropAdvisoryDetailsList[i].Block != "")
                            {
                                response.ObjCropAdvisoryDetailsList[i].Location = response.ObjCropAdvisoryDetailsList[i].Block;
                            }
                            else if (response.ObjCropAdvisoryDetailsList[i].District != null && response.ObjCropAdvisoryDetailsList[i].District != "")
                            {
                                response.ObjCropAdvisoryDetailsList[i].Location = response.ObjCropAdvisoryDetailsList[i].District;
                            }
                            else
                            {
                                response.ObjCropAdvisoryDetailsList[i].Location = response.ObjCropAdvisoryDetailsList[i].State;
                            }
                            objCropAdvisoryone.Id = objCropAdvisory.Id;
                            objCropAdvisoryone.CropAdvisoryID = response.ObjCropAdvisoryDetailsList[i].CropAdvisoryID;
                            objCropAdvisoryone.LanguageType = objCropAdvisory.LanguageType;
                            objCropAdvisoryone.RefreshDateTime = objCropAdvisory.RefreshDateTime;
                            responseone = GetAvgRating(objCropAdvisoryone);
                            if (responseone.IsSuccessful && responseone.ObjCropAdvisoryDetailsList.Count > 0)
                            {
                                response.ObjCropAdvisoryDetailsList[i].AvgFeedback = responseone.ObjCropAdvisoryDetailsList[0].AvgFeedback;
                                response.ObjCropAdvisoryDetailsList[i].FeedbackID = responseone.ObjCropAdvisoryDetailsList[0].FeedbackID;
                                //response.ObjCropAdvisoryDetailsList[i].Q1 = responseone.ObjCropAdvisoryDetailsList[0].Q1;
                                //response.ObjCropAdvisoryDetailsList[i].Q2 = responseone.ObjCropAdvisoryDetailsList[0].Q2;
                                //response.ObjCropAdvisoryDetailsList[i].Comments = responseone.ObjCropAdvisoryDetailsList[0].Comments;
                            }
                        }
                    }
                    if (response.ObjCropAdvisoryDetailsList.Count > 0 && response.ObjCropAdvisoryFavouritesList.Count > 0)
                    {
                        for (int j = 0; j < response.ObjCropAdvisoryDetailsList.Count; j++)
                        {
                            for (int i = 0; i < response.ObjCropAdvisoryFavouritesList.Count; i++)
                            {
                                if (response.ObjCropAdvisoryDetailsList[j].CropAdvisoryID == response.ObjCropAdvisoryFavouritesList[i].CropAdvisoryID)
                                {
                                    response.ObjCropAdvisoryDetailsList[j].FavouriteID = response.ObjCropAdvisoryFavouritesList[i].CAFLID;
                                }
                            }
                        }
                    }
                }
                response.ObjCropAdvisoryDetailsList = response.ObjCropAdvisoryDetailsList.OrderByDescending(c => c.IsCurrentLocation).ToList();
                //response.ObjCropAdvisoryFavouritesList = new List<CropAdvisoryFavourites>();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Get cropadvisory TopValues
        public static CropAdvisoryResponse GetGPSCropAdvisoryTopValues(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();

            DataTable dtone = new DataTable();
            DataSet ds = new DataSet();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            CropAdvisoryResponse responseone = new CropAdvisoryResponse();
            CropAdvisoryDetails objCropAdvisoryone = new CropAdvisoryDetails();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pStateName", objCropAdvisory.State),
                    new SqlParameter("@pDistrictName", objCropAdvisory.District),
                    new SqlParameter("@pStateID", objCropAdvisory.StateID),
                    new SqlParameter("@pDistrictID", objCropAdvisory.DistrictID),
                    new SqlParameter("@pBlockID", objCropAdvisory.BlockID),
                    new SqlParameter("@pAsdID", objCropAdvisory.AsdID),
                    new SqlParameter("@planguagetype", objCropAdvisory.LanguageType)

                   
                };
                dt = SQLHelper.Execute("spGet_GPS_CropAdvisoryDetailsByTopValues", arrParams);
               
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        VarietyId = (dr["VarietyId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["VarietyId"]),
                        VarietyName = (dr["VarietyName"] == DBNull.Value ? "" : Convert.ToString(dr["VarietyName"])),
                        CropImageURL = (dr["CropImageURL"] == DBNull.Value ? "" : Convert.ToString(dr["CropImageURL"])),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        Recommendations = (dr["Recommendations"]) == DBNull.Value ? "" : Convert.ToString(dr["Recommendations"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        District = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                        Block = (dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"]),
                        AsdName = (dr["AsdName"]) == DBNull.Value ? "" : Convert.ToString(dr["AsdName"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        Rating = (dr["Rating"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Rating"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString(),
                        ImageBytes = (dr["ThumbnailBytes"]) == DBNull.Value ? null : ((byte[])(dr["ThumbnailBytes"])),
                        PeriodStartDate = (dr["PeriodStartDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodStartDate"]).ToString("dd-MM-yyyy"),
                        PeriodEndDate = (dr["PeriodEndDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodEndDate"]).ToString("dd-MM-yyyy"),
                        WeatherCondition = (dr["WeatherCondition"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherCondition"]).ToString(),
                        AgroAdvisoryDetails = (dr["AgroAdvisoryDetails"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetails"]).ToString(),
                        WeatherConditionRegional = (dr["WeatherConditionRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherConditionRegional"]).ToString(),
                        AgroAdvisoryDetailsRegional = (dr["AgroAdvisoryDetailsRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetailsRegional"]).ToString(),
                        RegionalLanguage = (dr["RegionalLanguage"]) == DBNull.Value ? "" : Convert.ToString(dr["RegionalLanguage"]).ToString(),
                        BriefTextRegional = (dr["BriefTextRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefTextRegional"]).ToString(),
                        RecommendationsRegional = (dr["RecommendationsRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["RecommendationsRegional"]).ToString(),
                        StateID = (dr["Stateid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Stateid"]),
                        DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                        BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                        AsdID = (dr["AsdID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["AsdID"]),
                        YouTubeLink = (dr["youtubelink"]) == DBNull.Value ? "" : Convert.ToString(dr["youtubelink"]),
                    }).ToList();
                    
                    response.IsSuccessful = true;
                    if (response.ObjCropAdvisoryDetailsList.Count > 0)
                    {
                        for (int i = 0; i < response.ObjCropAdvisoryDetailsList.Count; i++)
                        {
                            //var yesterday = DateTime.Today.AddDays(-1);

                            //if (response.ObjCropAdvisoryDetailsList[i].CreatedDate == DateTime.Today.ToString("dd-MM-yyyy"))
                            //{
                            //    response.ObjCropAdvisoryDetailsList[i].CreatedDate = "Today";
                            //}
                            //else if (response.ObjCropAdvisoryDetailsList[i].CreatedDate == yesterday.ToString("dd-MM-yyyy"))
                            //{
                            //    response.ObjCropAdvisoryDetailsList[i].CreatedDate = "Yesterday";
                            //}
                            if (response.ObjCropAdvisoryDetailsList[i].Block != null && response.ObjCropAdvisoryDetailsList[i].Block != "")
                            {
                                response.ObjCropAdvisoryDetailsList[i].Location = response.ObjCropAdvisoryDetailsList[i].Block;
                            }
                            else if (response.ObjCropAdvisoryDetailsList[i].District != null && response.ObjCropAdvisoryDetailsList[i].District != "")
                            {
                                response.ObjCropAdvisoryDetailsList[i].Location = response.ObjCropAdvisoryDetailsList[i].District;
                            }
                            else
                            {
                                response.ObjCropAdvisoryDetailsList[i].Location = response.ObjCropAdvisoryDetailsList[i].State;
                            }
                            objCropAdvisoryone.Id = objCropAdvisory.Id;
                            objCropAdvisoryone.CropAdvisoryID = response.ObjCropAdvisoryDetailsList[i].CropAdvisoryID;
                            objCropAdvisoryone.LanguageType = objCropAdvisory.LanguageType;
                            objCropAdvisoryone.RefreshDateTime = objCropAdvisory.RefreshDateTime;
                            responseone = GetAvgRating(objCropAdvisoryone);
                            if (responseone.IsSuccessful && responseone.ObjCropAdvisoryDetailsList.Count > 0)
                            {
                                response.ObjCropAdvisoryDetailsList[i].AvgFeedback = responseone.ObjCropAdvisoryDetailsList[0].AvgFeedback;
                                response.ObjCropAdvisoryDetailsList[i].FeedbackID = responseone.ObjCropAdvisoryDetailsList[0].FeedbackID;
                                //response.ObjCropAdvisoryDetailsList[i].Q1 = responseone.ObjCropAdvisoryDetailsList[0].Q1;
                                //response.ObjCropAdvisoryDetailsList[i].Q2 = responseone.ObjCropAdvisoryDetailsList[0].Q2;
                                //response.ObjCropAdvisoryDetailsList[i].Comments = responseone.ObjCropAdvisoryDetailsList[0].Comments;
                            }
                        }
                    }
                    
                }

                response.ObjCropAdvisoryFavouritesList = new List<CropAdvisoryFavourites>();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Get cropadvisory Favourite List
        public static CropAdvisoryResponse GetCropAdvisoryFavouriteList(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            CropAdvisoryResponse responseone = new CropAdvisoryResponse();
            CropAdvisoryDetails objCropAdvisoryone = new CropAdvisoryDetails();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objCropAdvisory.Id),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryFavouriteListDetails", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryFavList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        StateID = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                        DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                        BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        Title = (dr["CropName"] == DBNull.Value ? "" : Convert.ToString(dr["CropName"])),
                        VarietyId = (dr["VarietyId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["VarietyId"]),
                        VarietyName = (dr["VarietyName"] == DBNull.Value ? "" : Convert.ToString(dr["VarietyName"])),
                        CropImageURL = (dr["CropImageURL"] == DBNull.Value ? "" : Convert.ToString(dr["CropImageURL"])),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        Recommendations = (dr["Recommendations"]) == DBNull.Value ? "" : Convert.ToString(dr["Recommendations"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        District = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                        Rating = (dr["Rating"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Rating"])),  
                        Block = (dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString(),
                        PeriodStartDate = (dr["PeriodStartDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodStartDate"]).ToString("dd-MM-yyyy"),
                        PeriodEndDate = (dr["PeriodEndDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodEndDate"]).ToString("dd-MM-yyyy"),
                        WeatherCondition = (dr["WeatherCondition"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherCondition"]).ToString(),
                        AgroAdvisoryDetails = (dr["AgroAdvisoryDetails"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetails"]).ToString(),
                        YouTubeLink = (dr["youtubelink"]) == DBNull.Value ? "" : Convert.ToString(dr["youtubelink"]),
                        WeatherConditionRegional = (dr["WeatherConditionRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherConditionRegional"]).ToString(),
                        AgroAdvisoryDetailsRegional = (dr["AgroAdvisoryDetailsRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetailsRegional"]).ToString(),
                        RegionalLanguage = (dr["RegionalLanguage"]) == DBNull.Value ? "" : Convert.ToString(dr["RegionalLanguage"]).ToString(),
                        BriefTextRegional = (dr["BriefTextRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefTextRegional"]).ToString(),
                        RecommendationsRegional = (dr["RecommendationsRegional"]) == DBNull.Value ? "" : Convert.ToString(dr["RecommendationsRegional"]).ToString(),
                    }).ToList();
                    response.IsSuccessful = true;
                }
                if (response.ObjCropAdvisoryFavList.Count > 0 )
                {
                    for (int j = 0; j < response.ObjCropAdvisoryFavList.Count; j++)
                    {
                        if (response.ObjCropAdvisoryFavList[j].Block != null && response.ObjCropAdvisoryFavList[j].Block != "")
                        {
                            response.ObjCropAdvisoryFavList[j].Location = response.ObjCropAdvisoryFavList[j].Block;
                        }
                        else if (response.ObjCropAdvisoryFavList[j].District != null && response.ObjCropAdvisoryFavList[j].District != "")
                        {
                            response.ObjCropAdvisoryFavList[j].Location = response.ObjCropAdvisoryFavList[j].District;
                        }
                        else
                        {
                            response.ObjCropAdvisoryFavList[j].Location = response.ObjCropAdvisoryFavList[j].State;
                        }
                        objCropAdvisoryone.Id = objCropAdvisory.Id;
                        objCropAdvisoryone.CropAdvisoryID = response.ObjCropAdvisoryFavList[j].CropAdvisoryID;
                        objCropAdvisoryone.LanguageType = objCropAdvisory.LanguageType;
                        objCropAdvisoryone.RefreshDateTime = objCropAdvisory.RefreshDateTime;
                        responseone = GetAvgRating(objCropAdvisoryone);
                        if(responseone != null)
                        {
                            if (responseone.IsSuccessful && responseone.ObjCropAdvisoryDetailsList.Count > 0 && responseone.ObjCropAdvisoryDetailsList != null)
                            {
                                response.ObjCropAdvisoryFavList[j].AvgFeedback = responseone.ObjCropAdvisoryDetailsList[0].AvgFeedback;
                                response.ObjCropAdvisoryFavList[j].FeedbackID = responseone.ObjCropAdvisoryDetailsList[0].FeedbackID;
                                response.ObjCropAdvisoryFavList[j].Rating = responseone.ObjCropAdvisoryDetailsList[0].FeedbackID;

                                //response.ObjCropAdvisoryDetailsList[j].Q1 = responseone.ObjCropAdvisoryDetailsList[0].Q1;
                                //response.ObjCropAdvisoryDetailsList[j].Q2 = responseone.ObjCropAdvisoryDetailsList[0].Q2;
                                //response.ObjCropAdvisoryDetailsList[j].Comments = responseone.ObjCropAdvisoryDetailsList[0].Comments;
                            }
                            else
                            {
                                response.ObjCropAdvisoryFavList[j].AvgFeedback = 0;
                                response.ObjCropAdvisoryFavList[j].FeedbackID = 0;
                            }
                        }
                       
                    }
                }
                    response.ObjCropAdvisoryFeedbackList = new List<CropAdvisoryFeedback>();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Get Crop Advisory Avg Rating
        public static CropAdvisoryResponse GetAvgRating(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@puserprofileID", objCropAdvisory.Id),
                new SqlParameter("@pCropAdvisoryID", objCropAdvisory.CropAdvisoryID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryFeedbackListDetails", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        FeedbackID = (dr["FeedbackID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["FeedbackID"]),
                        AvgFeedback = Convert.ToInt32(Math.Floor((dr["AvgFeedback"] == DBNull.Value ? 0 : Convert.ToDouble(dr["AvgFeedback"])))),
                        Rating = (dr["Rating"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["Rating"])
                        // Q1 = (dr["Q1"] == DBNull.Value ? false : Convert.ToBoolean(dr["Q1"])),
                        // Q2 = (dr["Q2"] == DBNull.Value ? false : Convert.ToBoolean(dr["Q2"])),
                        //Comments = (dr["Q3"] == DBNull.Value ? "" : Convert.ToString(dr["Q3"])),
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

        #region Search cropadvisory List
        public static CropAdvisoryResponse SearchCropAdvisory(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objCropAdvisory.Id),
                new SqlParameter("@pCategoryID", objCropAdvisory.CategoryID),
                new SqlParameter("@pDistrictid", objCropAdvisory.DistrictID),
                new SqlParameter("@pcropid", objCropAdvisory.CropID),
                new SqlParameter("@pBlockid", objCropAdvisory.BlockID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spSearch_CropAdvisoryDetails", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        Recommendations = (dr["Recommendations"]) == DBNull.Value ? "" : Convert.ToString(dr["Recommendations"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString("dd-MM-yyyy"),
                    }).ToList();
                    response.IsSuccessful = true;
                    if (response.ObjCropAdvisoryDetailsList.Count > 0)
                    {
                        foreach (var item in response.ObjCropAdvisoryDetailsList)
                        {
                            CropAdvisoryDetails objdetails = new CropAdvisoryDetails();
                            CropAdvisoryResponse responsecrop = new CropAdvisoryResponse();
                            objdetails.CropAdvisoryID = item.CropAdvisoryID;
                            objdetails.LanguageType = objCropAdvisory.LanguageType;
                            objdetails.RefreshDateTime = objCropAdvisory.RefreshDateTime;
                            responsecrop = GetCropAdvyCropMapping(objdetails);

                            if (responsecrop.ObjCropAdvisoryCropMappList.Count > 0)
                            {
                                response.ObjCropAdvisoryCropMappList.AddRange(responsecrop.ObjCropAdvisoryCropMappList);
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

        #region GetCropAdvisoryCategoryByID
        public static CropAdvisoryResponse GetCropAdvisoryCategoryByID(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCAMID", objCropAdvisory.CAMID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryDetailsMaster", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CAMID = (dr["CAMID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CAMID"]),
                        ScientistID = (dr["ScientistID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["ScientistID"]),
                        StateID = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                        LanguageId = (dr["languageid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["languageid"]),
                        SMSLanguage = (dr["languagename"] == DBNull.Value ? "" : Convert.ToString(dr["languagename"])),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        PeriodStartDate = (dr["PeriodStartDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodStartDate"]).ToString("dd-MM-yyyy"),
                        PeriodEndDate = (dr["PeriodEndDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["PeriodEndDate"]).ToString("dd-MM-yyyy"),
                        WeatherCondition = (dr["WeatherCondition"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherCondition"]),
                        AgroAdvisoryDetails = (dr["AgroAdvisoryDetails"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetails"]),
                        DistrictList = (dr["DistrictList"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictList"]),
                        BlockList = (dr["BlockList"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockList"]),
                        D1 = (dr["D1"]) == DBNull.Value ? false : Convert.ToBoolean(dr["D1"]),
                        D2 = (dr["D2"]) == DBNull.Value ? false : Convert.ToBoolean(dr["D2"]),
                        D3 = (dr["D3"]) == DBNull.Value ? false : Convert.ToBoolean(dr["D3"]),
                        D4 = (dr["D4"]) == DBNull.Value ? false : Convert.ToBoolean(dr["D4"]),
                        D5 = (dr["D5"]) == DBNull.Value ? false : Convert.ToBoolean(dr["D5"]),
                        CreatedDate = (dr["CreatedDate"])== DBNull.Value ? "" : Convert.ToDateTime(dr["CreatedDate"]).ToString("yyyy-MM-dd"),
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

        #region GetCropAdvisoryByID
        public static CropAdvisoryResponse GetCropAdvisoryByID(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCropAdvisoryID", objCropAdvisory.CropAdvisoryID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryByCropAdvisoryID", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        AgroAdvisoryDetails = (dr["AgroAdvisoryDetails"]) == DBNull.Value ? "" : Convert.ToString(dr["AgroAdvisoryDetails"]),
                        WeatherCondition = (dr["WeatherCondition"]) == DBNull.Value ? "" : Convert.ToString(dr["WeatherCondition"]),
                        VarietyName = (dr["VarietyName"]) == DBNull.Value ? "" : Convert.ToString(dr["VarietyName"]),
                        VarietyId = (dr["VarietyId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["VarietyId"]),
                        CropImageURL = (dr["CropImageURL"]) == DBNull.Value ? "" : Convert.ToString(dr["CropImageURL"]),
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        Title = (dr["Title"] == DBNull.Value ? "" : Convert.ToString(dr["Title"])),
                        BriefText = (dr["BriefText"]) == DBNull.Value ? "" : Convert.ToString(dr["BriefText"]),
                        Recommendations = (dr["Recommendations"]) == DBNull.Value ? "" : Convert.ToString(dr["Recommendations"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        District = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                        Category = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                        YouTubeLink = (dr["youtubelink"]) == DBNull.Value ? "" : Convert.ToString(dr["youtubelink"]),
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

        #region GetCropAdvisoryAttachments
        public static CropAdvisoryResponse GetCropAdvisoryAttachments(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            string AudioContainerName = ConfigurationManager.AppSettings["AudioContainerName"].ToString();
            string ImageContainerName = ConfigurationManager.AppSettings["ImageContainerName"].ToString();
            string ContainerName = "";
            if (objCropAdvisory.Type == "Image")
            {
                ContainerName = ImageContainerName;
            }
            if (objCropAdvisory.Type == "Audio")
            {
                ContainerName = AudioContainerName;
            }
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCropAdvisoryID", objCropAdvisory.CropAdvisoryID),
                new SqlParameter("@pType", objCropAdvisory.Type),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisory_Attachments", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryImageList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryImage
                    {
                        CAAID = (dr["CAAID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CAAID"]),
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        Type = (dr["Type"] == DBNull.Value ? "" : Convert.ToString(dr["Type"])),
                        //ThumbnailBytes = (dr["ThumbnailBytes"]) == DBNull.Value ? null : ((byte[])(dr["ThumbnailBytes"])),
                        ThumbNailImageName = "data:image/jpg;base64," + Convert.ToBase64String((dr["ThumbnailBytes"]) == DBNull.Value ? null : ((byte[])(dr["ThumbnailBytes"]))),
                        ImagePath = string.Format(Utilities.RetrieveDocumentUri_Params((dr["ImagePath"]) == DBNull.Value ? "" : Convert.ToString(dr["ImagePath"]), ContainerName)),
                        CreatedDate = (dr["Createddate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["Createddate"]).ToString("dd-MM-yyyy"),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString(),
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

        #region Get crop advisory category Distict Mapping

        public static CropAdvisoryResponse GetCAMDistrictMapping(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCropAdvisoryID", objCropAdvisory.CropAdvisoryID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryMasterDistrictMapping", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDistMappList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDistrict
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
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

        #region Get crop advisory category BlockMapping
        public static CropAdvisoryResponse GetCAMBlockMapping(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCropAdvisoryID", objCropAdvisory.CropAdvisoryID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryMasterBlockMapping", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryBlockMappList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryBlock
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
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

        #region Get Crop Advisory Distict Mapping

        public static CropAdvisoryResponse GetCropAdvyDistMapping(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCropAdvisoryID", objCropAdvisory.CropAdvisoryID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryDistrictMapping", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDistMappList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDistrict
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
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

        #region GetCropAdvyBlockMapping
        public static CropAdvisoryResponse GetCropAdvyBlockMapping(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCropAdvisoryID", objCropAdvisory.CropAdvisoryID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryBlockMapping", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryBlockMappList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryBlock
                    {
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
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

        #region GetCropAdvyCropMapping

        public static CropAdvisoryResponse GetCropAdvyCropMapping(CropAdvisoryDetails objCropAdvisory)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                            new SqlParameter("@pCropAdvisoryID", objCropAdvisory.CropAdvisoryID),
                            new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                            new SqlParameter("@pRefreshdatetime", objCropAdvisory.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryCropMapping", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryCropMappList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryCrop
                    {
                        CACMID = (dr["CACMID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CACMID"]),
                        CropAdvisoryID = (dr["CropAdvisoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryID"]),
                        CropID = (dr["CropID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropID"]),
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

        #region GetCrops
        public static CropAdvisoryResponse GetCrops(CropAdvisoryCrop objCrop)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {               
                SqlParameter[] arrParams = new SqlParameter[]
                {
                            new SqlParameter("@pUserProfileID", objCrop.ID),
                            new SqlParameter("@pCropCategoryID", objCrop.CropCategoryID),
                            new SqlParameter("@planguagetype", objCrop.LanguageType),
                            new SqlParameter("@pRefreshdatetime", objCrop.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryCropDetails", arrParams);
                if (dt.Rows.Count > 0)
                {     
                    
                    response.ObjCropAdvisoryCropMappList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryCrop
                    {
                        CropID = (dr["CropID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropID"]),
                        CropName = (dr["CropName"] == DBNull.Value ? "" : Convert.ToString(dr["CropName"])),
                        VarietyId = (dr["VarietyId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["VarietyId"]),
                        VarietyName = (dr["VarietyName"] == DBNull.Value ? "" : Convert.ToString(dr["VarietyName"])),
                        ThumbNailBytes = (dr["CropThumbnailbytes"] == DBNull.Value ? null : ((byte[])(dr["CropThumbnailbytes"]))),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString("dd-MM-yyyy"),
                        CropImageURL = (dr["CropImageURL"]) == DBNull.Value ? "" : Convert.ToString(dr["CropImageURL"]),
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

        #region GetCropCategory
        public static CropAdvisoryResponse GetCropCategory(CropAdvisoryCropCategory objCrop)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                            new SqlParameter("@pUserProfileID", objCrop.ID),
                            new SqlParameter("@planguagetype", objCrop.LanguageType),
                            new SqlParameter("@pRefreshdatetime", objCrop.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropAdvisoryCategoryDetails", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryCropCategoryList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryCropCategory
                    {
                        CropCategoryID = (dr["CropCategoryID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropCategoryID"]),
                        CropCategory = (dr["CropCategoryName"] == DBNull.Value ? "" : Convert.ToString(dr["CropCategoryName"])),
                        ThumbNailBytes = (dr["Thumbnailbytes"] == DBNull.Value ? null : ((byte[])(dr["Thumbnailbytes"]))),
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

        #region GetLanguageList
        public static CropAdvisoryResponse GetLanguageList(Languages objLanguage)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                            new SqlParameter("@pALID", objLanguage.ID),
                            new SqlParameter("@planguagetype", objLanguage.LanguageType),
                            new SqlParameter("@pRefreshdatetime", objLanguage.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_AgrometLanguages", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjLanguagesList =
                   (from DataRow dr in dt.Rows
                    select new Languages
                    {
                        ID = (dr["ALID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["ALID"]),
                        //English = (dr["English"] == DBNull.Value ? "" : Convert.ToString(dr["English"])),
                        Hindi = (dr["Hindi"] == DBNull.Value ? "" : Convert.ToString(dr["Hindi"])),
                        Bengali = (dr["Bengali"] == DBNull.Value ? "" : Convert.ToString(dr["Bengali"])),
                        Telugu = (dr["Telugu"] == DBNull.Value ? "" : Convert.ToString(dr["Telugu"])),
                        Tamil = (dr["Tamil"] == DBNull.Value ? "" : Convert.ToString(dr["Tamil"])),
                        Urdu = (dr["Urdu"] == DBNull.Value ? "" : Convert.ToString(dr["Urdu"])),
                        Gujarati = (dr["Gujarati"] == DBNull.Value ? "" : Convert.ToString(dr["Gujarati"])),
                        Kannada = (dr["Kannada"] == DBNull.Value ? "" : Convert.ToString(dr["Kannada"])),
                        Malayalam = (dr["Malayalam"] == DBNull.Value ? "" : Convert.ToString(dr["Malayalam"])),
                        Oriya = (dr["Oriya"] == DBNull.Value ? "" : Convert.ToString(dr["Oriya"])),
                        Punjabi = (dr["Punjabi"] == DBNull.Value ? "" : Convert.ToString(dr["Punjabi"])),
                        Assamese = (dr["Assamese"] == DBNull.Value ? "" : Convert.ToString(dr["Assamese"])),
                        Maithili = (dr["Maithili"] == DBNull.Value ? "" : Convert.ToString(dr["Maithili"])),
                        Bhili = (dr["Bhili"] == DBNull.Value ? "" : Convert.ToString(dr["Bhili"])),
                        Santali = (dr["Santali"] == DBNull.Value ? "" : Convert.ToString(dr["Santali"])),
                        Kashmiri = (dr["Kashmiri"] == DBNull.Value ? "" : Convert.ToString(dr["Kashmiri"])),
                        Nepali = (dr["Nepali"] == DBNull.Value ? "" : Convert.ToString(dr["Nepali"])),
                        Gondi = (dr["Gondi"] == DBNull.Value ? "" : Convert.ToString(dr["Gondi"])),
                        Sindhi = (dr["Sindhi"] == DBNull.Value ? "" : Convert.ToString(dr["Sindhi"])),
                        Konkani = (dr["Konkani"] == DBNull.Value ? "" : Convert.ToString(dr["Konkani"])),
                        Dogri = (dr["Dogri"] == DBNull.Value ? "" : Convert.ToString(dr["Dogri"])),
                        Khandeshi = (dr["Khandeshi"] == DBNull.Value ? "" : Convert.ToString(dr["Khandeshi"])),
                        Kurukh = (dr["Kurukh"] == DBNull.Value ? "" : Convert.ToString(dr["Kurukh"])),
                        Tulu = (dr["Tulu"] == DBNull.Value ? "" : Convert.ToString(dr["Tulu"])),
                        Manipuri = (dr["Manipuri"] == DBNull.Value ? "" : Convert.ToString(dr["Manipuri"])),
                        Bodo = (dr["Bodo"] == DBNull.Value ? "" : Convert.ToString(dr["Bodo"])),
                        Khasi = (dr["Khasi"] == DBNull.Value ? "" : Convert.ToString(dr["Khasi"])),
                        Mundari = (dr["Mundari"] == DBNull.Value ? "" : Convert.ToString(dr["Mundari"])),
                        Ho = (dr["Ho"] == DBNull.Value ? "" : Convert.ToString(dr["Ho"])),
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

        #region Get RatingList for web
        public static CropAdvisoryResponse GetRatingList(CropAdvisoryDetails objCropAdvisory)
        {
            var dt = new DataTable();
            var dtAvgRating = new DataTable();
            var dataSet = new DataSet();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pcropid", objCropAdvisory.CropID),
                new SqlParameter("@pStateId", objCropAdvisory.StateID),
                new SqlParameter("@pDistrictid", objCropAdvisory.DistrictID),
                //new SqlParameter("@pRating", objCropAdvisory.Rating),
                new SqlParameter("@pScientistid", objCropAdvisory.ScientistID),
                new SqlParameter("@planguagetype", objCropAdvisory.LanguageType),
                new SqlParameter("@pFromDate", objCropAdvisory.RefreshDateTime),
                new SqlParameter("@pToDate", objCropAdvisory.RecordDate),
                };
                dataSet = SQLHelper.ExecuteMulti("spSearch_FarmerRatingDetails", arrParams);
                dt = dataSet.Tables[0];
                dtAvgRating = dataSet.Tables[1];
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryDetailsList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryDetails
                    {
                        CAMID = (dr["CAMID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CAMID"]),
                        CropAdvisoryID = (dr["CropAdvisoryid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CropAdvisoryid"]),
                        CropName = (dr["CropName"]) == DBNull.Value ? "" : Convert.ToString(dr["CropName"]),
                        //LogInId = (dr["Phonenumber"]) == DBNull.Value ? "" : Convert.ToString(dr["Phonenumber"]),
                        //FarmerName = (dr["FarmerName"]) == DBNull.Value ? "" : Convert.ToString(dr["FarmerName"]),
                        State = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                        District = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                        //Rating = (dr["Rating"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Rating"])),                        
                        Rating = dtAvgRating.AsEnumerable().Where(e=>e.Field<int>("CropAdvisoryId") == dr.Field<int>("CropAdvisoryId"))
                        .Select(e=>e.Field<int>("Avgrating")).FirstOrDefault(),
                        RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["RefreshDateTime"]).ToString("dd-MM-yyyy"),
                        VarietyId = (dr["VarietyId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["VarietyId"]),
                        VarietyName = (dr["VarietyName"]) == DBNull.Value ? "" : Convert.ToString(dr["VarietyName"]),
                        CreatedDate = (dr["CreatedDate"]) == DBNull.Value ? "" : Convert.ToDateTime(dr["CreatedDate"]).ToString("dd-MM-yyyy"),
                        //Comments = (dr["Q3"]) == DBNull.Value ? "" : Convert.ToString(dr["Q3"]),
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

        #region Get FeedBack for web
        public static CropAdvisoryResponse GetFeedbackById(CropAdvisoryFeedback objCropAdvisoryFeedback)
        {
            DataTable dt = new DataTable();
            CropAdvisoryResponse response = new CropAdvisoryResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCropAdvisoryID", objCropAdvisoryFeedback.CropAdvisoryID),
                new SqlParameter("@pUserProfileID", objCropAdvisoryFeedback.UserProfileID),
                new SqlParameter("@planguagetype", objCropAdvisoryFeedback.LanguageType),
                new SqlParameter("@pRefreshdatetime", objCropAdvisoryFeedback.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_Feedback", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjCropAdvisoryFeedbackList =
                   (from DataRow dr in dt.Rows
                    select new CropAdvisoryFeedback
                    {
                        isFeedback = (dr["isFeedback"]) == DBNull.Value ? false : Convert.ToBoolean(dr["isFeedback"]),
                        Q1 = (dr["Q1"]) == DBNull.Value ? "" : Convert.ToString(dr["Q1"]),
                        Q2 = (dr["Q2"]) == DBNull.Value ? "" : Convert.ToString(dr["Q2"]),
                        Comments = (dr["Q3"]) == DBNull.Value ? "" : Convert.ToString(dr["Q3"]),
                        FarmerName = (dr["FarmerName"]) == DBNull.Value ? "" : Convert.ToString(dr["FarmerName"])
                        
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

        public static string GetAdvisoryFromIMD()
        {
            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.ToString("yyyy-MM-dd");

            try
            {
                //todayDate = "2020-07-03";
                AD += todayDate;
                //var ResultFromIMD = new HttpClient().GetAsync(AD).Result;
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Version", "1");
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                var ResultFromIMD = client.GetAsync(AD).Result;
                // added code by bipin
                AD = AD.Replace(todayDate, string.Empty);
                if (!ResultFromIMD.IsSuccessStatusCode)
                {
                    response.IsSuccessful = false;
                    str = "Data not found for insert";
                    return str;
                }
                
                //end
                var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                if(IMDResponse != null)
                {
                    string[] arr = IMDResponse.Split('[');
                    string temp = "[";
                    for (int j = 1; j < arr.Length; j++)
                    {
                        temp += arr[j];
                    }
                    var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                    foreach (var item in objresponse)
                    {
                        if (item.sms_eng == null)
                        {
                            item.sms_eng = "";
                        }
                        if (item.advisory_eng == null)
                        {
                            item.advisory_eng = "";
                        }
                        if (item.weather_summary_eng == null)
                        {
                            item.weather_summary_eng = "";
                        }
                        if (item.general_advisory_eng == null)
                        {
                            item.general_advisory_eng = "";
                        }
                        if(item.custom_date == null)
                        {
                            item.custom_date = "";
                        }
                        

                        ObjDetails = new CropAdvisoryDetails
                        {
                            CropID = Convert.ToInt32(item.type_id),
                            StateID = Convert.ToInt32(item.state_id),
                            DistrictID = Convert.ToInt32(item.district_id),
                            CategoryID = Convert.ToInt32(item.cat_id),
                            BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),                            
                            BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                            Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),                            
                            RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),                            
                            WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                            WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),                            
                            AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),                            
                            AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                            PeriodStartDate =  Convert.ToString(item.custom_date),
                            RegionalLanguage = Convert.ToString(item.reg_lang_name),
                            Title = item.crop_name,
                            YouTubeLink = "",
                            DistrictList = "",
                            BlockList = "",
                            AsdList = "",
                            LanguageId = 2,
                            D1 = false,
                            D2 = false,
                            D3 = false,
                            D4 = false,
                            D5 = false,
                            CropAdvisoryID = 0,
                            CAMID =0,
                            ScientistID =0,
                            Createdby = 0,
                            Updatedby=0,
                            CreatedDate = Convert.ToString(item.custom_date),
                            RecordDate = todayDate,
                            VarietyName = item.variety_name == null ? ""  : Convert.ToString(item.variety_name),
                            VarietyId =  (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                        };
                        if (item.custom_date != "")
                        {
                           ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            ObjDetails.PeriodEndDate = "";
                        }
                        if (ObjDetails.DistrictID != 0)
                        {
                            district = new CropAdvisoryDistrict
                            {
                                StateID = ObjDetails.StateID,
                                DistrictID = ObjDetails.DistrictID
                            };
                            ObjDetails.ObjDistrictList.Add(district);
                        }
                        else
                        {
                            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                        }
                        ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                        ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                        ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                        responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                        
                        if (responsemaster.IsSuccessful)
                        {
                            if (responsemaster.NewID >0)
                            {
                                ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                response = SaveCropAdvisory(ObjDetails);
                                if (response.IsSuccessful == false)
                                {
                                    str += response.ErrorMessage;
                                }
                            }
                        }
                        else
                        {
                            str += response.ErrorMessage;
                        }
                    }
                    str += "Data saved successfully!";
                }
            }
            catch (Exception ex)
            {
                AD = AD.Replace(todayDate, string.Empty);
                str = ex.Message.ToString();
            }
            return str;
        }

        // new flow services 

        public static async Task<string> GetAdvisoryByStateId1_5FromIMD()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId1_5FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start
            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                for (int i = 1; i <= 5; i++)
                {
                    appendInURL = string.Concat(todayDate, '/', i);
                    AD_NEWDistrict = string.Concat(AD_NEWDistrict, appendInURL);
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Version", "1");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");

                    client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                    HttpResponseMessage ResultFromIMD = null;
                    try
                    {
                        _log.Info("Callid : " + callId + " calling AD_NEW IMD Service cropadvisory service for station id : " + i);
                        ResultFromIMD = await client.GetAsync(AD_NEWDistrict);
                        _log.Info("Callid : " + callId + " complete AD_NEW IMD Service cropadvisory service for station id : " + 1);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in AD_NEWDistrict IMD Service cropadvisory service for station id : " + i + " " + ex.Message);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += ex.Message;
                        continue;
                    }

                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No Crop advisory found at station id  : " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += "No data found!";
                        continue;
                    }
                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    _log.Info("Callid : " + callId + " data read from  AD_NEWDistrict IMD Service cropadvisory service at station id :" + i);
                    if (IMDResponse != null)
                    {
                        string[] arr = IMDResponse.Split('[');
                        string temp = "[";
                        for (int j = 1; j < arr.Length; j++)
                        {
                            temp += arr[j];
                        }
                        var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                        foreach (var item in objresponse)
                        {
                            ObjDetails = new CropAdvisoryDetails
                            {
                                CropID = Convert.ToInt32(item.type_id),
                                StateID = Convert.ToInt32(item.state_id),
                                DistrictID = Convert.ToInt32(item.district_id),
                                CategoryID = Convert.ToInt32(item.cat_id),
                                BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                Title = item.crop_name,
                                YouTubeLink = "",
                                DistrictList = "",
                                BlockList = "",
                                AsdList = "",
                                LanguageId = 2,
                                D1 = false,
                                D2 = false,
                                D3 = false,
                                D4 = false,
                                D5 = false,
                                CropAdvisoryID = 0,
                                CAMID = 0,
                                ScientistID = 0,
                                Createdby = 0,
                                Updatedby = 0,
                                CreatedDate = Convert.ToString(item.custom_date),
                                RecordDate = todayDate,
                                VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                            };
                            if (item.custom_date != "")
                            {
                                ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                ObjDetails.PeriodEndDate = "";
                            }
                            if (ObjDetails.DistrictID != 0)
                            {
                                district = new CropAdvisoryDistrict
                                {
                                    StateID = ObjDetails.StateID,
                                    DistrictID = ObjDetails.DistrictID
                                };
                                ObjDetails.ObjDistrictList.Add(district);
                            }
                            else
                            {
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                            }
                            ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                            ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                            ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                            _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters Service cropadvisory service at station id :" + i);
                            responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                            _log.Info("Callid : " + callId + " complete SaveCropAdvisoryMasters Service cropadvisory service at station id : " + i);
                            if (responsemaster.IsSuccessful)
                            {
                                if (responsemaster.NewID > 0)
                                {
                                    ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisory Service cropadvisory service at station id : " + i);
                                    response = SaveCropAdvisory(ObjDetails);
                                    _log.Info("Callid : " + callId + " complete SaveCropAdvisory Service cropadvisory service at station id : " + i);
                                    if (response.IsSuccessful == false)
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                            }
                            else
                            {
                                str += response.ErrorMessage;
                            }
                        }
                        str += "Data saved successfully!";
                        _log.Info("Callid : " + callId + " complete GetAdvisoryByStateId1_5FromIMD Service cropadvisory service of station id : " + i);
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " Exception in GetAdvisoryByStateId1_5FromIMD Service cropadvisory service : " + ex.Message);
                AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }


        public static async Task<string> GetAdvisoryByStateAndDistrict(int stateId, int districtId, DateTime startDate, string endDate)
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateAndDistrict";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start
            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            DateTime lastDate = DateTime.Today;
            var appendInURL = "";
            try
            {                
                DateTime dtVal;                
                lastDate = (DateTime.TryParse(endDate, out dtVal)) ? Convert.ToDateTime(endDate) : startDate;
                while (lastDate>= startDate)
                {
                    todayDate = startDate.ToString("yyyy-MM-dd");
                    appendInURL = string.Concat(todayDate, '/', stateId);
                    AD_NEWDistrict = string.Concat(AD_NEWDistrict, appendInURL);
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Version", "1");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");

                    client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                    HttpResponseMessage ResultFromIMD = null;
                    try
                    {
                        _log.Info("Callid : " + callId + " calling AD_NEW IMD Service cropadvisory service for station id : " + stateId);
                        ResultFromIMD = await client.GetAsync(AD_NEWDistrict);
                        _log.Info("Callid : " + callId + " complete AD_NEW IMD Service cropadvisory service for station id : " + 1);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in AD_NEWDistrict IMD Service cropadvisory service for station id : " + stateId + "  and date : " + startDate.ToString("yyyy-MM-dd") + "" + ex.Message);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += ex.Message + "for " + startDate.ToString("yyyy-MM-dd") + "!";
                        startDate = startDate.AddDays(1);
                        continue;
                    }

                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No Crop advisory found at station id  : " + stateId);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += "No data found for "+ startDate.ToString("yyyy-MM-dd") + "!";
                        startDate = startDate.AddDays(1);
                        continue;
                    }
                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    _log.Info("Callid : " + callId + " data read from  AD_NEWDistrict IMD Service cropadvisory service at station id :" + stateId);
                    if (IMDResponse != null)
                    {
                        string[] arr = IMDResponse.Split('[');
                        string temp = "[";
                        for (int j = 1; j < arr.Length; j++)
                        {
                            temp += arr[j];
                        }
                        _log.Info(temp);
                        var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                        foreach (var item in objresponse)
                        {
                            if (item.district_id == districtId.ToString())
                            {
                                ObjDetails = new CropAdvisoryDetails
                                {
                                    CropID = Convert.ToInt32(item.type_id),
                                    StateID = Convert.ToInt32(item.state_id),
                                    DistrictID = Convert.ToInt32(item.district_id),
                                    CategoryID = Convert.ToInt32(item.cat_id),
                                    BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                    BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                    Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                    RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                    WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                    WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                    AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                    AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                    PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                    RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                    Title = item.crop_name,
                                    YouTubeLink = "",
                                    DistrictList = "",
                                    BlockList = "",
                                    AsdList = "",
                                    LanguageId = 2,
                                    D1 = false,
                                    D2 = false,
                                    D3 = false,
                                    D4 = false,
                                    D5 = false,
                                    CropAdvisoryID = 0,
                                    CAMID = 0,
                                    ScientistID = 0,
                                    Createdby = 0,
                                    Updatedby = 0,
                                    CreatedDate = Convert.ToString(item.custom_date),
                                    RecordDate = todayDate,
                                    VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                    VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                };
                                if (item.custom_date != "")
                                {
                                    ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    ObjDetails.PeriodEndDate = "";
                                }
                                if (ObjDetails.DistrictID != 0)
                                {
                                    district = new CropAdvisoryDistrict
                                    {
                                        StateID = ObjDetails.StateID,
                                        DistrictID = ObjDetails.DistrictID
                                    };
                                    ObjDetails.ObjDistrictList.Add(district);
                                }
                                else
                                {
                                    ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                }
                                ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters Service cropadvisory service at station id :" + stateId);
                                responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                            }

                            _log.Info("Callid : " + callId + " complete SaveCropAdvisoryMasters Service cropadvisory service at station id : " + stateId);
                            if (responsemaster.IsSuccessful)
                            {
                                if (responsemaster.NewID > 0)
                                {
                                    ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisory Service cropadvisory service at station id : " + stateId);
                                    response = SaveCropAdvisory(ObjDetails);
                                    _log.Info("Callid : " + callId + " complete SaveCropAdvisory Service cropadvisory service at station id : " + stateId);
                                    if (response.IsSuccessful == false)
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                            }
                            else
                            {
                                str += response.ErrorMessage;
                            }
                        }
                        str += "Data saved successfully for " + startDate.ToString("yyyy-MM-dd") + "!";
                        _log.Info("Callid : " + callId + " complete GetAdvisoryByStateId1_5FromIMD Service cropadvisory service of station id : " + stateId);
                    }
                    startDate = startDate.AddDays(1);
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " Exception in GetAdvisoryByStateId1_5FromIMD Service cropadvisory service : " + ex.Message);
                AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }
        public static async Task<string> GetAdvisoryByStateId6_10FromIMD()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId6_10FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                for (int i = 6; i <= 10; i++)
                {
                    appendInURL = string.Concat(todayDate, '/', i);
                    AD_NEWDistrict = string.Concat(AD_NEWDistrict, appendInURL);
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Version", "1");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");
                    client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                    HttpResponseMessage ResultFromIMD = null;
                    try
                    {
                        _log.Info("Callid : " + callId + " calling IMD Service for Crop advisory for station id : " + i);
                        ResultFromIMD = await client.GetAsync(AD_NEWDistrict);
                        _log.Info("Callid : " + callId + " ending IMD Service for Crop advisory for station id : " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in  IMD Service for Crop advisory for station id : " + i + " " + ex.Message);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += ex.Message;
                        continue;
                    }

                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No data from IMD Service for Crop advisory for station id : " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += "No data found!";
                        continue;
                    }
                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    _log.Info("Callid : " + callId + " get data from IMD Service for Crop advisory for station id : " + i);
                    if (IMDResponse != null)
                    {
                        string[] arr = IMDResponse.Split('[');
                        string temp = "[";
                        for (int j = 1; j < arr.Length; j++)
                        {
                            temp += arr[j];
                        }
                        var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                        foreach (var item in objresponse)
                        {
                            ObjDetails = new CropAdvisoryDetails
                            {
                                CropID = Convert.ToInt32(item.type_id),
                                StateID = Convert.ToInt32(item.state_id),
                                DistrictID = Convert.ToInt32(item.district_id),
                                CategoryID = Convert.ToInt32(item.cat_id),
                                BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                Title = item.crop_name,
                                YouTubeLink = "",
                                DistrictList = "",
                                BlockList = "",
                                AsdList = "",
                                LanguageId = 2,
                                D1 = false,
                                D2 = false,
                                D3 = false,
                                D4 = false,
                                D5 = false,
                                CropAdvisoryID = 0,
                                CAMID = 0,
                                ScientistID = 0,
                                Createdby = 0,
                                Updatedby = 0,
                                CreatedDate = Convert.ToString(item.custom_date),
                                RecordDate = todayDate,
                                VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                            };
                            if (item.custom_date != "")
                            {
                                ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                ObjDetails.PeriodEndDate = "";
                            }
                            if (ObjDetails.DistrictID != 0)
                            {
                                district = new CropAdvisoryDistrict
                                {
                                    StateID = ObjDetails.StateID,
                                    DistrictID = ObjDetails.DistrictID
                                };
                                ObjDetails.ObjDistrictList.Add(district);
                            }
                            else
                            {
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                            }
                            ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                            ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                            ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                            _log.Info("Callid : " + callId + " calling  SaveCropAdvisoryMasters in GetAdvisoryByStateId6_10  Crop advisory for station id : " + i);
                            responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                            _log.Info("Callid : " + callId + " called  SaveCropAdvisoryMasters in GetAdvisoryByStateId6_10  Crop advisory for station id : " + i);
                            if (responsemaster.IsSuccessful)
                            {
                                if (responsemaster.NewID > 0)
                                {
                                    ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                    _log.Info("Callid : " + callId + " calling  SaveCropAdvisory in GetAdvisoryByStateId6_10  Crop advisory for station id : " + i);
                                    response = SaveCropAdvisory(ObjDetails);
                                    _log.Info("Callid : " + callId + " calling  SaveCropAdvisory in GetAdvisoryByStateId6_10  Crop advisory for station id : " + i);
                                    if (response.IsSuccessful == false)
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                            }
                            else
                            {
                                str += response.ErrorMessage;
                            }
                        }
                        str += "Data saved successfully!";
                        _log.Info("Callid : " + callId + " ending of GetAdvisoryByStateId6_10  Crop advisory for station id : " + i);
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId11_15  Crop advisory : " + ex.Message);
                AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId11_15FromIMD()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId11_15FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                for (int i = 11; i <= 15; i++)
                {
                    appendInURL = string.Concat(todayDate, '/', i);
                    AD_NEWDistrict = string.Concat(AD_NEWDistrict, appendInURL);
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Version", "1");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");
                    client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                    HttpResponseMessage ResultFromIMD = null;
                    try
                    {
                        _log.Info("Callid : " + callId + " calling IMD Service of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i);
                        ResultFromIMD = await client.GetAsync(AD_NEWDistrict);
                        _log.Info("Callid : " + callId + " ending IMD Service of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i + " " + ex.Message);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += ex.Message;
                        continue;
                    }

                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No Data from IMD Service of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += "No data found!";
                        continue;
                    }
                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    _log.Info("getting data from IMD Service of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i);
                    if (IMDResponse != null)
                    {
                        string[] arr = IMDResponse.Split('[');
                        string temp = "[";
                        for (int j = 1; j < arr.Length; j++)
                        {
                            temp += arr[j];
                        }
                        var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                        foreach (var item in objresponse)
                        {
                            ObjDetails = new CropAdvisoryDetails
                            {
                                CropID = Convert.ToInt32(item.type_id),
                                StateID = Convert.ToInt32(item.state_id),
                                DistrictID = Convert.ToInt32(item.district_id),
                                CategoryID = Convert.ToInt32(item.cat_id),
                                BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                Title = item.crop_name,
                                YouTubeLink = "",
                                DistrictList = "",
                                BlockList = "",
                                AsdList = "",
                                LanguageId = 2,
                                D1 = false,
                                D2 = false,
                                D3 = false,
                                D4 = false,
                                D5 = false,
                                CropAdvisoryID = 0,
                                CAMID = 0,
                                ScientistID = 0,
                                Createdby = 0,
                                Updatedby = 0,
                                CreatedDate = Convert.ToString(item.custom_date),
                                RecordDate = todayDate,
                                VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                            };
                            if (item.custom_date != "")
                            {
                                ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                ObjDetails.PeriodEndDate = "";
                            }
                            if (ObjDetails.DistrictID != 0)
                            {
                                district = new CropAdvisoryDistrict
                                {
                                    StateID = ObjDetails.StateID,
                                    DistrictID = ObjDetails.DistrictID
                                };
                                ObjDetails.ObjDistrictList.Add(district);
                            }
                            else
                            {
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                            }
                            ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                            ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                            ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                            _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i);
                            responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                            _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i);
                            if (responsemaster.IsSuccessful)
                            {
                                if (responsemaster.NewID > 0)
                                {
                                    ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisory of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i);
                                    response = SaveCropAdvisory(ObjDetails);
                                    _log.Info("Callid : " + callId + " called SaveCropAdvisory of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i);
                                    if (response.IsSuccessful == false)
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                            }
                            else
                            {
                                str += response.ErrorMessage;
                            }
                        }
                        str += "Data saved successfully!";
                        _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + i);
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + ex.Message);
                AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId16_20FromIMD()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId16_20FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                for (int i = 16; i <= 20; i++)
                {
                    appendInURL = string.Concat(todayDate, '/', i);
                    AD_NEWDistrict = string.Concat(AD_NEWDistrict, appendInURL);
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Version", "1");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");
                    client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                    HttpResponseMessage ResultFromIMD = null;
                    try
                    {
                        _log.Info("Callid : " + callId + " calling IMD Service of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i);
                        ResultFromIMD = await client.GetAsync(AD_NEWDistrict);
                        _log.Info("Callid : " + callId + " called IMD Service of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i + " " + ex.Message);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += ex.Message;
                        continue;
                    }

                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No Data from IMD Service of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += "No data found!";
                        continue;
                    }
                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    _log.Info("Callid : " + callId + " get data from IMD Service of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i);
                    if (IMDResponse != null)
                    {
                        string[] arr = IMDResponse.Split('[');
                        string temp = "[";
                        for (int j = 1; j < arr.Length; j++)
                        {
                            temp += arr[j];
                        }
                        var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                        foreach (var item in objresponse)
                        {
                            ObjDetails = new CropAdvisoryDetails
                            {
                                CropID = Convert.ToInt32(item.type_id),
                                StateID = Convert.ToInt32(item.state_id),
                                DistrictID = Convert.ToInt32(item.district_id),
                                CategoryID = Convert.ToInt32(item.cat_id),
                                BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                Title = item.crop_name,
                                YouTubeLink = "",
                                DistrictList = "",
                                BlockList = "",
                                AsdList = "",
                                LanguageId = 2,
                                D1 = false,
                                D2 = false,
                                D3 = false,
                                D4 = false,
                                D5 = false,
                                CropAdvisoryID = 0,
                                CAMID = 0,
                                ScientistID = 0,
                                Createdby = 0,
                                Updatedby = 0,
                                CreatedDate = Convert.ToString(item.custom_date),
                                RecordDate = todayDate,
                                VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                            };
                            if (item.custom_date != "")
                            {
                                ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                ObjDetails.PeriodEndDate = "";
                            }
                            if (ObjDetails.DistrictID != 0)
                            {
                                district = new CropAdvisoryDistrict
                                {
                                    StateID = ObjDetails.StateID,
                                    DistrictID = ObjDetails.DistrictID
                                };
                                ObjDetails.ObjDistrictList.Add(district);
                            }
                            else
                            {
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                            }
                            ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                            ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                            ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                            _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i);
                            responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                            _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i);
                            if (responsemaster.IsSuccessful)
                            {
                                if (responsemaster.NewID > 0)
                                {
                                    ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisory of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i);
                                    response = SaveCropAdvisory(ObjDetails);
                                    _log.Info("Callid : " + callId + " called SaveCropAdvisory of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i);
                                    if (response.IsSuccessful == false)
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                            }
                            else
                            {
                                str += response.ErrorMessage;
                            }
                        }
                        str += "Data saved successfully!";
                        _log.Info("Callid : " + callId + " completetion of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + i);
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + ex.Message);
                AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId21_25FromIMD()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId21_25FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] { 21, 22, 23, 25, 24 };
                foreach (var value in values)
                //for (int i = 21; i <= 25; i++)
                {
                    //appendInURL = string.Concat(todayDate, '/', i);
                    appendInURL = string.Concat(todayDate, '/', value);
                    AD_NEWDistrict = string.Concat(AD_NEWDistrict, appendInURL);
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Version", "1");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");
                    client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                    HttpResponseMessage ResultFromIMD = null;
                    try
                    {
                        _log.Info("Callid : " + callId + " calling IMD Service of GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                        ResultFromIMD = await client.GetAsync(AD_NEWDistrict);
                        _log.Info("called IMD Service of GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += ex.Message;
                        continue;
                    }

                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No Data from IMD Service of GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += "No data found!";
                        continue;
                    }
                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    _log.Info("Callid : " + callId + " get data from IMD Service of GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                    if (IMDResponse != null)
                    {
                        string[] arr = IMDResponse.Split('[');
                        string temp = "[";
                        for (int j = 1; j < arr.Length; j++)
                        {
                            temp += arr[j];
                        }
                        var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                        foreach (var item in objresponse)
                        {
                            ObjDetails = new CropAdvisoryDetails
                            {
                                CropID = Convert.ToInt32(item.type_id),
                                StateID = Convert.ToInt32(item.state_id),
                                DistrictID = Convert.ToInt32(item.district_id),
                                CategoryID = Convert.ToInt32(item.cat_id),
                                BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                Title = item.crop_name,
                                YouTubeLink = "",
                                DistrictList = "",
                                BlockList = "",
                                AsdList = "",
                                LanguageId = 2,
                                D1 = false,
                                D2 = false,
                                D3 = false,
                                D4 = false,
                                D5 = false,
                                CropAdvisoryID = 0,
                                CAMID = 0,
                                ScientistID = 0,
                                Createdby = 0,
                                Updatedby = 0,
                                CreatedDate = Convert.ToString(item.custom_date),
                                RecordDate = todayDate,
                                VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                            };
                            if (item.custom_date != "")
                            {
                                ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                ObjDetails.PeriodEndDate = "";
                            }
                            if (ObjDetails.DistrictID != 0)
                            {
                                district = new CropAdvisoryDistrict
                                {
                                    StateID = ObjDetails.StateID,
                                    DistrictID = ObjDetails.DistrictID
                                };
                                ObjDetails.ObjDistrictList.Add(district);
                            }
                            else
                            {
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                            }
                            ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                            ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                            ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                            _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                            responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                            _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters  of GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                            if (responsemaster.IsSuccessful)
                            {
                                if (responsemaster.NewID > 0)
                                {
                                    ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisory of GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                    response = SaveCropAdvisory(ObjDetails);
                                    _log.Info("Callid : " + callId + " called SaveCropAdvisory of GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                    if (response.IsSuccessful == false)
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                            }
                            else
                            {
                                str += response.ErrorMessage;
                            }
                        }
                        str += "Data saved successfully!";
                        _log.Info("Callid : " + callId + " completion of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId21_25FromIMD  Crop advisory : " + ex.Message);
                AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId26_30FromIMD()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId26_30FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] { 26, 27, 28, 29, 30 };
                foreach (var value in values)
                //for (int i = 26; i <= 30; i++)
                {

                    //appendInURL = string.Concat(todayDate, '/', i);
                    appendInURL = string.Concat(todayDate, '/', value);
                    AD_NEWDistrict = string.Concat(AD_NEWDistrict, appendInURL);
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Version", "1");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");
                    client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                    HttpResponseMessage ResultFromIMD = null;
                    try
                    {
                        _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                        ResultFromIMD = await client.GetAsync(AD_NEWDistrict);
                        _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += ex.Message;
                        continue;
                    }

                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += "No data found!";
                        continue;
                    }

                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                    if (IMDResponse != null)
                    {
                        string[] arr = IMDResponse.Split('[');
                        string temp = "[";
                        for (int j = 1; j < arr.Length; j++)
                        {
                            temp += arr[j];
                        }
                        var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                        foreach (var item in objresponse)
                        {
                            ObjDetails = new CropAdvisoryDetails
                            {
                                CropID = Convert.ToInt32(item.type_id),
                                StateID = Convert.ToInt32(item.state_id),
                                DistrictID = Convert.ToInt32(item.district_id),
                                CategoryID = Convert.ToInt32(item.cat_id),
                                BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                Title = item.crop_name,
                                YouTubeLink = "",
                                DistrictList = "",
                                BlockList = "",
                                AsdList = "",
                                LanguageId = 2,
                                D1 = false,
                                D2 = false,
                                D3 = false,
                                D4 = false,
                                D5 = false,
                                CropAdvisoryID = 0,
                                CAMID = 0,
                                ScientistID = 0,
                                Createdby = 0,
                                Updatedby = 0,
                                CreatedDate = Convert.ToString(item.custom_date),
                                RecordDate = todayDate,
                                VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                            };
                            if (item.custom_date != "")
                            {
                                ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                ObjDetails.PeriodEndDate = "";
                            }
                            if (ObjDetails.DistrictID != 0)
                            {
                                district = new CropAdvisoryDistrict
                                {
                                    StateID = ObjDetails.StateID,
                                    DistrictID = ObjDetails.DistrictID
                                };
                                ObjDetails.ObjDistrictList.Add(district);
                            }
                            else
                            {
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                            }
                            ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                            ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                            ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                            _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                            responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                            _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                            if (responsemaster.IsSuccessful)
                            {
                                if (responsemaster.NewID > 0)
                                {
                                    ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    response = SaveCropAdvisory(ObjDetails);
                                    _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    if (response.IsSuccessful == false)
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                            }
                            else
                            {
                                str += response.ErrorMessage;
                            }
                        }
                        str += "Data saved successfully!";
                        _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId26_30FromIMD  Crop advisory :" + ex.Message);
                AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId31_35FromIMD()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId31_35FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                for (int i = 31; i <= 35; i++)
                {
                    appendInURL = string.Concat(todayDate, '/', i);
                    AD_NEWDistrict = string.Concat(AD_NEWDistrict, appendInURL);
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Version", "1");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");
                    client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                    HttpResponseMessage ResultFromIMD = null;
                    try
                    {
                        _log.Info("Callid : " + callId + " Calling IMD Service of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i);
                        ResultFromIMD = await client.GetAsync(AD_NEWDistrict);
                        _log.Info("Callid : " + callId + " called  IMD Service of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " exception in  GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i + " " + ex.Message);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += ex.Message;
                        continue;
                    }

                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No data from IMD Service of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += "No data found!";
                        continue;
                    }
                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    _log.Info("Callid : " + callId + " get date from IMD Service of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i);
                    if (IMDResponse != null)
                    {
                        string[] arr = IMDResponse.Split('[');
                        string temp = "[";
                        for (int j = 1; j < arr.Length; j++)
                        {
                            temp += arr[j];
                        }
                        var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                        foreach (var item in objresponse)
                        {
                            ObjDetails = new CropAdvisoryDetails
                            {
                                CropID = Convert.ToInt32(item.type_id),
                                StateID = Convert.ToInt32(item.state_id),
                                DistrictID = Convert.ToInt32(item.district_id),
                                CategoryID = Convert.ToInt32(item.cat_id),
                                BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                Title = item.crop_name,
                                YouTubeLink = "",
                                DistrictList = "",
                                BlockList = "",
                                AsdList = "",
                                LanguageId = 2,
                                D1 = false,
                                D2 = false,
                                D3 = false,
                                D4 = false,
                                D5 = false,
                                CropAdvisoryID = 0,
                                CAMID = 0,
                                ScientistID = 0,
                                Createdby = 0,
                                Updatedby = 0,
                                CreatedDate = Convert.ToString(item.custom_date),
                                RecordDate = todayDate,
                                VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                            };
                            if (item.custom_date != "")
                            {
                                ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                ObjDetails.PeriodEndDate = "";
                            }
                            if (ObjDetails.DistrictID != 0)
                            {
                                district = new CropAdvisoryDistrict
                                {
                                    StateID = ObjDetails.StateID,
                                    DistrictID = ObjDetails.DistrictID
                                };
                                ObjDetails.ObjDistrictList.Add(district);
                            }
                            else
                            {
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                            }
                            ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                            ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                            ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                            _log.Info("Callid : " + callId + " Calling SaveCropAdvisoryMasters of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i);
                            responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                            _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i);

                            if (responsemaster.IsSuccessful)
                            {
                                if (responsemaster.NewID > 0)
                                {
                                    ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisory of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i);
                                    response = SaveCropAdvisory(ObjDetails);
                                    _log.Info("Callid : " + callId + " called SaveCropAdvisory of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i);
                                    if (response.IsSuccessful == false)
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                            }
                            else
                            {
                                str += response.ErrorMessage;
                            }
                        }
                        str += "Data saved successfully!";
                        _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + i);
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId31_35FromIMD  Crop advisory : " + ex.Message);
                AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId36_37FromIMD()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId36_37FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                for (int i = 37; i >= 36; i--)
                {
                    appendInURL = string.Concat(todayDate, '/', i);
                    AD_NEWDistrict = string.Concat(AD_NEWDistrict, appendInURL);
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Version", "1");
                    client.DefaultRequestHeaders.Add("Accept", "*/*");
                    client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                    HttpResponseMessage ResultFromIMD = null;
                    try
                    {
                        _log.Info("Callid : " + callId + " calling IMD Service of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id :  " + i);
                        ResultFromIMD = await client.GetAsync(AD_NEWDistrict);
                        _log.Info("Callid : " + callId + " called IMD Service of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id :  " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        _log.Error("Callid : " + callId + " calling IMD Service of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id :  " + i + " " + ex.Message);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += ex.Message;
                        continue;
                    }

                    if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                    {
                        _log.Info("Callid : " + callId + " No date from IMD Service of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id :  " + i);
                        AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                        str += "No data found!";
                        continue;
                    }
                    var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                    _log.Info("Callid : " + callId + " get data from IMD Service of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id :  " + i);
                    if (IMDResponse != null)
                    {
                        string[] arr = IMDResponse.Split('[');
                        string temp = "[";
                        for (int j = 1; j < arr.Length; j++)
                        {
                            temp += arr[j];
                        }
                        var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                        foreach (var item in objresponse)
                        {
                            ObjDetails = new CropAdvisoryDetails
                            {
                                CropID = Convert.ToInt32(item.type_id),
                                StateID = Convert.ToInt32(item.state_id),
                                DistrictID = Convert.ToInt32(item.district_id),
                                CategoryID = Convert.ToInt32(item.cat_id),
                                BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                Title = item.crop_name,
                                YouTubeLink = "",
                                DistrictList = "",
                                BlockList = "",
                                AsdList = "",
                                LanguageId = 2,
                                D1 = false,
                                D2 = false,
                                D3 = false,
                                D4 = false,
                                D5 = false,
                                CropAdvisoryID = 0,
                                CAMID = 0,
                                ScientistID = 0,
                                Createdby = 0,
                                Updatedby = 0,
                                CreatedDate = Convert.ToString(item.custom_date),
                                RecordDate = todayDate,
                                VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                            };
                            if (item.custom_date != "")
                            {
                                ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                ObjDetails.PeriodEndDate = "";
                            }
                            if (ObjDetails.DistrictID != 0)
                            {
                                district = new CropAdvisoryDistrict
                                {
                                    StateID = ObjDetails.StateID,
                                    DistrictID = ObjDetails.DistrictID
                                };
                                ObjDetails.ObjDistrictList.Add(district);
                            }
                            else
                            {
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                            }
                            ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                            ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                            ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                            _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id :  " + i);
                            responsemaster = SaveCropAdvisoryMasters(ObjDetails);
                            _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id :  " + i);

                            if (responsemaster.IsSuccessful)
                            {
                                if (responsemaster.NewID > 0)
                                {
                                    ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisory of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id :  " + i);
                                    response = SaveCropAdvisory(ObjDetails);
                                    _log.Info("Callid : " + callId + " called SaveCropAdvisory of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id :  " + i);
                                    if (response.IsSuccessful == false)
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                            }
                            else
                            {
                                str += response.ErrorMessage;
                            }
                        }
                        str += "Data saved successfully!";
                        _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId36_37FromIMD  Crop advisory for station id : " + i);
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);

            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId36_37FromIMD  Crop advisory :" + ex.Message);
                AD_NEWDistrict = AD_NEWDistrict.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId1_5FromIMDBlock()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId1_5FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start
            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            CropAdvisoryBlock block = new CropAdvisoryBlock();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] { 1, 2, 3, 4, 5 };
                foreach (var value in values)
                {
                    var districts = Masters.GetDistrictMasterList(new DistrictMaster()
                    {
                        StateID = value,
                        LanguageType = "English",
                        RefreshDateTime = todayDate
                    });
                    foreach (DistrictMaster dis in districts.ObjDistrictMasterList)
                    {
                        //appendInURL = string.Concat(todayDate, '/', i);
                        appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                        AD_NEW = string.Concat(AD_NEW, appendInURL);
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Add("X-Version", "1");
                        client.DefaultRequestHeaders.Add("Accept", "*/*");
                        client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                        HttpResponseMessage ResultFromIMD = null;
                        try
                        {
                            _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value);
                            ResultFromIMD = await client.GetAsync(AD_NEW);
                            _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                        }
                        catch (Exception ex)
                        {
                            _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += ex.Message;
                            continue;
                        }

                        if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                        {
                            _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += "No data found!";
                            continue;
                        }

                        var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                        _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value);
                        if (IMDResponse != null)
                        {
                            string[] arr = IMDResponse.Split('[');
                            string temp = "[";
                            for (int j = 1; j < arr.Length; j++)
                            {
                                temp += arr[j];
                            }
                            var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                            foreach (var item in objresponse)
                            {
                                ObjDetails = new CropAdvisoryDetails
                                {
                                    CropID = Convert.ToInt32(item.type_id),
                                    StateID = Convert.ToInt32(item.state_id),
                                    DistrictID = Convert.ToInt32(item.district_id),
                                    BlockID = Convert.ToInt32(item.block_id),
                                    Block = item.block_name,
                                    CategoryID = Convert.ToInt32(item.cat_id),
                                    BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                    BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                    Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                    RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                    WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                    WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                    AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                    AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                    PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                    RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                    Title = item.crop_name,
                                    YouTubeLink = "",
                                    DistrictList = "",
                                    BlockList = "",
                                    AsdList = "",
                                    LanguageId = 2,
                                    D1 = false,
                                    D2 = false,
                                    D3 = false,
                                    D4 = false,
                                    D5 = false,
                                    CropAdvisoryID = 0,
                                    CAMID = 0,
                                    ScientistID = 0,
                                    Createdby = 0,
                                    Updatedby = 0,
                                    CreatedDate = Convert.ToString(item.custom_date),
                                    RecordDate = todayDate,
                                    VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                    VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                };
                                if (item.custom_date != "")
                                {
                                    ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    ObjDetails.PeriodEndDate = "";
                                }
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                if (ObjDetails.BlockID != 0)
                                {
                                    block = new CropAdvisoryBlock
                                    {
                                        DistrictID = ObjDetails.DistrictID,
                                        BlockID = ObjDetails.BlockID,
                                        BlockName = ObjDetails.Block
                                    };
                                    ObjDetails.ObjBlockList.Add(block);
                                }
                                else
                                {
                                    ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                }

                                ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value);
                                responsemaster = SaveCropAdvisoryMasters(ObjDetails, true);
                                _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value);
                                if (responsemaster.IsSuccessful)
                                {
                                    if (responsemaster.NewID > 0)
                                    {
                                        ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                        _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value);
                                        response = SaveCropAdvisory(ObjDetails);
                                        _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value);
                                        if (response.IsSuccessful == false)
                                        {
                                            str += response.ErrorMessage;
                                        }
                                    }
                                }
                                else
                                {
                                    str += response.ErrorMessage;
                                }
                            }
                            str += "Data saved successfully!";
                            _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId1_5FromIMD  Crop advisory for station id : " + value);
                        }
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " Exception in GetAdvisoryByStateId1_5FromIMD Service cropadvisory service : " + ex.Message);
                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId6_10FromIMDBlock()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId6_10FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            CropAdvisoryBlock block = new CropAdvisoryBlock();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] { 6, 7, 8, 9, 10 };
                foreach (var value in values)
                {
                    var districts = Masters.GetDistrictMasterList(new DistrictMaster()
                    {
                        StateID = value,
                        LanguageType = "English",
                        RefreshDateTime = todayDate
                    });
                    foreach (DistrictMaster dis in districts.ObjDistrictMasterList)
                    {
                        //appendInURL = string.Concat(todayDate, '/', i);
                        appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                        AD_NEW = string.Concat(AD_NEW, appendInURL);
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Add("X-Version", "1");
                        client.DefaultRequestHeaders.Add("Accept", "*/*");
                        client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                        HttpResponseMessage ResultFromIMD = null;
                        try
                        {
                            _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value);
                            ResultFromIMD = await client.GetAsync(AD_NEW);
                            _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                        }
                        catch (Exception ex)
                        {
                            _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += ex.Message;
                            continue;
                        }

                        if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                        {
                            _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += "No data found!";
                            continue;
                        }

                        var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                        _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value);
                        if (IMDResponse != null)
                        {
                            string[] arr = IMDResponse.Split('[');
                            string temp = "[";
                            for (int j = 1; j < arr.Length; j++)
                            {
                                temp += arr[j];
                            }
                            var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                            foreach (var item in objresponse)
                            {
                                ObjDetails = new CropAdvisoryDetails
                                {
                                    CropID = Convert.ToInt32(item.type_id),
                                    StateID = Convert.ToInt32(item.state_id),
                                    DistrictID = Convert.ToInt32(item.district_id),
                                    BlockID = Convert.ToInt32(item.block_id),
                                    Block = item.block_name,
                                    CategoryID = Convert.ToInt32(item.cat_id),
                                    BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                    BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                    Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                    RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                    WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                    WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                    AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                    AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                    PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                    RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                    Title = item.crop_name,
                                    YouTubeLink = "",
                                    DistrictList = "",
                                    BlockList = "",
                                    AsdList = "",
                                    LanguageId = 2,
                                    D1 = false,
                                    D2 = false,
                                    D3 = false,
                                    D4 = false,
                                    D5 = false,
                                    CropAdvisoryID = 0,
                                    CAMID = 0,
                                    ScientistID = 0,
                                    Createdby = 0,
                                    Updatedby = 0,
                                    CreatedDate = Convert.ToString(item.custom_date),
                                    RecordDate = todayDate,
                                    VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                    VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                };
                                if (item.custom_date != "")
                                {
                                    ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    ObjDetails.PeriodEndDate = "";
                                }
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                if (ObjDetails.BlockID != 0)
                                {
                                    block = new CropAdvisoryBlock
                                    {
                                        DistrictID = ObjDetails.DistrictID,
                                        BlockID = ObjDetails.BlockID,
                                        BlockName = ObjDetails.Block
                                    };
                                    ObjDetails.ObjBlockList.Add(block);
                                }
                                else
                                {
                                    ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                }

                                ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value);
                                responsemaster = SaveCropAdvisoryMasters(ObjDetails,true);
                                _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value);
                                if (responsemaster.IsSuccessful)
                                {
                                    if (responsemaster.NewID > 0)
                                    {
                                        ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                        _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value);
                                        response = SaveCropAdvisory(ObjDetails);
                                        _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value);
                                        if (response.IsSuccessful == false)
                                        {
                                            str += response.ErrorMessage;
                                        }
                                    }
                                }
                                else
                                {
                                    str += response.ErrorMessage;
                                }
                            }
                            str += "Data saved successfully!";
                            _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId6_10FromIMD  Crop advisory for station id : " + value);
                        }
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId6_10FromIMD  Crop advisory : " + ex.Message);
                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async  Task<string> GetAdvisoryByStateId11_15FromIMDBlock()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId11_15FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            CropAdvisoryBlock block = new CropAdvisoryBlock();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] { 11, 12, 13, 14, 15 };
                foreach (var value in values)
                {
                    var districts = Masters.GetDistrictMasterList(new DistrictMaster()
                    {
                        StateID = value,
                        LanguageType = "English",
                        RefreshDateTime = todayDate
                    });
                    foreach (DistrictMaster dis in districts.ObjDistrictMasterList)
                    {
                        //appendInURL = string.Concat(todayDate, '/', i);
                        appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                        AD_NEW = string.Concat(AD_NEW, appendInURL);
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Add("X-Version", "1");
                        client.DefaultRequestHeaders.Add("Accept", "*/*");
                        client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                        HttpResponseMessage ResultFromIMD = null;
                        try
                        {
                            _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value);
                            ResultFromIMD = await client.GetAsync(AD_NEW);
                            _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                        }
                        catch (Exception ex)
                        {
                            _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += ex.Message;
                            continue;
                        }

                        if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                        {
                            _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += "No data found!";
                            continue;
                        }

                        var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                        _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value);
                        if (IMDResponse != null)
                        {
                            string[] arr = IMDResponse.Split('[');
                            string temp = "[";
                            for (int j = 1; j < arr.Length; j++)
                            {
                                temp += arr[j];
                            }
                            var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                            foreach (var item in objresponse)
                            {
                                ObjDetails = new CropAdvisoryDetails
                                {
                                    CropID = Convert.ToInt32(item.type_id),
                                    StateID = Convert.ToInt32(item.state_id),
                                    DistrictID = Convert.ToInt32(item.district_id),
                                    BlockID = Convert.ToInt32(item.block_id),
                                    Block = item.block_name,
                                    CategoryID = Convert.ToInt32(item.cat_id),
                                    BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                    BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                    Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                    RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                    WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                    WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                    AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                    AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                    PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                    RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                    Title = item.crop_name,
                                    YouTubeLink = "",
                                    DistrictList = "",
                                    BlockList = "",
                                    AsdList = "",
                                    LanguageId = 2,
                                    D1 = false,
                                    D2 = false,
                                    D3 = false,
                                    D4 = false,
                                    D5 = false,
                                    CropAdvisoryID = 0,
                                    CAMID = 0,
                                    ScientistID = 0,
                                    Createdby = 0,
                                    Updatedby = 0,
                                    CreatedDate = Convert.ToString(item.custom_date),
                                    RecordDate = todayDate,
                                    VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                    VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                };
                                if (item.custom_date != "")
                                {
                                    ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    ObjDetails.PeriodEndDate = "";
                                }
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                if (ObjDetails.BlockID != 0)
                                {
                                    block = new CropAdvisoryBlock
                                    {
                                        DistrictID = ObjDetails.DistrictID,
                                        BlockID = ObjDetails.BlockID,
                                        BlockName = ObjDetails.Block
                                    };
                                    ObjDetails.ObjBlockList.Add(block);
                                }
                                else
                                {
                                    ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                }

                                ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value);
                                responsemaster = SaveCropAdvisoryMasters(ObjDetails,true);
                                _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value);
                                if (responsemaster.IsSuccessful)
                                {
                                    if (responsemaster.NewID > 0)
                                    {
                                        ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                        _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value);
                                        response = SaveCropAdvisory(ObjDetails);
                                        _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value);
                                        if (response.IsSuccessful == false)
                                        {
                                            str += response.ErrorMessage;
                                        }
                                    }
                                }
                                else
                                {
                                    str += response.ErrorMessage;
                                }
                            }
                            str += "Data saved successfully!";
                            _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + value);
                        }
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId11_15FromIMD  Crop advisory for station id : " + ex.Message);
                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId16_20FromIMDBlock()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId16_20FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            CropAdvisoryBlock block = new CropAdvisoryBlock();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] { 16, 17, 18, 19, 20 };
                foreach (var value in values)
                {
                    var districts = Masters.GetDistrictMasterList(new DistrictMaster()
                    {
                        StateID = value,
                        LanguageType = "English",
                        RefreshDateTime = todayDate
                    });
                    foreach (DistrictMaster dis in districts.ObjDistrictMasterList)
                    {
                        //appendInURL = string.Concat(todayDate, '/', i);
                        appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                        AD_NEW = string.Concat(AD_NEW, appendInURL);
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Add("X-Version", "1");
                        client.DefaultRequestHeaders.Add("Accept", "*/*");
                        client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                        HttpResponseMessage ResultFromIMD = null;
                        try
                        {
                            _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value);
                            ResultFromIMD = await client.GetAsync(AD_NEW);
                            _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                        }
                        catch (Exception ex)
                        {
                            _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += ex.Message;
                            continue;
                        }

                        if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                        {
                            _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += "No data found!";
                            continue;
                        }

                        var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                        _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value);
                        if (IMDResponse != null)
                        {
                            string[] arr = IMDResponse.Split('[');
                            string temp = "[";
                            for (int j = 1; j < arr.Length; j++)
                            {
                                temp += arr[j];
                            }
                            var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                            foreach (var item in objresponse)
                            {
                                ObjDetails = new CropAdvisoryDetails
                                {
                                    CropID = Convert.ToInt32(item.type_id),
                                    StateID = Convert.ToInt32(item.state_id),
                                    DistrictID = Convert.ToInt32(item.district_id),
                                    BlockID = Convert.ToInt32(item.block_id),
                                    Block = item.block_name,
                                    CategoryID = Convert.ToInt32(item.cat_id),
                                    BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                    BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                    Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                    RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                    WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                    WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                    AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                    AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                    PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                    RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                    Title = item.crop_name,
                                    YouTubeLink = "",
                                    DistrictList = "",
                                    BlockList = "",
                                    AsdList = "",
                                    LanguageId = 2,
                                    D1 = false,
                                    D2 = false,
                                    D3 = false,
                                    D4 = false,
                                    D5 = false,
                                    CropAdvisoryID = 0,
                                    CAMID = 0,
                                    ScientistID = 0,
                                    Createdby = 0,
                                    Updatedby = 0,
                                    CreatedDate = Convert.ToString(item.custom_date),
                                    RecordDate = todayDate,
                                    VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                    VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                };
                                if (item.custom_date != "")
                                {
                                    ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    ObjDetails.PeriodEndDate = "";
                                }
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                if (ObjDetails.BlockID != 0)
                                {
                                    block = new CropAdvisoryBlock
                                    {
                                        DistrictID = ObjDetails.DistrictID,
                                        BlockID = ObjDetails.BlockID,
                                        BlockName = ObjDetails.Block
                                    };
                                    ObjDetails.ObjBlockList.Add(block);
                                }
                                else
                                {
                                    ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                }

                                ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value);
                                responsemaster = SaveCropAdvisoryMasters(ObjDetails,true);
                                _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value);
                                if (responsemaster.IsSuccessful)
                                {
                                    if (responsemaster.NewID > 0)
                                    {
                                        ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                        _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value);
                                        response = SaveCropAdvisory(ObjDetails);
                                        _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value);
                                        if (response.IsSuccessful == false)
                                        {
                                            str += response.ErrorMessage;
                                        }
                                    }
                                }
                                else
                                {
                                    str += response.ErrorMessage;
                                }
                            }
                            str += "Data saved successfully!";
                            _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + value);
                        }
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId16_20FromIMD  Crop advisory for station id : " + ex.Message);
                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId21_25FromIMDBlock()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId21_25FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            CropAdvisoryBlock block = new CropAdvisoryBlock();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] { 21,22,23,25,24 };                
                foreach (var value in values)
                {
                    var districts = Masters.GetDistrictMasterList(new DistrictMaster()
                    {
                        StateID = value,
                        LanguageType = "English",
                        RefreshDateTime = todayDate
                    });
                    foreach (DistrictMaster dis in districts.ObjDistrictMasterList)
                    {
                        //appendInURL = string.Concat(todayDate, '/', i);
                        appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                        AD_NEW = string.Concat(AD_NEW, appendInURL);
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Add("X-Version", "1");
                        client.DefaultRequestHeaders.Add("Accept", "*/*");
                        client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                        HttpResponseMessage ResultFromIMD = null;
                        try
                        {
                            _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                            ResultFromIMD = await client.GetAsync(AD_NEW);
                            _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                        }
                        catch (Exception ex)
                        {
                            _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += ex.Message;
                            continue;
                        }

                        if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                        {
                            _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += "No data found!";
                            continue;
                        }

                        var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                        _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                        if (IMDResponse != null)
                        {
                            string[] arr = IMDResponse.Split('[');
                            string temp = "[";
                            for (int j = 1; j < arr.Length; j++)
                            {
                                temp += arr[j];
                            }
                            var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                            foreach (var item in objresponse)
                            {
                                ObjDetails = new CropAdvisoryDetails
                                {
                                    CropID = Convert.ToInt32(item.type_id),
                                    StateID = Convert.ToInt32(item.state_id),
                                    DistrictID = Convert.ToInt32(item.district_id),
                                    BlockID = Convert.ToInt32(item.block_id),
                                    Block = item.block_name,
                                    CategoryID = Convert.ToInt32(item.cat_id),
                                    BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                    BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                    Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                    RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                    WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                    WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                    AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                    AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                    PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                    RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                    Title = item.crop_name,
                                    YouTubeLink = "",
                                    DistrictList = "",
                                    BlockList = "",
                                    AsdList = "",
                                    LanguageId = 2,
                                    D1 = false,
                                    D2 = false,
                                    D3 = false,
                                    D4 = false,
                                    D5 = false,
                                    CropAdvisoryID = 0,
                                    CAMID = 0,
                                    ScientistID = 0,
                                    Createdby = 0,
                                    Updatedby = 0,
                                    CreatedDate = Convert.ToString(item.custom_date),
                                    RecordDate = todayDate,
                                    VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                    VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                };
                                if (item.custom_date != "")
                                {
                                    ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    ObjDetails.PeriodEndDate = "";
                                }
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                if (ObjDetails.BlockID != 0)
                                {
                                    block = new CropAdvisoryBlock
                                    {
                                        DistrictID = ObjDetails.DistrictID,
                                        BlockID = ObjDetails.BlockID,
                                        BlockName = ObjDetails.Block
                                    };
                                    ObjDetails.ObjBlockList.Add(block);
                                }
                                else
                                {
                                    ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                }

                                ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                responsemaster = SaveCropAdvisoryMasters(ObjDetails,true);
                                _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                if (responsemaster.IsSuccessful)
                                {
                                    if (responsemaster.NewID > 0)
                                    {
                                        ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                        _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                        response = SaveCropAdvisory(ObjDetails);
                                        _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                        if (response.IsSuccessful == false)
                                        {
                                            str += response.ErrorMessage;
                                        }
                                    }
                                }
                                else
                                {
                                    str += response.ErrorMessage;
                                }
                            }
                            str += "Data saved successfully!";
                            _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                        }
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId21_25FromIMD  Crop advisory : " + ex.Message);
                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId26_30FromIMDBlock()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId26_30FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            CropAdvisoryBlock block = new CropAdvisoryBlock();
            CropAdvisoryAsd asd = new CropAdvisoryAsd();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] {  26, 27, 28, 29, 30 };
                foreach(var value in values)                                    
                //for (int i = 26; i <= 30; i++)
               {
                    var districts = Masters.GetDistrictMasterList(new DistrictMaster()
                    {
                        StateID = value,
                        LanguageType = "English",
                        RefreshDateTime = todayDate
                    }) ;
                    foreach (DistrictMaster dis in districts.ObjDistrictMasterList)
                    {
                        if (value == 28)
                        {
                            
                                //appendInURL = string.Concat(todayDate, '/', i);
                                appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                                AD_NEWASD = string.Concat(AD_NEWASD, appendInURL);
                                HttpClient client = new HttpClient();
                                client.DefaultRequestHeaders.Add("X-Version", "1");
                                client.DefaultRequestHeaders.Add("Accept", "*/*");
                                client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                                HttpResponseMessage ResultFromIMD = null;
                                try
                                {
                                    _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    ResultFromIMD = await client.GetAsync(AD_NEWASD);
                                    _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    AD_NEWASD = AD_NEWASD.Replace(appendInURL, string.Empty);
                                }
                                catch (Exception ex)
                                {
                                    _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                                    AD_NEWASD = AD_NEWASD.Replace(appendInURL, string.Empty);
                                    str += ex.Message;
                                    continue;
                                }

                                if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                                {
                                    _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    AD_NEWASD = AD_NEWASD.Replace(appendInURL, string.Empty);
                                    str += "No data found!";
                                    continue;
                                }
                                var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                                _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                if (IMDResponse != null)
                                {
                                    string[] arr = IMDResponse.Split('[');
                                    string temp = "[";
                                    for (int j = 1; j < arr.Length; j++)
                                    {
                                        temp += arr[j];
                                    }
                                    var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                                    foreach (var item in objresponse)
                                    {
                                        ObjDetails = new CropAdvisoryDetails
                                        {
                                            CropID = Convert.ToInt32(item.type_id),
                                            StateID = Convert.ToInt32(item.state_id),
                                            DistrictID = Convert.ToInt32(item.district_id),
                                            AsdID = Convert.ToInt32(item.asd_id),
                                            AsdName = Convert.ToString(item.asd_name),
                                            CategoryID = Convert.ToInt32(item.cat_id),
                                            BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                            BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                            Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                            RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                            WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                            WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                            AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                            AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                            PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                            RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                            Title = item.crop_name,
                                            YouTubeLink = "",
                                            DistrictList = "",
                                            BlockList = "",
                                            AsdList = "",
                                            LanguageId = 2,
                                            D1 = false,
                                            D2 = false,
                                            D3 = false,
                                            D4 = false,
                                            D5 = false,
                                            CropAdvisoryID = 0,
                                            CAMID = 0,
                                            ScientistID = 0,
                                            Createdby = 0,
                                            Updatedby = 0,
                                            CreatedDate = Convert.ToString(item.custom_date),
                                            RecordDate = todayDate,
                                            VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                            VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                        };
                                        if (item.custom_date != "")
                                        {
                                            ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                        }
                                        else
                                        {
                                            ObjDetails.PeriodEndDate = "";
                                        }
                                        ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                        if (ObjDetails.AsdID != 0)
                                        {
                                            asd = new CropAdvisoryAsd
                                            {
                                                DistrictID = ObjDetails.DistrictID,
                                                AsdID = ObjDetails.AsdID,
                                                AsdName = ObjDetails.AsdName
                                            };
                                            ObjDetails.ObjAsdList.Add(asd);
                                        }
                                        else
                                        {
                                            ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                        }

                                        ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                        ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                        _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                        responsemaster = SaveCropAdvisoryMasters(ObjDetails, true);
                                        _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                        if (responsemaster.IsSuccessful)
                                        {
                                            if (responsemaster.NewID > 0)
                                            {
                                                ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                                _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                                response = SaveCropAdvisory(ObjDetails);
                                                _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                                if (response.IsSuccessful == false)
                                                {
                                                    str += response.ErrorMessage;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            str += response.ErrorMessage;
                                        }
                                        str += "Data saved successfully!";
                                        _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);

                                    }
                                }
                            
                        }
                        else
                        {
                            //appendInURL = string.Concat(todayDate, '/', i);
                            appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                            AD_NEW = string.Concat(AD_NEW, appendInURL);
                            HttpClient client = new HttpClient();
                            client.DefaultRequestHeaders.Add("X-Version", "1");
                            client.DefaultRequestHeaders.Add("Accept", "*/*");
                            client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                            HttpResponseMessage ResultFromIMD = null;
                            try
                            {
                                _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                ResultFromIMD = await client.GetAsync(AD_NEW);
                                _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            }
                            catch (Exception ex)
                            {
                                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                                str += ex.Message;
                                continue;
                            }

                            if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                            {
                                _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                                str += "No data found!";
                                continue;
                            }
                            var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                            _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                            if (IMDResponse != null)
                            {
                                string[] arr = IMDResponse.Split('[');
                                string temp = "[";
                                for (int j = 1; j < arr.Length; j++)
                                {
                                    temp += arr[j];
                                }
                                var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                                foreach (var item in objresponse)
                                {
                                    ObjDetails = new CropAdvisoryDetails
                                    {
                                        CropID = Convert.ToInt32(item.type_id),
                                        StateID = Convert.ToInt32(item.state_id),
                                        DistrictID = Convert.ToInt32(item.district_id),
                                        BlockID = Convert.ToInt32(item.block_id),
                                        Block = item.block_name,
                                        CategoryID = Convert.ToInt32(item.cat_id),
                                        BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                        BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                        Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                        RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                        WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                        WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                        AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                        AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                        PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                        RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                        Title = item.crop_name,
                                        YouTubeLink = "",
                                        DistrictList = "",
                                        BlockList = "",
                                        AsdList = "",
                                        LanguageId = 2,
                                        D1 = false,
                                        D2 = false,
                                        D3 = false,
                                        D4 = false,
                                        D5 = false,
                                        CropAdvisoryID = 0,
                                        CAMID = 0,
                                        ScientistID = 0,
                                        Createdby = 0,
                                        Updatedby = 0,
                                        CreatedDate = Convert.ToString(item.custom_date),
                                        RecordDate = todayDate,
                                        VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                        VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                    };
                                    if (item.custom_date != "")
                                    {
                                        ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                    }
                                    else
                                    {
                                        ObjDetails.PeriodEndDate = "";
                                    }
                                    ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                    if (ObjDetails.BlockID != 0)
                                    {
                                        block = new CropAdvisoryBlock
                                        {
                                            DistrictID = ObjDetails.DistrictID,
                                            BlockID = ObjDetails.BlockID,
                                            BlockName = ObjDetails.Block
                                        };
                                        ObjDetails.ObjBlockList.Add(block);
                                    }
                                    else
                                    {
                                        ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                    }

                                    ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                    ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    responsemaster = SaveCropAdvisoryMasters(ObjDetails,true);
                                    _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    if (responsemaster.IsSuccessful)
                                    {
                                        if (responsemaster.NewID > 0)
                                        {
                                            ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                            _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                            response = SaveCropAdvisory(ObjDetails);
                                            _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                            if (response.IsSuccessful == false)
                                            {
                                                str += response.ErrorMessage;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                                str += "Data saved successfully!";
                                _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                            }
                        }
                    }
                }
                
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId26_30FromIMD  Crop advisory :" + ex.Message);
                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async  Task<string> GetAdvisoryByStateId31_35FromIMDBlock()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId31_35FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            CropAdvisoryBlock block = new CropAdvisoryBlock();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] { 31, 32, 33, 34, 35 };
                foreach (var value in values)
                {
                    var districts = Masters.GetDistrictMasterList(new DistrictMaster()
                    {
                        StateID = value,
                        LanguageType = "English",
                        RefreshDateTime = todayDate
                    });
                    foreach (DistrictMaster dis in districts.ObjDistrictMasterList)
                    {
                        //appendInURL = string.Concat(todayDate, '/', i);
                        appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                        AD_NEW = string.Concat(AD_NEW, appendInURL);
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Add("X-Version", "1");
                        client.DefaultRequestHeaders.Add("Accept", "*/*");
                        client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                        HttpResponseMessage ResultFromIMD = null;
                        try
                        {
                            _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value);
                            ResultFromIMD = await client.GetAsync(AD_NEW);
                            _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                        }
                        catch (Exception ex)
                        {
                            _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += ex.Message;
                            continue;
                        }

                        if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                        {
                            _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value);
                            AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            str += "No data found!";
                            continue;
                        }

                        var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                        _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value);
                        if (IMDResponse != null)
                        {
                            string[] arr = IMDResponse.Split('[');
                            string temp = "[";
                            for (int j = 1; j < arr.Length; j++)
                            {
                                temp += arr[j];
                            }
                            var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                            foreach (var item in objresponse)
                            {
                                ObjDetails = new CropAdvisoryDetails
                                {
                                    CropID = Convert.ToInt32(item.type_id),
                                    StateID = Convert.ToInt32(item.state_id),
                                    DistrictID = Convert.ToInt32(item.district_id),
                                    BlockID = Convert.ToInt32(item.block_id),
                                    Block = item.block_name,
                                    CategoryID = Convert.ToInt32(item.cat_id),
                                    BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                    BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                    Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                    RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                    WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                    WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                    AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                    AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                    PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                    RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                    Title = item.crop_name,
                                    YouTubeLink = "",
                                    DistrictList = "",
                                    BlockList = "",
                                    AsdList = "",
                                    LanguageId = 2,
                                    D1 = false,
                                    D2 = false,
                                    D3 = false,
                                    D4 = false,
                                    D5 = false,
                                    CropAdvisoryID = 0,
                                    CAMID = 0,
                                    ScientistID = 0,
                                    Createdby = 0,
                                    Updatedby = 0,
                                    CreatedDate = Convert.ToString(item.custom_date),
                                    RecordDate = todayDate,
                                    VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                    VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                };
                                if (item.custom_date != "")
                                {
                                    ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    ObjDetails.PeriodEndDate = "";
                                }
                                ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                if (ObjDetails.BlockID != 0)
                                {
                                    block = new CropAdvisoryBlock
                                    {
                                        DistrictID = ObjDetails.DistrictID,
                                        BlockID = ObjDetails.BlockID,
                                        BlockName = ObjDetails.Block
                                    };
                                    ObjDetails.ObjBlockList.Add(block);
                                }
                                else
                                {
                                    ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                }

                                ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value);
                                responsemaster = SaveCropAdvisoryMasters(ObjDetails,true);
                                _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value);
                                if (responsemaster.IsSuccessful)
                                {
                                    if (responsemaster.NewID > 0)
                                    {
                                        ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                        _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value);
                                        response = SaveCropAdvisory(ObjDetails);
                                        _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value);
                                        if (response.IsSuccessful == false)
                                        {
                                            str += response.ErrorMessage;
                                        }
                                    }
                                }
                                else
                                {
                                    str += response.ErrorMessage;
                                }
                            }
                            str += "Data saved successfully!";
                            _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId31_35FromIMD  Crop advisory for station id : " + value);
                        }
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);
            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId31_35FromIMD  Crop advisory : " + ex.Message);
                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message, ex);
            }
            return str;
        }

        public static async Task<string> GetAdvisoryByStateId36_37FromIMDBlock()
        {
            #region Log Start

            string methodName = "GetAdvisoryByStateId36_37FromIMD";
            string callId = Guid.NewGuid().ToString();
            DateTime startTime = DateTime.Now;

            LogCallStart(callId, methodName, startTime);

            #endregion Log Start

            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            CropAdvisoryBlock block = new CropAdvisoryBlock(); 
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            var todayDate = DateTime.Now.AddHours(-10).ToString("yyyy-MM-dd");
            var appendInURL = "";
            try
            {
                todayDate = GlobalConstant.IsReRunFlow == true ? GlobalConstant.ReRunDate : todayDate;
                var values = new int[] { 36, 37};
                foreach (var value in values)
                {
                    var districts = Masters.GetDistrictMasterList(new DistrictMaster()
                    {
                        StateID = value,
                        LanguageType = "English",
                        RefreshDateTime = todayDate
                    });
                    foreach (DistrictMaster dis in districts.ObjDistrictMasterList)
                    {
                        if (value == 36)
                        {
                            //appendInURL = string.Concat(todayDate, '/', i);
                            appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                            AD_NEWASD = string.Concat(AD_NEWASD, appendInURL);
                            HttpClient client = new HttpClient();
                            client.DefaultRequestHeaders.Add("X-Version", "1");
                            client.DefaultRequestHeaders.Add("Accept", "*/*");
                            client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                            HttpResponseMessage ResultFromIMD = null;
                            try
                            {
                                _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                ResultFromIMD = await client.GetAsync(AD_NEWASD);
                                _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                AD_NEWASD = AD_NEWASD.Replace(appendInURL, string.Empty);
                            }
                            catch (Exception ex)
                            {
                                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                                AD_NEWASD = AD_NEWASD.Replace(appendInURL, string.Empty);
                                str += ex.Message;
                                continue;
                            }

                            if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                            {
                                _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                AD_NEWASD = AD_NEWASD.Replace(appendInURL, string.Empty);
                                str += "No data found!";
                                continue;
                            }
                            var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                            _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                            if (IMDResponse != null)
                            {
                                string[] arr = IMDResponse.Split('[');
                                string temp = "[";
                                for (int j = 1; j < arr.Length; j++)
                                {
                                    temp += arr[j];
                                }
                                var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                                foreach (var item in objresponse)
                                {
                                    ObjDetails = new CropAdvisoryDetails
                                    {
                                        CropID = Convert.ToInt32(item.type_id),
                                        StateID = Convert.ToInt32(item.state_id),
                                        DistrictID = Convert.ToInt32(item.district_id),
                                        AsdID = Convert.ToInt32(item.asd_id),
                                        AsdName = Convert.ToString(item.asd_name),
                                        CategoryID = Convert.ToInt32(item.cat_id),
                                        BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                        BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                        Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                        RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                        WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                        WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                        AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                        AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                        PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                        RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                        Title = item.crop_name,
                                        YouTubeLink = "",
                                        DistrictList = "",
                                        BlockList = "",
                                        AsdList = "",
                                        LanguageId = 2,
                                        D1 = false,
                                        D2 = false,
                                        D3 = false,
                                        D4 = false,
                                        D5 = false,
                                        CropAdvisoryID = 0,
                                        CAMID = 0,
                                        ScientistID = 0,
                                        Createdby = 0,
                                        Updatedby = 0,
                                        CreatedDate = Convert.ToString(item.custom_date),
                                        RecordDate = todayDate,
                                        VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                        VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                    };
                                    if (item.custom_date != "")
                                    {
                                        ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                    }
                                    else
                                    {
                                        ObjDetails.PeriodEndDate = "";
                                    }
                                    ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                    if (ObjDetails.AsdID != 0)
                                    {
                                        CropAdvisoryAsd asd = new CropAdvisoryAsd
                                        {
                                            DistrictID = ObjDetails.DistrictID,
                                            AsdID = ObjDetails.AsdID,
                                            AsdName = ObjDetails.AsdName
                                        };
                                        ObjDetails.ObjAsdList.Add(asd);
                                    }
                                    else
                                    {
                                        ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                    }

                                    ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                    ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    responsemaster = SaveCropAdvisoryMasters(ObjDetails, true);
                                    _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    if (responsemaster.IsSuccessful)
                                    {
                                        if (responsemaster.NewID > 0)
                                        {
                                            ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                            _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                            response = SaveCropAdvisory(ObjDetails);
                                            _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                            if (response.IsSuccessful == false)
                                            {
                                                str += response.ErrorMessage;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        str += response.ErrorMessage;
                                    }
                                    str += "Data saved successfully!";
                                    _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);

                                }
                            }

                        }
                        else
                        {
                            //appendInURL = string.Concat(todayDate, '/', i);
                            appendInURL = string.Concat(todayDate, '/', dis.DistrictID);
                            AD_NEW = string.Concat(AD_NEW, appendInURL);
                            HttpClient client = new HttpClient();
                            client.DefaultRequestHeaders.Add("X-Version", "1");
                            client.DefaultRequestHeaders.Add("Accept", "*/*");
                            client.Timeout = TimeSpan.FromMinutes(GlobalConstant.IMDServiceTimeOut);
                            HttpResponseMessage ResultFromIMD = null;
                            try
                            {
                                _log.Info("Callid : " + callId + " calling IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                ResultFromIMD = await client.GetAsync(AD_NEW);
                                _log.Info("Callid : " + callId + " called IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                            }
                            catch (Exception ex)
                            {
                                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value + " " + ex.Message);
                                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                                str += ex.Message;
                                continue;
                            }

                            if (ResultFromIMD == null || !ResultFromIMD.IsSuccessStatusCode)
                            {
                                _log.Info("Callid : " + callId + " No date from IMD Service of  GetAdvisoryByStateId21_25FromIMD  Crop advisory for station id : " + value);
                                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                                str += "No data found!";
                                continue;
                            }
                            var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                            _log.Info("Callid : " + callId + " get data from IMD Service of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                            if (IMDResponse != null)
                            {
                                string[] arr = IMDResponse.Split('[');
                                string temp = "[";
                                for (int j = 1; j < arr.Length; j++)
                                {
                                    temp += arr[j];
                                }
                                var objresponse = JsonConvert.DeserializeObject<List<AdvisoryFromIMD>>(temp);
                                foreach (var item in objresponse)
                                {
                                    ObjDetails = new CropAdvisoryDetails
                                    {
                                        CropID = Convert.ToInt32(item.type_id),
                                        StateID = Convert.ToInt32(item.state_id),
                                        DistrictID = Convert.ToInt32(item.district_id),
                                        BlockID = Convert.ToInt32(item.block_id),
                                        Block = item.block_name,
                                        CategoryID = Convert.ToInt32(item.cat_id),
                                        BriefText = item.sms_eng == null ? "" : Convert.ToString(item.sms_eng),
                                        BriefTextRegional = item.sms_reg == null ? "" : Convert.ToString(item.sms_reg),
                                        Recommendations = item.advisory_eng == null ? "" : Convert.ToString(item.advisory_eng),
                                        RecommendationsRegional = item.advisory_reg == null ? "" : Convert.ToString(item.advisory_reg),
                                        WeatherCondition = item.weather_summary_eng == null ? "" : Convert.ToString(item.weather_summary_eng),
                                        WeatherConditionRegional = item.weather_summary_reg == null ? "" : Convert.ToString(item.weather_summary_reg),
                                        AgroAdvisoryDetails = item.general_advisory_eng == null ? "" : Convert.ToString(item.general_advisory_eng),
                                        AgroAdvisoryDetailsRegional = item.general_advisory_reg == null ? "" : Convert.ToString(item.general_advisory_reg),
                                        PeriodStartDate = item.custom_date == null ? "" : Convert.ToString(item.custom_date),
                                        RegionalLanguage = Convert.ToString(item.reg_lang_name),
                                        Title = item.crop_name,
                                        YouTubeLink = "",
                                        DistrictList = "",
                                        BlockList = "",
                                        AsdList = "",
                                        LanguageId = 2,
                                        D1 = false,
                                        D2 = false,
                                        D3 = false,
                                        D4 = false,
                                        D5 = false,
                                        CropAdvisoryID = 0,
                                        CAMID = 0,
                                        ScientistID = 0,
                                        Createdby = 0,
                                        Updatedby = 0,
                                        CreatedDate = Convert.ToString(item.custom_date),
                                        RecordDate = todayDate,
                                        VarietyName = item.variety_name == null ? "" : Convert.ToString(item.variety_name),
                                        VarietyId = (item.variety_id == null ? 0 : Convert.ToInt32(item.variety_id))
                                    };
                                    if (item.custom_date != "")
                                    {
                                        ObjDetails.PeriodEndDate = ((Convert.ToDateTime(item.custom_date)).AddDays(5)).ToString("yyyy-MM-dd");
                                    }
                                    else
                                    {
                                        ObjDetails.PeriodEndDate = "";
                                    }
                                    ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
                                    if (ObjDetails.BlockID != 0)
                                    {
                                        block = new CropAdvisoryBlock
                                        {
                                            DistrictID = ObjDetails.DistrictID,
                                            BlockID = ObjDetails.BlockID,
                                            BlockName = ObjDetails.Block
                                        };
                                        ObjDetails.ObjBlockList.Add(block);
                                    }
                                    else
                                    {
                                        ObjDetails.ObjBlockList = new List<CropAdvisoryBlock>();
                                    }

                                    ObjDetails.ObjCropList = new List<CropAdvisoryCrop>();
                                    ObjDetails.ObjCropAdvisoryImageList = new List<CropAdvisoryImage>();
                                    _log.Info("Callid : " + callId + " calling SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    responsemaster = SaveCropAdvisoryMasters(ObjDetails,true);
                                    _log.Info("Callid : " + callId + " called SaveCropAdvisoryMasters of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                    if (responsemaster.IsSuccessful)
                                    {
                                        if (responsemaster.NewID > 0)
                                        {
                                            ObjDetails.CAMID = Convert.ToInt32(responsemaster.NewID);
                                            _log.Info("Callid : " + callId + " calling SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                            response = SaveCropAdvisory(ObjDetails);
                                            _log.Info("Callid : " + callId + " called SaveCropAdvisory of  GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                                            if (response.IsSuccessful == false)
                                            {
                                                str += response.ErrorMessage;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        str += response.ErrorMessage;
                                    }
                                }
                                str += "Data saved successfully!";
                                _log.Info("Callid : " + callId + " completion of GetAdvisoryByStateId26_30FromIMD  Crop advisory for station id : " + value);
                            }
                        }
                    }
                }
                LogCallEnd(callId, methodName, DateTime.Now);

            }
            catch (Exception ex)
            {
                _log.Error("Callid : " + callId + " exception in GetAdvisoryByStateId36_37FromIMD  Crop advisory :" + ex.Message);
                AD_NEW = AD_NEW.Replace(appendInURL, string.Empty);
                str = ex.Message.ToString();
                LogCallEnd(callId, methodName, DateTime.Now, ex.Message,ex);
            }
            return str;
        }

        public static string SaveCropsInMasterIMD()
        {
            CropAdvisoryDetails ObjDetails = new CropAdvisoryDetails();
            TransactionDetails response = new TransactionDetails();
            TransactionDetails responsemaster = new TransactionDetails();
            AdvisoryFromIMD advisory = new AdvisoryFromIMD();
            CropAdvisoryDistrict district = new CropAdvisoryDistrict();
            ObjDetails.ObjDistrictList = new List<CropAdvisoryDistrict>();
            CropDetailsMaster cropDetailsMaster = new CropDetailsMaster();
            string str = "";
            try
            {                
                //var ResultFromIMD = new HttpClient().GetAsync(AD).Result;
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Version", "1");
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                var ResultFromIMD = client.GetAsync(MasterCrops).Result; 

                var IMDResponse = ResultFromIMD.Content.ReadAsStringAsync().Result;
                if (IMDResponse != null)
                {
                    string[] arr = IMDResponse.Split('[');
                    string temp = "[";
                    for (int j = 1; j < arr.Length; j++)
                    {
                        temp += arr[j];
                    }
                    var objresponse = JsonConvert.DeserializeObject<List<CropsNameFromIMD>>(temp);
                    foreach (var item in objresponse)
                    {                        
                        //ading crop to master table
                        cropDetailsMaster = new CropDetailsMaster
                        {
                            CategoryName = item.category_name,
                            CropID = Convert.ToInt32(item.crop_id),
                            CropCategoryID = Convert.ToInt32(item.cat_id),
                            CropName = item.crop_name,
                            Hindi = item.crop_name,
                            Telugu = item.crop_name,
                            Kannada = item.crop_name,
                            Marathi = item.crop_name,
                            Punjabi = item.crop_name,
                            Flag = false,
                            CreatedDate = DateTime.Now.ToString("yyyy-MM-dd"),
                            UpdatedDate = DateTime.Now.ToString("yyyy-MM-dd"),
                            Createdby = 0,
                            CropCode = item.crop_name,
                            Assamese = item.crop_name,
                            Gujarati = item.crop_name,
                            Oriya = item.crop_name,
                            Tamil = item.crop_name,
                            Malayalam = item.crop_name,
                            VarietyName = item.variety_name ?? "",
                            VarietyId = item.variety_id ?? ""
                        };

                        SqlParameter[] arrParams = new SqlParameter[] {
                                       new SqlParameter("@pCategoryName",cropDetailsMaster.CategoryName),
                                        new SqlParameter("@pCropID",cropDetailsMaster.CropID),
                                        new SqlParameter("@pCropCategoryID",cropDetailsMaster.CropCategoryID),
                                        new SqlParameter("@pCropName", cropDetailsMaster.CropName),
                                        new SqlParameter("@pHindi", cropDetailsMaster.Hindi),
                                        new SqlParameter("@pTelugu",cropDetailsMaster.Telugu),
                                        new SqlParameter("@pKannada",cropDetailsMaster.Kannada),
                                        new SqlParameter("@pMarathi",cropDetailsMaster.Marathi),
                                        new SqlParameter("@pPunjabi",cropDetailsMaster.Punjabi),
                                        new SqlParameter("@pFlag",cropDetailsMaster.Flag),
                                        new SqlParameter("@pCreatedDate",cropDetailsMaster.CreatedDate),
                                        new SqlParameter("@pUpdatedDate",cropDetailsMaster.UpdatedDate),
                                        new SqlParameter("@pCropCode",cropDetailsMaster.CropCode),
                                        new SqlParameter("@pAssamese",cropDetailsMaster.Assamese),
                                        new SqlParameter("@pGujarati",cropDetailsMaster.Gujarati),
                                        new SqlParameter("@pOriya",cropDetailsMaster.Oriya),
                                        new SqlParameter("@pTamil",cropDetailsMaster.Tamil),
                                        new SqlParameter("@pcreatedby",cropDetailsMaster.Createdby),
                                        new SqlParameter("@pMalayalam",cropDetailsMaster.Malayalam),
                                        new SqlParameter("@pVarietyName",cropDetailsMaster.VarietyName),
                                        new SqlParameter("@pVarietyId",cropDetailsMaster.VarietyId)
                        };
                        response = SQLHelper.ExecuteOutIDParameter("spSave_CropDetailsMaster", arrParams);                                            
                    }
                    str += "Data saved successfully!";
                }
            }
            catch (Exception ex)
            {
                str = ex.Message.ToString();
            }
            return str;
        }

        public static TransactionDetails RemoveCropAdvisoryFavouriteList(CropAdvisoryFavourites objFavourites)
        {
            TransactionDetails response = new TransactionDetails();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pCropAdvisoryID",objFavourites.CropAdvisoryID),
                   new SqlParameter("@pUserProfileID",objFavourites.UserProfileID)
                };
                response = SQLHelper.ExecuteOutIDParameter("spDelete_CropAdvisoryFavouriteList", arrParams);
                response.IsSuccessful = response.IsSuccessful;
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        #endregion



        #region Save Crop Images in Master CropImage
        public static TransactionDetails SaveCropImageInMater(CropImageForMasterTable objImage)
        {
            TransactionDetails response = new TransactionDetails();
            DocumentInfo objDocumentInfo = new DocumentInfo();
            var objDocumentResponse = new GetDocumentResponse();

            if (objImage.ByteStream != null && objImage.ByteStream.Length > 0)
            {
                objDocumentInfo.ByteStream = objImage.ByteStream;
                objDocumentInfo.ContentType = objImage.Type;
                objDocumentResponse = Utilities.SaveImageUpload(objDocumentInfo);
                objImage.ImagePath = objDocumentResponse.LargeImgBlobURL;               
            }
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {                  
                   new SqlParameter("@pCropID",objImage.CropID),
                   new SqlParameter("@pCropImageURL",objImage.ImagePath),                                     
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropImagesForMaster", arrParams);                
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        #endregion


        public static TransactionDetails SaveCropImagePathInDB(CropImageForMasterTable objImage)
        {
            TransactionDetails response = new TransactionDetails();
                             
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pCropID",objImage.CropID),
                   new SqlParameter("@pCropImageURL",objImage.ImagePath),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_CropImagesForMaster", arrParams);
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

    #region "Model"
    public class RequestCropAdvisoryInput
    {
       public int stateId;
        public int distrctId;
        public DateTime startDate;
        public string endDate = "";
    }
    #endregion

}