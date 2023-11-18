using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sala aplicação web MVC para o curso de c#.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
                /*
                * // ActionResult e um generico        
                public ActionResult Index()
                {
                return View();
                // return Content("ops");
                //return Redirect("http://www.google.com");
                }

                //retorna um conteudo
                // caso queira usar ActionResult pode
                public ContentResult ContentResult() {
                return Content("ops");
                }

                //download
                // caso queira usar ActionResult pode
                public FileContentResult FileContentResult() {
                byte[] foto = System.IO.File.ReadAllBytes(Server.MapPath("/Content/Img/Icone-Carta.jpg"));
                return File(foto,contentType: "Img/jpg", fileDownloadName: "Icone-Carta.jpg");

                }

                //resultado não autorizado
                // caso queira usar ActionResult pode
                public HttpUnauthorizedResult HttpUnauthorizedResult()
                {
                return new HttpUnauthorizedResult();
                }

                //AllowGet permitir um Get
                // caso queira usar ActionResult pode
                public JsonResult JsonResult() {
                return Json(data:"teste: TesteOps", JsonRequestBehavior.AllowGet );
                }

                // caso queira usar ActionResult pode
                // caso queira usar ActionResult pode
                public RedirectResult RedirectResult() {

                return Redirect("http://www.google.com");
                //return new RedirectResult( url:"http://www.google.com");
                }

                // caso queira usar ActionResult pode
                public RedirectToRouteResult RedirectToRouteResult(){


                // return RedirectToRoute(new {
                //     Controller = "Home",
                //     action = "About"            
                // });

                // ou algo mas simples
                // return RedirectToAction("About");
                return RedirectToAction("Home", controllerName: "About");

                }

                // caso queira usar ActionResult pode
                public ActionResult About()
                {
                ViewBag.Message = "Your application description page.";

                return View();

                }

                // caso queira usar ActionResult pode
                public ActionResult Contact()
                {
                ViewBag.Message = "Your contact page.";

                return View();
                }
                */


    }
}
