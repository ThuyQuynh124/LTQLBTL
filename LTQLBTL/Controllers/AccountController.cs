using LTQLBTL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using LTQLBTL.Models;

namespace LTQLBTL.Controllers
{
    [Authorize (Roles = "1")]
    public class AccountController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();
        [AllowAnonymous]
        //Action Login(HttpGet), mặc định là get
        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        //nhận dữ liệu từ client gửi lên
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account acc, string returnUrl)
        {
            // Nếu vượt qua được validation ở accounmodel
            if (ModelState.IsValid)
            {
                var models = db.Accounts.Where(m => m.Username == acc.Username && m.Password == acc.Password).ToList().Count();
                //kiểm tra thông tin đăng nhập
                if (acc.Username == "admin" && acc.Password == "123123")
                {
                    //set cookie
                    FormsAuthentication.SetAuthCookie(acc.Username, true);
                    return RedirectToLocal(returnUrl);
                }
            }
            return View(acc);
        }
        //hàm đăng xuất khỏi chương trình
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        //Kiểm tra xem returUrl có thuộc hệ thống hay không
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
