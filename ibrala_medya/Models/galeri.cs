//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ibrala_medya.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class galeri
    {
        public int gid { get; set; }
        public string baslikbgresim { get; set; }
        public string sayfabaslik { get; set; }
        public string foto { get; set; }
        public string fotoadi { get; set; }
        public bool aktif_pasif { get; set; }
        public Nullable<bool> onecikar { get; set; }
    }
}