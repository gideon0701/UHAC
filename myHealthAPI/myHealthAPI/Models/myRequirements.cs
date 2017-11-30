using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myHealthAPI.Models
{
    public class myRequirements
    {
        public int employee_id { get; set; }
        public string documentLabel { get; set; }
        public int? is_received { get; set; }
        public int doctag_id { get; set; }
    }
}