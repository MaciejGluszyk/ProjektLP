using ProjektLP.Models.Data;
using ProjektLP.Models.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektLP.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        public ActionResult Index()
        {
            // Deklaracja listy PageVM
            List<PageVM> pagesList;

          
            using (Db db = new Db())
            {
                // Zainicjuj liste
                pagesList = db.Pages.ToArray().OrderBy(x => x.Sorting).Select(x => new PageVM(x)).ToList();

            }

            // Powrót do widoku z listą
            return View(pagesList);
        }
        public ActionResult AddPage()
        {
            return View();
        }
    }
}