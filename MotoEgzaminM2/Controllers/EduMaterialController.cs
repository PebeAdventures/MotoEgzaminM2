using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MotoEgzaminM2.Controllers
{
    public class EduMaterialController : Controller
    {
        // GET: EduMaterialController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EduMaterialController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EduMaterialController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EduMaterialController/Create
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

        // GET: EduMaterialController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EduMaterialController/Edit/5
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

        // GET: EduMaterialController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EduMaterialController/Delete/5
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
