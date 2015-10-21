using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMVC1.Models;

namespace WebMVC1.Controllers
{
    [AllowAnonymous]
    public class AuthenticationController : Controller
    {
        //
        // GET: /Authentication/
        public ActionResult Login()
        {
            return View("Login");
        }

        //[HttpPost]
        //public ActionResult DoLogin(UserDetails u)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
        //        if (bal.IsValidUser(u))
        //        {
        //            FormsAuthentication.SetAuthCookie(u.UserName, false);
        //            return RedirectToAction("Index", "Employee");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("CredentialError", "Invalid Username or Password");
        //            return View("Login");
        //        }
        //    }
        //    else
        //    {
        //        return View("Login");
        //    }
        //}

        [HttpPost]
        public ActionResult DoLogin(UserDetails u)
        {
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
                UserStatus status = bal.GetUserValidity(u);
                bool IsAdmin = false;
                if (status == UserStatus.AuthenticatedAdmin)
                {
                    IsAdmin = true;
                }
                else if  (status == UserStatus.AuthentucatedUser)
                {
                    IsAdmin = false;
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "Invalid Username or Password");
                    return View("Login");
                }
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                Session["IsAdmin"] = IsAdmin;
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
	}
}