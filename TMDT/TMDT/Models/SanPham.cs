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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.CHITIETDONDATHANGs = new HashSet<CHITIETDONDATHANG>();
        }
    
        public int IdSP { get; set; }
        public string TenSP { get; set; }
        public string MotaSP { get; set; }
        public Nullable<int> DonGia { get; set; }
        public int IdNCC { get; set; }
        public int IdLoaiSP { get; set; }
        public int IdKM { get; set; }
        public string Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONDATHANG> CHITIETDONDATHANGs { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
