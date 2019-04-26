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
    public class SampleBasesController : Controller
    {
        private readonly BioDaSysContext _context;

        public SampleBasesController(BioDaSysContext context)
        {
            _context = context;
        }

        // GET: SampleBases
        public async Task<IActionResult> Index(int? SampleBaseId, int? FishId)
        {
            if (SampleBaseId == null && FishId == null)
            {
                var bioDaSysContext = _context.SampleBase
                    .Where(f => f.Comment != null && f.Comment.Contains("Wallalis"))
                    .Include(s => s.Fish)
                    .Include(s => s.FreezerLocation)
                    .Include(s => s.InventoryLocation)
                    .Include(s => s.InventoryStaff)
                    .Include(s => s.OwnershipLocation)
                    .Include(s => s.StorageQuality)
                    .Include(s => s.StorageQualityCondition)
                    .Include(s => s.Tissue)
                    .Include(s => s.TissueCondition)
                    .Include(s => s.TissueNavigation)
                    .Include(s => s.TissuePosition)
                    .Include(s => s.TissueType);
                return View(await bioDaSysContext.ToListAsync());
            }

            else if (FishId == null)
            {
                var bioDaSysContext = _context.SampleBase
                    .Where(f => f.Comment != null && f.Comment.Contains("Wallalis"))
                    .Where(f => f.SampleBaseId == SampleBaseId)
                    .Include(s => s.Fish)
                    .Include(s => s.FreezerLocation)
                    .Include(s => s.InventoryLocation)
                    .Include(s => s.InventoryStaff)
                    .Include(s => s.OwnershipLocation)
                    .Include(s => s.StorageQuality)
                    .Include(s => s.StorageQualityCondition)
                    .Include(s => s.Tissue)
                    .Include(s => s.TissueCondition)
                    .Include(s => s.TissueNavigation)
                    .Include(s => s.TissuePosition)
                    .Include(s => s.TissueType);
                return View(await bioDaSysContext.ToListAsync());
            }

            else
            {
                var bioDaSysContext = _context.SampleBase
                   .Where(f => f.Comment != null && f.Comment.Contains("Wallalis"))
                   .Where(f => f.FishId == FishId)
                   .Include(s => s.Fish)
                   .Include(s => s.FreezerLocation)
                   .Include(s => s.InventoryLocation)
                   .Include(s => s.InventoryStaff)
                   .Include(s => s.OwnershipLocation)
                   .Include(s => s.StorageQuality)
                   .Include(s => s.StorageQualityCondition)
                   .Include(s => s.Tissue)
                   .Include(s => s.TissueCondition)
                   .Include(s => s.TissueNavigation)
                   .Include(s => s.TissuePosition)
                   .Include(s => s.TissueType);
                return View(await bioDaSysContext.ToListAsync());

            }

        }

        // GET: SampleBases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sampleBase = await _context.SampleBase

                .Include(s => s.Fish)
                .Include(s => s.FreezerLocation)
                .Include(s => s.InventoryLocation)
                .Include(s => s.InventoryStaff)
                .Include(s => s.OwnershipLocation)
                .Include(s => s.StorageQuality)
                .Include(s => s.StorageQualityCondition)
                .Include(s => s.Tissue)
                .Include(s => s.TissueCondition)
                .Include(s => s.TissueNavigation)
                .Include(s => s.TissuePosition)
                .Include(s => s.TissueType)
                .FirstOrDefaultAsync(m => m.SampleBaseId == id);
            if (sampleBase == null)
            {
                return NotFound();
            }

            return View(sampleBase);
        }

        //// GET: SampleBases/Create
        //public IActionResult Create()
        //{
        //    ViewData["FishId"] = new SelectList(_context.Fish, "FishId", "FishNo");
        //    ViewData["FreezerLocationId"] = new SelectList(_context.FreezerLocation, "FreezerLocationId", "FreezerLocationDesc");
        //    ViewData["InventoryLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId");
        //    ViewData["InventoryStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId");
        //    ViewData["OwnershipLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId");
        //    ViewData["StorageQualityId"] = new SelectList(_context.StorageQuality, "StorageQualityId", "StorageQualityId");
        //    ViewData["StorageQualityId"] = new SelectList(_context.StorageQualityCondition, "StorageQualityId", "StorageQualityId");
        //    ViewData["TissueConditionId"] = new SelectList(_context.ConditionSampleType, "TissueConditionId", "TissueConditionId");
        //    ViewData["TissueConditionId"] = new SelectList(_context.TissueCondition, "TissueConditionId", "TissueConditionId");
        //    ViewData["TissuePositionId"] = new SelectList(_context.PositionSampleType, "TissuePositionId", "TissuePositionId");
        //    ViewData["TissuePositionId"] = new SelectList(_context.TissuePosition, "TissuePositionId", "TissuePositionId");
        //    ViewData["TissueTypeId"] = new SelectList(_context.TissueType, "TissueTypeId", "TissueTypeId");
        //    return View();
        //}

        //// POST: SampleBases/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("SampleBaseId,FishId,SampleNo,OwnershipLocationId,PriceUsd,IsAvailable,IsLost,MissingDate,IsDiscarded,IsPendingAnalysis,IsAnalyzed,TissueTypeId,TissuePositionId,TissueConditionId,StorageQualityId,QualityStaffId,LastLocationId,LocationDate,InventoryLocationId,InventoryDate,InventoryStaffId,FreezerLocationId,LocationDetails,Comment,CreationDate,IsTransfered,InventoryLocationIdOld,TmpId")] SampleBase sampleBase)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(sampleBase);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["FishId"] = new SelectList(_context.Fish, "FishId", "FishNo", sampleBase.FishId);
        //    ViewData["FreezerLocationId"] = new SelectList(_context.FreezerLocation, "FreezerLocationId", "FreezerLocationDesc", sampleBase.FreezerLocationId);
        //    ViewData["InventoryLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId", sampleBase.InventoryLocationId);
        //    ViewData["InventoryStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", sampleBase.InventoryStaffId);
        //    ViewData["OwnershipLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId", sampleBase.OwnershipLocationId);
        //    ViewData["StorageQualityId"] = new SelectList(_context.StorageQuality, "StorageQualityId", "StorageQualityId", sampleBase.StorageQualityId);
        //    ViewData["StorageQualityId"] = new SelectList(_context.StorageQualityCondition, "StorageQualityId", "StorageQualityId", sampleBase.StorageQualityId);
        //    ViewData["TissueConditionId"] = new SelectList(_context.ConditionSampleType, "TissueConditionId", "TissueConditionId", sampleBase.TissueConditionId);
        //    ViewData["TissueConditionId"] = new SelectList(_context.TissueCondition, "TissueConditionId", "TissueConditionId", sampleBase.TissueConditionId);
        //    ViewData["TissuePositionId"] = new SelectList(_context.PositionSampleType, "TissuePositionId", "TissuePositionId", sampleBase.TissuePositionId);
        //    ViewData["TissuePositionId"] = new SelectList(_context.TissuePosition, "TissuePositionId", "TissuePositionId", sampleBase.TissuePositionId);
        //    ViewData["TissueTypeId"] = new SelectList(_context.TissueType, "TissueTypeId", "TissueTypeId", sampleBase.TissueTypeId);
        //    return View(sampleBase);
        //}

        //// GET: SampleBases/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sampleBase = await _context.SampleBase.FindAsync(id);
        //    if (sampleBase == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["FishId"] = new SelectList(_context.Fish, "FishId", "FishNo", sampleBase.FishId);
        //    ViewData["FreezerLocationId"] = new SelectList(_context.FreezerLocation, "FreezerLocationId", "FreezerLocationDesc", sampleBase.FreezerLocationId);
        //    ViewData["InventoryLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId", sampleBase.InventoryLocationId);
        //    ViewData["InventoryStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", sampleBase.InventoryStaffId);
        //    ViewData["OwnershipLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId", sampleBase.OwnershipLocationId);
        //    ViewData["StorageQualityId"] = new SelectList(_context.StorageQuality, "StorageQualityId", "StorageQualityId", sampleBase.StorageQualityId);
        //    ViewData["StorageQualityId"] = new SelectList(_context.StorageQualityCondition, "StorageQualityId", "StorageQualityId", sampleBase.StorageQualityId);
        //    ViewData["TissueConditionId"] = new SelectList(_context.ConditionSampleType, "TissueConditionId", "TissueConditionId", sampleBase.TissueConditionId);
        //    ViewData["TissueConditionId"] = new SelectList(_context.TissueCondition, "TissueConditionId", "TissueConditionId", sampleBase.TissueConditionId);
        //    ViewData["TissuePositionId"] = new SelectList(_context.PositionSampleType, "TissuePositionId", "TissuePositionId", sampleBase.TissuePositionId);
        //    ViewData["TissuePositionId"] = new SelectList(_context.TissuePosition, "TissuePositionId", "TissuePositionId", sampleBase.TissuePositionId);
        //    ViewData["TissueTypeId"] = new SelectList(_context.TissueType, "TissueTypeId", "TissueTypeId", sampleBase.TissueTypeId);
        //    return View(sampleBase);
        //}

        //// POST: SampleBases/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("SampleBaseId,FishId,SampleNo,OwnershipLocationId,PriceUsd,IsAvailable,IsLost,MissingDate,IsDiscarded,IsPendingAnalysis,IsAnalyzed,TissueTypeId,TissuePositionId,TissueConditionId,StorageQualityId,QualityStaffId,LastLocationId,LocationDate,InventoryLocationId,InventoryDate,InventoryStaffId,FreezerLocationId,LocationDetails,Comment,CreationDate,IsTransfered,InventoryLocationIdOld,TmpId")] SampleBase sampleBase)
        //{
        //    if (id != sampleBase.SampleBaseId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(sampleBase);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SampleBaseExists(sampleBase.SampleBaseId))
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
        //    ViewData["FishId"] = new SelectList(_context.Fish, "FishId", "FishNo", sampleBase.FishId);
        //    ViewData["FreezerLocationId"] = new SelectList(_context.FreezerLocation, "FreezerLocationId", "FreezerLocationDesc", sampleBase.FreezerLocationId);
        //    ViewData["InventoryLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId", sampleBase.InventoryLocationId);
        //    ViewData["InventoryStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", sampleBase.InventoryStaffId);
        //    ViewData["OwnershipLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId", sampleBase.OwnershipLocationId);
        //    ViewData["StorageQualityId"] = new SelectList(_context.StorageQuality, "StorageQualityId", "StorageQualityId", sampleBase.StorageQualityId);
        //    ViewData["StorageQualityId"] = new SelectList(_context.StorageQualityCondition, "StorageQualityId", "StorageQualityId", sampleBase.StorageQualityId);
        //    ViewData["TissueConditionId"] = new SelectList(_context.ConditionSampleType, "TissueConditionId", "TissueConditionId", sampleBase.TissueConditionId);
        //    ViewData["TissueConditionId"] = new SelectList(_context.TissueCondition, "TissueConditionId", "TissueConditionId", sampleBase.TissueConditionId);
        //    ViewData["TissuePositionId"] = new SelectList(_context.PositionSampleType, "TissuePositionId", "TissuePositionId", sampleBase.TissuePositionId);
        //    ViewData["TissuePositionId"] = new SelectList(_context.TissuePosition, "TissuePositionId", "TissuePositionId", sampleBase.TissuePositionId);
        //    ViewData["TissueTypeId"] = new SelectList(_context.TissueType, "TissueTypeId", "TissueTypeId", sampleBase.TissueTypeId);
        //    return View(sampleBase);
        //}

        //// GET: SampleBases/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sampleBase = await _context.SampleBase
        //        .Include(s => s.Fish)
        //        .Include(s => s.FreezerLocation)
        //        .Include(s => s.InventoryLocation)
        //        .Include(s => s.InventoryStaff)
        //        .Include(s => s.OwnershipLocation)
        //        .Include(s => s.StorageQuality)
        //        .Include(s => s.StorageQualityCondition)
        //        .Include(s => s.Tissue)
        //        .Include(s => s.TissueCondition)
        //        .Include(s => s.TissueNavigation)
        //        .Include(s => s.TissuePosition)
        //        .Include(s => s.TissueType)
        //        .FirstOrDefaultAsync(m => m.SampleBaseId == id);
        //    if (sampleBase == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sampleBase);
        //}

        //// POST: SampleBases/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var sampleBase = await _context.SampleBase.FindAsync(id);
        //    _context.SampleBase.Remove(sampleBase);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool SampleBaseExists(int id)
        //{
        //    return _context.SampleBase.Any(e => e.SampleBaseId == id);
        //}
    }
}
