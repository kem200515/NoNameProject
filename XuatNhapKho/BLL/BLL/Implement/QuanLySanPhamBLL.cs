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
    public class QuanLySanPhamBLL : IQuanLySanPhamBLL
    {
        public void DeleteQuanLySanPham(Guid id)
        {
            BaseBLL<QuanLySanPham, QuanLySanPhamModel>.Delete(id);
        }

        public List<QuanLySanPhamModel> GetAll()
        {
            return BaseBLL<QuanLySanPham, QuanLySanPhamModel>.GetAll();
        }

        public QuanLySanPhamModel GetById(Guid id)
        {
            return BaseBLL<QuanLySanPham, QuanLySanPhamModel>.GetById(id);
        }

        public void InsertQuanLySanPham(QuanLySanPhamModel QuanLySanPham)
        {
            BaseBLL<QuanLySanPham, QuanLySanPhamModel>.Insert(QuanLySanPham);
        }

        public void UpdateQuanLySanPham(QuanLySanPhamModel QuanLySanPhamModel)
        {
            BaseBLL<QuanLySanPham, QuanLySanPhamModel>.Update(QuanLySanPhamModel);
        }
    }
}
