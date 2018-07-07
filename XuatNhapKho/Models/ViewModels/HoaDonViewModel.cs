using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class HoaDonViewModel
    {
        public Guid SanPhamId { get; set; }
        public decimal ChieuDai { get; set; }
        public decimal Kho { get; set; }
        public int SoTam { get; set; }
        public decimal Som2 { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
    public class ListHoaDon
    {
        public ListHoaDon()
        {
            listHoaDon = new List<HoaDonViewModel>();
        }
        public List<HoaDonViewModel> listHoaDon;
        public long NgayThucHienTimestamp;
        public DateTime NgayThucHien;
        public decimal TongTien;
    }
}
