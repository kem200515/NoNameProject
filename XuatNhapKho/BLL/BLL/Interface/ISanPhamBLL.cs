using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Interface
{
    public interface ISanPhamBLL
    {
        void InsertSanPham(SanPhamModel SanPham);
        void DeleteSanPham(Guid id);
        void UpdateSanPham(SanPhamModel SanPhamModel);
        SanPhamModel GetById(Guid id);
        List<SanPhamModel> GetAll();
    }
}
