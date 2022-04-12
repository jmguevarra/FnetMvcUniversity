using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FnetMvcUniversity.Models;

namespace FnetMvcUniversity.Controllers
{
    

    public class StudentsController : Controller
    {
        private FnetMvcUniDbContext db = new FnetMvcUniDbContext();

        public StudentsController()
        {
            
        }

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Student.ToList()); ;
        }
    }
}