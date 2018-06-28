using Model;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Interface
{
    public interface IUserBLL
    {
        void InsertUser(UserModel user);
        void DeleteUser(Guid id);
        void UpdateUser(UserModel userModel);
        UserModel GetById(Guid id);
        List<UserModel> GetAll();
        UserModel Login(string username, string password)
    }
}
