using BLL.BLL.Implement;
using BLL.BLL.Interface;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace XuatNhapKhoAPI.Controllers
{
    public class UserController : ApiController
    {
        private IUserBLL _userBLL;
        public UserController()
        {
            _userBLL = new UserBLL();
        }
        [HttpPost]
        [Route("User/InsertUser")]
        public void InsertUser([FromBody]UserModel userModel)
        {
            var user = new UserModel
            {
                RoleID = Guid.NewGuid(),
                Username = "anh.tran",
                FirstName = "anh",
                LastName = "tran",
                Password = "123456"
            };
            var a = new JavaScriptSerializer().Serialize(user);
            _userBLL.SaveUser(userModel);
            
        }
    }
}
