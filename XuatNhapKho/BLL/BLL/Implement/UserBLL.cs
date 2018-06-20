using BLL.BLL.Interface;
using BLL.Models;
using Model;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Implement
{
    public class UserBLL : IUserBLL
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public void SaveUser(UserModel userModel)
        {
            User user = BaseBLL<User, UserModel>.ConvertFromModel(userModel);
            unitOfWork.StudentRepository.Insert(user);
            unitOfWork.Save();
            unitOfWork.Dispose();
        }
    }
}
