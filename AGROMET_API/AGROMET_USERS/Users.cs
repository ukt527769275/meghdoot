using AGROMET_COMMON;
using AGROMET_DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace AGROMET_USERS
{
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
        public int AsdID { get; set; }
        public string AsdName { get; set; }
        public int VillageID { get; set; }
        public long ProfileId { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string DepartmentName { get; set; }
        public string BlockName { get; set; }
        public string VillageName { get; set; }
        public string PanchayatName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int LanguageID { get; set; }
        public int DepartmentID { get; set; }
        public int TitleID { get; set; }
        public int GenderID { get; set; }
        public string LanguageName { get; set; }
        public string Title { get; set; }
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
        public List<UserDistrict> ObjDistrictList { get; set; }
        public List<UserBlock> ObjBlockList { get; set; }
        public List<UserCrop> ObjCropList { get; set; }
        public UserImage ObjUserImage { get; set; }
        public UsersDetails()
        {
            this.ObjUserImage = new UserImage();
        }
    }
    public class UserProfile
    {
        public int UserProfileID { get; set; }
        public string UserName { get; set; }
        public string GenderName { get; set; }
        public string TitleName { get; set; }
        public string LanguageType { get; set; }
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
        public string PhoneNumber { get; set; }
        public string EmailID { get; set; }
        public string RoleType { set; get; }
    }
    public class UserLocations
    {
        public int UALID { get; set; }
        public int UserProfileID { get; set; }
        public int StateID { get; set; }
        public int DistrictID { get; set; }
        public int BlockID { get; set; }
        public int AsdID { get; set; }
        public string AsdName { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string BlockName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
    }

    public class UserProfileImageDetails
    {
        public int UserProfileID { get; set; }
        public string UserProfileImage { get; set; }
    }
    public class UserDistrict
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int DistrictID { get; set; }
        public string DistictName { get; set; }
        public int StateID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }

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
    public class UserCrop
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string CropName { get; set; }
        public int CropID { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class UserImage
    {
        public int ImagID { get; set; }
        public int UserID { get; set; }
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
    public class GetUsersResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<UsersDetails> ObjUserList { get; set; }
        public List<UserProfile> ObjUserProfileList { get; set; }
        public List<UserDistrict> ObjDistrictList { get; set; }
        public List<UserBlock> ObjBlockList { get; set; }
        public List<UserCrop> ObjCropList { get; set; }
        public List<UserLocations> ObjUserLocationsList { get; set; }
        public GetUsersResponse()
        {
            this.ObjUserList = new List<UsersDetails>();
            this.ObjUserProfileList = new List<UserProfile>();
            this.ObjDistrictList = new List<UserDistrict>();
            this.ObjBlockList = new List<UserBlock>();
            this.ObjCropList = new List<UserCrop>();
            this.ObjUserLocationsList = new List<UserLocations>();
        }
    }
    public class Users
    {
        public static string ProfileImageUrl = ConfigurationManager.AppSettings["ProfileImageUrl"].ToString();

        #region Save User login details
        public static TransactionDetails SaveUserLoginDetails(UsersDetails ObjDetails)
        {
            TransactionDetails response = new TransactionDetails();
            try
            {
                SqlParameter[] arrParamsone = new SqlParameter[] {
                                          new SqlParameter("@puserid",ObjDetails.UserId),
                                        new SqlParameter("@pFirstname",ObjDetails.FirstName),
                                        new SqlParameter("@pLastname",ObjDetails.LastName),
                                        new SqlParameter("@ploginid",ObjDetails.MobileNumber),
                                        //new SqlParameter("@ploginid",ObjDetails.LogInId),
                                        new SqlParameter("@ploginpassword","XVcATlld+Ok="),
                                        new SqlParameter("@pRoleType",ObjDetails.RoleType),
                                        new SqlParameter("@pProfileid",ObjDetails.ProfileId),
                                        new SqlParameter("@proleid",ObjDetails.RoleId),
                                        new SqlParameter("@pEmailid",ObjDetails.Email),
                                        new SqlParameter("@pcreatedby",ObjDetails.CreatedBy),
                                        new SqlParameter("@pupdatedby",ObjDetails.UpdatedBy),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_Users", arrParamsone);
                response.IsSuccessful = true;
            }

            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message.ToString();
            }
            return response;
        }
        #endregion

        #region Save Scientist
        public static TransactionDetails SaveScientist(UsersDetails ObjDetails)
        {
            TransactionDetails response = new TransactionDetails();
            if (GetVerifyUserName(ObjDetails))
            {
                TransactionDetails responseuser = new TransactionDetails();
                UserDistrict ObjDistrict = new UserDistrict();
                DocumentInfo objDocumentInfo = new DocumentInfo();
                GetDocumentResponse objDocumentResponse = new GetDocumentResponse();
                if (ObjDetails.ObjUserImage.ByteStream != null)
                {
                    if (ObjDetails.ObjUserImage.ByteStream.Length > 0)
                    {
                        objDocumentInfo.ByteStream = ObjDetails.ObjUserImage.ByteStream;
                        objDocumentResponse = Utilities.SaveImageUpload(objDocumentInfo);
                        ObjDetails.UserImagePath = objDocumentResponse.LargeImgBlobFileName;
                        ObjDetails.UserThumbnailImagePath = objDocumentResponse.ThumbnailImgBlobFileName;
                        ObjDetails.ThumbNailBytes = objDocumentResponse.ImageURl_bytes;
                    }
                    else
                    {
                        ObjDetails.UserImagePath = "";
                        ObjDetails.UserThumbnailImagePath = "";
                        ObjDetails.ThumbNailBytes = new byte[0];
                    }
                }
                else
                {
                    ObjDetails.UserImagePath = "";
                    ObjDetails.UserThumbnailImagePath = "";
                    ObjDetails.ThumbNailBytes = new byte[0];
                }

                try
                {
                    SqlParameter[] arrParams = new SqlParameter[] {
                                          new SqlParameter("@pScientistID",ObjDetails.UserId),
                                          new SqlParameter("@pRoleID",2),
                                        new SqlParameter("@pTitleId", ObjDetails.TitleID),
                                        new SqlParameter("@pGenderId",ObjDetails.GenderID),
                                        new SqlParameter("@pStateID",ObjDetails.StateID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pFirstname",ObjDetails.FirstName),
                                        new SqlParameter("@pLastname",ObjDetails.LastName),
                                        new SqlParameter("@pInstitution",ObjDetails.Institution),
                                        new SqlParameter("@pDesignation",ObjDetails.Designation),
                                        new SqlParameter("@pLocation",ObjDetails.Location),
                                        new SqlParameter("@pPinCode",ObjDetails.PinCode),
                                        new SqlParameter("@pLanguageID",ObjDetails.LanguageID),
                                        new SqlParameter("@pDepartmentID",ObjDetails.DepartmentID),
                                        new SqlParameter("@pImagePath",ObjDetails.UserImagePath),
                                        new SqlParameter("@pThumbnailImageName",ObjDetails.UserThumbnailImagePath),
                                        new SqlParameter("@pThumbnailBytes",ObjDetails.ThumbNailBytes),
                                        new SqlParameter("@pcreatedby",ObjDetails.CreatedBy),
                                        new SqlParameter("@pupdatedby",ObjDetails.UpdatedBy),
                };
                    response = SQLHelper.ExecuteOutIDParameter("spSave_ScientistProfileDetails", arrParams);
                    if (response.IsSuccessful == true)
                    {
                        if (response.NewID > 0)
                        {
                            ObjDetails.ProfileId = response.NewID;
                            ObjDetails.RoleId = 2;
                            ObjDetails.RoleType = "Scientist";
                            responseuser = SaveUserLoginDetails(ObjDetails);
                            if (responseuser.IsSuccessful && responseuser.SuccessMessage == "Inserting Data")
                            {
                                string mobilenumber = Convert.ToString(ObjDetails.MobileNumber);
                                string message = ObjDetails.Title + " " + ObjDetails.FirstName
                                                + "\r\n" + "Welcome to AGROMET " + "Username: "
                                                + ObjDetails.MobileNumber + "\r\n"
                                                + "Password: 1234 \r\n"
                                                + "\r\n" +
                                                 "Regards" + "\r\n" + "AGROMET.";
                                Utilities.SendSMS(message, mobilenumber);
                            }
                            if (ObjDetails.ObjBlockList.Count > 0)
                            {
                                foreach (var Item in ObjDetails.ObjBlockList)
                                {
                                    Item.UserID = Convert.ToInt32(response.NewID);
                                    Item.StateID = ObjDetails.StateID;
                                    Item.DistrictID = ObjDetails.DistrictID;
                                    SaveUserBlock(Item);
                                }
                            }
                            if (ObjDetails.ObjCropList.Count > 0)
                            {
                                foreach (var Item in ObjDetails.ObjCropList)
                                {
                                    Item.UserID = Convert.ToInt32(response.NewID);
                                    SaveUserCrop(Item);
                                }
                            }
                            response.IsSuccessful = true;
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
            else
            {
                response.IsSuccessful = false;
                response.ErrorMessage = "Scientist already exist.";
                return response;
            }
        }
        #endregion

        #region SaveFarmer
        /// <summary>
        /// SaveFarmer
        /// </summary>
        /// <param name="ObjDetails"></param>
        /// <returns></returns>
        public static TransactionDetails SaveFarmer(UsersDetails ObjDetails)
        {
            TransactionDetails response = new TransactionDetails();
            if (GetVerifyUserName(ObjDetails))
            {
                TransactionDetails responsefarmer = new TransactionDetails();
                UserDistrict ObjDistrict = new UserDistrict();
                DocumentInfo objDocumentInfo = new DocumentInfo();
                GetDocumentResponse objDocumentResponse = new GetDocumentResponse();
                if (ObjDetails.ThumbNailBytes != null)
                {
                    if (ObjDetails.ThumbNailBytes.Length > 0)
                    {
                        objDocumentInfo.ByteStream = ObjDetails.ThumbNailBytes;
                        objDocumentResponse = Utilities.SaveImageUpload(objDocumentInfo);
                        ObjDetails.UserImagePath = objDocumentResponse.LargeImgBlobFileName;
                        ObjDetails.UserThumbnailImagePath = objDocumentResponse.ThumbnailImgBlobFileName;
                        ObjDetails.ThumbNailBytes = objDocumentResponse.ImageURl_bytes;
                    }
                    else
                    {
                        ObjDetails.UserImagePath = "";
                        ObjDetails.UserThumbnailImagePath = "";
                        ObjDetails.ThumbNailBytes = new byte[0];
                    }
                }
                else
                {
                    ObjDetails.UserImagePath = "";
                    ObjDetails.UserThumbnailImagePath = "";
                    ObjDetails.ThumbNailBytes = new byte[0];
                }
                if (ObjDetails.FirstName == null)
                {
                    ObjDetails.FirstName = "";
                }
                if (ObjDetails.LastName == null)
                {
                    ObjDetails.LastName = "";
                }
                if (ObjDetails.Institution == null)
                {
                    ObjDetails.Institution = "";
                }
                if (ObjDetails.Designation == null)
                {
                    ObjDetails.Designation = "";
                }
                if (ObjDetails.Location == null)
                {
                    ObjDetails.Location = "";
                }
                if (ObjDetails.PinCode == null)
                {
                    ObjDetails.PinCode = "";
                }
                if (ObjDetails.Email == null)
                {
                    ObjDetails.Email = "";
                }
                if (ObjDetails.DOB == null)
                {
                    ObjDetails.DOB = "";
                }
                if (ObjDetails.GenderID == 0)
                {
                    ObjDetails.GenderID = 1;
                }
                if (ObjDetails.VillageName == null)
                {
                    ObjDetails.VillageName = "";
                }
                if (ObjDetails.PanchayatName == null)
                {
                    ObjDetails.PanchayatName = "";
                }
                if (ObjDetails.BlockID == 0)
                {
                    ObjDetails.BlockID = 0;
                }
                //Checking if stateid is 28 or 36
                if (ObjDetails.StateID == 28 || ObjDetails.StateID == 36)
                {
                    try
                    {
                        SqlParameter[] arrParams = new SqlParameter[] {
                                          new SqlParameter("@pUserProfileId",ObjDetails.UserId),
                                        new SqlParameter("@pTitleId", ObjDetails.TitleID),
                                        new SqlParameter("@pGenderId",ObjDetails.GenderID),
                                        new SqlParameter("@pFirstname",ObjDetails.FirstName),
                                        new SqlParameter("@pLastname",ObjDetails.LastName),
                                        new SqlParameter("@pDOB",ObjDetails.DOB),
                                        new SqlParameter("@pStateID",ObjDetails.StateID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pAsdID",ObjDetails.AsdID),
                                        new SqlParameter("@pBlockID",DBNull.Value),
                                        new SqlParameter("@pBlockName",DBNull.Value),
                                        new SqlParameter("@pLatitude",ObjDetails.Latitude),
                                        new SqlParameter("@pLongitude",ObjDetails.Longitude),
                                        new SqlParameter("@pLanguageID",ObjDetails.LanguageID),
                                        new SqlParameter("@pUserImagePath",ObjDetails.UserImagePath),
                                        new SqlParameter("@pThumbnailImageName",ObjDetails.UserThumbnailImagePath),
                                        new SqlParameter("@pUserThumbnailBytes",ObjDetails.ThumbNailBytes),
                                        new SqlParameter("@pcreatedby",ObjDetails.CreatedBy),
                                        new SqlParameter("@pupdatedby",ObjDetails.UpdatedBy),
                                        new SqlParameter("@pStateName",ObjDetails.StateName),
                                        new SqlParameter("@pDistrictName",ObjDetails.DistrictName),
                                        new SqlParameter("@pAsdName",ObjDetails.AsdName),
                                        new SqlParameter("@pVillageName",ObjDetails.VillageName),
                                        new SqlParameter("@pPanchayatName",ObjDetails.PanchayatName),
                        };
                        response = SQLHelper.ExecuteOutIDParameter("spSave_UserProfileDetails", arrParams);
                        if (response.IsSuccessful == true)
                        {
                            if (response.NewID > 0)
                            {
                                if (ObjDetails.MobileNumber != null || ObjDetails.MobileNumber != "")
                                {
                                    ObjDetails.ProfileId = response.NewID;
                                    ObjDetails.RoleId = 1;
                                    ObjDetails.RoleType = "User";
                                    responsefarmer = SaveUserLoginDetails(ObjDetails);
                                    if (responsefarmer.IsSuccessful && responsefarmer.SuccessMessage == "Inserting Data")
                                    {
                                        string mobilenumber = Convert.ToString(ObjDetails.LogInId);
                                        string message = ObjDetails.Title + " " + ObjDetails.FirstName
                                                        + "\r\n" + "Welcome to AGROMET " + "Username: " + ObjDetails.MobileNumber + "\r\n"
                                                        //+ "Password: 1234 \r\n"
                                                        + "\r\n" +
                                                         "Regards" + "\r\n" + "AGROMET.";
                                        //Utilities.SendSMS(message, mobilenumber);
                                    }
                                }
                            }
                            response.IsSuccessful = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        response.IsSuccessful = false;
                        response.ErrorMessage = ex.Message.ToString();
                    }
                }
                // if stateid is not 28 or 36
                else
                {
                    try
                    {
                        SqlParameter[] arrParams = new SqlParameter[] {
                                          new SqlParameter("@pUserProfileId",ObjDetails.UserId),
                                        new SqlParameter("@pTitleId", ObjDetails.TitleID),
                                        new SqlParameter("@pGenderId",ObjDetails.GenderID),
                                        new SqlParameter("@pFirstname",ObjDetails.FirstName),
                                        new SqlParameter("@pLastname",ObjDetails.LastName),
                                        new SqlParameter("@pDOB",ObjDetails.DOB),
                                        new SqlParameter("@pStateID",ObjDetails.StateID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pBlockID",ObjDetails.BlockID),
                                        new SqlParameter("@pAsdID",DBNull.Value),
                                        new SqlParameter("@pAsdName",DBNull.Value),
                                        new SqlParameter("@pLatitude",ObjDetails.Latitude),
                                        new SqlParameter("@pLongitude",ObjDetails.Longitude),
                                        //new SqlParameter("@pVillageID",ObjDetails.VillageID),
                                        new SqlParameter("@pLanguageID",ObjDetails.LanguageID),
                                        new SqlParameter("@pUserImagePath",ObjDetails.UserImagePath),
                                        new SqlParameter("@pThumbnailImageName",ObjDetails.UserThumbnailImagePath),
                                        new SqlParameter("@pUserThumbnailBytes",ObjDetails.ThumbNailBytes),
                                        new SqlParameter("@pcreatedby",ObjDetails.CreatedBy),
                                        new SqlParameter("@pupdatedby",ObjDetails.UpdatedBy),
                                        new SqlParameter("@pStateName",ObjDetails.StateName),
                                        new SqlParameter("@pDistrictName",ObjDetails.DistrictName),
                                        new SqlParameter("@pBlockName",ObjDetails.BlockName),
                                        new SqlParameter("@pVillageName",ObjDetails.VillageName),
                                        new SqlParameter("@pPanchayatName",ObjDetails.PanchayatName),
                };
                        response = SQLHelper.ExecuteOutIDParameter("spSave_UserProfileDetails", arrParams);
                        if (response.IsSuccessful == true)
                        {
                            if (response.NewID > 0)
                            {
                                if (ObjDetails.MobileNumber != null || ObjDetails.MobileNumber != "")
                                {
                                    ObjDetails.ProfileId = response.NewID;
                                    ObjDetails.RoleId = 1;
                                    ObjDetails.RoleType = "User";
                                    responsefarmer = SaveUserLoginDetails(ObjDetails);
                                    if (responsefarmer.IsSuccessful && responsefarmer.SuccessMessage == "Inserting Data")
                                    {
                                        string mobilenumber = Convert.ToString(ObjDetails.LogInId);
                                        string message = ObjDetails.Title + " " + ObjDetails.FirstName
                                                        + "\r\n" + "Welcome to AGROMET " + "Username: " + ObjDetails.MobileNumber + "\r\n"
                                                        //+ "Password: 1234 \r\n"
                                                        + "\r\n" +
                                                         "Regards" + "\r\n" + "AGROMET.";
                                        //Utilities.SendSMS(message, mobilenumber);
                                    }
                                }
                            }
                            response.IsSuccessful = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        response.IsSuccessful = false;
                        response.ErrorMessage = ex.Message.ToString();
                    }
                }
                return response;
            }
            else
            {
                response.IsSuccessful = false;
                response.ErrorMessage = "You have already registered with this account.";
                return response;
            }
        }
        #endregion

        #region SaveUserBlock
        public static TransactionDetails SaveUserBlock(UserBlock ObjDetails)
        {
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[] {

                                        new SqlParameter("@pScientistMappingID",ObjDetails.ID),
                                        new SqlParameter("@pScientistID", ObjDetails.UserID),
                                        new SqlParameter("@pStateID",ObjDetails.StateID),
                                        new SqlParameter("@pDistrictID",ObjDetails.DistrictID),
                                        new SqlParameter("@pBlockID",ObjDetails.BlockID),
                                        new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                                        new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_ScientistGeoDetails", arrParams);
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

        #region SaveUserCrop
        public static TransactionDetails SaveUserCrop(UserCrop ObjDetails)
        {
            TransactionDetails response = new TransactionDetails();

            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pScientistCropMappingID",ObjDetails.ID),
                   new SqlParameter("@pScientistID",ObjDetails.UserID),
                   new SqlParameter("@pCropID",ObjDetails.CropID),
                   new SqlParameter("@pcreatedby",ObjDetails.Createdby),
                   new SqlParameter("@pupdatedby",ObjDetails.Updatedby),
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_ScientistCropDetails", arrParams);
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

        #region SaveUserLocations
        /// <summary>
        /// SaveUserLocations
        /// </summary>
        /// <param name="ObjLocation"></param>
        /// <returns></returns>
        public static TransactionDetails SaveUserLocations(UserLocations ObjLocation)
        {
            TransactionDetails response = new TransactionDetails();
            //Checking if stateid is 28 or 36
            if (ObjLocation.StateID == 28 || ObjLocation.StateID == 36)
            {
                try
                {
                    SqlParameter[] arrParams = new SqlParameter[]
                    {
                       new SqlParameter("@pUALID",ObjLocation.UALID),
                       new SqlParameter("@pUserProfileID",ObjLocation.UserProfileID),
                       new SqlParameter("@pStateID",ObjLocation.StateID),
                       new SqlParameter("@pDistrictID",ObjLocation.DistrictID),
                       new SqlParameter("@pAsdID",ObjLocation.AsdID),
                       new SqlParameter("@pBlockID",DBNull.Value),
                       new SqlParameter("@pcreatedby",ObjLocation.Createdby),
                       new SqlParameter("@pupdatedby",ObjLocation.Updatedby)
                    };
                    response = SQLHelper.ExecuteOutIDParameter("spSave_UserLocationDetails", arrParams);
                    response.IsSuccessful = true;
                }
                catch (Exception ex)
                {
                    response.IsSuccessful = false;
                    response.ErrorMessage = ex.Message;
                }
            }
            // if stateid is not 28 or 36
            else
            {
                try
                {
                    SqlParameter[] arrParams = new SqlParameter[]
                    {
                       new SqlParameter("@pUALID",ObjLocation.UALID),
                       new SqlParameter("@pUserProfileID",ObjLocation.UserProfileID),
                       new SqlParameter("@pStateID",ObjLocation.StateID),
                       new SqlParameter("@pDistrictID",ObjLocation.DistrictID),
                       new SqlParameter("@pBlockID",ObjLocation.BlockID),
                       new SqlParameter("@pAsdID",DBNull.Value),
                       new SqlParameter("@pcreatedby",ObjLocation.Createdby),
                       new SqlParameter("@pupdatedby",ObjLocation.Updatedby)
                    };
                    response = SQLHelper.ExecuteOutIDParameter("spSave_UserLocationDetails", arrParams);
                    response.IsSuccessful = true;
                }
                catch (Exception ex)
                {

                    response.IsSuccessful = false;
                    response.ErrorMessage = ex.Message;
                }
            }
            
            return response;
        }
        #endregion

        #region GetUserLoginDetails
        /// <summary>
        /// GetUserLoginDetails
        /// </summary>
        /// <param name="objUserLoginDetail"></param>
        /// <returns></returns>
        public static GetUsersResponse GetUserLoginDetails(UsersDetails objUserLoginDetail)
        {
            GetUsersResponse response = new GetUsersResponse();
            DataTable dt = new DataTable();
            //string Var_Password = Utilities.Encrypt(objUserLoginDetail.LogInPassword);
            try
            {
                if (objUserLoginDetail.LanguageType == null || objUserLoginDetail.LanguageType == "")
                {
                    objUserLoginDetail.LanguageType = "English";
                }                
                // change id = 123
                // reson : get language id
                // changed by 

                SqlParameter[] languageType = new SqlParameter[] {
                        new SqlParameter("@pLanguageID",objUserLoginDetail.LanguageID),
                        new SqlParameter("@pRefreshdatetime",""),
                        new SqlParameter("@planguagetype",objUserLoginDetail.LanguageType)
                    };
                var languageResult = SQLHelper.Execute("spGet_LanguageMaster", languageType);                
                var languageId = languageResult.AsEnumerable().Where(e=>e.Field<string>("LanguageName") == objUserLoginDetail.LanguageType)
                    .Select(r=>r.Field<Int32>("LanguageID")).FirstOrDefault();
                objUserLoginDetail.LanguageID = languageId;
                objUserLoginDetail.MobileNumber = objUserLoginDetail.LogInId;
                objUserLoginDetail.BlockName = "";
                objUserLoginDetail.UpdatedBy = "";
                //end
                SqlParameter[] arrParams = new SqlParameter[]
                {
                            new SqlParameter("@ploginid",objUserLoginDetail.LogInId),
                            //new SqlParameter("@ploginpassword",Var_Password),
                            new SqlParameter("@pLanguageType",objUserLoginDetail.LanguageType),
                            new SqlParameter("@pRefreshdatetime",objUserLoginDetail.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_UserLoginDetails", arrParams);

                // In case of stateid 28 and 36, if BlockID and BlockName is null, AsdID and AsdName will be shown.
                if (dt.Rows.Count > 0)
                {
                    response.ObjUserList =
                    (from DataRow dr in dt.Rows
                     select new UsersDetails
                     {
                         UserId = (dr["userid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["userid"]),
                         FirstName = (dr["firstname"] == DBNull.Value ? "" : Convert.ToString(dr["firstname"])),
                         LastName = (dr["lastname"] == DBNull.Value ? "" : Convert.ToString(dr["lastname"])),
                         LogInId = (dr["loginid"]) == DBNull.Value ? "" : Convert.ToString(dr["loginid"]),
                         LogInPassword = (dr["loginpassword"] == DBNull.Value ? "" : Convert.ToString(Utilities.Decrypt(dr["loginpassword"].ToString()))),
                         RoleId = (dr["roleid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["roleid"]),
                         TypeOfRole = (dr["ProfileID"]) == DBNull.Value ? "" : Convert.ToString(dr["ProfileID"]),
                         RoleType = (dr["RoleType"] == DBNull.Value ? "" : Convert.ToString(dr["RoleType"])),
                         CreatedBy = (dr["createdby"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["createdby"]),
                         ImagePath = (dr["imagepath"] == DBNull.Value ? "" : Convert.ToString(dr["imagepath"])),
                         ThumbNailBytes = (dr["thumbnailbytes"] == DBNull.Value ? null : ((byte[])(dr["thumbnailbytes"]))),
                         StateID = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                         StateName = (dr["StateName"]) == DBNull.Value ? "" : Convert.ToString(dr["StateName"]),
                         DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                         DistrictName = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                         BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                         BlockName = (dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"]),
                         AsdID = (dr["AsdID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["AsdID"]),
                         AsdName = (dr["AsdName"]) == DBNull.Value ? "" : Convert.ToString(dr["AsdName"]),
                         VillageID = (dr["villageid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["villageid"]),
                         VillageName = (dr["village"]) == DBNull.Value ? "" : Convert.ToString(dr["village"]),
                         PanchayatName = (dr["PanchayatName"]) == DBNull.Value ? "" : Convert.ToString(dr["PanchayatName"]),
                         Latitude = (dr["Latitude"]) == DBNull.Value ? 0 : Convert.ToDouble(dr["Latitude"]),
                         Longitude = (dr["Longitude"]) == DBNull.Value ? 0 : Convert.ToDouble(dr["Longitude"]),
                         LanguageID = (dr["LanguageID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["LanguageID"]),
                         LanguageName = (dr["LanguageName"]) == DBNull.Value ? "" : Convert.ToString(dr["LanguageName"]),
                         CultureCode = (dr["CultureCode"]) == DBNull.Value ? "" : Convert.ToString(dr["CultureCode"]),
                         RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),
                     }).ToList();
                    response.IsSuccessful = true;
                }
                else
                {
                    //TransactionDetails result = SaveFarmer(objUserLoginDetail);
                    //if (result.IsSuccessful)
                    //{
                    //    GetUsersResponse results = GetUserLoginDetails(objUserLoginDetail);
                    //    response.IsSuccessful = true;
                    //    response.ObjUserList = results.ObjUserList;
                    //    return response;
                    //}
                    //else
                    //{
                    //    response.ErrorMessage = result.ErrorMessage;
                    //}
                    
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

        #region GetUserProfileDetails
        public static GetUsersResponse GetUserProfileDetails(UserProfile objUserLoginDetail)
        {
            GetUsersResponse response = new GetUsersResponse();
            DataTable dt = new DataTable();

            try
            {
                if (objUserLoginDetail.LanguageType == null || objUserLoginDetail.LanguageType == "")
                {
                    objUserLoginDetail.LanguageType = "English";
                }
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pUserProfileid",objUserLoginDetail.UserProfileID),
                    new SqlParameter("@pRoleType",objUserLoginDetail.RoleType),
                    new SqlParameter("@planguagetype",objUserLoginDetail.LanguageType),
                    new SqlParameter("@pRefreshdatetime",objUserLoginDetail.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_UserProfileDetails", arrParams);

                if (dt.Rows.Count > 0)

                {
                    response.ObjUserProfileList = (from DataRow dr in dt.Rows
                                                   select new UserProfile
                                                   {
                                                       UserName = (dr["UserName"]) == DBNull.Value ? "" : Convert.ToString(dr["UserName"]),
                                                       GenderName = (dr["Gendername"] == DBNull.Value ? "" : Convert.ToString(dr["Gendername"])),
                                                       TitleName = (dr["TitleName"] == DBNull.Value ? "" : Convert.ToString(dr["TitleName"])),
                                                       StateName = (dr["stateName"]) == DBNull.Value ? "" : Convert.ToString(dr["stateName"]),
                                                       DistrictName = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                                                       BlockName = (dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"]),
                                                       VillageName = (dr["VillageName"] == DBNull.Value ? "" : Convert.ToString(dr["VillageName"])),
                                                       LanguageName = (dr["LanguageName"]) == DBNull.Value ? "" : Convert.ToString(dr["LanguageName"]),
                                                       Latitude = (dr["Latitude"]) == DBNull.Value ? "" : Convert.ToString(dr["Latitude"]),
                                                       Longitude = (dr["Longitude"]) == DBNull.Value ? "" : Convert.ToString(dr["Longitude"]),
                                                       ImagePath = (dr["ImagePath"]) == DBNull.Value ? "" : Convert.ToString(dr["ImagePath"]),
                                                       UserProfileID = (dr["ProfileID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["ProfileID"]),
                                                       PhoneNumber = (dr["PhoneNumber"]) == DBNull.Value ? "" : Convert.ToString(dr["PhoneNumber"]),
                                                       EmailID = (dr["EmailID"]) == DBNull.Value ? "" : Convert.ToString(dr["EmailID"]),
                                                       ThumbNailBytes = (dr["ThumbnailBytes"]) == DBNull.Value ? null : ((byte[])(dr["ThumbnailBytes"])),
                                                       RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),


                                                   }).ToList();

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
        #endregion     

        #region GetUserslist
        public static GetUsersResponse GetUsersList(UsersDetails objUser)
        {
            GetUsersResponse response = new GetUsersResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserPofileID",objUser.UserId),
               new SqlParameter("@planguagetype",objUser.LanguageType),
               new SqlParameter("@pRefreshdatetime",objUser.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_UserDetailsCreatedByAdmin", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjUserList =
                    (from DataRow dr in dt.Rows
                     select new UsersDetails
                     {
                         FirstName = (dr["firstname"] == DBNull.Value ? "" : Convert.ToString(dr["firstname"])),
                         LastName = (dr["lastname"] == DBNull.Value ? "" : Convert.ToString(dr["lastname"])),
                         LogInId = (dr["Phonenumber"]) == DBNull.Value ? "" : Convert.ToString(dr["Phonenumber"]),
                         DistrictName = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                         DepartmentName = (dr["DepartmentName"]) == DBNull.Value ? "" : Convert.ToString(dr["DepartmentName"]),
                         RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),
                     }).ToList();
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
        #endregion

        #region SearchUserslist
        public static GetUsersResponse SearchUsersList(UsersDetails objUser)
        {
            GetUsersResponse response = new GetUsersResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileId",objUser.UserId),
               new SqlParameter("@pBlockid",objUser.BlockID),
               new SqlParameter("@pphonenumber",objUser.LogInId),
               new SqlParameter("@planguagetype",objUser.LanguageType),
               new SqlParameter("@pRefreshdatetime",objUser.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spSearch_ScientistProfileDetails", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjUserList =
                    (from DataRow dr in dt.Rows
                     select new UsersDetails
                     {
                         FirstName = (dr["firstname"] == DBNull.Value ? "" : Convert.ToString(dr["firstname"])),
                         LastName = (dr["lastname"] == DBNull.Value ? "" : Convert.ToString(dr["lastname"])),
                         LogInId = (dr["Phonenumber"]) == DBNull.Value ? "" : Convert.ToString(dr["Phonenumber"]),
                         DistrictName = (dr["DistrictName"]) == DBNull.Value ? "" : Convert.ToString(dr["DistrictName"]),
                         DepartmentName = (dr["DepartmentName"]) == DBNull.Value ? "" : Convert.ToString(dr["DepartmentName"]),
                         RefreshDateTime = (dr["RefreshDateTime"]) == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]),
                     }).ToList();
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
        #endregion

        #region GetUserBlocks
        public static GetUsersResponse GetUserBlocks(UserBlock objblock)
        {
            DataTable dt = new DataTable();
            GetUsersResponse response = new GetUsersResponse();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pUserProfileID", objblock.UserID),
                new SqlParameter("@planguagetype", objblock.LanguageType),
                new SqlParameter("@pRefreshdatetime", objblock.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_BlockDetailsCreatedbyAdmin", arrParams);
                if (dt.Rows.Count > 0)
                {
                    response.ObjBlockList =
                   (from DataRow dr in dt.Rows
                    select new UserBlock
                    {
                        BlockID = (dr["blockid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["blockid"]),
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

        #region GetUserLocations
        public static GetUsersResponse GetUserLocations(UserLocations objLocation)
        {
            DataTable dt = new DataTable();
            GetUsersResponse response = new GetUsersResponse();
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
                        AsdID = (dr["AsdId"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["AsdId"]),
                        AsdName = (dr["AsdName"] == DBNull.Value ? "" : Convert.ToString(dr["AsdName"])),
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

        #region GetForgetPassword
        public static GetUsersResponse GetForgetPassword(UsersDetails objUser)
        {
            GetUsersResponse response = new GetUsersResponse();
            UsersDetails objuser = new UsersDetails();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@ploginid",objUser.LogInId),
                };
                dt = SQLHelper.Execute("spGet_ForgotPassword", arrParams);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    objuser.UserId = (dr["userid"] == DBNull.Value ? 0 : Convert.ToInt32(dr["userid"]));
                    objuser.FirstName = (dr["firstname"] == DBNull.Value ? "" : Convert.ToString(dr["firstname"]));
                    objuser.LastName = (dr["lastname"] == DBNull.Value ? "" : Convert.ToString(dr["lastname"]));
                    objuser.LogInId = (dr["loginid"]) == DBNull.Value ? "" : Convert.ToString(dr["loginid"]);
                    objuser.LogInPassword = (dr["loginpassword"] == DBNull.Value ? "" : Convert.ToString(dr["loginpassword"]));
                    objuser.RoleId = (dr["roleid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["roleid"]);
                    objuser.MobileNumber = (dr["phonenumber"] == DBNull.Value ? "" : Convert.ToString(dr["phonenumber"]));
                    if (objuser.LogInId != null && objuser.MobileNumber != "")
                    {
                        string password = Utilities.Decrypt(objuser.LogInPassword);
                        string MobileNumber = objuser.MobileNumber;
                        string sms = "Dear" + " " + objuser.FirstName + " " + objuser.LastName
                            + "\r\n" + "\r\n" +
                            "Welcome to AGROMET"
                            + "\r\n"
                            + "your PIN number is : " + password + "\r\n" +
                            "\r\n" + "Regards AGROMET.";
                        Utilities.SendSMS(sms, MobileNumber);
                        response.SuccessMessage = "PIN number send to your mobile.";
                    }
                    response.IsSuccessful = true;
                }
                else
                {
                    response.SuccessMessage = "User Does not Exist";
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

        #region VerifyUserName
        public static bool GetVerifyUserName(UsersDetails objUsersDetails)
        {
            GetUsersResponse response = new GetUsersResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@ploginid",objUsersDetails.MobileNumber)
                    //new SqlParameter("@ploginid",objUsersDetails.LogInId)

                };
                dt = SQLHelper.Execute("spVerify_UserName", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjUserList = (from DataRow dr in dt.Rows
                                            select new UsersDetails
                                            {
                                                LogInId = (dr["loginid"]) == DBNull.Value ? "" : Convert.ToString(dr["loginid"]),
                                                LogInPassword = (dr["loginpassword"] == DBNull.Value ? "" : Convert.ToString(dr["loginpassword"])),

                                            }).ToList();

                    response.IsSuccessful = true;
                }


            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            if (response.IsSuccessful && response.ObjUserList.Count > 0)
            {
                if (response.ObjUserList[0].LogInId == objUsersDetails.MobileNumber)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

        }
        #endregion

        #region RemoveUserLocations
        public static TransactionDetails RemoveUserLocations(UserLocations ObjLocation) 
        {
            TransactionDetails response = new TransactionDetails();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                    {
                       new SqlParameter("@pUserProfileID",ObjLocation.UserProfileID),
                       new SqlParameter("@pDistrictID",ObjLocation.DistrictID),
                       new SqlParameter("@pBlockID",ObjLocation.BlockID),
                       new SqlParameter("@pAsdID",ObjLocation.AsdID)
                    };
                response = SQLHelper.ExecuteOutIDParameter("spDelete_UserLocationDetails", arrParams);
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
        #region RemoveUserLocationsAsd
        public static TransactionDetails RemoveUserLocationsAsd(UserLocations ObjLocation)
        {
            TransactionDetails response = new TransactionDetails();
            try
            {
                // Getting asdid to delete location.
                SqlParameter[] arrParams = new SqlParameter[]
                {
                   new SqlParameter("@pUserProfileID",ObjLocation.UserProfileID),
                   new SqlParameter("@pDistrictID",ObjLocation.DistrictID),
                   new SqlParameter("@pAsdID",ObjLocation.AsdID),
                   new SqlParameter("@pBlockID",DBNull.Value)
                };
                response = SQLHelper.ExecuteOutIDParameter("spDelete_UserLocationDetails", arrParams);
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

        #region SaveUserProfilImage
        public static TransactionDetails SaveUserProfilImage(UserProfileImageDetails ObjProfilImage)
        {
            TransactionDetails response = new TransactionDetails();
            try
            {
                var IsValid = IsValidImage(ObjProfilImage.UserProfileImage);
                if (!IsValid)
                {
                    response.IsSuccessful = false;
                    response.ErrorMessage = "Invalid Image";
                    return response;
                }

                var extension = GetFileExtension(ObjProfilImage.UserProfileImage);
                if (extension == null)
                {
                    response.IsSuccessful = false;
                    response.ErrorMessage = "Invalid Image";
                    return response;
                }
                byte[] bytes = Convert.FromBase64String(ObjProfilImage.UserProfileImage);
                string path = HttpContext.Current.Server.MapPath("~/UserProfileImages/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                var file = ObjProfilImage.UserProfileID + "." + extension;
                File.WriteAllBytes(path + file, bytes);

                var imagePath = ProfileImageUrl + file;
                SqlParameter[] arrParams = new SqlParameter[]
                {
                           new SqlParameter("@pUserProfileID",ObjProfilImage.UserProfileID),
                           new SqlParameter("@pImage",imagePath)
                };
                response = SQLHelper.ExecuteOutIDParameter("spSave_UserProfileImage", arrParams);
                response.IsSuccessful = response.IsSuccessful;
            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
            
        }
        #endregion SaveUserProfilImage
        /// <summary>
        /// GetFileExtension
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private static string GetFileExtension(string image)
        {
            var data = image.Substring(0, 5);

            switch (data.ToUpper())
            {
                case "IVBOR":
                    return "png";
                case "/9J/4":
                    return "jpg";
                case "AAAAF":
                    return "mp4";
                case "JVBER":
                    return "pdf";
                case "AAABA":
                    return "ico";
                case "UMFYI":
                    return "rar";
                case "E1XYD":
                    return "rtf";
                case "U1PKC":
                    return "txt";
                case "MQOWM":
                case "77U/M":
                    return "srt";
                default:
                    return null;
            }
        }

        /// <summary>
        /// IsValidImage
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private static bool IsValidImage(string image)
        {
            var trimImage = image.Trim();
            return (trimImage.Length % 4 == 0) && System.Text.RegularExpressions.Regex.IsMatch(trimImage, @"^[a-zA-Z0-9\+/]*={0,3}$", System.Text.RegularExpressions.RegexOptions.None);
        }
    }
}
