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
    public class FishController : Controller
    {
        private readonly BioDaSysContext _context;

        public FishController(BioDaSysContext context)
        {
            _context = context;
        }

        // GET: Fish
        public async Task<IActionResult> Index(int? id)

        {
            if (id == null)
            {

                var bioDaSysContext = _context.Fish
                    .Where(f => f.Comment != null && f.Comment.Contains("Wallalis"))
                    .Include(f => f.EditorStaff)
      .Include(f => f.EditorStaffId2Navigation)
      .Include(f => f.FishType)
      .Include(f => f.LengthCode)
      .Include(f => f.LengthCodeId2Navigation)
      .Include(f => f.LengthCodeId3Navigation)
      .Include(f => f.SetBase)
      .Include(f => f.Sex)
      .Include(f => f.Species)
      .Include(f => f.WeightCode);

                return View(await bioDaSysContext.ToListAsync());
            }

            else
            {
                var bioDaSysContext = _context.Fish
                    .Where(f => f.SetBaseId == id)
                                        .Include(f => f.EditorStaff)
      .Include(f => f.EditorStaffId2Navigation)
      .Include(f => f.FishType)
      .Include(f => f.LengthCode)
      .Include(f => f.LengthCodeId2Navigation)
      .Include(f => f.LengthCodeId3Navigation)
      .Include(f => f.SetBase)
      .Include(f => f.Sex)
      .Include(f => f.Species)
      .Include(f => f.WeightCode);

                return View(await bioDaSysContext.ToListAsync());

            }
        }

            // GET: Fish/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var fish = await _context.Fish
                    .Include(f => f.EditorStaff)
                    .Include(f => f.EditorStaffId2Navigation)
                    .Include(f => f.FishType)
                    .Include(f => f.LengthCode)
                    .Include(f => f.LengthCodeId2Navigation)
                    .Include(f => f.LengthCodeId3Navigation)
                    .Include(f => f.SetBase)
                    .Include(f => f.Sex)
                    .Include(f => f.Species)
                    .Include(f => f.WeightCode)
                    .FirstOrDefaultAsync(m => m.FishId == id);
                if (fish == null)
                {
                    return NotFound();
                }

                return View(fish);
            }

            //// GET: Fish/Create
            //public IActionResult Create()
            //{
            //    ViewData["EditorStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId");
            //    ViewData["EditorStaffId2"] = new SelectList(_context.Staff, "StaffId", "CountryId");
            //    ViewData["FishTypeId"] = new SelectList(_context.FishType, "FishTypeId", "FishTypeId");
            //    ViewData["LengthCodeId"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId");
            //    ViewData["LengthCodeId2"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId");
            //    ViewData["LengthCodeId3"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId");
            //    ViewData["SetBaseId"] = new SelectList(_context.SetBase, "SetBaseId", "GearId");
            //    ViewData["SexId"] = new SelectList(_context.Sex, "SexId", "SexId");
            //    ViewData["SpeciesId"] = new SelectList(_context.Species, "SpeciesId", "ScientificName");
            //    ViewData["WeightCodeId"] = new SelectList(_context.WeightCode, "WeightCodeId", "WeightCodeId");
            //    return View();
            //}

            //// POST: Fish/Create
            //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
            //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public async Task<IActionResult> Create([Bind("FishId,TmpPredatorId,SetBaseId,CsiroId,FishTypeId,SamplingDate,CatchTime,HookNo,ReelNo,DropNo,FishNo,IsOfInterest,OwnershipId,SpeciesId,LengthMm,LengthCodeId,LengthMm2,LengthCodeId2,LengthMm3,LengthCodeId3,CalculatedWtGr,WeightGr,WeightCodeId,GonadWeightGr,SexId,Photo1,Photo2,Photo3,Photo4,DataReceptionDate,PaiementDate,Comment,EnteredByOld,CreationDate,EditorStaffId,EditorStaffId2,Timestamp,TmpId")] Fish fish)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        _context.Add(fish);
            //        await _context.SaveChangesAsync();
            //        return RedirectToAction(nameof(Index));
            //    }
            //    ViewData["EditorStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", fish.EditorStaffId);
            //    ViewData["EditorStaffId2"] = new SelectList(_context.Staff, "StaffId", "CountryId", fish.EditorStaffId2);
            //    ViewData["FishTypeId"] = new SelectList(_context.FishType, "FishTypeId", "FishTypeId", fish.FishTypeId);
            //    ViewData["LengthCodeId"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId", fish.LengthCodeId);
            //    ViewData["LengthCodeId2"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId", fish.LengthCodeId2);
            //    ViewData["LengthCodeId3"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId", fish.LengthCodeId3);
            //    ViewData["SetBaseId"] = new SelectList(_context.SetBase, "SetBaseId", "GearId", fish.SetBaseId);
            //    ViewData["SexId"] = new SelectList(_context.Sex, "SexId", "SexId", fish.SexId);
            //    ViewData["SpeciesId"] = new SelectList(_context.Species, "SpeciesId", "ScientificName", fish.SpeciesId);
            //    ViewData["WeightCodeId"] = new SelectList(_context.WeightCode, "WeightCodeId", "WeightCodeId", fish.WeightCodeId);
            //    return View(fish);
            //}

            //// GET: Fish/Edit/5
            //public async Task<IActionResult> Edit(int? id)
            //{
            //    if (id == null)
            //    {
            //        return NotFound();
            //    }

            //    var fish = await _context.Fish.FindAsync(id);
            //    if (fish == null)
            //    {
            //        return NotFound();
            //    }
            //    ViewData["EditorStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", fish.EditorStaffId);
            //    ViewData["EditorStaffId2"] = new SelectList(_context.Staff, "StaffId", "CountryId", fish.EditorStaffId2);
            //    ViewData["FishTypeId"] = new SelectList(_context.FishType, "FishTypeId", "FishTypeId", fish.FishTypeId);
            //    ViewData["LengthCodeId"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId", fish.LengthCodeId);
            //    ViewData["LengthCodeId2"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId", fish.LengthCodeId2);
            //    ViewData["LengthCodeId3"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId", fish.LengthCodeId3);
            //    ViewData["SetBaseId"] = new SelectList(_context.SetBase, "SetBaseId", "GearId", fish.SetBaseId);
            //    ViewData["SexId"] = new SelectList(_context.Sex, "SexId", "SexId", fish.SexId);
            //    ViewData["SpeciesId"] = new SelectList(_context.Species, "SpeciesId", "ScientificName", fish.SpeciesId);
            //    ViewData["WeightCodeId"] = new SelectList(_context.WeightCode, "WeightCodeId", "WeightCodeId", fish.WeightCodeId);
            //    return View(fish);
            //}

            //// POST: Fish/Edit/5
            //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
            //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public async Task<IActionResult> Edit(int id, [Bind("FishId,TmpPredatorId,SetBaseId,CsiroId,FishTypeId,SamplingDate,CatchTime,HookNo,ReelNo,DropNo,FishNo,IsOfInterest,OwnershipId,SpeciesId,LengthMm,LengthCodeId,LengthMm2,LengthCodeId2,LengthMm3,LengthCodeId3,CalculatedWtGr,WeightGr,WeightCodeId,GonadWeightGr,SexId,Photo1,Photo2,Photo3,Photo4,DataReceptionDate,PaiementDate,Comment,EnteredByOld,CreationDate,EditorStaffId,EditorStaffId2,Timestamp,TmpId")] Fish fish)
            //{
            //    if (id != fish.FishId)
            //    {
            //        return NotFound();
            //    }

            //    if (ModelState.IsValid)
            //    {
            //        try
            //        {
            //            _context.Update(fish);
            //            await _context.SaveChangesAsync();
            //        }
            //        catch (DbUpdateConcurrencyException)
            //        {
            //            if (!FishExists(fish.FishId))
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
            //    ViewData["EditorStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", fish.EditorStaffId);
            //    ViewData["EditorStaffId2"] = new SelectList(_context.Staff, "StaffId", "CountryId", fish.EditorStaffId2);
            //    ViewData["FishTypeId"] = new SelectList(_context.FishType, "FishTypeId", "FishTypeId", fish.FishTypeId);
            //    ViewData["LengthCodeId"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId", fish.LengthCodeId);
            //    ViewData["LengthCodeId2"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId", fish.LengthCodeId2);
            //    ViewData["LengthCodeId3"] = new SelectList(_context.LengthCode, "LengthCodeId", "LengthCodeId", fish.LengthCodeId3);
            //    ViewData["SetBaseId"] = new SelectList(_context.SetBase, "SetBaseId", "GearId", fish.SetBaseId);
            //    ViewData["SexId"] = new SelectList(_context.Sex, "SexId", "SexId", fish.SexId);
            //    ViewData["SpeciesId"] = new SelectList(_context.Species, "SpeciesId", "ScientificName", fish.SpeciesId);
            //    ViewData["WeightCodeId"] = new SelectList(_context.WeightCode, "WeightCodeId", "WeightCodeId", fish.WeightCodeId);
            //    return View(fish);
            //}

            //// GET: Fish/Delete/5
            //public async Task<IActionResult> Delete(int? id)
            //{
            //    if (id == null)
            //    {
            //        return NotFound();
            //    }

            //    var fish = await _context.Fish
            //        .Include(f => f.EditorStaff)
            //        .Include(f => f.EditorStaffId2Navigation)
            //        .Include(f => f.FishType)
            //        .Include(f => f.LengthCode)
            //        .Include(f => f.LengthCodeId2Navigation)
            //        .Include(f => f.LengthCodeId3Navigation)
            //        .Include(f => f.SetBase)
            //        .Include(f => f.Sex)
            //        .Include(f => f.Species)
            //        .Include(f => f.WeightCode)
            //        .FirstOrDefaultAsync(m => m.FishId == id);
            //    if (fish == null)
            //    {
            //        return NotFound();
            //    }

            //    return View(fish);
            //}

            //// POST: Fish/Delete/5
            //[HttpPost, ActionName("Delete")]
            //[ValidateAntiForgeryToken]
            //public async Task<IActionResult> DeleteConfirmed(int id)
            //{
            //    var fish = await _context.Fish.FindAsync(id);
            //    _context.Fish.Remove(fish);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}

            //private bool FishExists(int id)
            //{
            //    return _context.Fish.Any(e => e.FishId == id);
            //}
        }
    }
