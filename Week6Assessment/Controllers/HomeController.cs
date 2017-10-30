using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6Assessment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Please provide two numbers to add.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Just Google it!";

            return View();
        }

        public ActionResult AddNumbers(string No1, string No2) //receives user numbers 
        {
            double x = double.Parse(No1); //parses the user numbers into doubles
            double y = double.Parse(No2);

            double sum = x + y; //adds the two doubles to get sum total 

            ViewBag.Summation = sum;

            return View("Result");

        }
    }
}