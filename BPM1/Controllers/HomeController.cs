using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BPM.Repository;

namespace BPM1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _db;
        public HomeController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {



            int a = 1;
            if (a > 0)
            {
                a++;
            }
            else
            {
                a = 1;
            }

            var list = _db.FlowTemplate.ToList();
            return View();
        }
    }
}