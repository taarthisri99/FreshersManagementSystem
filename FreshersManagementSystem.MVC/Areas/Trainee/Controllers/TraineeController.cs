using System;
using System.Linq;
using System.Web.Mvc;
using FreshersManagement.Service;
using Trainee;

namespace FreshersManagementSystem.MVC.Areas.Trainee.Controllers
{
    public class TraineeController : Controller
    {
        Service service = new Service();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Fresher fresher)
        {
            service.SaveTrainee(fresher);

            return RedirectToAction("ShowFreshers");
        }

        [HttpGet] 
        public ActionResult ShowFreshers()
        {
            return View(service.FetchTrainees().ToList());
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult UpdateTrainee(Fresher fresher)
        {
            return Json(service.UpdateTrainee(fresher), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Delete(int id)
        {
            return Json(service.DeleteTrainee(id), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetbyID(int id)
        {
            return Json(service.FetchTrainee(id), JsonRequestBehavior.AllowGet);
        }
    }
}