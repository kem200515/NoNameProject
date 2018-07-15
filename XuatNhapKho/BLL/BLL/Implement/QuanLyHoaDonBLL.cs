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
    public class QuanLyHoaDonBLL : IQuanLyHoaDonBLL
    {
        public void Insert(QuanLyHoaDonModel quanLyHoaDonModel)
        {
            BaseBLL<QuanLyHoaDon, QuanLyHoaDonModel>.Insert(quanLyHoaDonModel);
        }

        public void Delete(Guid id)
        {
            BaseBLL<QuanLyHoaDon, QuanLyHoaDonModel>.Delete(id);
        }

        public void Update(QuanLyHoaDonModel quanLyHoaDonModel)
        {
            BaseBLL<QuanLyHoaDon, QuanLyHoaDonModel>.Update(quanLyHoaDonModel);
        }

        public QuanLyHoaDonModel GetById(Guid id)
        {
            return BaseBLL<QuanLyHoaDon, QuanLyHoaDonModel>.GetById(id);
        }

        public List<QuanLyHoaDonModel> GetAll()
        {
            return BaseBLL<QuanLyHoaDon, QuanLyHoaDonModel>.GetAll();
        }
    }
}
