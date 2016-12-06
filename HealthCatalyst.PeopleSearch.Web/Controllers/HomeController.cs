using HealthCatalyst.PeopleSearch.MiddleWare.Services;
using HealthCatalyst.PeopleSearch.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace HealthCatalyst.PeopleSearch.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Search(string q)
        {
            //Simulate delay to illustrate loading status
            Thread.Sleep(2000);
            var people = PersonService.Instance.GetPeopleByName(q).Select(p => new SearchResultViewModel(p));
            return Json(people, JsonRequestBehavior.AllowGet);
        }
    }
}