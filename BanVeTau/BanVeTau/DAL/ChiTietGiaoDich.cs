//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanVeTau.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietGiaoDich
    {
        public int GiaoDichId { get; set; }
        public Nullable<bool> Huy { get; set; }
        public int ThuTu { get; set; }
        public int LoaiGheId { get; set; }
        public int LichTrinhTuyenDuongId { get; set; }
        public int SoGhe { get; set; }
    
        public virtual GiaoDich GiaoDich { get; set; }
        public virtual LichTrinh_TuyenDuong LichTrinh_TuyenDuong { get; set; }
        public virtual LoaiGhe LoaiGhe { get; set; }
    }
}