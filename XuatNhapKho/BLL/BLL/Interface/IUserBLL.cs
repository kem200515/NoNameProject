using BLL.Models;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Interface
{
    public interface IUserBLL
    {
        void SaveUser(UserModel user);
    }
}
