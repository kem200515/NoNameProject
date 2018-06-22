using BLL.BLL.Implement;
using BLL.BLL.Interface;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        private IUserBLL _userBLL = new UserBLL();
        [HttpPost]
        [Route("User/InsertUser")]
        public void InsertUser(UserModel userModel)
        {
            _userBLL.SaveUser(userModel);
        }
    }
}
