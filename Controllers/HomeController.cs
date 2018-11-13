using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Auction.Models;

namespace Auction.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckIn()
        {
            ViewBag.Message = "Bidder Check In";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Payments()
        {
            ViewBag.Message = "Payment page.";

            return View();
        }
        public ActionResult SilentAuction()
        {
            ViewBag.Message = "Silent Auction page.";

            return View();
        }


        public ActionResult NewItem()

        {
            ViewBag.Message = "New Item page.";
            return View();
        }
    }
}
