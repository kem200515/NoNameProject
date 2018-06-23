using BLL.BLL.Interface;
using Database.Interface;
using Model;
using Model.Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Implement
{
    public class UserBLL : IUserBLL
    {
        public void InsertUser(UserModel userModel)
        {
            BaseBLL<User, UserModel>.Insert(userModel);
        }
    }
}
