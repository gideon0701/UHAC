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
                string pos = appmodel.gotoDashboard(emp.usergroup_id); //2017.11.15 Gideon Add
                Session["Emp_ID"] = emp.id;
                
                return RedirectToAction("Index",pos,new { id = emp.id}); //2017.11.15 Gideon Edit
            }
            employees.Login_Message = "Wrong Email or Password";
            return View("Index", employees);
        }
    }
}