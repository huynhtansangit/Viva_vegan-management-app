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
    
    public partial class LOAICTKM
    {
        public LOAICTKM()
        {
            this.CHUONGTRINHKMs = new HashSet<CHUONGTRINHKM>();
        }
    
        public string MALOAIKM { get; set; }
        public string TENLOAIKM { get; set; }
    
        public virtual ICollection<CHUONGTRINHKM> CHUONGTRINHKMs { get; set; }
    }
}
