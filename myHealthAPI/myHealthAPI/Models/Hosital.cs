using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myHealthAPI.Models
{
    public class Hosital
    {
        public int hospital_id { get; set; }
        public string healthProvider { get; set; }
        public string hospital_name { get; set; }
        public string hospital_address { get; set; }

    }
}