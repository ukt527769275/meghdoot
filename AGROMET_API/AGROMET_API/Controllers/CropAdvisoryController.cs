using AGROMET_COMMON;
using AGROMET_CROPADVISORY;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;

namespace AGROMET_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/CropAdvisory")]
    public class CropAdvisoryController : ApiController
    {
        #region private fields

        public static int TimeOutValue = Convert.ToInt32(ConfigurationManager.AppSettings["TimeOutValue"]);
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion private fields

        #region methods 

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveCropAdvisoryMasters")]
        [ActionName("SaveCropAdvisoryMasters")]
        public TransactionDetails SaveCropAdvisoryMasters(CropAdvisoryDetails ObjDetails)
        {
            TransactionDetails response = CropAdvisory.SaveCropAdvisoryMasters(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveCropAdvisory")]
        [ActionName("SaveCropAdvisory")]
        public TransactionDetails SaveCropAdvisory(CropAdvisoryDetails ObjDetails)
        {
            TransactionDetails response = CropAdvisory.SaveCropAdvisory(ObjDetails);
            return response;
        }     

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveCropAdvisoryDistrict")]
        [ActionName("SaveCropAdvisoryDistrict")]
        public TransactionDetails SaveCropAdvisoryDistrict(CropAdvisoryDistrict ObjDetails)
        {
            TransactionDetails response = CropAdvisory.SaveCropAdvisoryDistrict(ObjDetails);
            return response;
        }
      
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveCropAdvisoryBlock")]
        [ActionName("SaveCropAdvisoryBlock")]
        public TransactionDetails SaveCropAdvisoryBlock(CropAdvisoryBlock ObjDetails)
        {
            TransactionDetails response = CropAdvisory.SaveCropAdvisoryBlock(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveCropAdvisoryCrop")]
        [ActionName("SaveCropAdvisoryCrop")]
        public TransactionDetails SaveCropAdvisoryCrop(CropAdvisoryCrop ObjDetails)
        {
            TransactionDetails response = CropAdvisory.SaveCropAdvisoryCrop(ObjDetails);
            return response;
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveCropAdvisoryFavouriteList")]
        [ActionName("SaveCropAdvisoryFavouriteList")]
        public TransactionDetails SaveCropAdvisoryFavouriteList(CropAdvisoryFavourites objFavourites)
        {
            TransactionDetails response = CropAdvisory.SaveCropAdvisoryFavouriteList(objFavourites);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveCropAdvisoryFeedbackList")]
        [ActionName("SaveCropAdvisoryFeedbackList")]
        public TransactionDetails SaveCropAdvisoryFeedbackList(CropAdvisoryFeedback objFeedback)
        {
            TransactionDetails response = CropAdvisory.SaveCropAdvisoryFeedbackList(objFeedback);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveLanguageList")]
        [ActionName("SaveLanguageList")]
        public TransactionDetails SaveLanguageList(Languages objLanguage)
        {
            TransactionDetails response = CropAdvisory.SaveLanguageList(objLanguage);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisoryCategory")]
        [ActionName("GetCropAdvisoryCategory")]
        public CropAdvisoryResponse GetCropAdvisoryCategory(CropAdvisoryDetails ObjDetails)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvisoryCategory(ObjDetails);
            return response;
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("GetRatingList")]
        [ActionName("GetRatingList")]
        public CropAdvisoryResponse GetRatingList(CropAdvisoryDetails ObjDetails)
        {
            CropAdvisoryResponse response = CropAdvisory.GetRatingList(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisoryofCropAdvisoryCategory")]
        [ActionName("GetCropAdvisoryofCropAdvisoryCategory")]
        public CropAdvisoryResponse GetCropAdvisoryofCropAdvisoryCategory(CropAdvisoryDetails ObjDetails)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvisoryofCropAdvisoryCategory(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisory")]
        [ActionName("GetCropAdvisory")]
        public CropAdvisoryResponse GetCropAdvisory(CropAdvisoryDetails ObjDetails)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvisory(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisoryFavouriteRatingList")]
        [ActionName("GetCropAdvisoryFavouriteRatingList")]
        public CropAdvisoryResponse GetCropAdvisoryFavouriteRatingList(CropAdvisoryDetails ObjDetails)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvisoryFavouriteRatingList(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisoryTopValues")]
        [ActionName("GetCropAdvisoryTopValues")]
        public CropAdvisoryResponse GetCropAdvisoryTopValues(CropAdvisoryDetails ObjDetails)
        {
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvisoryTopValues(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetGPSCropAdvisoryTopValues")]
        [ActionName("GetGPSCropAdvisoryTopValues")]
        public CropAdvisoryResponse GetGPSCropAdvisoryTopValues(CropAdvisoryDetails ObjDetails)
        {            
            CropAdvisoryResponse response = CropAdvisory.GetGPSCropAdvisoryTopValues(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SearchCamList")]
        [ActionName("SearchCamList")]
        public CropAdvisoryResponse SearchCamList(CropAdvisoryDetails ObjDetails)
        {
            CropAdvisoryResponse response = CropAdvisory.SearchCamList(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SearchCropAdvisory")]
        [ActionName("SearchCropAdvisory")]
        public CropAdvisoryResponse SearchCropAdvisory(CropAdvisoryDetails ObjDetails)
        {
            CropAdvisoryResponse response = CropAdvisory.SearchCropAdvisory(ObjDetails);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCAMDistrictMapping")]
        [ActionName("GetCAMDistrictMapping")]
        public CropAdvisoryResponse GetCAMDistrictMapping(CropAdvisoryDetails objCropAdvisory)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCAMDistrictMapping(objCropAdvisory);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCAMBlockMapping")]
        [ActionName("GetCAMBlockMapping")]
        public CropAdvisoryResponse GetCAMBlockMapping(CropAdvisoryDetails objCropAdvisory)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCAMBlockMapping(objCropAdvisory);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvyDistMapping")]
        [ActionName("GetCropAdvyDistMapping")]
        public CropAdvisoryResponse GetCropAdvyDistMapping(CropAdvisoryDetails objCropAdvisory)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvyDistMapping(objCropAdvisory);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvyBlockMapping")]
        [ActionName("GetCropAdvyBlockMapping")]
        public CropAdvisoryResponse GetCropAdvyBlockMapping(CropAdvisoryDetails objCropAdvisory)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvyBlockMapping(objCropAdvisory);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvyCropMapping")]
        [ActionName("GetCropAdvyCropMapping")]
        public CropAdvisoryResponse GetCropAdvyCropMapping(CropAdvisoryDetails objCropAdvisory)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvyCropMapping(objCropAdvisory);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisoryByID")]
        [ActionName("GetCropAdvisoryByID")]
        public CropAdvisoryResponse GetCropAdvisoryByID(CropAdvisoryDetails objCropAdvisory)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvisoryByID(objCropAdvisory);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisoryCategoryByID")]
        [ActionName("GetCropAdvisoryCategoryByID")]
        public CropAdvisoryResponse GetCropAdvisoryCategoryByID(CropAdvisoryDetails objCropAdvisory)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvisoryCategoryByID(objCropAdvisory);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisoryAttachments")]
        [ActionName("GetCropAdvisoryAttachments")]
        public CropAdvisoryResponse GetCropAdvisoryAttachments(CropAdvisoryDetails objCropAdvisory)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvisoryAttachments(objCropAdvisory);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCrops")]
        [ActionName("GetCrops")]
        public CropAdvisoryResponse GetCrops(CropAdvisoryCrop objCrop)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCrops(objCrop);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropCategory")]
        [ActionName("GetCropCategory")]
        public CropAdvisoryResponse GetCropCategory(CropAdvisoryCropCategory objCrop)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropCategory(objCrop);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetCropAdvisoryFavouriteList")]
        [ActionName("GetCropAdvisoryFavouriteList")]
        public CropAdvisoryResponse GetCropAdvisoryFavouriteList(CropAdvisoryDetails objCrop)
        {
            CropAdvisoryResponse response = CropAdvisory.GetCropAdvisoryFavouriteList(objCrop);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetLanguageList")]
        [ActionName("GetLanguageList")]
        public CropAdvisoryResponse GetLanguageList(Languages objLanguages)
        {
            CropAdvisoryResponse response = CropAdvisory.GetLanguageList(objLanguages);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetFeedbackById")]
        [ActionName("GetFeedbackById")]
        public CropAdvisoryResponse GetFeedbackById(CropAdvisoryFeedback objCropAdvisoryFeedback)
        {
            CropAdvisoryResponse response = CropAdvisory.GetFeedbackById(objCropAdvisoryFeedback);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryFromIMD")]
        [ActionName("GetAdvisoryFromIMD")]
        public string GetAdvisoryFromIMD()
        {
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            return CropAdvisory.GetAdvisoryFromIMD();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId1_5FromIMD")]
        [ActionName("GetAdvisoryByStateId1_5FromIMD")]
        public async Task<string> GetAdvisoryByStateId1_5FromIMD()
        {
            _log.Info("starting GetAdvisoryByStateId1_5FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId1_5FromIMD();
            _log.Info("ending GetAdvisoryByStateId1_5FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateAndDistrict")]
        [ActionName("GetAdvisoryByStateAndDistrict")]
        public async Task<string> GetAdvisoryByStateAndDistrict(RequestCropAdvisoryInput requestCropAdvisoryInput)
        {
            _log.Info("starting GetAdvisoryByStateAndDistrict controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateAndDistrict(requestCropAdvisoryInput.stateId, requestCropAdvisoryInput.distrctId, requestCropAdvisoryInput.startDate, requestCropAdvisoryInput.endDate);
            _log.Info("ending GetAdvisoryByStateAndDistrict controller service");
            return result;
        }
        


        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId6_10FromIMD")]
        [ActionName("GetAdvisoryByStateId6_10FromIMD")]
        public async Task<string> GetAdvisoryByStateId6_10FromIMD()
        {
            _log.Info("starting GetAdvisoryByStateId6_10FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId6_10FromIMD();
            _log.Info("ending GetAdvisoryByStateId6_10FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId11_15FromIMD")]
        [ActionName("GetAdvisoryByStateId11_15FromIMD")]
        public async Task<string> GetAdvisoryByStateId11_15FromIMD()
        {
            _log.Info("starting GetAdvisoryByStateId11_15FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId11_15FromIMD();
            _log.Info("ending GetAdvisoryByStateId11_15FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId16_20FromIMD")]
        [ActionName("GetAdvisoryByStateId16_20FromIMD")]
        public async Task<string> GetAdvisoryByStateId16_20FromIMD()
        {
            _log.Info("starting GetAdvisoryByStateId16_20FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId16_20FromIMD();
            _log.Info("ending GetAdvisoryByStateId16_20FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId21_25FromIMD")]
        [ActionName("GetAdvisoryByStateId21_25FromIMD")]
        public async Task<string> GetAdvisoryByStateId21_25FromIMD()
        {
            _log.Info("starting GetAdvisoryByStateId21_25FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId21_25FromIMD();
            _log.Info("ending GetAdvisoryByStateId21_25FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId26_30FromIMD")]
        [ActionName("GetAdvisoryByStateId26_30FromIMD")]
        public async Task<string> GetAdvisoryByStateId26_30FromIMD()
        {
            _log.Info("starting GetAdvisoryByStateId26_30FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId26_30FromIMD();
            _log.Info("ending GetAdvisoryByStateId26_30FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId31_35FromIMD")]
        [ActionName("GetAdvisoryByStateId31_35FromIMD")]
        public async Task<string> GetAdvisoryByStateId31_35FromIMD()
        {
            _log.Info("starting GetAdvisoryByStateId31_35FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId31_35FromIMD();
            _log.Info("ending GetAdvisoryByStateId31_35FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId36_37FromIMD")]
        [ActionName("GetAdvisoryByStateId36_37FromIMD")]
        public async Task<string> GetAdvisoryByStateId36_37FromIMD()
        {
            _log.Info("starting GetAdvisoryByStateId36_37FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId36_37FromIMD();
            _log.Info("ending GetAdvisoryByStateId36_37FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId1_5FromIMDBlock")]
        [ActionName("GetAdvisoryByStateId1_5FromIMDBlock")]
        public async Task<string> GetAdvisoryByStateId1_5FromIMDBlock()
        {
            _log.Info("starting GetAdvisoryByStateId1_5FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId1_5FromIMDBlock();
            _log.Info("ending GetAdvisoryByStateId1_5FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId6_10FromIMDBlock")]
        [ActionName("GetAdvisoryByStateId6_10FromIMDBlock")]
        public async Task<string> GetAdvisoryByStateId6_10FromIMDBlock()
        {
            _log.Info("starting GetAdvisoryByStateId6_10FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId6_10FromIMDBlock();
            _log.Info("ending GetAdvisoryByStateId6_10FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId11_15FromIMDBlock")]
        [ActionName("GetAdvisoryByStateId11_15FromIMDBlock")]
        public async Task<string> GetAdvisoryByStateId11_15FromIMDBlock()
        {
            _log.Info("starting GetAdvisoryByStateId11_15FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId11_15FromIMDBlock();
            _log.Info("ending GetAdvisoryByStateId11_15FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId16_20FromIMDBlock")]
        [ActionName("GetAdvisoryByStateId16_20FromIMDBlock")]
        public async Task<string> GetAdvisoryByStateId16_20FromIMDBlock()
        {
            _log.Info("starting GetAdvisoryByStateId16_20FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId16_20FromIMDBlock();
            _log.Info("ending GetAdvisoryByStateId16_20FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId21_25FromIMDBlock")]
        [ActionName("GetAdvisoryByStateId21_25FromIMDBlock")]
        public async Task<string> GetAdvisoryByStateId21_25FromIMDBlock()
        {
            _log.Info("starting GetAdvisoryByStateId21_25FromIMD controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId21_25FromIMDBlock();
            _log.Info("ending GetAdvisoryByStateId21_25FromIMD controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId26_30FromIMDBlock")]
        [ActionName("GetAdvisoryByStateId26_30FromIMDBlock")]
        public async Task<string> GetAdvisoryByStateId26_30FromIMDBlock()
        {
            _log.Info("starting GetAdvisoryByStateId26_30FromIMDBlock controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId26_30FromIMDBlock();
            _log.Info("ending GetAdvisoryByStateId26_30FromIMDBlock controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId31_35FromIMDBlock")]
        [ActionName("GetAdvisoryByStateId31_35FromIMDBlock")]
        public async Task<string> GetAdvisoryByStateId31_35FromIMDBlock()
        {
            _log.Info("starting GetAdvisoryByStateId31_35FromIMDBlock controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId31_35FromIMDBlock();
            _log.Info("ending GetAdvisoryByStateId31_35FromIMDBlock controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("GetAdvisoryByStateId36_37FromIMDBlock")]
        [ActionName("GetAdvisoryByStateId36_37FromIMDBlock")]
        public async Task<string> GetAdvisoryByStateId36_37FromIMDBlock()
        {
            _log.Info("starting GetAdvisoryByStateId36_37FromIMDBlock controller service");
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            var result = await CropAdvisory.GetAdvisoryByStateId36_37FromIMDBlock();
            _log.Info("ending GetAdvisoryByStateId36_37FromIMDBlock controller service");
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveCropsInMaster")]
        [ActionName("SaveCropsInMaster")]
        public string SaveCropsInMasterFromIMD()
        {
            HttpContext.Current.Server.ScriptTimeout = GlobalConstant.TimeOutValue;
            return CropAdvisory.SaveCropsInMasterIMD(); 
        }

        #endregion methods

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("SaveCropsImages")]
        //[ActionName("SaveCropsImages")]
        //[SwaggerOperation(operationId: "UploadImages")]
        //public async Task<string> SaveCropsImages(int cropId)
        //{                               
        //    string root = System.Web.HttpContext.Current.Server.MapPath("~/App_Data");
        //    var provider = new MultipartFormDataStreamProvider(root);
        //    var filename = "";
        //    var fileType = "";

        //    try
        //    {
        //        // Read the form data.
        //        await Request.Content.ReadAsMultipartAsync(provider); //image / jpeg

        //        // This illustrates how to get the file names.
        //        foreach (MultipartFileData file in provider.FileData)
        //        {
        //            Trace.WriteLine(file.Headers.ContentDisposition.FileName);
        //            Trace.WriteLine("Server file path: " + file.LocalFileName);
        //            filename = file.LocalFileName;
        //            fileType = file.Headers.ContentType.ToString().Substring(0,5);
        //        }
        //        MemoryStream stream = new MemoryStream(System.IO.File.ReadAllBytes(filename));
        //        BinaryReader binaryReader = new BinaryReader(stream);
        //        byte[] imageBytes = binaryReader.ReadBytes((Int32)stream.Length);

        //        System.IO.File.Delete(filename);
        //        var obj = new CropImageForMasterTable()
        //        {
        //            ByteStream = imageBytes,
        //            Type = fileType,
        //            CropID = cropId
        //        };

        //        var result = CropAdvisory.SaveCropImageInMater(obj);
        //        if (result.IsSuccessful) return result.SuccessMessage;
        //    }
        //    catch (Exception ex)
        //    {
        //        return "";
        //    }
        //    return null;
        //}


        #region Public Methods  

        /// <summary>  
        /// This method is created to upload the image.  
        /// </summary>  
        /// <returns></returns>  
        [HttpPost, ActionName("UploadImage")]
        [Route("SaveCropsImagesInFile")]
        [SwaggerOperation(operationId: "UploadImages")]
        [AllowAnonymous]
        public async Task<HttpResponseMessage> UploadImage(int cropId)
        {
            #region Variables  
            HttpResponseMessage response = new HttpResponseMessage();
            string baseURL = ConfigurationManager.AppSettings["BaseURL"];
            #endregion
            string sub = string.Empty;
            int ImageResult = 0;

            if (!Request.Content.IsMimeMultipartContent())
            {
                return Request.CreateResponse<string>(HttpStatusCode.BadRequest, "This is not Mime Multipart Content");
            }

            //This is the static path for user images  
            string rootPath = HostingEnvironment.MapPath("~/CropsImage/");
            System.IO.Directory.CreateDirectory(rootPath);
            //get the path where content of MIME multipart body parts are written to  
            var provider = new MultipartFormDataStreamProvider(HostingEnvironment.MapPath("~/CropsImage/"));
            try
            {
                //read multi part data  
                await Request.Content.ReadAsMultipartAsync(provider);
               
                //get the file name from returned data  
                string uploadedFileName = provider.FileData.First().Headers.ContentDisposition.FileName;
                if (uploadedFileName.Length == 0)
                {
                    return Request.CreateResponse<string>(HttpStatusCode.BadRequest, "Image file not found");
                }

                string uploadedFileNameWithBackSlash = uploadedFileName.LastIndexOf("\\").ToString();

                int position = uploadedFileName.LastIndexOf('\\');


                string fileNameext = string.Empty;
                var fileName = uploadedFileName.Substring(uploadedFileName.LastIndexOf(("\\")) + 1);

                int fileExtPos = fileName.LastIndexOf(".");

                if (fileExtPos >= 0)
                    fileNameext = (fileName.Substring(fileExtPos, (fileName.Length - fileExtPos))).Replace("\"", "");

                sub = fileNameext;
                //check file is image type  
                string[] extensionArray = { ".jpg,.png,.JPEG,.PNG,.bmp" };

                List<string> extentions = extensionArray.FirstOrDefault().Split(',').Where(c => c.Equals(sub.ToLower())).ToList();
                if (extentions.Count == 0)
                {
                    return Request.CreateResponse<string>(HttpStatusCode.BadRequest, "file not supported");
                }

                String strFinalFileName = string.Empty;
                strFinalFileName = Guid.NewGuid().ToString().Trim().Replace(" ", "").Replace("-", "") + sub;

                String strDatabaseFilePath = string.Empty;

                //rootPath = rootPath + "\\Images\\";
                strDatabaseFilePath = "/CropsImage/" + strFinalFileName;

                if (!System.IO.Directory.Exists(rootPath))
                {
                    System.IO.Directory.CreateDirectory(rootPath);
                }

                var obj = new CropImageForMasterTable()
                {
                    ByteStream = null,
                    Type = null,
                    CropID = cropId,
                    ImagePath = string.Concat(baseURL, strDatabaseFilePath)// Path.Combine(baseURL, strDatabaseFilePath)
                };
                //do stuff to save the file path into the datbase  
                var result = CropAdvisory.SaveCropImagePathInDB(obj);
                if (!result.IsSuccessful) {
                    //delete temp file  
                    if (File.Exists(provider.FileData.First().LocalFileName))
                    {
                        File.Delete(provider.FileData.First().LocalFileName);
                    }
                    return Request.CreateResponse(HttpStatusCode.BadRequest, result.ErrorMessage);
                }
                

                // After saving image compress it and save image to the directory.  
                var fullFilePath = provider.FileData.First().LocalFileName + sub;
                var copyToPath = rootPath + strFinalFileName;
                FileStream stream = File.OpenRead(provider.FileData.First().LocalFileName);
                byte[] fileBytes = new byte[stream.Length];

                stream.Read(fileBytes, 0, fileBytes.Length);
                double fileSizeKB = stream.Length / 1024;

                ImageResult = await NewCompressImageWithNewDimensions(stream, copyToPath, provider.FileData.First().Headers.ContentDisposition.Size.HasValue ? Convert.ToDouble(provider.FileData.First().Headers.ContentDisposition.Size) : 0);
                stream.Close();

                //delete temp file
                if (File.Exists(provider.FileData.First().LocalFileName))
                {
                    File.Delete(provider.FileData.First().LocalFileName);
                }

                response = Request.CreateResponse(HttpStatusCode.OK, result.SuccessMessage);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        #endregion Public Methods  

        #region Private Methods  
        /// <summary>  
        /// This method is created to compress the image.  
        /// </summary>  
        /// <param name="stream">file stream</param>  
        /// <param name="copyToPath">target path</param>  
        /// <param name="fileSizeKB">file size</param>  
        /// <returns></returns>  
        private async Task<int> NewCompressImageWithNewDimensions(FileStream stream, string copyToPath, double fileSizeKB)
        {
            int result = 0;
            try
            {
                using (var image = Image.FromStream(stream))
                {
                    double scaleFactor;
                    if (fileSizeKB <= 900)
                    {
                        scaleFactor = 0.9;
                    }
                    else if (fileSizeKB <= 1500)
                    {
                        scaleFactor = 0.8;
                    }
                    else if (fileSizeKB <= 2000)
                    {
                        scaleFactor = 0.7;
                    }
                    else
                    {
                        scaleFactor = 0.3;
                    }
                    var newWidth = (int)(image.Width * scaleFactor);
                    var newHeight = (int)(image.Height * scaleFactor);
                    var CompressImage = new Bitmap(newWidth, newHeight);
                    var CompressImageGraph = Graphics.FromImage(CompressImage);
                    CompressImageGraph.CompositingQuality = CompositingQuality.HighQuality;
                    CompressImageGraph.SmoothingMode = SmoothingMode.HighQuality;
                    CompressImageGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    var imageRectangle = new Rectangle(0, 0, newWidth, newHeight);
                    CompressImageGraph.DrawImage(image, imageRectangle);
                    CompressImage.Save(copyToPath, image.RawFormat);
                    if (File.Exists(copyToPath))
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 2;
                    }
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("RemoveCropAdvisoryFavouriteList")]
        [ActionName("RemoveCropAdvisoryFavouriteList")]
        public TransactionDetails RemoveCropAdvisoryFavouriteList(CropAdvisoryFavourites objFavourites)
        {
            TransactionDetails response = CropAdvisory.RemoveCropAdvisoryFavouriteList(objFavourites);
            return response;
        }

        #endregion Private Methods  
    }
}
