//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ROTIKITA
{
    using System;
    using System.Collections.Generic;
    
    public partial class buang
    {
        public string kode_buang { get; set; }
        public string kode_roti { get; set; }
        public string kode_jenis { get; set; }
        public string nama_roti { get; set; }
        public Nullable<int> harga { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<int> subtotal { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> expired_at { get; set; }
        public Nullable<System.DateTime> dibuang_at { get; set; }
    
        public virtual jenis_roti jenis_roti { get; set; }
        public virtual roti roti { get; set; }
    }
}
