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
    public class ChiTietHoaDonBLL : IChiTietHoaDonBLL
    {
        public void DeleteChiTietHoaDon(Guid id)
        {
            BaseBLL<ChiTietHoaDon, ChiTietHoaDonModel>.Delete(id);
        }

        public List<ChiTietHoaDonModel> GetAll()
        {
            return BaseBLL<ChiTietHoaDon, ChiTietHoaDonModel>.GetAll();
        }

        public ChiTietHoaDonModel GetById(Guid id)
        {
            return BaseBLL<ChiTietHoaDon, ChiTietHoaDonModel>.GetById(id);
        }

        public void InsertChiTietHoaDon(ChiTietHoaDonModel ChiTietHoaDon)
        {
            BaseBLL<ChiTietHoaDon, ChiTietHoaDonModel>.Insert(ChiTietHoaDon);
        }

        public void UpdateChiTietHoaDon(ChiTietHoaDonModel ChiTietHoaDonModel)
        {
            BaseBLL<ChiTietHoaDon, ChiTietHoaDonModel>.Update(ChiTietHoaDonModel);
        }
    }
}
