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
    
    public partial class tbl_Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Customer()
        {
            this.tbl_Contact = new HashSet<tbl_Contact>();
        }
    
        public int CusId { get; set; }
        public string CusCMND { get; set; }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public string CusAddress { get; set; }
        public string CusCompany { get; set; }
        public string CusPosition { get; set; }
        public Nullable<double> CusSalary { get; set; }
        public string CusNote { get; set; }
        public string CusEmail { get; set; }
        public Nullable<bool> CusSexIsMale { get; set; }
        public Nullable<System.DateTime> CusDateOfBirth { get; set; }
        public string CusCICNumber { get; set; }
        public Nullable<double> CusLimitOffer { get; set; }
        public string CusDistrict { get; set; }
        public string CusCity { get; set; }
        public string CusLeadProDuct { get; set; }
        public string CusVPID { get; set; }
        public string Branches { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Contact> tbl_Contact { get; set; }
    }
}
