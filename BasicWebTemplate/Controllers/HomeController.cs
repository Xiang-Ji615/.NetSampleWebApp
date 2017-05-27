using BasicWebTemplate.Models;
using BasicWebTemplateDAO.User;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BasicWebTemplate.Controllers
{
    public class HomeController : Controller
    {
        IUserDao userDao;

        //[Authorize]
        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Home Page";
            userDao = new UserDaoImp();
            int id = Thread.CurrentThread.ManagedThreadId;
            await userDao.addUser(new BasicWebTemplateDAO.User.User() { Username = "JJ", Password = "Pass1" });
            int id2 = Thread.CurrentThread.ManagedThreadId;
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            FormsAuthentication.SignOut();
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin()
        {
            UserManager<MVCUser> usermanager;
            IAuthenticationManager manager = HttpContext.GetOwinContext().Authentication;
     
            FormsAuthentication.SetAuthCookie("admin", false);
            return RedirectToAction("Index", "Home");
        }
    }
}
