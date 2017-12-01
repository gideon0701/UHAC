using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myHealthAPI.Models
{
    public class myBenefits
    {
        public int rowID { get; set; }
        public int hmoID { get; set; }
        public string benefitsName { get; set; }
        public int? amountCovered { get; set; }
    }
}