//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMDT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHangVanChuyen
    {
        public int ShippingID { get; set; }
        public Nullable<System.DateTime> NgayGiaoHang { get; set; }
        public Nullable<System.DateTime> NgayNhanHang { get; set; }
        public string TinhtrangDH { get; set; }
        public string PhuongthucVC { get; set; }
        public string PhiVC { get; set; }
        public int IdDHH { get; set; }
        public int IdTT { get; set; }
        public int Sdt { get; set; }
    
        public virtual ChiTietThanhToan ChiTietThanhToan { get; set; }
    }
}
