using BLL.BLL.Interface;
using Model;
using Models.Models;
using System;
using System.Collections.Generic;

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

        public List<UserModel> GetAll()
        {
            return BaseBLL<User, UserModel>.GetAll();
        }
    }
}
