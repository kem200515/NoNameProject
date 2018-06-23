using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Interface
{
    public interface IRoleBLL
    {
        void InsertRole(RoleModel roleModel);
        void DeleteRole(Guid id);
        void UpdateRole(RoleModel roleModel);
        RoleModel GetById(Guid id);
        List<RoleModel> GetAll();
    }
}
