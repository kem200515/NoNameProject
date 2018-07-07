using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ChiTietHoaDonModel : BaseModel
    {
        public System.Guid QuanLyHoaDonId { get; set; }
        public Nullable<System.Guid> SanPhamId { get; set; }
        public Nullable<decimal> ChieuDai { get; set; }
        public Nullable<int> SoTam { get; set; }
        public Nullable<decimal> Som2 { get; set; }
        public Nullable<decimal> Somd { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    }
}
