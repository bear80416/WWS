using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myspace.Data;
using Microsoft.EntityFrameworkCore;

namespace MYSPACE.Controllers
{
    public class BlogController : Controller
    {

        private readonly MainContext _context;

        public BlogController(MainContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> main()
        {
            var model = await _context.Blog.ToListAsync();
            return View();
        }
    }
}