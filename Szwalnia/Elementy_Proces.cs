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
    
    public partial class Elementy_Proces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Elementy_Proces()
        {
            this.Material_Na_Produkcji = new HashSet<Material_Na_Produkcji>();
        }
    
        public int ID_Elementy_Proces { get; set; }
        public int ID_Proces_Technologiczny { get; set; }
        public int ID_Element { get; set; }
        public int Liczba { get; set; }
        public int ID_jednostka { get; set; }
    
        public virtual Elementy Elementy { get; set; }
        public virtual Elementy_Jednostki Elementy_Jednostki { get; set; }
        public virtual Proces_Technologiczny Proces_Technologiczny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Na_Produkcji> Material_Na_Produkcji { get; set; }
    }
}
