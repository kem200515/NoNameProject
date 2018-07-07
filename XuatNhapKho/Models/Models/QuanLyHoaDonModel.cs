using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class QuanLyHoaDonModel:BaseModel
    {
        public Nullable<System.DateTime> NgayThucHien { get; set; }
        public Nullable<decimal> TongTien { get; set; }
    }
}
