using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TMS.Models;

namespace TMS.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> test2 = new List<Customer>();

            localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
            CWS.Timeout = 2000;
            localhost.Customer[] aaa = CWS.findCustomerArray();

            Customer cust;
            foreach (localhost.Customer cust2 in aaa) {
                cust = new Customer();
                cust.setCustomer(cust2);
                test2.Add(cust);
            }

            IEnumerable<Customer> test = test2;


            return View(test.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = new Customer();
            localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
            CWS.Timeout = 2000;
            customer.setCustomer(CWS.findCustomer((int)id));
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,CompanyName,CVR,CompanyAddress,Phone,ApplicationUserId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                localhost.Customer cust = new localhost.Customer();
                cust = customer.getCustomer();
                localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
                CWS.Timeout = 2000;
                String result = CWS.createCustomer(cust);
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = new Customer();
            localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
            CWS.Timeout = 2000;
            customer.setCustomer(CWS.findCustomer((int)id));
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,CompanyName,CVR,CompanyAddress,Phone")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                localhost.Customer cust = new localhost.Customer();
                cust = customer.getCustomer();
                localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
                CWS.Timeout = 2000;
                String result = CWS.updateCustomer(cust);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = new Customer();
            localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
            CWS.Timeout = 2000;
            customer.setCustomer(CWS.findCustomer((int)id));
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = new Customer();
            localhost.CustomerWebserviceService CWS = new localhost.CustomerWebserviceService();
            CWS.Timeout = 2000;
            localhost.Customer deleteCustomer = CWS.findCustomer((int)id);
            CWS.deleteCustomer(deleteCustomer);            
            return RedirectToAction("Index");
        }
    }
}
