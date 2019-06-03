using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomePet.Data;
using HomePet.Models;
namespace HomePet.Controllers
{
    public class HomeController: Controller
    {
        private HomePetDbContext _context;

        public HomeController(HomePetDbContext c){
            _context = c;
        }
        public IActionResult Index()
        {

          return View();
        }
        public IActionResult RegistrarMascota()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [HttpPost]

        public IActionResult RegistrarMascota(Mascota m)
        {
            if(ModelState.IsValid){
                _context.Add(m);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
          return View(m);
        }


    }
}