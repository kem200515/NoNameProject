using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IUserRepository
    {
        p_User_GetByUsernameAndPassword_Result Login(string username, string password);
    }
}
