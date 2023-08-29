using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            try
            {
               string data= HttpContext.Session.GetString("test");
            }
            catch (Exception ex)
            {

             
            }
            return View();
        }

        public IActionResult Create(string key,string value)
        {
            addToSesison(key, value);
            return RedirectToAction("index");
        }

        private void addToSesison(string key, string value)
        {
            HttpContext.Session.SetString(key, value);
        }
    }
}