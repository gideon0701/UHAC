using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PENTAGON.Models;

namespace PENTAGON.AppModel
{
    public class ApplicationModel
    {
        private myhealthDbEntities db = new myhealthDbEntities();

        // To check if the employee email and password match
        public employee getAccess(employee employee) 
        {
           
            var res = db.employees
                .Where(e => e.email == employee.email && e.pwd == employee.pwd)
                .FirstOrDefault();

            return res;
        }

    }
}