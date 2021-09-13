using DLBudinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContract icontract;
        public HomeController(IContract contract)
        {
            icontract = contract;
        }
        // GET: Home
        [HttpGet]
        [Route("Home/Index")]
        public ActionResult Index()
        {
            icontract.displayStudent();
            return View();
        }

        [HttpPost]
        [Route("Home/addstud")]
        public ActionResult AddStudent(string sname)
        {
            int i = icontract.addStudent(sname);
            return View();
        }

        [HttpPut]
        [Route("Home/updateStudent")]
        public ActionResult UpdateStudent(int sid,string sname)
        {
            int i = icontract.updateStudent(sid, sname);
            return View();
        }

        [HttpDelete]
        [Route("Home/deletestudent")]
        public ActionResult DeleteStudent(int sid)
        {
            bool result = icontract.deletestudent(sid);
            return View();
        }
    }
}