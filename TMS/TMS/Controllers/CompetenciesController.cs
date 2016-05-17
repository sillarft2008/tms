using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TMS.Models;

namespace TMS.Controllers
{
    public class CompetenciesController : Controller
    {
        public ICollection<Competency> All
        {
            get
            {
                List<Competency> compList = new List<Competency>();

                localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
                localhostCompetency.Competency[] pancake = CWS.getAllCompetencies();
                CWS.Timeout = 2000;

                Competency competency;
                foreach (localhostCompetency.Competency comp in pancake)
                {
                    competency = new Competency();
                    competency.setCompetency(comp);
                    compList.Add(competency);
                }
                ICollection<Competency> l = compList.ToList();
                return l;
            }
        }

        // GET: Competencies
        public ActionResult Index()
        {
            List<Competency> compList = new List<Competency>();

            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            localhostCompetency.Competency[] pancake = CWS.getAllCompetencies();
            CWS.Timeout = 2000;

            Competency competency;
            foreach (localhostCompetency.Competency comp in pancake)
            {
                competency = new Competency();
                competency.setCompetency(comp);
                compList.Add(competency);
            }
            IEnumerable<Competency> l = compList.ToList();
            return View(l);
        }

        // GET: Competencies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Competency competency = new Competency();
            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            CWS.Timeout = 2000;
            competency.setCompetency(CWS.findCompetency((int)id));
           
            if (competency == null)
            {
                return HttpNotFound();
            }
            return View(competency);
        }

        // GET: Competencies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Competencies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Competencies")] Competency competency)
        {
            if (ModelState.IsValid)
            {
                localhostCompetency.Competency comp = new localhostCompetency.Competency();
                comp = competency.getCompetency();
                localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
                CWS.Timeout = 2000;
                String result = CWS.createCompetency(comp);
                return RedirectToAction("Index");
            }

            return View(competency);
        }

        // GET: Competencies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Competency competency = new Competency();
            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            CWS.Timeout = 2000;
            competency.setCompetency(CWS.findCompetency((int)id));
            if (competency == null)
            {
                return HttpNotFound();
            }
            return View(competency);
        }

        // POST: Competencies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Competencies")] Competency competency)
        {
            if (ModelState.IsValid)
            {
                localhostCompetency.Competency comp = new localhostCompetency.Competency();
                comp = competency.getCompetency();
                localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
                CWS.Timeout = 2000;
                String result = CWS.updateCompetency(comp);
                return RedirectToAction("Index");
            }
            return View(competency);
        }

        // GET: Competencies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Competency competency = new Competency();
            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            CWS.Timeout = 2000;
            competency.setCompetency(CWS.findCompetency((int)id));
            if (competency == null)
            {
                return HttpNotFound();
            }
            return View(competency);
        }

        // POST: Competencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Competency competency = new Competency();
            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            CWS.Timeout = 2000;
            localhostCompetency.Competency deleteCompetency = CWS.findCompetency((int)id);
            CWS.deleteCompetency(deleteCompetency);
            return RedirectToAction("Index");
        }
    }
}
