using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingApp.Models;
using TestingApp.Models.BindingModels;
using TestingApp.Services;

namespace TestingApp.Controllers
{
    public class TestController : Controller
    {
        private FirstTestService firstTestService;

        public TestController()
        {
            this.firstTestService = new FirstTestService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "quest1, quest2,quest3,quest4,quest5,quest6,quest7,quest8,quest9," +
                                                  "quest10,quest11,quest12,quest13,quest14,quest15,quest16,quest17,quest18,quest19,"+
                                                  "quest20,quest21,quest22,quest23,quest24,quest25,quest26,quest27,quest28,quest29,"+
                                                  "quest30,quest31,quest32,quest33,quest34,quest35,quest36,quest37,quest38,quest39,"+
                                                  "quest40,quest41,quest42,quest43,quest44,quest45,quest46,quest47,quest48,quest49,"+
                                                  "quest50,quest51,quest52,quest53,quest54,quest55,quest56,quest57,quest58,quest59,"+
                                                  "quest60,quest61,quest62,quest63,quest64,quest65,quest66,quest67,quest68,quest69,"+
                                                  "quest70,quest71,quest72,quest73,quest74,quest75,quest76,quest77,quest78,quest79,"+
                                                  "quest80,"
                                                  )] FirstTestBM bind)
        {
            
            this.firstTestService.AddTest(bind);
            if (this.firstTestService.Calculator() == "style1")
            {
                return this.RedirectToAction("Style1");
            }

            if (this.firstTestService.Calculator() == "style2")
            {
                return this.RedirectToAction("Style2");
            }

            if (this.firstTestService.Calculator() == "style3")
            {
                return this.RedirectToAction("Style3");
            }

            if (this.firstTestService.Calculator() == "style4")
            {
                return this.RedirectToAction("Style4");
            }

            if (this.firstTestService.Calculator() == "again")
            {
                return View();
            }

            return this.RedirectToAction("Index");
        }

        //Styles
        const string clickCountSessionKey = "clickCount";
        //Style 1
        [HttpGet]
        public ActionResult Style1()
        {
            var model = new ApplyButtonCounter();
            return View(model);
        }

        [HttpPost]
        public ActionResult Style1(ApplyButtonCounter model)
        {
            model.ClickCount = 1;
            this.firstTestService.AddCounter(model.ClickCount);
            return View(model);
        }
        //Style2
        [HttpGet]
        public ActionResult Style2()
        {
            var model = new ApplyButtonCounter();
            return View(model);
        }
        [HttpPost]
        public ActionResult Style2(ApplyButtonCounter model)
        {
            model.ClickCount = 1;
            this.firstTestService.AddCounter(model.ClickCount);
            return View(model);
        }

        //Style 3
        [HttpGet]
        public ActionResult Style3()
        {
            var model = new ApplyButtonCounter();
            return View(model);
        }

        [HttpPost]
        public ActionResult Style3(ApplyButtonCounter model)
        {
            model.ClickCount = 1;
            this.firstTestService.AddCounter(model.ClickCount);
            return View(model);
        }
        //Style 4
        [HttpGet]
        public ActionResult Style4()
        {
            var model = new ApplyButtonCounter();
            return View(model);
        }
        [HttpPost]
        public ActionResult Style4(ApplyButtonCounter model)
        {
            model.ClickCount = 1;
            this.firstTestService.AddCounter(model.ClickCount);
            return View(model);
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }

      
    }
}