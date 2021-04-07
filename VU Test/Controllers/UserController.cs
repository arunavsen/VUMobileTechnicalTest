using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VU_Test.Models;

namespace VU_Test.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            _db = db;
        }

        // GET: User
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Hello()
        {

            return View();
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(User user)
        {
            var users = _db.Users.FirstOrDefault(m => m.Username == user.Username && m.Password == user.Password);
            if (users != null)
            {
                return RedirectToAction("Hello");
            }
            else
            {
                ViewBag.messege = "User is not found";
                return View();
            }
        }

    }
}