using BLL.BLL.Implement;
using BLL.BLL.Interface;
using Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
            if (userModel == null) return;
            _userBLL.InsertUser(userModel);
        }

        [HttpPost]
        [Route("User/Login")]
        public string Login(UserModel userModel)
        {
            //if (
            //    userModel == null
            //    || string.IsNullOrWhiteSpace(userModel.Username)
            //    || string.IsNullOrWhiteSpace(userModel.Password)
            //    )
            //    return new HttpResponseMessage(HttpStatusCode.NoContent);
            //var response = new HttpResponseMessage();
            //var user = _userBLL.Login(userModel.Username, userModel.Password);

            //response.Content = new StringContent(user.Id.ToString());
            //return response;
            if (
                userModel == null
                || string.IsNullOrWhiteSpace(userModel.Username)
                || string.IsNullOrWhiteSpace(userModel.Password)
                )
                return string.Empty;
            var response = new HttpResponseMessage();
            var user = _userBLL.Login(userModel.Username, userModel.Password);
            if (user == null) return string.Empty;
            return user.Id.ToString();
        }
        [HttpPost]
        [Route("User/GetUserById")]
        public UserModel GetUserById(string userID)
        {
            return _userBLL.GetById(Guid.Parse(userID));
        }
    }
}
