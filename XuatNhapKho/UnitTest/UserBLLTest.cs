using System;
using BLL.BLL.Implement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;

namespace UnitTest
{
    [TestClass]
    public class UserBLLTest
    {
        private UserBLL _userBLL = new UserBLL();
        [TestMethod]
        public void TestSaveUser()
        {
            var userModel = new UserModel
            {
                RoleID = Guid.NewGuid(),
                Username = "anh.tran",
                FirstName = "anh",
                LastName = "tran",
                Password = "123456"
            };
            _userBLL.SaveUser(userModel);
        }
    }
}
