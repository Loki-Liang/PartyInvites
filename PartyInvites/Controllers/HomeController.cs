using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //get: home
        //public actionresult index()
        //{
        //    return view();
        //}

        //public string index()
        //{
        //    return "hello world";
        //}

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "God Morning ": "Good Afternoon";
            return View();
        }
        public ViewResult RsvpFrom()
        {
            return View ();
        }


    }
}