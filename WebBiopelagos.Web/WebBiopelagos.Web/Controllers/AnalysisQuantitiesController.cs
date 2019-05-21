using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBiopelagos.Web.Models;

namespace WebBiopelagos.Web.Controllers
{
    public class AnalysisQuantitiesController : Controller
    {
        private readonly BioDaSysContext _context;

        public AnalysisQuantitiesController(BioDaSysContext context)
        {
            _context = context;
        }

        // GET: AnalysisQuantities
        public async Task<IActionResult> Index()
        {
            var bioDaSysContext = _context.AnalysisQuantity.Include(a => a.Analysis);
            return View(await bioDaSysContext.ToListAsync());
        }

        // GET: AnalysisQuantities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analysisQuantity = await _context.AnalysisQuantity
                .Include(a => a.Analysis)
                .FirstOrDefaultAsync(m => m.AnalysisBaseId == id);
            if (analysisQuantity == null)
            {
                return NotFound();
            }

            return View(analysisQuantity);
        }

        // GET: AnalysisQuantities/Create
        public IActionResult Create()
        {
            ViewData["AnalysisBaseId"] = new SelectList(_context.AnalysisBase, "AnalysisBaseId", "AnalysisTypeId");
            return View();
        }

        // POST: AnalysisQuantities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnalysisBaseId,QunatityValue,QuantityUnit,Comment,SubAnalysisType,AnalysisTypeId")] AnalysisQuantity analysisQuantity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(analysisQuantity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnalysisBaseId"] = new SelectList(_context.AnalysisBase, "AnalysisBaseId", "AnalysisTypeId", analysisQuantity.AnalysisBaseId);
            return View(analysisQuantity);
        }

        // GET: AnalysisQuantities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analysisQuantity = await _context.AnalysisQuantity.FindAsync(id);
            if (analysisQuantity == null)
            {
                return NotFound();
            }
            ViewData["AnalysisBaseId"] = new SelectList(_context.AnalysisBase, "AnalysisBaseId", "AnalysisTypeId", analysisQuantity.AnalysisBaseId);
            return View(analysisQuantity);
        }

        // POST: AnalysisQuantities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AnalysisBaseId,QunatityValue,QuantityUnit,Comment,SubAnalysisType,AnalysisTypeId")] AnalysisQuantity analysisQuantity)
        {
            if (id != analysisQuantity.AnalysisBaseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(analysisQuantity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnalysisQuantityExists(analysisQuantity.AnalysisBaseId))
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
            ViewData["AnalysisBaseId"] = new SelectList(_context.AnalysisBase, "AnalysisBaseId", "AnalysisTypeId", analysisQuantity.AnalysisBaseId);
            return View(analysisQuantity);
        }

        // GET: AnalysisQuantities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analysisQuantity = await _context.AnalysisQuantity
                .Include(a => a.Analysis)
                .FirstOrDefaultAsync(m => m.AnalysisBaseId == id);
            if (analysisQuantity == null)
            {
                return NotFound();
            }

            return View(analysisQuantity);
        }

        // POST: AnalysisQuantities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var analysisQuantity = await _context.AnalysisQuantity.FindAsync(id);
            _context.AnalysisQuantity.Remove(analysisQuantity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnalysisQuantityExists(int id)
        {
            return _context.AnalysisQuantity.Any(e => e.AnalysisBaseId == id);
        }
    }
}
