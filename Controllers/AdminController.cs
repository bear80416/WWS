using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myspace.Data;
using Microsoft.EntityFrameworkCore;

namespace MYSPACE.Controllers
{
    public class AdminController : Controller
    {

        private readonly MainContext _context;

        public AdminController(MainContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> index()
        {
            var model = await _context.Admin.ToListAsync();
            return View();
        }
    }
}