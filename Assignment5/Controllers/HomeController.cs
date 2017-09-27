using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        EmpContext context = new EmpContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            Emp e = new Emp();
            var Cities = context.Ctys.ToList();
            var States = context.States.ToList();
            var viewModel = new EmpVM
            {
                Name = e.Name,
                Email = e.Email,
                Phone = e.Phone,
                MaritalStatus = e.MaritalStatus,

                State = States,
                City = Cities

            };

            return View("Create", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Create(EmpVM person)
         {

             if (ModelState.IsValid)
             {
                 context.Emps.Add(person.Employee);
                 
               
             }
            


             return RedirectToAction("Index");



         } 

    }
}