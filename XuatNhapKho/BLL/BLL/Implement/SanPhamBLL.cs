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
    public class SanPhamBLL : ISanPhamBLL
    {
        public void DeleteSanPham(Guid id)
        {
            BaseBLL<SanPham, SanPhamModel>.Delete(id);
        }

        public List<SanPhamModel> GetAll()
        {
            return BaseBLL<SanPham, SanPhamModel>.GetAll();
        }

        public SanPhamModel GetById(Guid id)
        {
            return BaseBLL<SanPham, SanPhamModel>.GetById(id);
        }

        public void InsertSanPham(SanPhamModel SanPham)
        {
            BaseBLL<SanPham, SanPhamModel>.Insert(SanPham);
        }

        public void UpdateSanPham(SanPhamModel SanPhamModel)
        {
            BaseBLL<SanPham, SanPhamModel>.Update(SanPhamModel);
        }
    }
}
