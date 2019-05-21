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
    public class SetBiologicalZooplanktonsController : Controller
    {
        private readonly BioDaSysContext _context;

        public SetBiologicalZooplanktonsController(BioDaSysContext context)
        {
            _context = context;
        }

        // GET: SetBiologicalZooplanktons
        public async Task<IActionResult> Index()
        {
            var bioDaSysContext = _context.SetBiologicalZooplankton.Include(s => s.SetBase);
            return View(await bioDaSysContext.ToListAsync());
        }

        // GET: SetBiologicalZooplanktons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setBiologicalZooplankton = await _context.SetBiologicalZooplankton
                .Include(s => s.SetBase)
                .FirstOrDefaultAsync(m => m.SetZooplanktonId == id);
            if (setBiologicalZooplankton == null)
            {
                return NotFound();
            }

            return View(setBiologicalZooplankton);
        }

//        // GET: SetBiologicalZooplanktons/Create
//        public IActionResult Create()
//        {
//            ViewData["SetBaseId"] = new SelectList(_context.SetBase, "SetBaseId", "GearId");
//            return View();
//        }

//        // POST: SetBiologicalZooplanktons/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("SetZooplanktonId,SetBaseId,DepthMinM,DepthMaxM,DepthNo,VolumeFilteredM3,Comment,TmpId")] SetBiologicalZooplankton setBiologicalZooplankton)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(setBiologicalZooplankton);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["SetBaseId"] = new SelectList(_context.SetBase, "SetBaseId", "GearId", setBiologicalZooplankton.SetBaseId);
//            return View(setBiologicalZooplankton);
//        }

//        // GET: SetBiologicalZooplanktons/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var setBiologicalZooplankton = await _context.SetBiologicalZooplankton.FindAsync(id);
//            if (setBiologicalZooplankton == null)
//            {
//                return NotFound();
//            }
//            ViewData["SetBaseId"] = new SelectList(_context.SetBase, "SetBaseId", "GearId", setBiologicalZooplankton.SetBaseId);
//            return View(setBiologicalZooplankton);
//        }

//        // POST: SetBiologicalZooplanktons/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("SetZooplanktonId,SetBaseId,DepthMinM,DepthMaxM,DepthNo,VolumeFilteredM3,Comment,TmpId")] SetBiologicalZooplankton setBiologicalZooplankton)
//        {
//            if (id != setBiologicalZooplankton.SetZooplanktonId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(setBiologicalZooplankton);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!SetBiologicalZooplanktonExists(setBiologicalZooplankton.SetZooplanktonId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["SetBaseId"] = new SelectList(_context.SetBase, "SetBaseId", "GearId", setBiologicalZooplankton.SetBaseId);
//            return View(setBiologicalZooplankton);
//        }

//        // GET: SetBiologicalZooplanktons/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var setBiologicalZooplankton = await _context.SetBiologicalZooplankton
//                .Include(s => s.SetBase)
//                .FirstOrDefaultAsync(m => m.SetZooplanktonId == id);
//            if (setBiologicalZooplankton == null)
//            {
//                return NotFound();
//            }

//            return View(setBiologicalZooplankton);
//        }

//        // POST: SetBiologicalZooplanktons/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var setBiologicalZooplankton = await _context.SetBiologicalZooplankton.FindAsync(id);
//            _context.SetBiologicalZooplankton.Remove(setBiologicalZooplankton);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool SetBiologicalZooplanktonExists(int id)
//        {
//            return _context.SetBiologicalZooplankton.Any(e => e.SetZooplanktonId == id);
//        }
   }
}
