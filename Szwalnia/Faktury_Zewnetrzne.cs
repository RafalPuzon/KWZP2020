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
    
    public partial class Faktury_Zewnetrzne
    {
        public int ID_Faktura_zewnetrzna { get; set; }
        public string Nr_Faktury { get; set; }
        public Nullable<int> ID_Grupa { get; set; }
        public string Nazwa_Firmy { get; set; }
        public int Netto { get; set; }
        public int Brutto { get; set; }
        public int Podatek { get; set; }
    
        public virtual Grupa Grupa { get; set; }
    }
}
