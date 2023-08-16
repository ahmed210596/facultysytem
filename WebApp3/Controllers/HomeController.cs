using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp3.Models;
namespace WebApp3.Controllers
{
    public class HomeController : Controller
    {
        FacultyEntities db = new FacultyEntities();
        public ActionResult Index()
           
        {
            List<Departements> list= db.Departements.ToList();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            WebsiteDesc obj =db.WebsiteDesc.FirstOrDefault();

            return View(obj);
        }
        public ActionResult Students(int id)
        {
            List<Student> Studlist = db.Student.Where(x => x.DepId == id).ToList();

            return View(Studlist);
        }
    }
}