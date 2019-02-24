using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()    // 一个函数就是一个网页，函数名即网页title及网页文件名
        {
            return View();
        }
    }
}