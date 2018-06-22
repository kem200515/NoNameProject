using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class SanPhamModel : BaseModel
    {
        public string TenHang { get; set; }
        public string Kho { get; set; }
        public Nullable<decimal> DonGia { get; set; }
    }
}
