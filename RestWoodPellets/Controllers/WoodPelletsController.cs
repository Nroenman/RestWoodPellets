using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WoodPelletLib;

namespace RestWoodPellets.Controllers
{
    public class WoodPelletsController : Controller
    {
        // GET: WoodPelletsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WoodPelletsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WoodPelletsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WoodPelletsController/Create
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

        // GET: WoodPelletsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WoodPelletsController/Edit/5
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

        // GET: WoodPelletsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WoodPelletsController/Delete/5
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


        [HttpGet]
        [Route("Woodpellet")]
        public IEnumerable<WoodPellet> GetWoodPellets()
        {
            return GetWoodPellets();
        }

        [HttpGet]
        [Route("WoodPellet")]
        public IEnumerable<WoodPellet> AddWoodPellets (int id)
        {
            return AddWoodPellets(id);
        }

    }
}
