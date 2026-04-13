using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UC000608.Data;
using UC000608.Models;

namespace UC000608.Controllers
{
    public class MembroController : Controller
    {
        private readonly UC000608Context _context;

        public MembroController(UC000608Context context)
        {
            _context = context;
        }

        // GET: Membro
        public async Task<IActionResult> Index()
        {
            var uC000608Context = _context.Membros.Include(m => m.Plano);
            return View(await uC000608Context.ToListAsync());
        }

        // GET: Membro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membro = await _context.Membros
                .Include(m => m.Plano)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (membro == null)
            {
                return NotFound();
            }

            return View(membro);
        }

        // GET: Membro/Create
        public IActionResult Create()
        {
            ViewData["PlanoId"] = new SelectList(_context.Planos, "Id", "Nome");
            return View();
        }

        // POST: Membro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NrSocio,Ativo,PlanoId")] Membro membro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(membro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlanoId"] = new SelectList(_context.Planos, "Id", "Nome", membro.PlanoId);
            return View(membro);
        }

        // GET: Membro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membro = await _context.Membros.FindAsync(id);
            if (membro == null)
            {
                return NotFound();
            }
            ViewData["PlanoId"] = new SelectList(_context.Set<Plano>(), "Id", "Id", membro.PlanoId);
            return View(membro);
        }

        // POST: Membro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NrSocio,Ativo,PlanoId")] Membro membro)
        {
            if (id != membro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembroExists(membro.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlanoId"] = new SelectList(_context.Set<Plano>(), "Id", "Id", membro.PlanoId);
            return View(membro);
        }

        // GET: Membro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membro = await _context.Membros
                .Include(m => m.Plano)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (membro == null)
            {
                return NotFound();
            }

            return View(membro);
        }

        // POST: Membro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var membro = await _context.Membros.FindAsync(id);
            if (membro != null)
            {
                _context.Membros.Remove(membro);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembroExists(int id)
        {
            return _context.Membros.Any(e => e.Id == id);
        }
    }
}
