using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcLocalizedApp.Infrastructure
{
  public class LocalizationFilterAttribute : ActionFilterAttribute
  {
    private const string CultureCookieName = "_culture";

    private static SelectListItem[] _s_supportedCultures =
    {
      new SelectListItem() { Value = "en-US", Text = "English" },
      new SelectListItem() { Value="sk-SK", Text = "Slovensky" }
    };


    public LocalizationFilterAttribute()
    { }


    public static List<SelectListItem> GetSupportedCultures()
    {
      string currentCulture = Thread.CurrentThread.CurrentUICulture.Name;
      return _s_supportedCultures
        .Select(item => new SelectListItem() { Value = item.Value, Text = item.Text, Selected = item.Value == currentCulture })
        .ToList();
    }


    public static void SetCurrentCultureCookie(HttpResponseBase response, string cultureName)
    {
      if (_s_supportedCultures.Any(item => item.Value == cultureName))
      {
        response.SetCookie(new HttpCookie(CultureCookieName, cultureName) { HttpOnly = true });
      }
    }


    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      base.OnActionExecuting(filterContext);

      if (filterContext.IsChildAction)
      {
        return;
      }

      HttpRequestBase request = filterContext.HttpContext.Request;
      HttpCookie cultureCookie = request.Cookies.Get(CultureCookieName);
      if (cultureCookie == null)
      {
        cultureCookie = new HttpCookie(CultureCookieName, _s_supportedCultures[0].Value)
        {
          HttpOnly = true
        };

        // Culture cookie namáme - pozrieme, čo chce browser.
        if (request.UserLanguages != null)
        {
          string firstSupportedCulture = request.UserLanguages
            .Intersect(_s_supportedCultures.Select(item => item.Value))
            .FirstOrDefault();

          if (firstSupportedCulture != null)
          {
            cultureCookie.Value = firstSupportedCulture;
          }
        }
        filterContext.HttpContext.Response.SetCookie(cultureCookie);
      }

      Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureCookie.Value);
      Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
    }
  }
}