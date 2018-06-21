using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ChiTienModel : BaseModel
    {
        public Nullable<decimal> SoTien { get; set; }
        public string MoTa { get; set; }
        public Nullable<System.DateTime> NgayChiTien { get; set; }
    }
}
