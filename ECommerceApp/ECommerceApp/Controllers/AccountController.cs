using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceApp.Controllers
{
    
    public class AccountController : Controller
    {

        private void MigrateShoppingCart(string username)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            cart.MigrateCart(username);
            Session[ShoppingCart.CartSessionKey] = username;

        }

        public ActionResult Logon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logon(LogonModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.Username, model.Password))
                {
                    MigrateShoppingCart(model.Username);

                    FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The username or password provided is incorrect!");
                }
            }
            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                MembershipCreateStatus createStatus;

                Membership.CreateUser(model.Username, model.Password, model.Email, model.Question, model.Answer, true, out createStatus);
                if (createStatus == MembershipCreateStatus.Success)
                {
                    MigrateShoppingCart(model.Username);

                    FormsAuthentication.SetAuthCookie(model.Username, true);

                    Roles.AddUserToRole(model.Username, "Customer");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Error");
                }
            }
            return View(model);
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                bool changePasswordSuccess;
                try
                {
                    MembershipUser currentUser = Membership.GetUser(User.Identity, true);
                    changePasswordSuccess = currentUser.ChangePassword(model.OldPassword, model.NewPassword);
                }
                catch
                {
                    changePasswordSuccess = false;
                }

                if (changePasswordSuccess)
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid!");
                }
            }
            return View(model);
        }

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }
    }
}
