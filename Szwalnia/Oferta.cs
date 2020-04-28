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
    
    public partial class Oferta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oferta()
        {
            this.Dostawcy_Oferta = new HashSet<Dostawcy_Oferta>();
            this.Zamowienia_Zawartosc = new HashSet<Zamowienia_Zawartosc>();
        }
    
        public int ID_Oferta { get; set; }
        public Nullable<int> ID_Element { get; set; }
        public string Element_Oznaczenie { get; set; }
        public Nullable<int> ID_Dostawcy { get; set; }
        public Nullable<decimal> Cena_Jedn { get; set; }
        public Nullable<System.DateTime> Data_Oferty { get; set; }
        public Nullable<int> Ilosc_Minimalna { get; set; }
        public Nullable<int> Ilosc_Maksymalna { get; set; }
        public Nullable<int> Ilosc_W_Opakowaniu_Zbiorczym { get; set; }
        public Nullable<int> Deklarowany_czas_dostawy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostawcy_Oferta> Dostawcy_Oferta { get; set; }
        public virtual Dostawcy_Zaopatrzenie Dostawcy_Zaopatrzenie { get; set; }
        public virtual Elementy Elementy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienia_Zawartosc> Zamowienia_Zawartosc { get; set; }
    }
}
