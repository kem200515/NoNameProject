﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ChiTietHoaDonModel : BaseModel
    {
        public System.Guid SanPhamId { get; set; }
        public Nullable<System.DateTime> NgayBan { get; set; }
        public Nullable<int> SoTam { get; set; }
        public Nullable<decimal> KichThuoc { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
    }
}
