//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Viva_vegan
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        public HOADON()
        {
            this.QUANHE_HD_DKKM = new HashSet<QUANHE_HD_DKKM>();
        }
    
        public string MAHD { get; set; }
        public string MAKH { get; set; }
        public string MANV { get; set; }
        public Nullable<System.DateTime> NGAYLAP { get; set; }
        public string NOIDUNG { get; set; }
        public string HTTT { get; set; }
        public string SOBAN { get; set; }
        public string TINHTRANGHD { get; set; }
        public Nullable<double> VAT { get; set; }
        public Nullable<long> TIENSAUTHUE { get; set; }
        public Nullable<long> TIENNHANKH { get; set; }
        public Nullable<long> TIENTRALAIKH { get; set; }
        public string makm { get; set; }
    
        public virtual BAN BAN { get; set; }
        public virtual CHUONGTRINHKM CHUONGTRINHKM { get; set; }
        public virtual CTHD_MA CTHD_MA { get; set; }
        public virtual CTHD_TU CTHD_TU { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual ICollection<QUANHE_HD_DKKM> QUANHE_HD_DKKM { get; set; }
    }
}