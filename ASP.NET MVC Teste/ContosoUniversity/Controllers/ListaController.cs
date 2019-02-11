using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class ListaController : Controller
    {
        // GET: Lista
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaAlunos()
        {
            return View();
        }

        public ActionResult ListaProfessores()
        {
            return View();
        }
    }
}