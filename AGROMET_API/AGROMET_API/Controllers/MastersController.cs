using AGROMET_MASTERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AGROMET_API.Controllers
{
    [RoutePrefix("api/Masters")]
    public class MastersController : ApiController
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("GetTitleMasterList")]
        [ActionName("GetTitleMasterList")]
        public GetMasterResponse GetTitleMasterList(TitleMaster objTitleMaster)
        {
            GetMasterResponse response = Masters.GetTitleMasterList(objTitleMaster);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetStateMasterList")]
        [ActionName("GetStateMasterList")]
        public GetMasterResponse GetStateMasterList(StateMaster objStateMaster)
        {
            GetMasterResponse response = Masters.GetStateMasterList(objStateMaster);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetDistrictMasterList")]
        [ActionName("GetDistrictMasterList")]
        public GetMasterResponse GetDistrictMasterList(DistrictMaster objDistrictMaster)
        {
            GetMasterResponse response = Masters.GetDistrictMasterList(objDistrictMaster);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetGenderMasterList")]
        [ActionName("GetGenderMasterList")]
        public GetMasterResponse GetGenderMasterList(GenderMaster objGenderMaster)
        {
            GetMasterResponse response = Masters.GetGenderMasterList(objGenderMaster);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetLanguageMasterList")]
        [ActionName("GetLanguageMasterList")]
        public GetMasterResponse GetLanguageMasterList(LanguageMaster objLanguageMaster)
        {
            GetMasterResponse response = Masters.GetLanguageMasterList(objLanguageMaster);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetBlockMasterList")]
        [ActionName("GetBlockMasterList")]
        public GetMasterResponse GetBlockMasterList(BlockMaster objBlockMaster)
        {
            GetMasterResponse response = Masters.GetBlockMasterList(objBlockMaster);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetASDMasterList")]
        [ActionName("GetASDMasterList")]
        public GetMasterResponse GetASDMasterList(AsdMaster objAsdMaster)
        {
            GetMasterResponse response = Masters.GetASDMasterList(objAsdMaster);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropMasterList")]
        [ActionName("GetCropMasterList")]
        public GetMasterResponse GetCropMasterList(CropMaster objCropMaster)
        {
            GetMasterResponse response = Masters.GetCropMasterList(objCropMaster);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisoryCategoryMaster")]
        [ActionName("GetCropAdvisoryCategoryMaster")]
        public GetMasterResponse GetCropAdvisoryCategoryMaster(CropAdvisoryCategoryMaster objCategory)
        {
            GetMasterResponse response = Masters.GetCropAdvisoryCategoryMaster(objCategory);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetDepartmentMasterList")]
        [ActionName("GetDepartmentMasterList")]
        public GetMasterResponse GetDepartmentMasterList(DepartmentMaster objDepartmentMaster)
        {
            GetMasterResponse response = Masters.GetDepartmentMasterList(objDepartmentMaster);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetBlobMaster")]
        [ActionName("GetBlobMaster")]
        public GetMasterResponse GetBlobMaster(BlobMaster obj)
        {
            GetMasterResponse response = Masters.GetBlobMaster(obj);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetKey")]
        [ActionName("GetKey")]
        public string GetKey()
        {
            return GetKey();
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetCountryCodeMasterList")]
        [ActionName("GetCountryCodeMasterList")]
        public GetMasterResponse GetCountryCodeMasterList(CountryCodeMaster objCCMaster)
        {
            GetMasterResponse response = Masters.GetCountryCodeMasterList(objCCMaster);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetStationDistrictMasters")]
        [ActionName("GetStationDistrictMasters")]
        public GetMasterResponse GetStationDistrictMasters(DistrictMaster objDistrictMaster)
        {
            GetMasterResponse response = Masters.GetStationDistrictMasters(objDistrictMaster);
            return response;
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("GetStationStateMasters")]
        [ActionName("GetStationStateMasters")]
        public GetMasterResponse GetStationStateMasters(StateMaster objStateMaster)
        {
            GetMasterResponse response = Masters.GetStationStateMasters(objStateMaster);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCurrentLocationDetails")]
        [ActionName("GetCurrentLocationDetails")]
        public GetCurrentLocationResponse GetCurrentLocationDetails(string latitude, string longitude)
        {
            GetCurrentLocationResponse response = Masters.GetCurrentLocationDetails(latitude, latitude);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("UpdateData")]
        [ActionName("UpdateData")]
        public string UpdateData()
        {
            string response = string.Empty;
            var result = Masters.GetNameFromExcel();
            foreach (var data in result)
            {
                var districtName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(data.Name.ToLower());
                var districtText = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(data.UpdateName.ToLower());

                var updateDistrictName = Masters.UpdateName(districtName, districtText);
            }

            return "Success";
        }
    }
}
