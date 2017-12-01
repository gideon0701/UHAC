using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myHealthAPI.Models
{
    public class Doctors
    {
        public int doctorID { get; set; }
        public int hospitalID { get; set; }
        public string doctorsName { get; set; }
        public string specialization { get; set; }
    }
}