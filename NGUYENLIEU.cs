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
    
    public partial class NGUYENLIEU
    {
        public NGUYENLIEU()
        {
            this.TONKHOes = new HashSet<TONKHO>();
        }
    
        public string MANGUYENLIEU { get; set; }
        public string TENNGUYENLIEU { get; set; }
        public string MOTA { get; set; }
        public string DVT { get; set; }
    
        public virtual ICollection<TONKHO> TONKHOes { get; set; }
    }
}
