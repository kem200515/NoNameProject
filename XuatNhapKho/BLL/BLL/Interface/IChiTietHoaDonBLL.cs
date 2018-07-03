using Models.Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Interface
{
    public interface IChiTietHoaDonBLL
    {
        void InsertListHoaDon(ListHoaDon listHoaDon);
        void InsertChiTietHoaDon(ChiTietHoaDonModel ChiTietHoaDon);
        void DeleteChiTietHoaDon(Guid id);
        void UpdateChiTietHoaDon(ChiTietHoaDonModel ChiTietHoaDonModel);
        ChiTietHoaDonModel GetById(Guid id);
        List<ChiTietHoaDonModel> GetAll();
    }
}
