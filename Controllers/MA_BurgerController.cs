using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MellArguello_EXAMENP1.Data;
using MellArguello_EXAMENP1.Models;

namespace MellArguello_EXAMENP1.Controllers
{
    public class MA_BurgerController : Controller
    {
        private readonly MellArguello_EXAMENP1Context _context;

        public MA_BurgerController(MellArguello_EXAMENP1Context context)
        {
            _context = context;
        }

        // GET: MA_Burger
        public async Task<IActionResult> Index()
        {
            return View(await _context.MA_Burger.ToListAsync());
        }

        // GET: MA_Burger/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mA_Burger = await _context.MA_Burger
                .FirstOrDefaultAsync(m => m.MA_Nombre == id);
            if (mA_Burger == null)
            {
                return NotFound();
            }

            return View(mA_Burger);
        }

        // GET: MA_Burger/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MA_Burger/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MA_Id,MA_Nombre,MA_ConsumidorFinal,MA_Precio,MA_Fecha,OtraFecha")] MA_Burger mA_Burger)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mA_Burger);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mA_Burger);
        }

        // GET: MA_Burger/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mA_Burger = await _context.MA_Burger.FindAsync(id);
            if (mA_Burger == null)
            {
                return NotFound();
            }
            return View(mA_Burger);
        }

        // POST: MA_Burger/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MA_Id,MA_Nombre,MA_ConsumidorFinal,MA_Precio,MA_Fecha,OtraFecha")] MA_Burger mA_Burger)
        {
            if (id != mA_Burger.MA_Nombre)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mA_Burger);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MA_BurgerExists(mA_Burger.MA_Nombre))
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
            return View(mA_Burger);
        }

        // GET: MA_Burger/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mA_Burger = await _context.MA_Burger
                .FirstOrDefaultAsync(m => m.MA_Nombre == id);
            if (mA_Burger == null)
            {
                return NotFound();
            }

            return View(mA_Burger);
        }

        // POST: MA_Burger/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var mA_Burger = await _context.MA_Burger.FindAsync(id);
            if (mA_Burger != null)
            {
                _context.MA_Burger.Remove(mA_Burger);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MA_BurgerExists(string id)
        {
            return _context.MA_Burger.Any(e => e.MA_Nombre == id);
        }
    }
}
