using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingApp.Models;
using TestingApp.Services;

namespace TestingApp.Controllers
{
    public class BotController : Controller
    {
        private FirstTestService firstTestService;

        public BotController()
        {
            this.firstTestService = new FirstTestService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new BotButtonCounter();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(BotButtonCounter model)
        {
            model.ClickCount = 1;
            this.firstTestService.AddBotCounter(model.ClickCount);
            return View(model);
        }

        [HttpGet]
        public ActionResult Bot()
        {
            return View();
        }
    }
}