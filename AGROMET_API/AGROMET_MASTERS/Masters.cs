using AGROMET_COMMON;
using AGROMET_DAL;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROMET_MASTERS
{
    public class TitleMaster
    {
        public int TitleID { get; set; }
        public string TitleName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class LanguageMaster
    {
        public int LanguageTypeId { get; set; }
        public string LanguageTypeName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }

        public string Culture { get; set; }
    }
    public class GenderMaster
    {
        public int GenderID { get; set; }
        public string GenderName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
    }
    public class DistrictMaster
    {
        public int ScientistID { get; set; }
        public int StateID { get; set; }
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }

    }
    public class StateMaster
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
        public int ScientistID { get; set; }

    }

    public class BlockMasterAsd
    {
        public string AsdID { get; set; }
        public int BlockID { get; set; }
        public string BlockName { get; set; }
        public string RefreshDateTime { get; set; }
    }

    public class AsdMaster
    {
        public int AsdID { get; set; }
        public string AsdName { get; set; }
        public int DistrictID { get; set; }
        public int StateID { get; set; }
        public string RefreshDateTime { get; set; }
        public string LanguageType { get; set; }
        public int ScientistID { get; set; }
    }

    public class BlockMaster
    {
        public int AsdID { get; set; }
        public int BlockID { get; set; }
        public int DistrictID { get; set; }
        public string BlockName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
        public int ScientistID { get; set; }

    }
    public class CropMaster
    {
        public int CropID { get; set; }
        public string CropName { get; set; }
        public string LanguageType { get; set; }
        public string RefreshDateTime { get; set; }
        public int ScientistID { get; set; }        
    }
    public class CropAdvisoryCategoryMaster
    {
        public int CACID { get; set; }
        public int CropID { get; set; }
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

    public class CountryCodeMaster
    {
        public int CountryCodeId { get; set; }
        public string CountryCodes { get; set; }
        public string CountryName { get; set; }
        public string CreatedDate { get; set; }
        public string LastUpdated { get; set; }
        public string Createdbyint { get; set; }
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

    public class UpdateDataDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UpdateName { get; set; }
    }

    public class GetMasterResponse
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public List<TitleMaster> ObjTitleMasterList { get; set; }
        public List<LanguageMaster> ObjLanguageTypeMasterList { set; get; }
        public List<GenderMaster> ObjGenderMasterList { get; set; }
        public List<DistrictMaster> ObjDistrictMasterList { get; set; }
        public List<StateMaster> ObjStateMasterList { get; set; }
        public List<BlockMaster> ObjBlockMasterList { get; set; }
        public List<AsdMaster> ObjAsdMasterList { get; set; }
        public List<BlockMasterAsd> ObjBlockMasterAsdList { get; set; }
        public List<CropMaster> ObjCropMasterList { get; set; }
        public List<CropAdvisoryCategoryMaster> ObjAdvisoryCategoryMasterList { get; set; }
        public List<DepartmentMaster> ObjDepartmentMasterList { get; set; }
        public List<BlobMaster> ObjBlobMasterList { get; set; }
        public List<CountryCodeMaster> ObjCountryCodeMasterList { get; set; }

        public GetMasterResponse()
        {
            this.ObjTitleMasterList = new List<TitleMaster>();
            this.ObjLanguageTypeMasterList = new List<LanguageMaster>();
            this.ObjGenderMasterList = new List<GenderMaster>();
            this.ObjDistrictMasterList = new List<DistrictMaster>();
            this.ObjBlockMasterList = new List<BlockMaster>();
            this.ObjBlockMasterAsdList = new List<BlockMasterAsd>();
            this.ObjAsdMasterList = new List<AsdMaster>();
            this.ObjCropMasterList = new List<CropMaster>();
            this.ObjAdvisoryCategoryMasterList = new List<CropAdvisoryCategoryMaster>();
            this.ObjBlobMasterList = new List<BlobMaster>();
            this.ObjCountryCodeMasterList = new List<CountryCodeMaster>();
        }
    }
    public class Masters
    {
        public static string storageAccountName = ConfigurationManager.AppSettings["AccountName"].ToString();
        public static string storageAccountKey = ConfigurationManager.AppSettings["AccountKey"].ToString();
        public static string AudioContainerName = ConfigurationManager.AppSettings["AudioContainerName"].ToString();
        public static string GoogleTransalateKey = ConfigurationManager.AppSettings["GoogleTransalateKey"].ToString();

        #region GetTitleMasterList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetTitleMasterList
                Params              :-
                Usage               :-To Get Title Master List
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */
        public static GetMasterResponse GetTitleMasterList(TitleMaster objTitleMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@ptitleid",objTitleMaster.TitleID),
            new SqlParameter("@planguagetype", objTitleMaster.LanguageType),
            new SqlParameter("@pRefreshdatetime",objTitleMaster.RefreshDateTime)

            };
                dt = SQLHelper.Execute("spGet_TitleMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjTitleMasterList = (from DataRow dr in dt.Rows
                                                   select new TitleMaster
                                                   {
                                                       TitleID = (dr["titleid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["titleid"]),
                                                       TitleName = (dr["titlename"]) == DBNull.Value ? "" : Convert.ToString(dr["titlename"]),
                                                       RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

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

        #region GetLanguageMasterList

        public static GetMasterResponse GetLanguageMasterList(LanguageMaster objlanguagemaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pLanguageID",objlanguagemaster.LanguageTypeId),
                  new SqlParameter("@pRefreshdatetime",objlanguagemaster.RefreshDateTime),
                  new SqlParameter("@planguagetype",objlanguagemaster.LanguageType)
                };
                dt = SQLHelper.Execute("spGet_LanguageMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjLanguageTypeMasterList = (from DataRow dr in dt.Rows
                                                          select new LanguageMaster
                                                          {
                                                              LanguageTypeId = (dr["LanguageID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["LanguageID"]),

                                                              LanguageTypeName = (dr["LanguageName"]) == DBNull.Value ? "" : Convert.ToString(dr["LanguageName"]),

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

        #region GetGenderMasterList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetGenderMasterList
                Params              :-
                Usage               :-To Get Gender Master List
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                 
           </Summary>                 
        */
        public static GetMasterResponse GetGenderMasterList(GenderMaster objGenderMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pgenderid",objGenderMaster.GenderID),
            new SqlParameter("@planguagetype", objGenderMaster.LanguageType),
            new SqlParameter("@pRefreshdatetime",objGenderMaster.RefreshDateTime)

            };
                dt = SQLHelper.Execute("spGet_GenderMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjGenderMasterList = (from DataRow dr in dt.Rows
                                                    select new GenderMaster
                                                    {
                                                        GenderID = (dr["genderid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["genderid"]),
                                                        GenderName = (dr["gendername"]) == DBNull.Value ? "" : Convert.ToString(dr["gendername"]),
                                                        RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

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

        #region GetDistrictMasterList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetDistrictMasterList
                Params              :-
                Usage               :-To Get DistrictMaster List
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */

        public static GetMasterResponse GetDistrictMasterList(DistrictMaster objDistrictMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pScientistID",objDistrictMaster.ScientistID),
                    new SqlParameter("@pstateid",objDistrictMaster.StateID),
                    new SqlParameter("@planguagetype", objDistrictMaster.LanguageType),
                    new SqlParameter("@pRefreshdatetime",objDistrictMaster.RefreshDateTime)

                };
                dt = SQLHelper.Execute("spGet_DistrictMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjDistrictMasterList = (from DataRow dr in dt.Rows
                                                      select new DistrictMaster
                                                      {
                                                          StateID = (dr["stateid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["stateid"]),
                                                          DistrictID = (dr["districtid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["districtid"]),
                                                          DistrictName = (dr["districtname"]) == DBNull.Value ? "" : Convert.ToString(dr["districtname"]),
                                                          RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

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

        #region GetStateMasterList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetStateMasterList
                Params              :-
                Usage               :-To Get State Master List
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :- 
                ModifiedBy_V1       :-
                Modified params_v1  :- 
                ModifiedDate_V1     :- 
           </Summary>                 
        */
        public static GetMasterResponse GetStateMasterList(StateMaster objStateMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pstateid",objStateMaster.StateID),
            new SqlParameter("@planguagetype", objStateMaster.LanguageType),
            new SqlParameter("@pscientistid", objStateMaster.ScientistID),
            new SqlParameter("@pRefreshdatetime",objStateMaster.RefreshDateTime)

            };
                dt = SQLHelper.Execute("spGet_StateMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjStateMasterList = (from DataRow dr in dt.Rows
                                                   select new StateMaster
                                                   {
                                                       StateID = (dr["stateid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["stateid"]),
                                                       StateName = (dr["statename"]) == DBNull.Value ? "" : Convert.ToString(dr["statename"]),
                                                       RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

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

        #region GetBlockMasterAsdList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetBlockMasterAsdList
                Params              :-
                Usage               :-
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */

        public static GetMasterResponse GetBlockMasterAsdList(BlockMasterAsd objBlockMasterAsd)
        {

            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pAsdID",objBlockMasterAsd.AsdID),
                    new SqlParameter("@pRefreshdatetime", objBlockMasterAsd.RefreshDateTime),


                };
                dt = SQLHelper.Execute("spGet_BlockMasterAsd", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjBlockMasterList = (from DataRow dr in dt.Rows
                                                   select new BlockMaster
                                                   {
                                                       BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                                                       BlockName = (dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"]),                                                       
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

        #region GetBlockMasterList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetBlockMasterList
                Params              :-
                Usage               :-
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */
        public static GetMasterResponse GetBlockMasterList(BlockMaster objBlockMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pScientistID",objBlockMaster.ScientistID),

                    new SqlParameter("@pdistrictid",objBlockMaster.DistrictID),
                    new SqlParameter("@planguagetype", objBlockMaster.LanguageType),

                    new SqlParameter("@pRefreshdatetime", objBlockMaster.RefreshDateTime),


                };
                dt = SQLHelper.Execute("spGet_BlockMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjBlockMasterList = (from DataRow dr in dt.Rows
                                                   select new BlockMaster
                                                   {
                                                       DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                                                       BlockID = (dr["BlockID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["BlockID"]),
                                                       BlockName = (dr["BlockName"]) == DBNull.Value ? "" : Convert.ToString(dr["BlockName"]),
                                                       RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

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

        #region GetASDMasterList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetASDMasterList
                Params              :-
                Usage               :-
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */
        public static GetMasterResponse GetASDMasterList(AsdMaster objAsdMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pdistrictid",objAsdMaster.DistrictID),
                    new SqlParameter("@pscientistid",objAsdMaster.ScientistID),
                    new SqlParameter("@planguagetype", objAsdMaster.LanguageType),
                    new SqlParameter("@pRefreshdatetime", objAsdMaster.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_AsdMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjAsdMasterList = (from DataRow dr in dt.Rows
                                                   select new AsdMaster
                                                   {
                                                       AsdID = (dr["AsdID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["AsdID"]),
                                                       AsdName = (dr["AsdName"]) == DBNull.Value ? "" : Convert.ToString(dr["AsdName"]),
                                                       DistrictID = (dr["DistrictID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DistrictID"]),
                                                       StateID = (dr["StateID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["StateID"]),
                                                       RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))
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

        #region GetCropMasterList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetCropMasterList
                Params              :-
                Usage               :-
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */
        public static GetMasterResponse GetCropMasterList(CropMaster objCropMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                    new SqlParameter("@pcropid",objCropMaster.CropID),
                    new SqlParameter("@planguagetype", objCropMaster.LanguageType),
                    new SqlParameter("@pScientistID", objCropMaster.ScientistID),
                    new SqlParameter("@pRefreshdatetime", objCropMaster.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CropMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjCropMasterList = (from DataRow dr in dt.Rows
                                                  select new CropMaster
                                                  {
                                                      CropID = (dr["cropid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["cropid"]),
                                                      CropName = (dr["cropname"]) == DBNull.Value ? "" : Convert.ToString(dr["cropname"]),
                                                      RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))                                                      
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

        #region GetCropMasterList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetCropMasterList
                Params              :-
                Usage               :-
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */
        public static GetMasterResponse GetCropAdvisoryCategoryMaster(CropAdvisoryCategoryMaster objCategory)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pCACID",objCategory.CACID),
                new SqlParameter("@pcropid",objCategory.CropID),
            new SqlParameter("@planguagetype", objCategory.LanguageType),
            new SqlParameter("@pRefreshdatetime", objCategory.RefreshDateTime),
            };
                dt = SQLHelper.Execute("spGet_CropAdvisoryCategoryMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjAdvisoryCategoryMasterList = (from DataRow dr in dt.Rows
                                                              select new CropAdvisoryCategoryMaster
                                                              {
                                                                  CACID = (dr["CACID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["CACID"]),
                                                                  CropAdvisoryCategory = (dr["CropAdvisoryCategory"]) == DBNull.Value ? "" : Convert.ToString(dr["CropAdvisoryCategory"]),
                                                                  RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

                                                              }).ToList();
                    response.IsSuccessful = true;
                }
                var List = response.ObjAdvisoryCategoryMasterList;
                var unique = (from o in List
                              orderby o.CACID ascending
                              group o by o.CropAdvisoryCategory into g
                              select g.First()).ToList();
                response.ObjAdvisoryCategoryMasterList = unique;

            }
            catch (Exception ex)
            {
                response.IsSuccessful = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        #endregion       

        #region GetDepartmentMasterList
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetDepartmentMasterList
                Params              :-
                Usage               :-To Get Department Master List
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */
        public static GetMasterResponse GetDepartmentMasterList(DepartmentMaster objDepartmentMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pDepartmentID",objDepartmentMaster.DepartmentID),
            new SqlParameter("@planguagetype", objDepartmentMaster.LanguageType),
            new SqlParameter("@pRefreshdatetime",objDepartmentMaster.RefreshDateTime)

            };
                dt = SQLHelper.Execute("spGet_DepartmentMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjDepartmentMasterList = (from DataRow dr in dt.Rows
                                                        select new DepartmentMaster
                                                        {
                                                            DepartmentID = (dr["DepartmentID"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["DepartmentID"]),
                                                            DepartmentName = (dr["DepartmentName"]) == DBNull.Value ? "" : Convert.ToString(dr["DepartmentName"]),
                                                            RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

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
        public static string GetKey()
        {
            return GoogleTransalateKey;
        }
        #region
        public static GetMasterResponse GetBlobMaster(BlobMaster obj)
        {
            GetMasterResponse response = new GetMasterResponse();
            BlobMaster objblob = new BlobMaster();
            objblob.AccountName = storageAccountName;
            objblob.AccountKey = storageAccountKey;
            objblob.ContainerName = AudioContainerName;
            response.ObjBlobMasterList.Add(objblob);
            response.IsSuccessful = true;
            return response;
        }
        #endregion

        #region GetLanguageMasterList

        public static GetMasterResponse GetCountryCodeMasterList(CountryCodeMaster objCCemaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pcountrycodeid",objCCemaster.CountryCodeId),
                  new SqlParameter("@pRefreshdatetime",objCCemaster.RefreshDateTime),
                };
                dt = SQLHelper.Execute("spGet_CountryCodes", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjCountryCodeMasterList = (from DataRow dr in dt.Rows
                                                         select new CountryCodeMaster
                                                         {
                                                             CountryCodeId = (dr["countrycodeid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["countrycodeid"]),

                                                             CountryCodes = (dr["countrycodes"]) == DBNull.Value ? "" : Convert.ToString(dr["countrycodes"]),
                                                             CountryName = (dr["countryname"]) == DBNull.Value ? "" : Convert.ToString(dr["countryname"]),

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

        #region GetStationDistrictMasters
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetStationDistrictMasters
                Params              :-
                Usage               :-
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */

        public static GetMasterResponse GetStationDistrictMasters(DistrictMaster objDistrictMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]

                {
                    new SqlParameter("@pstateid", objDistrictMaster.StateID),
            new SqlParameter("@planguagetype", objDistrictMaster.LanguageType),
            new SqlParameter("@pRefreshdatetime", objDistrictMaster.RefreshDateTime)

            };
                dt = SQLHelper.Execute("spGet_WeatherStationDistrictMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjDistrictMasterList = (from DataRow dr in dt.Rows
                                                      select new DistrictMaster
                                                      {
                                                          StateID = (dr["stateid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["stateid"]),
                                                          DistrictID = (dr["districtid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["districtid"]),
                                                          DistrictName = (dr["districtname"]) == DBNull.Value ? "" : Convert.ToString(dr["districtname"]),
                                                          RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

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

        #region GetStationStateMasters
        /*  <summary>          
                AuthorName          :- 
                MethodName          :- GetStationStateMasters
                Params              :-
                Usage               :-
                CreatedDate         :-
                ModifiedBy          :-
                Modified params     :- 
                ModifiedDate        :-                
           </Summary>                 
        */
        public static GetMasterResponse GetStationStateMasters(StateMaster objStateMaster)
        {
            GetMasterResponse response = new GetMasterResponse();
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] arrParams = new SqlParameter[]
                {
                new SqlParameter("@pstateid",objStateMaster.StateID),
            new SqlParameter("@planguagetype", objStateMaster.LanguageType),
            new SqlParameter("@pRefreshdatetime",objStateMaster.RefreshDateTime)

            };
                dt = SQLHelper.Execute("spGet_WeatherStationStateMaster", arrParams);

                if (dt.Rows.Count > 0)
                {
                    response.ObjStateMasterList = (from DataRow dr in dt.Rows
                                                   select new StateMaster
                                                   {
                                                       StateID = (dr["stateid"]) == DBNull.Value ? 0 : Convert.ToInt32(dr["stateid"]),
                                                       StateName = (dr["statename"]) == DBNull.Value ? "" : Convert.ToString(dr["statename"]),
                                                       RefreshDateTime = (dr["RefreshDateTime"] == DBNull.Value ? "" : Convert.ToString(dr["RefreshDateTime"]))

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

        #region GetCurrentLocationDetails
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

        /// <summary>
        /// GetNameFromExcel
        /// </summary>
        /// <returns></returns>
        public static List<UpdateDataDetails> GetNameFromExcel()
        {
            try
            {
                // get path
                var filePath = System.Configuration.ConfigurationManager.AppSettings["ExcelFile"];

                #region Read excel

                List<UpdateDataDetails> result = new List<UpdateDataDetails>();

                using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filePath, false))
                {
                    //create the object for workbook part  
                    WorkbookPart wbPart = doc.WorkbookPart;

                    //statement to get the sheet object  
                    Sheet mysheet = (Sheet)doc.WorkbookPart.Workbook.Sheets.ChildElements.GetItem(0);

                    //statement to get the worksheet object by using the sheet id  
                    Worksheet Worksheet = ((WorksheetPart)wbPart.GetPartById(mysheet.Id)).Worksheet;

                    //Note: worksheet has 4 children and the first child[1] = sheetviewdimension,....child[4]=sheetdata  
                    int wkschildno = 4;

                    //statement to get the sheetdata which contains the rows and cell in table  
                    SheetData Rows = (SheetData)Worksheet.ChildElements.GetItem(wkschildno);

                    int count = 1;
                    int rowCount = 1;

                    foreach (Row r in Rows.Elements<Row>())
                    {
                        // heading
                        if (rowCount == 1) { count++; rowCount++; continue; }

                        var cells = r.Elements<Cell>();

                        //station name
                        var A = cells.Where(c => c.CellReference.Value == ("B" + count.ToString())).FirstOrDefault();
                        var A1 = ReturnCellObject(wbPart, A);

                        //stationin name in hindi
                        var B = cells.Where(c => c.CellReference.Value == ("C" + count.ToString())).FirstOrDefault();
                        var B1 = ReturnCellObject(wbPart, B);

                        UpdateDataDetails datfromexcel = new UpdateDataDetails()
                        {
                            Name = A1,
                            UpdateName = B1
                        };

                        result.Add(datfromexcel);

                        count++;
                    }

                    doc.Close();
                }

                #endregion Read excel

                return result;
            }
            catch (Exception ex)
            {
                return null; 
            }

        }

        /// <summary>
        /// UpdateName
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="updateName"></param>
        /// <returns></returns>
        public static bool UpdateName(string Name, string updateName)
        {
            try
            {
                TransactionDetails response = new TransactionDetails();
                response.IsSuccessful = false;

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString);
                con.Open();
                string query = "update Master_Block set Telugu = @pupdateName where BlockName = @pName ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pupdateName", updateName);
                cmd.Parameters.AddWithValue("@pName", Name);
                 cmd.ExecuteNonQuery();
                return true;
                //SqlParameter[] arrParams = new SqlParameter[]
                //{
                //    new SqlParameter("@pName",Name),
                //    new SqlParameter("@pupdateName",updateName)
                //};
                //SQLHelper.Execute("spUpdateName", arrParams);

                //return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// ReturnCellObject
        /// </summary>
        /// <param name="wbPart"></param>
        /// <param name="cell"></param>
        /// <returns></returns>
        public static string ReturnCellObject(WorkbookPart wbPart, Cell cell)
        {
            string text = cell?.InnerText;

            switch (cell?.DataType?.Value)
            {
                case CellValues.SharedString:

                    // For shared strings, look up the value in the
                    // shared strings table.
                    var stringTable =
                        wbPart.GetPartsOfType<SharedStringTablePart>()
                        .FirstOrDefault();

                    // If the shared string table is missing, something 
                    // is wrong. Return the index that is in
                    // the cell. Otherwise, look up the correct text in 
                    // the table.
                    if (stringTable != null)
                    {
                        text =
                            stringTable.SharedStringTable
                            .ElementAt(int.Parse(text)).InnerText;
                    }
                    break;

                case CellValues.Boolean:
                    switch (text)
                    {
                        case "0":
                            text = "FALSE";
                            break;
                        default:
                            text = "TRUE";
                            break;
                    }
                    break;
            }
            return text;
        }

        #endregion

        #endregion
    }
}
