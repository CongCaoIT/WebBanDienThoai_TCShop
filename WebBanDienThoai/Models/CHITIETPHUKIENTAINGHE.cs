//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETPHUKIENTAINGHE
    {
        public int MaPKTaiNghe { get; set; }
        public int MaSP { get; set; }
        public string DUNGLUONGPIN { get; set; }
        public string THOILUONGSAC { get; set; }
        public string CONGSAC { get; set; }
        public string CONGNGHEAMTHANH { get; set; }
        public string TIENICH { get; set; }
        public string TUONGTHICH { get; set; }
        public string CONGNGHEKETNOT { get; set; }
        public string PHIMDIEUKHIEN { get; set; }
        public string KICHTHUOC { get; set; }
        public Nullable<int> BAOHANH { get; set; }
        public string KHOILUONG { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
    }
}