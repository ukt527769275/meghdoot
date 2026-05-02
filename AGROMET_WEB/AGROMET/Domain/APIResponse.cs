using System;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using AGROMET.Models;
using AGROMET.MasterModels;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AGROMET.Domain
{
    public class APIResponse
    {
        #region Get Masters data from Api
        public static List<TitleMaster> GetTitles(JObject Jobj, string posturl)
        {
            List<TitleMaster> ObjTitleMasterList = new List<TitleMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objTitleMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objTitleMasters.IsSuccessful)
                {
                    if (objTitleMasters.ObjTitleMasterList.Count > 0)
                    {
                        ObjTitleMasterList = objTitleMasters.ObjTitleMasterList;
                    }
                    else
                    {
                        ObjTitleMasterList = new List<TitleMaster>();
                    }
                }
                else
                {
                    ObjTitleMasterList = new List<TitleMaster>();
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjTitleMasterList;
        }
        public static List<StateMaster> GetStates(JObject Jobj, string posturl)
        {
            List<StateMaster> ObjStateMasterList = new List<StateMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objStateMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objStateMasters.IsSuccessful)
                {
                    if (objStateMasters.ObjStateMasterList.Count > 0)
                    {
                        ObjStateMasterList = objStateMasters.ObjStateMasterList;
                    }
                    else
                    {
                        ObjStateMasterList = new List<StateMaster>();
                    }
                }
                else
                {
                    ObjStateMasterList = new List<StateMaster>();
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjStateMasterList;
        }
        public static List<DistrictMaster> GetDistricts(JObject Jobj, string posturl)
        {
            List<DistrictMaster> ObjDistrictMasterList = new List<DistrictMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objDistrictMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objDistrictMasters.IsSuccessful)
                {
                    if (objDistrictMasters.ObjDistrictMasterList.Count > 0)
                    {
                        ObjDistrictMasterList = objDistrictMasters.ObjDistrictMasterList;
                    }
                    else
                    {
                        ObjDistrictMasterList = new List<DistrictMaster>();
                    }
                }
                else
                {
                    ObjDistrictMasterList = new List<DistrictMaster>();
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjDistrictMasterList;
        }
        public static List<BlockMaster> GetBlocks(JObject Jobj, string posturl)
        {
            List<BlockMaster> ObjBlockMasterList = new List<BlockMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objBlockMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objBlockMasters.IsSuccessful)
                {
                    if (objBlockMasters.ObjBlockMasterList.Count > 0)
                    {
                        ObjBlockMasterList = objBlockMasters.ObjBlockMasterList;
                    }
                    else
                    {
                        ObjBlockMasterList = new List<BlockMaster>();
                    }
                }
                else
                {
                    ObjBlockMasterList = new List<BlockMaster>();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjBlockMasterList;
        }
        public static List<CropMaster> GetCrops(JObject Jobj, string posturl)
        {
            List<CropMaster> ObjCropMasterList = new List<CropMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objCropMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objCropMasters.IsSuccessful)
                {
                    if (objCropMasters.ObjCropMasterList.Count > 0)
                    {
                        ObjCropMasterList = objCropMasters.ObjCropMasterList;
                    }
                    else
                    {
                        ObjCropMasterList = new List<CropMaster>();
                    }
                }
                else
                {
                    ObjCropMasterList = new List<CropMaster>();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjCropMasterList;
        }
        public static List<GenderMaster> GetGender(JObject Jobj, string posturl)
        {
            List<GenderMaster> ObjGenderMasterList = new List<GenderMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objGenderMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objGenderMasters.IsSuccessful)
                {
                    if (objGenderMasters.ObjGenderMasterList.Count > 0)
                    {
                        ObjGenderMasterList = objGenderMasters.ObjGenderMasterList;
                    }
                    else
                    {
                        ObjGenderMasterList = new List<GenderMaster>();
                    }
                }
                else
                {
                    ObjGenderMasterList = new List<GenderMaster>();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjGenderMasterList;
        }
        public static List<LanguageMaster> GetLanguages(JObject Jobj, string posturl)
        {
            List<LanguageMaster> ObjLanguageTypeMasterList = new List<LanguageMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objLanguageMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objLanguageMasters.IsSuccessful)
                {
                    if (objLanguageMasters.ObjLanguageTypeMasterList.Count > 0)
                    {
                        ObjLanguageTypeMasterList = objLanguageMasters.ObjLanguageTypeMasterList;
                    }
                    else
                    {
                        ObjLanguageTypeMasterList = new List<LanguageMaster>();
                    }
                }
                else
                {
                    ObjLanguageTypeMasterList = new List<LanguageMaster>();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjLanguageTypeMasterList;
        }
        public static List<DepartmentMaster> GetDepartments(JObject Jobj, string posturl)
        {
            List<DepartmentMaster> ObjDepartmentMasterList = new List<DepartmentMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objDepartmentMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objDepartmentMasters.IsSuccessful)
                {
                    if (objDepartmentMasters.ObjDepartmentMasterList.Count > 0)
                    {
                        ObjDepartmentMasterList = objDepartmentMasters.ObjDepartmentMasterList;
                    }
                    else
                    {
                        ObjDepartmentMasterList = new List<DepartmentMaster>();
                    }
                }
                else
                {
                    ObjDepartmentMasterList = new List<DepartmentMaster>();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjDepartmentMasterList;
        }
        public static List<CropAdvisoryCategoryMaster> GetCropAdvisoryCategory(JObject Jobj, string posturl)
        {
            List<CropAdvisoryCategoryMaster> ObjAdvisoryCategoryMasterList = new List<CropAdvisoryCategoryMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objCropAdvisoryCategoryMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objCropAdvisoryCategoryMasters.IsSuccessful)
                {
                    if (objCropAdvisoryCategoryMasters.ObjAdvisoryCategoryMasterList.Count > 0)
                    {
                        ObjAdvisoryCategoryMasterList = objCropAdvisoryCategoryMasters.ObjAdvisoryCategoryMasterList;
                    }
                    else
                    {
                        ObjAdvisoryCategoryMasterList = new List<CropAdvisoryCategoryMaster>();
                    }
                }
                else
                {
                    ObjAdvisoryCategoryMasterList = new List<CropAdvisoryCategoryMaster>();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjAdvisoryCategoryMasterList;
        }
        public static List<BlobMaster> GetBlob(JObject Jobj, string posturl)
        {
            List<BlobMaster> ObjBlobMasterList = new List<BlobMaster>();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                GetMasterResponse objBlobMasters = JsonConvert.DeserializeObject<GetMasterResponse>(earthquakesJson);
                if (objBlobMasters.IsSuccessful)
                {
                    if (objBlobMasters.ObjBlobMasterList.Count > 0)
                    {
                        ObjBlobMasterList = objBlobMasters.ObjBlobMasterList;
                    }
                    else
                    {
                        ObjBlobMasterList = new List<BlobMaster>();
                    }
                }
                else
                {
                    ObjBlobMasterList = new List<BlobMaster>();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ObjBlobMasterList;
        }
        #endregion
        #region Get Transaction Data from Api
        public static LoginModelResponse GetUserDetailsResponse(JObject Jobj, string posturl)
        {
            LoginModelResponse objLoginModelResponse = new LoginModelResponse();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                objLoginModelResponse = JsonConvert.DeserializeObject<LoginModelResponse>(earthquakesJson);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            if (objLoginModelResponse.IsSuccessful)
            {
                return objLoginModelResponse;
            }
            else
            {
                return objLoginModelResponse = new LoginModelResponse();
            }
        }
        public static UserProfileResponse GetUserProfileResponse(JObject Jobj, string posturl)
        {
            UserProfileResponse objLoginModelResponse = new UserProfileResponse();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                objLoginModelResponse = JsonConvert.DeserializeObject<UserProfileResponse>(earthquakesJson);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            if (objLoginModelResponse.IsSuccessful)
            {
                return objLoginModelResponse;
            }
            else
            {
                return objLoginModelResponse = new UserProfileResponse();
            }
        }
        public static GetUsersResponse GetUsersResponse(JObject Jobj, string posturl)
        {
            GetUsersResponse objLoginModelResponse = new GetUsersResponse();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                objLoginModelResponse = JsonConvert.DeserializeObject<GetUsersResponse>(earthquakesJson);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            if (objLoginModelResponse.IsSuccessful)
            {
                return objLoginModelResponse;
            }
            else
            {
                return objLoginModelResponse = new GetUsersResponse();
            }
        }
        public static WeatherForecastDetailsResponse GetWeatherForecastResponse(JObject Jobj, string posturl)
        {
            WeatherForecastDetailsResponse ObjWeatherForecastResponse = new WeatherForecastDetailsResponse();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                ObjWeatherForecastResponse = JsonConvert.DeserializeObject<WeatherForecastDetailsResponse>(earthquakesJson);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            if (ObjWeatherForecastResponse.IsSuccessful)
            {
                return ObjWeatherForecastResponse;
            }
            else
            {
                return ObjWeatherForecastResponse = new WeatherForecastDetailsResponse();
            }
        }
        public static CropAdvisoryResponse GetCropAdvisoryResponse(JObject Jobj, string posturl)
        {
            CropAdvisoryResponse ObjCropAdvisoryResponse = new CropAdvisoryResponse();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                ObjCropAdvisoryResponse = JsonConvert.DeserializeObject<CropAdvisoryResponse>(earthquakesJson);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            if (ObjCropAdvisoryResponse.IsSuccessful)
            {
                return ObjCropAdvisoryResponse;
            }
            else
            {
                return ObjCropAdvisoryResponse = new CropAdvisoryResponse();
            }
        }
        public static NotificationsResponse GetNotificationsResponse(JObject Jobj, string posturl)
        {
            NotificationsResponse ObjNotificationsResponse = new NotificationsResponse();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                ObjNotificationsResponse = JsonConvert.DeserializeObject<NotificationsResponse>(earthquakesJson);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            if (ObjNotificationsResponse.IsSuccessful)
            {
                return ObjNotificationsResponse;
            }
            else
            {
                return ObjNotificationsResponse = new NotificationsResponse();
            }
        }
        public static CountResponse GetCountResponse(JObject Jobj, string posturl)
        {
            CountResponse ObjCountResponse = new CountResponse();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(posturl, HC).Result;
                var earthquakesJson = response.Content.ReadAsStringAsync().Result;
                ObjCountResponse = JsonConvert.DeserializeObject<CountResponse>(earthquakesJson);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            if (ObjCountResponse.IsSuccessful)
            {
                return ObjCountResponse;
            }
            else
            {
                return ObjCountResponse = new CountResponse();
            }
        }
        #endregion
        #region Save Transaction data api
        public static TransactionDetails SaveDetails(JObject Jobj, string PostURL)
        {
            JObject Result = new JObject();
            TransactionDetails responsedata = new TransactionDetails();
            try
            {
                var client = new HttpClient();
                HttpContent HC = new StringContent(Jobj.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(PostURL, HC).Result;
                var responseText = response.Content.ReadAsStringAsync().Result;
                responsedata = JsonConvert.DeserializeObject<TransactionDetails>(responseText);
                
            }
            catch (JsonException ex)
            {
                responsedata.ErrorMessage = ex.ToString();
            }
            return responsedata;
        }
        #endregion
    }
}