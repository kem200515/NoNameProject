using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class QuanLySanPhamModel:BaseModel
    {
        public System.Guid SanPhamId { get; set; }
        public string Loai { get; set; }
        public Nullable<System.DateTime> NgayThucHien { get; set; }
        public Nullable<int> SoTam { get; set; }
        public Nullable<decimal> KichThuoc { get; set; }
    }
}
