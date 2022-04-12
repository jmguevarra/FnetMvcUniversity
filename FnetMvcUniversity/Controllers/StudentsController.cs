using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FnetMvcUniversity.Models;
using System.Net;
using System.Data.Entity;

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

        public ActionResult Edit(int? id) {

            //return id is null
            if ( id == null ) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //check if id is exists in student record
            Student student = db.Student.Find(id);
            if ( student == null ) return HttpNotFound();

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id, StudLRN, FullName, FullName, StudCourse, StudYear, StudSection")] Student student) {

            if (ModelState.IsValid) {

                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(student);
        }

        public ActionResult Delete()
        {

            return View();
        }
    }
}