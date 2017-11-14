//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PENTAGON.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class employee
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "HMO ID")]
        public int HMO_id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Position")]
        public string position { get; set; }
        [Display(Name = "Department")]
        public string department { get; set; }
        [Required(ErrorMessage = "*")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
          ErrorMessage = "Input Valid Email Address")]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string pwd { get; set; }
        [Display(Name = "Group ID")]
        public int usergroup_id { get; set; }

        public string Login_Message { get; set; }

        public virtual attr_HMO attr_HMO { get; set; }
        public virtual usergroup usergroup { get; set; }
    }
}
