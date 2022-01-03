using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Refugiados.Models;

namespace Refugiados.Controllers
{
    public class VoluntariadoesController : Controller
    {
        private readonly BancoDeDados _context;

        public VoluntariadoesController(BancoDeDados context)
        {
            _context = context;
        }

        // GET: Voluntariadoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Voluntariados.ToListAsync());
        }

        // GET: Voluntariadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voluntariado = await _context.Voluntariados
                .FirstOrDefaultAsync(m => m.Id_Voluntario == id);
            if (voluntariado == null)
            {
                return NotFound();
            }

            return View(voluntariado);
        }

        // GET: Voluntariadoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Voluntariadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Voluntario,Nome,CPF,Email,Conselho,Uf_Conselho,Numero_Conselho,Especialidade,Servicos")] Voluntariado voluntariado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voluntariado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voluntariado);
        }

        // GET: Voluntariadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voluntariado = await _context.Voluntariados.FindAsync(id);
            if (voluntariado == null)
            {
                return NotFound();
            }
            return View(voluntariado);
        }

        // POST: Voluntariadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Voluntario,Nome,CPF,Email,Conselho,Uf_Conselho,Numero_Conselho,Especialidade,Servicos")] Voluntariado voluntariado)
        {
            if (id != voluntariado.Id_Voluntario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voluntariado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoluntariadoExists(voluntariado.Id_Voluntario))
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
            return View(voluntariado);
        }

        // GET: Voluntariadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voluntariado = await _context.Voluntariados
                .FirstOrDefaultAsync(m => m.Id_Voluntario == id);
            if (voluntariado == null)
            {
                return NotFound();
            }

            return View(voluntariado);
        }

        // POST: Voluntariadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voluntariado = await _context.Voluntariados.FindAsync(id);
            _context.Voluntariados.Remove(voluntariado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoluntariadoExists(int id)
        {
            return _context.Voluntariados.Any(e => e.Id_Voluntario == id);
        }
    }
}
