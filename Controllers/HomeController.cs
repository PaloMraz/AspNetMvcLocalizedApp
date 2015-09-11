using AspNetMvcLocalizedApp.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcLocalizedApp.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      this.ViewBag.Title = Strings.Common_AppName;
      return this.View();
    }


    public ActionResult ChooseCulture()
    {
      return this.View(Infrastructure.LocalizationFilterAttribute.GetSupportedCultures());
    }


    [HttpPost]
    public ActionResult ChooseCulture(string selectedCulture)
    {
      Infrastructure.LocalizationFilterAttribute.SetCurrentCultureCookie(this.Response, selectedCulture);
      return this.RedirectToAction("Index");
    }
  }
}