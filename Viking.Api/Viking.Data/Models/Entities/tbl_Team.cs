//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Viking.Data.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Team()
        {
            this.tbl_Account = new HashSet<tbl_Account>();
            this.tbl_Contact = new HashSet<tbl_Contact>();
        }
    
        public string teamId { get; set; }
        public string teamDescription { get; set; }
        public string leaderId { get; set; }
        public string teamCampain { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Account> tbl_Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Contact> tbl_Contact { get; set; }
    }
}
