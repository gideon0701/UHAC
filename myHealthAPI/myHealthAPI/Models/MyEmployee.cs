using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myHealthAPI.Models
{
    public class MyEmployee
    {
        public int id { get; set; }
        public int HMO_id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string department { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string healthProvider { get; set; }
        public string hmoStatus { get; set; }
        public string hmoBenefits { get; set; }
        public int? maximumAmount { get; set; }
        public int? amountLeft { get; set; }

    }
}