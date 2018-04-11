using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NanjingMetro.Models;

namespace NanjingMetro.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult MetroQuery()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MetroQuery(MetroQuery metroQuery)
        {
            if (ModelState.IsValid)
            {
                metroQuery.Query();
                return View("QueryResult", metroQuery);
            }
            else
            {
                return View();
            }

        }
    }
}
