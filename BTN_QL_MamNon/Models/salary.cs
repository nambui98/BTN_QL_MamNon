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
    
    public partial class salary
    {
        public long id { get; set; }
        public Nullable<long> id_staff { get; set; }
        public Nullable<double> main_salary { get; set; }
        public Nullable<double> allowance_salary { get; set; }
        public Nullable<double> bonus_young_salary { get; set; }
    
        public virtual staff_teacher staff_teacher { get; set; }
    }
}
