using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Warsztat_3.Models;

namespace Warsztat_3.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View(SourceManager.Get(1,3));
        }

        [HttpGet]
        public IActionResult Show (int id)
        {
            return View(SourceManager.GetByID(id));
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add (PersonModel person)
        {
            if (ModelState.IsValid)
            {
                SourceManager.Add(person);
                return RedirectToAction("Index");
            }
            return View();           
            
        }

        [HttpGet]
        public IActionResult Remove (int id)
        {
            SourceManager.Remove(id);
            return RedirectToAction("Index");
        }

    }
}