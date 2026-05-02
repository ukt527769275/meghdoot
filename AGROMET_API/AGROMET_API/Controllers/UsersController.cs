using AGROMET_USERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AGROMET_COMMON;

namespace AGROMET_API.Controllers
{
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {

        [AllowAnonymous]
        [HttpPost]
        [Route("GetUserLoginDetails")]
        [ActionName("GetUserLoginDetails")]
        public GetUsersResponse GetUserLoginDetails(UsersDetails objUserLoginDetail)
        {
            GetUsersResponse response = Users.GetUserLoginDetails(objUserLoginDetail);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetUserProfileDetails")]
        [ActionName("GetUserProfileDetails")]
        public GetUsersResponse GetUserProfileDetails(UserProfile objUserProfileDetail)
        {
            GetUsersResponse response = Users.GetUserProfileDetails(objUserProfileDetail);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveScientist")]
        [ActionName("SaveScientist")]
        public TransactionDetails SaveScientist(UsersDetails ObjDetails)
        {
            TransactionDetails response = Users.SaveScientist(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveFarmer")]
        [ActionName("SaveFarmer")]
        public TransactionDetails SaveFarmer(UsersDetails ObjDetails)
        {
            TransactionDetails response = Users.SaveFarmer(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveUserLocations")]
        [ActionName("SaveUserLocations")]
        public TransactionDetails SaveUserLocations(UserLocations ObjLocation)
        {
            TransactionDetails response = Users.SaveUserLocations(ObjLocation);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetUsersList")]
        [ActionName("GetUsersList")]
        public GetUsersResponse GetUsersList(UsersDetails ObjDetails)
        {
            GetUsersResponse response = Users.GetUsersList(ObjDetails);
            return response;
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("SearchUsersList")]
        [ActionName("SearchUsersList")]
        public GetUsersResponse SearchUsersList(UsersDetails ObjDetails)
        {
            GetUsersResponse response = Users.SearchUsersList(ObjDetails);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetUserBlocks")]
        [ActionName("GetUserBlocks")]
        public GetUsersResponse GetUserBlocks(UserBlock objblock)
        {
            GetUsersResponse response = Users.GetUserBlocks(objblock);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetUserLocations")]
        [ActionName("GetUserLocations")]
        public GetUsersResponse GetUserLocations(UserLocations objLocation)
        {
            GetUsersResponse response = Users.GetUserLocations(objLocation);
            return response;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetForgetPassword")]
        [ActionName("GetForgetPassword")]
        public GetUsersResponse GetForgetPassword(UsersDetails objUsers)
        {
            GetUsersResponse response = Users.GetForgetPassword(objUsers);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("RemoveUserLocations")]
        [ActionName("RemoveUserLocations")]
        public TransactionDetails RemoveUserLocations(UserLocations ObjLocation)
        {
            TransactionDetails response = Users.RemoveUserLocations(ObjLocation);
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("SaveUserProfilImage")]
        [ActionName("SaveUserProfilImage")]
        public TransactionDetails SaveUserProfilImage(UserProfileImageDetails ObjProfilImage)
        {
            TransactionDetails response = Users.SaveUserProfilImage(ObjProfilImage);
            return response;
        }

    }
}
