using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MotoEgzaminM2.Controllers
{
    public class EduMaterialReviewController : Controller
    {
        // GET: EduMaterialReviewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EduMaterialReviewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EduMaterialReviewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EduMaterialReviewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EduMaterialReviewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EduMaterialReviewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EduMaterialReviewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EduMaterialReviewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
