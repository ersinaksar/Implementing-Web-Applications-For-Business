//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToolShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Satis_Detaylari
    {
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public decimal BirimFiyati { get; set; }
        public short Miktar { get; set; }
        public float İndirim { get; set; }
    
        public virtual Satislar Satislar { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
