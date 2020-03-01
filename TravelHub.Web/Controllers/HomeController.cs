using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelHub.Models;

namespace TravelHub.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Users> userList = new List<Users>();
            userList.Add(new Users
            {
                FirstName =  "Christopher",
                MiddleName = "Moral",
                LastName = "Palisoc",
                UserId = 1
            });
            userList.Add(new Users
            {
                FirstName = "Jessica",
                MiddleName = "Cabanero",
                LastName = "Palisoc",
                UserId =2
            });

            return View(userList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}