using System.Collections.Generic;
namespace AGROMET.MasterModels
{
    public class Masters
    {
    }
    public class TitleMaster
    {
        public int TitleID { get; set; }
        public string TitleName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class GenderMaster
    {
        public int GenderID { get; set; }
        public string GenderName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class LanguageMaster
    {
        public int LanguageTypeId { get; set; }
        public string LanguageTypeName { get; set; }
        public string RefreshDateTime { get; set; }
        public string Culture { get; set; }
    }

    public class StateMaster
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }

    }
    public class DistrictMaster
    {
        public int StateID { get; set; }
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }

    }
    public class BlockMaster
    {
        public int BlockID { get; set; }
        public int DistrictID { get; set; }
        public string BlockName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CropMaster
    {
        public int CropID { get; set; }
        public string CropName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class CropAdvisoryCategoryMaster
    {
        public int CACID { get; set; }
        public string CropAdvisoryCategory { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class DepartmentMaster
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class BlobMaster
    {
        public string Type { get; set; }
        public string AccountName { get; set; }
        public string AccountKey { get; set; }
        public string ContainerName { get; set; }
    }
    public class TransactionDetails
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public long NewID { get; set; }
        public string FileUrl { get; set; }

    }
    public class GetMasterResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<TitleMaster> ObjTitleMasterList { get; set; }
        public List<LanguageMaster> ObjLanguageTypeMasterList { set; get; }
        public List<GenderMaster> ObjGenderMasterList { get; set; }
        public List<StateMaster> ObjStateMasterList { get; set; }
        public List<DistrictMaster> ObjDistrictMasterList { get; set; }
        public List<BlockMaster> ObjBlockMasterList { get; set; }
        public List<CropMaster> ObjCropMasterList { get; set; }
        public List<CropAdvisoryCategoryMaster> ObjAdvisoryCategoryMasterList { get; set; }
        public List<DepartmentMaster> ObjDepartmentMasterList { get; set; }
        public List<BlobMaster> ObjBlobMasterList { get; set; }

        public GetMasterResponse()
        {
            this.ObjTitleMasterList = new List<TitleMaster>();
            this.ObjLanguageTypeMasterList = new List<LanguageMaster>();
            this.ObjGenderMasterList = new List<GenderMaster>();
            this.ObjStateMasterList = new List<StateMaster>();
            this.ObjDistrictMasterList = new List<DistrictMaster>();
            this.ObjBlockMasterList = new List<BlockMaster>();
            this.ObjCropMasterList = new List<CropMaster>();
            this.ObjAdvisoryCategoryMasterList = new List<CropAdvisoryCategoryMaster>();
            this.ObjDepartmentMasterList = new List<DepartmentMaster>();
            this.ObjBlobMasterList = new List<BlobMaster>();

        }
    }
}