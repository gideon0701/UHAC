using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using myHealthAPI.Models;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace myHealthAPI.Controllers
{
    public class HomeController : ApiController
    {
        private myhealthDbEntities db = new myhealthDbEntities();

        [HttpGet]
        public String index()
        {
            return "hello";

        }

        [HttpGet]
        public String getAllEmployee()
        {
            List<employee> emp;
            List<MyEmployee> myempList = new List<MyEmployee>();
            MyEmployee myemp;
            emp = db.employees.ToList();
            foreach (var employee in emp)
            {
                myemp = new MyEmployee
                {
                    id = employee.id,
                    HMO_id = employee.HMO_id,
                    name = employee.name,
                    position = employee.position,
                    department = employee.department,
                    email = employee.email,
                    password = employee.pwd,
                    healthProvider = employee.healthProvider,
                    hmoStatus = employee.HMO.status,
                    hmoBenefits = employee.HMO.benefits
                };

                myempList.Add(myemp);
            }
            JavaScriptSerializer json = new JavaScriptSerializer();
            var js = json.Serialize(myempList);
            return js;
        }
        [HttpGet]
        public String getEmployee(int id)
        {
            employee emp;
            MyEmployee myemp;
            emp = db.employees.Find(id);

            myemp = new MyEmployee {
                id = emp.id,
                HMO_id = emp.HMO_id,
                name = emp.name,
                position = emp.position,
                department = emp.department,
                email = emp.email,
                password = emp.pwd,
                healthProvider = emp.healthProvider,
                hmoStatus = emp.HMO.status,
                hmoBenefits = emp.HMO.benefits
            };
            JavaScriptSerializer json = new JavaScriptSerializer();
            var js = json.Serialize(myemp);
            return js;

        }
        [HttpPost]
        public string login(String email, String password)
        {
            employee emp;
           
            emp = db.employees.Where(e => e.email == email && e.pwd == password).FirstOrDefault();
            if (emp == null)
            {
                return "wrong";
            }
            else
            {
                MyEmployee myemp;
                JavaScriptSerializer json = new JavaScriptSerializer();
                myemp = new MyEmployee {
                    id = emp.id,
                    HMO_id = emp.HMO_id,
                    name = emp.name,
                    position = emp.position,
                    department = emp.department,
                    email = emp.email,
                    password = emp.pwd,
                    healthProvider = emp.healthProvider,
                    hmoStatus = emp.HMO.status,
                    hmoBenefits = emp.HMO.benefits

                };
                var js = json.Serialize(myemp);
                return js;

            }
        }

        [HttpGet]
        public string getAllHospital(string provider)
        {
            List<AccreditedHospital> listHosp = new List<AccreditedHospital>();

            listHosp = db.AccreditedHospitals.Where(h => h.healthProvider == provider).ToList();

            JavaScriptSerializer json = new JavaScriptSerializer();
            var js = json.Serialize(listHosp);
            return js;

        }

        [HttpGet]
        public string getMyRequirements(int id)
        {
            List<requirement> rqm = new List<requirement>();
            List<myRequirements> myRqmList = new List<myRequirements>();
            myRequirements myRqm;
            rqm = db.requirements.Where(r => r.employee_id == id).ToList();
            foreach (var r in rqm)
            {
                myRqm = new myRequirements
                {
                    employee_id = r.employee_id,
                    documentLabel = r.documentLabel,
                    is_received = r.is_received,
                    doctag_id = r.doctag_id
                };

                myRqmList.Add(myRqm);
            }
            JavaScriptSerializer json = new JavaScriptSerializer();
            var js = json.Serialize(myRqmList);
            return js;


        }

    }
}
