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
    
    public partial class koraci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public koraci()
        {
            this.koraciigracas = new HashSet<koraciigraca>();
        }
    
        public int korakid { get; set; }
        public int brpoena { get; set; }
        public string opis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<koraciigraca> koraciigracas { get; set; }
    }
}
