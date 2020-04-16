using DiegoLopez.Models;
using DiegoLopez.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2;

namespace DiegoLopez.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ServiceClient clienteServicio = new ServiceClient();
            List<ServiceReference1.ObjConsuta> objModelo = new List<ServiceReference1.ObjConsuta>();

            objModelo = clienteServicio.GetData().ToList();

            return View(objModelo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}