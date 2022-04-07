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
            if (ModelState.IsValid)
            {
                service.SaveTrainee(fresher);
            }
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
        public JsonResult UpdateTrainee([Bind] Fresher fresher)
        {
            int affectedRows = 0;

            if (ModelState.IsValid)
            {
                affectedRows = service.UpdateTrainee(fresher);
            }
                return Json(affectedRows, JsonRequestBehavior.AllowGet);
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