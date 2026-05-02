using System;
using System.Configuration;
using System.Web;
using System.Web.Mvc;
using AGROMET.Models;
using Newtonsoft.Json.Linq;
using AGROMET.Domain;
using System.Web.Security;

namespace AGROMET.Controllers
{
    public class AccountController : Controller
    {
        public string APIURL = ConfigurationManager.AppSettings["API"].ToString();
        public string Language = "English";
        LoginModelResponse ObjloginModelResponse = new LoginModelResponse();
        GetUsersResponse response = new GetUsersResponse();
        public LoginModelResponse GetUserDetails(string LogInId, string LogInPassword)
        {
            string url = APIURL + "Users/GetUserLoginDetails";
            JObject jobj = new JObject
            {
              { "LogInId",LogInId },
              { "LogInPassword",LogInPassword },
              { "LanguageType", Language },
              { "RefreshDateTime","2019-01-01" }
            };
            return APIResponse.GetUserDetailsResponse(jobj, url);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetFarmerDetails(string LogInId, string LogInPassword)
        {
            LoginModelResponse response = new LoginModelResponse();
            string url = APIURL + "Users/GetUserLoginDetails";
            JObject jobj = new JObject
            {
              { "LogInId",LogInId },
              { "LogInPassword",LogInPassword },
              { "LanguageType", Language },
              { "RefreshDateTime","2019-01-01" }
            };
            response = APIResponse.GetUserDetailsResponse(jobj, url);
            return Json(response.ObjUserList, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetForgetPassword(string LogInId)
        {
            string urlState = APIURL + "Users/GetForgetPassword";
            JObject jobjState = new JObject
            {
                { "LogInId", LogInId }
            };
            response = APIResponse.GetUsersResponse(jobjState, urlState);
            return Json(response.SuccessMessage, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return PartialView();
        }
        [HttpPost]
        public ActionResult Login(LoginModel loginModel, string returnUrl)
        {
            ObjloginModelResponse = GetUserDetails(loginModel.EmailID, loginModel.SignInPassword);
            if (ObjloginModelResponse.IsSuccessful == true && ObjloginModelResponse.ObjUserList.Count > 0)
            {
                if (ObjloginModelResponse.ObjUserList[0].LogInPassword == loginModel.SignInPassword)
                {
                    if (ObjloginModelResponse.ObjUserList[0].RoleId == 2 || ObjloginModelResponse.ObjUserList[0].RoleId == 3)
                    {
                        string Name = ObjloginModelResponse.ObjUserList[0].FirstName + " " + ObjloginModelResponse.ObjUserList[0].LastName;
                        HttpCookie cookie1 = new HttpCookie("Name");
                        if (Name != null)
                        {
                            cookie1.Value = Name;
                        }
                        else
                        {
                            cookie1.Value = "";
                        }
                        HttpCookie cookie2 = new HttpCookie("StateID")
                        {
                            Value = ObjloginModelResponse.ObjUserList[0].StateID.ToString()
                        };
                        HttpCookie cookie3 = new HttpCookie("DistrictID")
                        {
                            Value = ObjloginModelResponse.ObjUserList[0].DistrictID.ToString()
                        };
                        HttpCookie cookie4 = new HttpCookie("BlockID")
                        {
                            Value = ObjloginModelResponse.ObjUserList[0].BlockID.ToString()
                        };
                        HttpCookie cookie5 = new HttpCookie("RoleName");
                        if (ObjloginModelResponse.ObjUserList[0].RoleType != null)
                        {
                            cookie5.Value = ObjloginModelResponse.ObjUserList[0].RoleType.ToString();
                        }
                        else
                        {
                            cookie5.Value = "";
                        }
                        byte[] Image = ObjloginModelResponse.ObjUserList[0].ThumbNailBytes;
                        string base64String = "";
                        if (Image != null)
                        {
                            base64String = Convert.ToBase64String(Image, 0, Image.Length).ToString();
                        }
                        HttpCookie cookie6 = new HttpCookie("Image");
                        if (ObjloginModelResponse.ObjUserList[0].ThumbNailBytes != null)
                        {
                            cookie6.Value = base64String;
                        }
                        else
                        {
                            cookie6.Value = "";
                        }
                        HttpCookie cookie7 = new HttpCookie("LanguageName")
                        {
                            Value = "English" //ObjloginModelResponse.ObjUserList[0].LanguageName.ToString()
                        };
                        HttpCookie cookie8 = new HttpCookie("TypeOfRole")
                        {
                            Value = ObjloginModelResponse.ObjUserList[0].TypeOfRole.ToString()
                        };
                        HttpCookie cookie9 = new HttpCookie("RoleType")
                        {
                            Value = ObjloginModelResponse.ObjUserList[0].RoleType.ToString()
                        };
                        HttpCookie cookie10 = new HttpCookie("CultureCode")
                        {
                            Value = ObjloginModelResponse.ObjUserList[0].CultureCode.ToString()
                        };
                        HttpCookie cookie11 = new HttpCookie("RoleId")
                        {
                            Value = ObjloginModelResponse.ObjUserList[0].RoleId.ToString()
                        };
                        Response.Cookies.Add(cookie1);
                        Response.Cookies.Add(cookie2);
                        Response.Cookies.Add(cookie3);
                        Response.Cookies.Add(cookie4);
                        Response.Cookies.Add(cookie5);
                        Response.Cookies.Add(cookie6);
                        Response.Cookies.Add(cookie7);
                        Response.Cookies.Add(cookie8);
                        Response.Cookies.Add(cookie9);
                        Response.Cookies.Add(cookie10);
                        Response.Cookies.Add(cookie11);
                        FormsAuthentication.SetAuthCookie(Name, false);
                        if (returnUrl != null && returnUrl != "")
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Dashboard", "AGROMET");
                        }
                    }
                    else
                    {
                        @ViewBag.message = "Please login using mobile application!";
                        return PartialView(loginModel);
                    }
                }
                else
                {
                    @ViewBag.message = "Invalid Pin!";
                    return PartialView(loginModel);
                }
            }
            else
            {
                @ViewBag.message = "No User Found!";
                return PartialView(loginModel);
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1000));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            return RedirectToAction("Login");
        }
        public ActionResult AdvisoryDetails(string AdvisoryId, string LanguageType)
        {
            ViewBag.LanguageType = LanguageType;
            ViewBag.AdvisoryId = AdvisoryId;
            return PartialView();
        }
    }
}