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
    
    public partial class Elementy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Elementy()
        {
            this.Czesci_Obsluga = new HashSet<Czesci_Obsluga>();
            this.Dostarczenia_Wewn = new HashSet<Dostarczenia_Wewn>();
            this.Dostarczenia_Zewn = new HashSet<Dostarczenia_Zewn>();
            this.Dostawy_Zawartosc = new HashSet<Dostawy_Zawartosc>();
            this.Elementy_Cechy = new HashSet<Elementy_Cechy>();
            this.Elementy_Proces = new HashSet<Elementy_Proces>();
            this.Oferta = new HashSet<Oferta>();
            this.Zamowienie_Element = new HashSet<Zamowienie_Element>();
            this.Zawartosc = new HashSet<Zawartosc>();
        }
    
        public int ID_Element { get; set; }
        public Nullable<int> ID_Element_Typ { get; set; }
        public string Element_Nazwa { get; set; }
        public Nullable<int> Okres_Przydatnosci_Miesiace { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Czesci_Obsluga> Czesci_Obsluga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostarczenia_Wewn> Dostarczenia_Wewn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostarczenia_Zewn> Dostarczenia_Zewn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostawy_Zawartosc> Dostawy_Zawartosc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Elementy_Cechy> Elementy_Cechy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Elementy_Proces> Elementy_Proces { get; set; }
        public virtual Elementy_Typy Elementy_Typy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oferta> Oferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienie_Element> Zamowienie_Element { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zawartosc> Zawartosc { get; set; }
    }
}
