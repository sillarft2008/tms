using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TMS.Models;
using TMS.Repositories;

namespace TMS.Controllers
{
    public class EmployeeCompetencyController : Controller
    {

        localhostEC.EmployeeCompetencyWebserviceService ECS = new localhostEC.EmployeeCompetencyWebserviceService();

        public IEnumerable<Employee_Competency> All
        {
            get
            {
                List<Employee_Competency> compList = new List<Employee_Competency>();

                localhostEC.EmployeeCompetency[] pancake = ECS.getAllEmployeeCompetencies();
                ECS.Timeout = 2000;

                Employee_Competency ec;
                foreach (localhostEC.EmployeeCompetency comp in pancake)
                {
                    ec = new Employee_Competency();
                    ec.setEmployeeCompetency(comp);
                    compList.Add(ec);
                }
                IEnumerable<Employee_Competency> l = compList.ToList();
                return l;
            }
        }

        // GET: Competencies
        public ActionResult Index()
        {
            List<Employee_Competency> compList = new List<Employee_Competency>();

            localhostEC.EmployeeCompetency[] pancake = ECS.getAllEmployeeCompetencies();
            ECS.Timeout = 2000;

            Employee_Competency ec;
            foreach (localhostEC.EmployeeCompetency comp in pancake)
            {
                ec = new Employee_Competency();
                ec.setEmployeeCompetency(comp);
                compList.Add(ec);
            }
            IEnumerable<Employee_Competency> l = compList.ToList();
            return View(l);
        }

        // GET: Employee_Competencies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Competency ec = new Employee_Competency();
            ECS.Timeout = 2000;
            ec.setEmployeeCompetency(ECS.findEmployeeCompetency((int)id));

            if (ec == null)
            {
                return HttpNotFound();
            }
            return View(ec);
        }

        // GET: Employee_Competencies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee_Competencies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,employeeId,competencyId")] Employee_Competency ec)
        {
            if (ModelState.IsValid)
            {
                localhostEC.EmployeeCompetency ecomp = new localhostEC.EmployeeCompetency();
                ecomp = ec.getEmployeeCompetency();
                ECS.Timeout = 2000;
                String result = ECS.createEmployeeCompetency(ecomp);
                return RedirectToAction("Index");
            }

            return View(ec);
        }

        // GET: Employee_Competencies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Competency ec = new Employee_Competency();
            ECS.Timeout = 2000;
            ec.setEmployeeCompetency(ECS.findEmployeeCompetency((int)id));
            if (ec == null)
            {
                return HttpNotFound();
            }
            return View(ec);
        }

        // POST: Employee_Competencies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,employeeId,competencyId")] Employee_Competency ec)
        {
            if (ModelState.IsValid)
            {
                localhostEC.EmployeeCompetency ecomp = new localhostEC.EmployeeCompetency();
                ecomp = ec.getEmployeeCompetency();
                ECS.Timeout = 2000;
                String result = ECS.updateEmployeeCompetency(ecomp);
                return RedirectToAction("Index");
            }
            return View(ec);
        }

        // GET: Employee_Competencies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Competency ec = new Employee_Competency();
            ECS.Timeout = 2000;
            ec.setEmployeeCompetency(ECS.findEmployeeCompetency((int)id));
            if (ec == null)
            {
                return HttpNotFound();
            }
            return View(ec);
        }

        // POST: Employee_Competencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee_Competency ec = new Employee_Competency();
            ECS.Timeout = 2000;
            localhostEC.EmployeeCompetency delete = ECS.findEmployeeCompetency((int)id);
            ECS.deleteEmployeeCompetency(delete);
            return RedirectToAction("Index");
        }
    }
}