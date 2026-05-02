using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGROMET.Models
{
    public class UserProfile
    {
        public string PhoneNumber { get; set; }
        public string ImageString { get; set; }
        public int UserProfileID { get; set; }
        public string UserName { get; set; }
        public string GenderName { get; set; }
        public string TitleName { get; set; }
        public string LanguageType { get; set; }
        public string LogInId { get; set; }
        public string ImagePath { get; set; }
        public string RefreshDateTime { get; set; }
        public byte[] ThumbNailBytes { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string BlockName { get; set; }
        public string VillageName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string LanguageName { get; set; }
        public string EmailID { get; set; }
    }
    public class UserProfileResponse{
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<UserProfile> ObjUserProfileList { get; set; }
        public UserProfileResponse()
        {
            this.ObjUserProfileList = new List<UserProfile>();
        }
    }
}