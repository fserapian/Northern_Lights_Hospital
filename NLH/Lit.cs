//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NLH
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lit()
        {
            this.DossierAdmissions = new HashSet<DossierAdmission>();
        }
    
        public int NumLit { get; set; }
        public bool Occupe { get; set; }
        public Nullable<int> NumType { get; set; }
        public Nullable<int> IdDepartement { get; set; }
    
        public virtual Departement Departement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DossierAdmission> DossierAdmissions { get; set; }
        public virtual TypeLit TypeLit { get; set; }
    }
}
