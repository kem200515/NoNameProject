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
        public void DeleteUser(Guid id)
        {
            BaseBLL<User, UserModel>.Delete(id);
        }
        public void UpdateUser(UserModel userModel)
        {
            BaseBLL<User, UserModel>.Update(userModel);
        }
        public UserModel GetById(Guid id)
        {
            return BaseBLL<User, UserModel>.GetById(id);
        }
    }
}
