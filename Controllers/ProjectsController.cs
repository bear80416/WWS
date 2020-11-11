using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myspace
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult Apple()
        {
            return View();
        }
         public IActionResult Calculator()
        {
            return View();
        }
         public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult GuessTheNumber()
        {
            return View();
        }
        public IActionResult Pizza()
        {
            return View();
        }
          public IActionResult Puzzle()
        {
            return View();
        }
         public IActionResult Statistics()
        {
            return View();
        }

        public IActionResult LocalFoods()
        {
            return View();
        }
    }
}