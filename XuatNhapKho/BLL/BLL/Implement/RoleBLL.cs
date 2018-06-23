using BLL.BLL.Interface;
using Model;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Implement
{
    public class RoleBLL : IRoleBLL
    {
        public void DeleteRole(Guid id)
        {
            BaseBLL<Role, RoleModel>.Delete(id);
        }

        public List<RoleModel> GetAll()
        {
            return BaseBLL<Role, RoleModel>.GetAll();
        }

        public RoleModel GetById(Guid id)
        {
            return BaseBLL<Role, RoleModel>.GetById(id);
        }

        public void InsertRole(RoleModel roleModel)
        {
            BaseBLL<Role, RoleModel>.Insert(roleModel);
        }

        public void UpdateRole(RoleModel roleModel)
        {
            BaseBLL<Role, RoleModel>.Update(roleModel);
        }
    }
}
