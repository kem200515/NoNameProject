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
    
    public partial class SanPham
    {
        public System.Guid Id { get; set; }
        public string TenHang { get; set; }
        public string Kho { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int Status { get; set; }
    }
}
