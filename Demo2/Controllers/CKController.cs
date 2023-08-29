using Demo2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Demo2.Controllers
{
    public class CKController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult GetCart()
        {
           string cartStr= HttpContext.Request.Cookies["cart"].ToString();
           Cart cart= JsonConvert.DeserializeObject<Cart>(cartStr);
            return View();
        }

        public IActionResult UpdateCart()
        {
            Cart cart = new Cart()
            {
                Username = "n@f",
                CartLines = new List<CartLine>()
                {
                    new CartLine(){Count=2,ProductName="sun glass"},
                    new CartLine(){Count=2,ProductName="ring"}
                }

            };
            string data = JsonConvert.SerializeObject(cart);
            addTpCookie("cart", data);

            return RedirectToAction("index");
        }
        public IActionResult Create(string key,string value)
        {
            addTpCookie(key, value);
            return RedirectToAction("index");
        }

        private void addTpCookie(string key, string value)
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddSeconds(520);
            options.HttpOnly = true;
            options.IsEssential = true;
            HttpContext.Response.Cookies.Append(key, value, options);
        }
    }
}
