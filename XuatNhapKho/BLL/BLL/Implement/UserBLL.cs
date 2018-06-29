using BLL.BLL.Interface;
using Model;
using Model.Implement;
using Model.Interface;
using Models.Models;
using System;
using System.Collections.Generic;

namespace BLL.BLL.Implement
{
    public class UserBLL : IUserBLL
    {
        private IUserRepository _userRepository;
        public UserBLL()
        {
            if (_userRepository == null)
                _userRepository = new UserRepository();
        }
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
        public UserModel Login(string username, string password)
        {
            var user = _userRepository.Login(username, password);
            if (user == null) return null;
            return BaseBLL<p_User_GetByUsernameAndPassword_Result, UserModel>.ConvertToModel(user);
        }
    }
}
