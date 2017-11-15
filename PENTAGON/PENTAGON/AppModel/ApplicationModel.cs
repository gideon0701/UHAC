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

        //2017.11.15 Gideon Add Start
        // To Determin what is the appropriate dashboard to the corresponding group id
        public string gotoDashboard(int groupId)
        {
            switch (groupId)
            {
                case 1:
                    return "EmployeeDashboard";
                case 2:
                    return "BenefitsOfficerDashboard";
                case 3:
                    return "HealthProviderDashboard";
                case 4:
                    return "BenefitsHeadDashboard";
                default:
                    return "Home";
                  
            }
        }
        //2017.11.15 Gideon Add End

    }
}