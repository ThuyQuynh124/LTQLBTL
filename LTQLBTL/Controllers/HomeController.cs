using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQLBTL.Controllers
{
    public class HomeController : Controller
    {
        //Với action cho phép truy cập không cần kiểm tra đăng nhập
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        //Kiểm tra đăng nhập trước khi truy cập với action
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}