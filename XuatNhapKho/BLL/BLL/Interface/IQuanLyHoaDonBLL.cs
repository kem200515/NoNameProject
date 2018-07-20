using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Interface
{
    public interface IQuanLyHoaDonBLL
    {        
        void Insert(QuanLyHoaDonModel ChiTietHoaDon);
        void Delete(Guid id);
        void Update(QuanLyHoaDonModel ChiTietHoaDonModel);
        QuanLyHoaDonModel GetById(Guid id);
        List<QuanLyHoaDonModel> GetAll();
    }
}
