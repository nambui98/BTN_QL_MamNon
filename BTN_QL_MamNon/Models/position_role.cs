//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTN_QL_MamNon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class position_role
    {
        public long id { get; set; }
        public Nullable<long> id_position { get; set; }
        public Nullable<long> id_role { get; set; }
    
        public virtual position position { get; set; }
        public virtual role role { get; set; }
    }
}
