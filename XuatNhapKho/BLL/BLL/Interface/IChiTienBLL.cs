using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Interface
{
    public interface IChiTienBLL
    {
        void InsertChiTien(ChiTienModel ChiTien);
        void DeleteChiTien(Guid id);
        void UpdateChiTien(ChiTienModel ChiTienModel);
        ChiTienModel GetById(Guid id);
        List<ChiTienModel> GetAll();
    }
}
