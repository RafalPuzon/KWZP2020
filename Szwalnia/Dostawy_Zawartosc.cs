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
    
    public partial class Dostawy_Zawartosc
    {
        public int ID_Dostawy_Zawartosc { get; set; }
        public Nullable<int> ID_Dostawy { get; set; }
        public Nullable<int> ID_Element { get; set; }
        public Nullable<int> ID_oferta { get; set; }
        public Nullable<int> Ilosc_Dostarczona { get; set; }
    
        public virtual Zamowienia_Dostawy Zamowienia_Dostawy { get; set; }
        public virtual Elementy Elementy { get; set; }
        public virtual Oferta Oferta { get; set; }
    }
}
