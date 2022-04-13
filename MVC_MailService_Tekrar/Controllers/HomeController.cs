using MVC_MailService_Tekrar.DesignPatterns.SingletonPattern;
using MVC_MailService_Tekrar.Models.Context;
using MVC_MailService_Tekrar.Models.Entities;
using MVC_MailService_Tekrar.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_MailService_Tekrar.Controllers
{
    public class HomeController : Controller
    {

        MyContext _db;

        public HomeController()
        {
            _db = DBTool.DBInstance;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AppUser appUser)
        {
            MailService.Send(appUser.Email,body:"Teknoromaya Hoşgeldiniz!",subject:"Alışverişe Hemen Başla!");
            ViewBag.Message = "Mail başarılı bir şekilde gönderilmiştir";
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}