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
    public class ChiTienBLL : IChiTienBLL
    {
        public void DeleteChiTien(Guid id)
        {
            BaseBLL<ChiTien, ChiTienModel>.Delete(id);
        }

        public List<ChiTienModel> GetAll()
        {
            return BaseBLL<ChiTien, ChiTienModel>.GetAll();
        }

        public ChiTienModel GetById(Guid id)
        {
           return BaseBLL<ChiTien, ChiTienModel>.GetById(id);
        }

        public void InsertChiTien(ChiTienModel ChiTien)
        {
            BaseBLL<ChiTien, ChiTienModel>.Insert(ChiTien);
        }

        public void UpdateChiTien(ChiTienModel ChiTienModel)
        {
            BaseBLL<ChiTien, ChiTienModel>.Update(ChiTienModel);
        }
    }
}
