using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Implement
{
    public class UserRepository : IUserRepository
    {
        private Secrect_DevelopmentEntities _context;
        public UserRepository()
        {
            if (_context == null)
                _context = new Secrect_DevelopmentEntities();
        }
        public p_User_GetByUsernameAndPassword_Result Login(string username, string password)
        {
            return _context.p_User_GetByUsernameAndPassword(username, password).FirstOrDefault();
        }
    }
}
