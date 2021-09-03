using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaCandidato.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.NomeEmpresa = System.Configuration.ConfigurationSettings.AppSettings["NomeEmpresa"];
      return View();
    }
  }
}