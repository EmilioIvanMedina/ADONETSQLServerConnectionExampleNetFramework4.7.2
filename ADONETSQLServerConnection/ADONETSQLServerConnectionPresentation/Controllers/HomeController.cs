using ADONETSQLServerConnection.Application.Interfaces;
using ADONETSQLServerConnectionPresentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADONETSQLServerConnectionPresentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public HomeController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var vm = new ContactViewModle
            {
                Title = "Contact",
                Message = "Your contact page.",
                Contacts = _contactRepository.GetAll()
            };

            return View(vm);
        }
    }
}