//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Szwalnia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Statusy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Statusy()
        {
            this.Zamowienia_Dostawy = new HashSet<Zamowienia_Dostawy>();
        }
    
        public int ID_statusu { get; set; }
        public string Status_zatw { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienia_Dostawy> Zamowienia_Dostawy { get; set; }
    }
}
