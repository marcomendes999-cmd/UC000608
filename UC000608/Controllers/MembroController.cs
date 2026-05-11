using Microsoft.AspNetCore.Mvc;
using UC000608.Models;
using UC000608.Services;

namespace UC000608.Controllers
{
    public class MembroController : Controller
    {
        private readonly MembroService _service = new MembroService();

        // GET: Membro
        public IActionResult Index()
        {
            return View(_service.ObterMembros());
        }

        // GET: Membro/Details/5
        public IActionResult Details(int id)
        {
            var membro = _service.ObterMembroPorID(id);

            if (membro == null)
            {
                return NotFound();
            }

            return View(membro);
        }

        // GET: Membro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Membro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Membro membro)
        {
            return RedirectToAction(nameof(Index));
        }

        // GET: Membro/Edit/5
        public IActionResult Edit(int id)
        {
            var membro = _service.ObterMembroPorID(id);

            if (membro == null)
            {
                return NotFound();
            }

            return View(membro);
        }

        // POST: Membro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Membro membro)
        {
            return RedirectToAction(nameof(Index));
        }

        // GET: Membro/Delete/5
        public IActionResult Delete(int id)
        {
            var membro = _service.ObterMembroPorID(id);

            if (membro == null)
            {
                return NotFound();
            }

            return View(membro);
        }

        // POST: Membro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
