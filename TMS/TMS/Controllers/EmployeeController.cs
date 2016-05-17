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
using TMS.Repositories;
using TMS.ViewModels;

namespace TMS.Controllers
{
    public class EmployeeController : Controller
    {

        //private readonly CompetencyRepository _competencyRepository = new CompetencyRepository();
        private readonly IEmployeeRepository _iEmployeeRepository;
       // private readonly EmployeeCompetencyRepository _employeeCompetencyRepository = new EmployeeCompetencyRepository();
        private readonly CompetenciesController CC = new CompetenciesController();
        private readonly EmployeeCompetencyController ECC = new EmployeeCompetencyController();



        public EmployeeController(IEmployeeRepository iEmployeeRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;
        }

        // GET: People
        public ActionResult Index(string search = "")
        {
           var employees = _iEmployeeRepository.All.ToList();

            if (!string.IsNullOrEmpty(search))
            {

                var eivm = new EmployeeIndexViewModel
                {
                    Employees = _iEmployeeRepository.All.ToList(),
                    Competencies = CC.All.ToList(),
                    Employees_Competency = ECC.All.ToList()
                };
                return View(eivm);
            }
            else
            {
                List<Employee_Competency> ecList = new List<Employee_Competency>();
                List<Competency> compList = new List<Competency>();


                localhostEC.EmployeeCompetencyWebserviceService ECWS = new localhostEC.EmployeeCompetencyWebserviceService();
                localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();

                localhostEC.EmployeeCompetency[] pancake = ECWS.findAllEmployeeCompetencies(person.Id);
                localhostCompetency.Competency[] cake = CWS.getAllCompetencies();

                ECWS.Timeout = 2000;
                CWS.Timeout = 2000;

                Employee_Competency ec;
                Competency competency;

                foreach (localhostEC.EmployeeCompetency comp in pancake)
                {
                    ec = new Employee_Competency();
                    ec.setEmployeeCompetency(comp);
                    ecList.Add(ec);


                    foreach (localhostCompetency.Competency compot in cake)
                    {

                        if (compot.id == ec.competencyId)
                        {
                            competency = new Competency();
                            competency.setCompetency(compot);
                            compList.Add(competency);
                        }

                    }
                }
                var vm = new EmployeeIndexViewModel
                {
                    Employee = person,
                    //Employees_Competency = ecList,
                    Competencies = compList

                };
                return View(vm);
            }
        }

        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee person = _iEmployeeRepository.Find(id);

            if (person == null)
            {
                return HttpNotFound();
            }
            else
            {

                List<Employee_Competency> ecList = new List<Employee_Competency>();
                List<Competency> compList = new List<Competency>();


                localhostEC.EmployeeCompetencyWebserviceService ECWS = new localhostEC.EmployeeCompetencyWebserviceService();
                localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();

                localhostEC.EmployeeCompetency[] pancake = ECWS.findAllEmployeeCompetencies(person.Id);
                localhostCompetency.Competency[] cake = CWS.getAllCompetencies();

                ECWS.Timeout = 2000;
                CWS.Timeout = 2000;

                Employee_Competency ec;
                Competency competency;

                foreach (localhostEC.EmployeeCompetency comp in pancake)
                {
                    ec = new Employee_Competency();
                    ec.setEmployeeCompetency(comp);
                    ecList.Add(ec);


                    foreach (localhostCompetency.Competency compot in cake)
                    {
                       
                        if(compot.id == ec.competencyId)
                        {
                            competency = new Competency();
                            competency.setCompetency(compot);
                            compList.Add(competency);
                        }
                       
                    }
                }
                var vm = new EmployeeIndexViewModel
                {
                    Employee = person,
                    //Employees_Competency = ecList,
                    Competencies = compList
                    
                };
                return View(vm);
            }
        }

        // GET: People/Create
        public ActionResult Create()
        {
            List<Competency> compList = new List<Competency>();

            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            localhostCompetency.Competency[] cake = CWS.getAllCompetencies();
            CWS.Timeout = 2000;

            Competency competency;
            foreach (localhostCompetency.Competency comp in cake)
            {
                competency = new Competency();
                competency.setCompetency(comp);
                compList.Add(competency);
            }

            var ecvm = new EmployeeCompetencyViewModel
            {
                Employee = new Employee(),
                Competencies = compList
            };
            return View(ecvm);
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,Phone,BirthDate,HomeAddress,Competencies,")] Employee person,
            EmployeeCompetencyViewModel data, IEnumerable<int> compIds)
        {
            if (ModelState.IsValid)
            {
                _iEmployeeRepository.InsertOrUpdate(data.Employee);

                if (compIds != null)
                {
                    foreach (var pancake in compIds)
                    {
                        var employeeCompetency = new Employee_Competency
                        {
                            competencyId = pancake,
                            employeeId = data.Employee.Id
                        };
                        ECC.Create(employeeCompetency);
                    }
                }

                return RedirectToAction("Index");
            }
            List<Competency> compList = new List<Competency>();

            localhostCompetency.CompetencyWebserviceService CWS = new localhostCompetency.CompetencyWebserviceService();
            localhostCompetency.Competency[] cake = CWS.getAllCompetencies();
            CWS.Timeout = 2000;

            Competency competency;
            foreach (localhostCompetency.Competency comp in cake)
            {
                competency = new Competency();
                competency.setCompetency(comp);
                compList.Add(competency);
            }

            var ecvm = new EmployeeCompetencyViewModel
            {
                Employee = person,
                Competencies = compList
            };
            return View(ecvm);
        }

        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = _iEmployeeRepository.Find(id);
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

            var vm = new EmployeeCompetencyViewModel
            {
                Employee = employee,
                Competencies =compList
            };
            return View(vm);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,Phone,BirthDate,HomeAddress,Competencies")] Employee person,
            EmployeeCompetencyViewModel data, IEnumerable<int> compIds)
        {
            if (ModelState.IsValid)

            {
                _iEmployeeRepository.InsertOrUpdate(data.Employee);

                if (compIds != null)
                {
                    foreach (var pancake in compIds)
                    {
                        var employeeCompetency = new Employee_Competency
                        {
                            competencyId = pancake,
                            employeeId = data.Employee.Id
                        };
                        ECC.Create(employeeCompetency);
                    }
                }
                else 
                {
                    throw new ArgumentNullException(nameof(compIds),
                        "The competencies can not be NULL, you have to select at least 1.");
                }
                return RedirectToAction("Index");
            }

            return View();
        }
        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee person = _iEmployeeRepository.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _iEmployeeRepository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
