//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class H_NhapXuatTon
    {
        public System.Guid Id { get; set; }
        public string TenHang { get; set; }
        public string Kho { get; set; }
        public Nullable<int> SoTamTonDau { get; set; }
        public Nullable<decimal> SoTonDau { get; set; }
        public Nullable<int> SoTamNhap { get; set; }
        public Nullable<decimal> SoNhap { get; set; }
        public Nullable<int> SoTamNhapNoiBo { get; set; }
        public Nullable<decimal> SoNhapNoiBo { get; set; }
        public Nullable<int> SoTamXuatBanTrucTiep { get; set; }
        public Nullable<decimal> SoXuatBanTrucTiep { get; set; }
        public Nullable<int> SoTamXuatBanGiaoCONT { get; set; }
        public Nullable<decimal> SoXuatBanGiaoCONT { get; set; }
        public Nullable<int> SoTamXuatNoiBo { get; set; }
        public Nullable<decimal> SoXuatNoiBo { get; set; }
        public Nullable<int> SoTamDieuChinhChenhLech { get; set; }
        public Nullable<decimal> SoDieuChinhChenhLech { get; set; }
        public Nullable<int> SoTamTonCuoi { get; set; }
        public Nullable<decimal> SoTonCuoi { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int Status { get; set; }
    }
}
