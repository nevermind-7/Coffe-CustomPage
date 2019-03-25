using System.Collections.Generic;
using System.Web.Mvc;
using CustomPage.Factories;
using CustomPage.Filters;
using CustomPage.Models;
using CustomPage.Repositories;

namespace CustomPage.Controllers
{
    [Localization("en")]
    public class AboutUsController : Controller
    {
        public ActionResult WhereAre()
        {
            return PartialView("WhereAre");
        }
        public ActionResult ContactUs()
        {
            return PartialView("ContactUs");
        }
        public ActionResult Specializations()
        {
            CoffeeRepository oCoffeeRepository = new CoffeeRepository(SqlEngineSpecificationsFactory.CreateSqlEngineSpecifications());
            var coffeeList = oCoffeeRepository.GetAll();
            return PartialView("Specializations", coffeeList);
        }
        public ActionResult HowWeAre()
        {
            return PartialView("WhoWeAre");
        }

        [HttpPost]
        public JsonResult addContact(Contact oContact)
        {
            if (ModelState.IsValid)
            {
                ContactRepository oContactRepository = new ContactRepository(SqlEngineSpecificationsFactory.CreateSqlEngineSpecifications());
                oContactRepository.Create(oContact);
                return Json(new { response = true });
            }

            return Json(new { response = false });
        }
    }
}
