//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myHealthAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class requirement
    {
        public int rqtId { get; set; }
        public int employee_id { get; set; }
        public string documentLabel { get; set; }
        public Nullable<int> is_received { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
