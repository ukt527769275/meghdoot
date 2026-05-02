using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AGROMET.Models
{
    public class LoginModel
    {
        [Display(Name = "Mobile Number")]
        public string SignInId { get; set; }
        [Display(Name = "PIN")]
        public string SignInPassword { get; set; }
        [Display(Name = "Email ID")]
        public string EmailID { get; set; }
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
        public string BlockName { get; set; }
        public string VillageName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
        public string CultureCode { get; set; }
    }
    public class LoginModelResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<LoginModel> ObjUserList { get; set; }

    }
}