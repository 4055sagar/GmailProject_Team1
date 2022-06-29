using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GmailProject_Team1.Controllers
{
    public class MyAccountController : Controller
    {
        // GET: MyAccount
        public ActionResult Login()
        {
            return View();
        }
    }
}