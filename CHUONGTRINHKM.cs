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
    
    public partial class CHUONGTRINHKM
    {
        public CHUONGTRINHKM()
        {
            this.DIEUKIENKMs = new HashSet<DIEUKIENKM>();
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public string MAKM { get; set; }
        public string MALOAIKM { get; set; }
        public string TENKM { get; set; }
        public System.DateTime NGAYBATDAU { get; set; }
        public System.DateTime NGAYKETTHUC { get; set; }
        public string TRANGTHAI { get; set; }
        public string GHICHU { get; set; }
    
        public virtual LOAICTKM LOAICTKM { get; set; }
        public virtual ICollection<DIEUKIENKM> DIEUKIENKMs { get; set; }
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}