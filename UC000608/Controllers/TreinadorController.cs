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
    public class TreinadorController : Controller
    {
        private readonly UC000608Context _context;

        public TreinadorController(UC000608Context context)
        {
            _context = context;
        }

        // GET: Treinador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Treinadores.ToListAsync());
        }

        // GET: Treinador/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treinador = await _context.Treinadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (treinador == null)
            {
                return NotFound();
            }

            return View(treinador);
        }

        // GET: Treinador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Treinador/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Especialidade,Id,Nome,Email,Telefone")] Treinador treinador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(treinador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(treinador);
        }

        // GET: Treinador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treinador = await _context.Treinadores.FindAsync(id);
            if (treinador == null)
            {
                return NotFound();
            }
            return View(treinador);
        }

        // POST: Treinador/Edit/5
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Especialidade,Id,Nome,Email,Telefone")] Treinador treinador)
        {
            if (id != treinador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(treinador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TreinadorExists(treinador.Id))
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
            return View(treinador);
        }

        // GET: Treinador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var treinador = await _context.Treinadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (treinador == null)
            {
                return NotFound();
            }

            return View(treinador);
        }

        // POST: Treinador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var treinador = await _context.Treinadores.FindAsync(id);
            if (treinador != null)
            {
                _context.Treinadores.Remove(treinador);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TreinadorExists(int id)
        {
            return _context.Treinadores.Any(e => e.Id == id);
        }
    }
}
