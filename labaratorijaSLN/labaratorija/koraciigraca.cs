//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace labaratorija
{
    using System;
    using System.Collections.Generic;
    
    public partial class koraciigraca
    {
        public string username { get; set; }
        public int korakid { get; set; }
        public int redbrkoraka { get; set; }
    
        public virtual koraci koraci { get; set; }
        public virtual profili profili { get; set; }
    }
}
