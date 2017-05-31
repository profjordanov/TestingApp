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

        const string clickCountSessionKey = "clickCount";

        [HttpGet]
        public ActionResult Index()
        {
            var model = new BotButtonCounter() {ClickCount = 0};
            var previousClickCount = Session[clickCountSessionKey];
            if (previousClickCount != null)
            {
                model.ClickCount = (int) previousClickCount;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(BotButtonCounter model)
        {
            model.ClickCount++;
            this.firstTestService.AddBotCounter(model.ClickCount);
            Session[clickCountSessionKey] = model.ClickCount;
            return View(model);
        }

        [HttpGet]
        public ActionResult Bot()
        {
            return View();
        }
    }
}