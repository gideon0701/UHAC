using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PENTAGON.Models;
using PENTAGON.AppModel;
namespace PENTAGON.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationModel appmodel;
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        //POST: Home/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include ="email,pwd")] employee employees)
        {
            appmodel = new ApplicationModel();
            if (appmodel.getAccess(employees) != null)
            {
                var emp = appmodel.getAccess(employees);
                Session["Emp_ID"] = emp.id;
                return RedirectToAction("Index","EmployeeDashboard",new { id = emp.id});
            }
            employees.Login_Message = "Wrong Email or Password";
            return View("Index", employees);
        }
    }
}