using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Interface
{
    interface IQuanLySanPhamBLL
    {
        void InsertQuanLySanPham(QuanLySanPhamModel QuanLySanPham);
        void DeleteQuanLySanPham(Guid id);
        void UpdateQuanLySanPham(QuanLySanPhamModel QuanLySanPhamModel);
        QuanLySanPhamModel GetById(Guid id);
        List<QuanLySanPhamModel> GetAll();
    }
}
