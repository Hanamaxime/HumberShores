//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumberShores.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PASS
    {
        public int PASS_ID { get; set; }
        public int USER_ID { get; set; }
        public int PASS_TYPE { get; set; }
        public System.DateTime PURCHASE_DATE { get; set; }
        public System.DateTime EXPIRY_DATE { get; set; }
        public string PURCHASE_SUCCESS { get; set; }
    
        public virtual PASS_TYPE PASS_TYPE1 { get; set; }
        public virtual site_users site_users { get; set; }
    }
}
