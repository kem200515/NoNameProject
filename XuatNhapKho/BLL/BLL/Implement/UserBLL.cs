using BLL.BLL.Interface;
using BLL.Models;
using Database.Interface;
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
        private UnitOfWork _unitOfWork;
        private IRepository<User> _userRepository;
        public UserBLL()
        {
            if (_unitOfWork == null)
                _unitOfWork = new UnitOfWork();
            _userRepository = _unitOfWork.UserRepository;
        }

        public void SaveUser(UserModel userModel)
        {
            User user = BaseBLL<User, UserModel>.ConvertFromModel(userModel);
            _userRepository.Insert(user);
            _unitOfWork.Save();
        }
    }
}
