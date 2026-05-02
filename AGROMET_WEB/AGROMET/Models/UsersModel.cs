using AGROMET.App_GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AGROMET.Models
{
    public class UsersModel
    {
        [Required(ErrorMessage = "Please select title")]
        public int TitleId { get; set; }
        [Required(ErrorMessage = "Please select department")]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please select state")]
        public int StateId { get; set; }
        [Required(ErrorMessage = "Please select district")]
        public int DistrictID { get; set; }
        [Required(ErrorMessage = "Please Select language")]
        public int LanguageId { get; set; }
        public int ScientistId { get; set; }
        [Required(ErrorMessage ="Please enter first name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter 10 digit mobile number")]
        public string MobileNumber { get; set; }
        public string DistrictList { get; set; }
        public string BlockList { get; set; }
        public string CropList { get; set; }
        public string Designation { get; set; }
        public string Institution { get; set; }
        public string Location { get; set; }
        public string PinCode { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please select gender")]
        public int GenderId { get; set; }
        public HttpPostedFileBase File { get; set; }
    }
    public class UsersDetails
    {
        public string GeoStatus { get; set; }
        public string LanguageType { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public string UserName { get; set; }
        public string LogInPassword { get; set; }
        public int RoleId { get; set; }
        public string RoleType { set; get; }
        public string TypeOfRole { set; get; }
        public string RoleName { get; set; }
        public string LogInId { get; set; }
        public int CreatedBy { get; set; }
        public string ImagePath { get; set; }
        public string RefreshDateTime { get; set; }
        public byte[] ThumbNailBytes { get; set; }
        public int StateID { get; set; }
        public int DistrictID { get; set; }
        public int BlockID { get; set; }
        public int VillageID { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string DepartmentName { get; set; }
        public string BlockName { get; set; }
        public string VillageName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int LanguageID { get; set; }
        public int DepartmentID { get; set; }
        public int TitleID { get; set; }
        public int GenderID { get; set; }
        public string LanguageName { get; set; }
        public string CultureCode { get; set; }
        public string DOB { get; set; }
        public string MobileNumber { get; set; }
        public string Institution { get; set; }
        public string Designation { get; set; }
        public string Location { get; set; }
        public string PinCode { get; set; }
        public string Email { get; set; }
        public string UserImagePath { get; set; }
        public string UserThumbnailImagePath { get; set; }
        public string UpdatedBy { get; set; }
    }
    public class UserBlock
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string BlockName { get; set; }
        public int BlockID { get; set; }
        public int DistrictID { get; set; }
        public int StateID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class GetUsersResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<UsersDetails> ObjUserList { get; set; }
        public List<UserProfile> ObjUserProfileList { get; set; }
        public List<UserBlock> ObjBlockList { get; set; }
        public GetUsersResponse()
        {
            this.ObjUserList = new List<UsersDetails>();
            this.ObjUserProfileList = new List<UserProfile>();
            this.ObjBlockList = new List<UserBlock>();
        }
    }
}