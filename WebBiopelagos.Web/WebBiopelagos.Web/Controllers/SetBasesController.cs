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
    public class SetBasesController : Controller
    {
        private readonly BioDaSysContext _context;

        public SetBasesController(BioDaSysContext context)
        {
            _context = context;
        }

        // GET: SetBases
        public async Task<IActionResult> Index(int? setBaseId)
        {
            if (setBaseId == null)
            {
                var bioDaSysContext = _context.SetBase
                .Where(s => s.TripId == 6440)
                .Include(s => s.DayNight)
                .Include(s => s.Gear)
                .Include(s => s.Staff)
                .Include(s => s.Trip);

                return View(await bioDaSysContext.ToListAsync());
            }

            else
            {
                var bioDaSysContext = _context.SetBase
                                .Where(s => s.SetBaseId == setBaseId)
                                .Where(s => s.TripId ==6440)
                                .Include(s => s.DayNight)
                                .Include(s => s.Gear)
                                .Include(s => s.Staff)
                                .Include(s => s.Trip);

                return View(await bioDaSysContext.ToListAsync());

            }



        }

        // GET: SetBases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setBase = await _context.SetBase
                .Include(s => s.DayNight)
                .Include(s => s.Gear)
                .Include(s => s.Staff)
                .Include(s => s.Trip)
                .FirstOrDefaultAsync(m => m.SetBaseId == id);
            if (setBase == null)
            {
                return NotFound();
            }

            return View(setBase);
        }

        //// GET: SetBases/Create
        //public IActionResult Create()
        //{
        //    ViewData["DayNightId"] = new SelectList(_context.DayNight, "DayNightId", "DayNightId");
        //    ViewData["GearId"] = new SelectList(_context.Gear, "GearId", "GearId");
        //    ViewData["StaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId");
        //    ViewData["TripId"] = new SelectList(_context.Trip, "TripId", "CountryCodeId");
        //    return View();
        //}

        //// POST: SetBases/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("SetBaseId,TripId,T2LogId,SetNo,SetDateLocal,SetTimeLocal,DayNightId,SchoolAssociationId,Latitude,Longitude,SetEndDateLocal,SetEndTimeLocal,EndLatitude,EndLongitude,BaitList,LatitudeDec,LongitudeDec,GearId,StaffId,EezSubcountryId,EezClosest,LonghurstCode,BetRegionId,SstCelsius,BathyMeters,OniNoaa,Comment,CreationDate,LogIdTubsOld")] SetBase setBase)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(setBase);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["DayNightId"] = new SelectList(_context.DayNight, "DayNightId", "DayNightId", setBase.DayNightId);
        //    ViewData["GearId"] = new SelectList(_context.Gear, "GearId", "GearId", setBase.GearId);
        //    ViewData["StaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", setBase.StaffId);
        //    ViewData["TripId"] = new SelectList(_context.Trip, "TripId", "CountryCodeId", setBase.TripId);
        //    return View(setBase);
        //}

        //// GET: SetBases/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var setBase = await _context.SetBase.FindAsync(id);
        //    if (setBase == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["DayNightId"] = new SelectList(_context.DayNight, "DayNightId", "DayNightId", setBase.DayNightId);
        //    ViewData["GearId"] = new SelectList(_context.Gear, "GearId", "GearId", setBase.GearId);
        //    ViewData["StaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", setBase.StaffId);
        //    ViewData["TripId"] = new SelectList(_context.Trip, "TripId", "CountryCodeId", setBase.TripId);
        //    return View(setBase);
        //}

        //// POST: SetBases/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("SetBaseId,TripId,T2LogId,SetNo,SetDateLocal,SetTimeLocal,DayNightId,SchoolAssociationId,Latitude,Longitude,SetEndDateLocal,SetEndTimeLocal,EndLatitude,EndLongitude,BaitList,LatitudeDec,LongitudeDec,GearId,StaffId,EezSubcountryId,EezClosest,LonghurstCode,BetRegionId,SstCelsius,BathyMeters,OniNoaa,Comment,CreationDate,LogIdTubsOld")] SetBase setBase)
        //{
        //    if (id != setBase.SetBaseId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(setBase);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SetBaseExists(setBase.SetBaseId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["DayNightId"] = new SelectList(_context.DayNight, "DayNightId", "DayNightId", setBase.DayNightId);
        //    ViewData["GearId"] = new SelectList(_context.Gear, "GearId", "GearId", setBase.GearId);
        //    ViewData["StaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", setBase.StaffId);
        //    ViewData["TripId"] = new SelectList(_context.Trip, "TripId", "CountryCodeId", setBase.TripId);
        //    return View(setBase);
        //}

        //// GET: SetBases/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var setBase = await _context.SetBase
        //        .Include(s => s.DayNight)
        //        .Include(s => s.Gear)
        //        .Include(s => s.Staff)
        //        .Include(s => s.Trip)
        //        .FirstOrDefaultAsync(m => m.SetBaseId == id);
        //    if (setBase == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(setBase);
        //}

        //// POST: SetBases/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var setBase = await _context.SetBase.FindAsync(id);
        //    _context.SetBase.Remove(setBase);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool SetBaseExists(int id)
        //{
        //    return _context.SetBase.Any(e => e.SetBaseId == id);
        //}
    }
}
