//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AltHealth.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblClientInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClientInfo()
        {
            this.tblInv_Info = new HashSet<tblInv_Info>();
        }
    
        public string Client_id { get; set; }
        public string C_name { get; set; }
        public string C_surname { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public string C_Tel_H { get; set; }
        public string C_Tel_W { get; set; }
        public string C_Tel_Cell { get; set; }
        public string C_Email { get; set; }
        public int Reference_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInv_Info> tblInv_Info { get; set; }
        public virtual tblReference tblReference { get; set; }
    }
}
