using BLL.BLL.Interface;
using Model;
using Models.Models;
using Models.ViewModels;
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

        public void InsertListHoaDon(ListHoaDon listHoaDon)
        {
            if (listHoaDon == null || listHoaDon.listHoaDon == null || listHoaDon.listHoaDon.Count == 0) return;
            var listHoaDonModel = new List<ChiTietHoaDonModel>();
            var quanLyHoaDonModel = new QuanLyHoaDonModel()
            {
                NgayThucHien = listHoaDon.NgayThucHien,
                TongTien = listHoaDon.TongTien
            };
            BaseBLL<QuanLyHoaDon, QuanLyHoaDonModel>.Insert(quanLyHoaDonModel);
            foreach (var hoadon in listHoaDon.listHoaDon)
            {
                var hoaDonModel = BaseBLL<ChiTietHoaDonModel, HoaDonViewModel>.ConvertFromModel(hoadon);
                hoaDonModel.QuanLyHoaDonId = quanLyHoaDonModel.Id;
                listHoaDonModel.Add(hoaDonModel);
            }
            BaseBLL<ChiTietHoaDon, ChiTietHoaDonModel>.InsertList(listHoaDonModel);
        }

        public void UpdateChiTietHoaDon(ChiTietHoaDonModel ChiTietHoaDonModel)
        {
            BaseBLL<ChiTietHoaDon, ChiTietHoaDonModel>.Update(ChiTietHoaDonModel);
        }
    }
}
