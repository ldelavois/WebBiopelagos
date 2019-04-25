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
    public class AnalysisBasesController : Controller
    {
        private readonly BioDaSysContext _context;

        public AnalysisBasesController(BioDaSysContext context)
        {
            _context = context;
        }

        // GET: AnalysisBases
        public async Task<IActionResult> Index()
        {
            var bioDaSysContext = _context.AnalysisBase.Include(a => a.AnalyserStaff).Include(a => a.AnalyserStaffId2Navigation).Include(a => a.AnalyserStaffId3Navigation).Include(a => a.AnalysisSampleType).Include(a => a.AnalysisType).Include(a => a.LaboratoryLocation).Include(a => a.SampleBase);
            return View(await bioDaSysContext.ToListAsync());
        }

        // GET: AnalysisBases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analysisBase = await _context.AnalysisBase
                .Include(a => a.AnalyserStaff)
                .Include(a => a.AnalyserStaffId2Navigation)
                .Include(a => a.AnalyserStaffId3Navigation)
                .Include(a => a.AnalysisSampleType)
                .Include(a => a.AnalysisType)
                .Include(a => a.LaboratoryLocation)
                .Include(a => a.SampleBase)
                .FirstOrDefaultAsync(m => m.AnalysisBaseId == id);
            if (analysisBase == null)
            {
                return NotFound();
            }

            return View(analysisBase);
        }

        //// GET: AnalysisBases/Create
        //public IActionResult Create()
        //{
        //    ViewData["AnalyserStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId");
        //    ViewData["AnalyserStaffId2"] = new SelectList(_context.Staff, "StaffId", "CountryId");
        //    ViewData["AnalyserStaffId3"] = new SelectList(_context.Staff, "StaffId", "CountryId");
        //    ViewData["AnalysisTypeId"] = new SelectList(_context.AnalysisSampleType, "AnalysisTypeId", "AnalysisTypeId");
        //    ViewData["AnalysisTypeId"] = new SelectList(_context.AnalysisType, "AnalysisTypeId", "AnalysisTypeId");
        //    ViewData["LaboratoryLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId");
        //    ViewData["SampleBaseId"] = new SelectList(_context.SampleBase, "SampleBaseId", "SampleNo");
        //    return View();
        //}

        //// POST: AnalysisBases/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("AnalysisBaseId,SampleBaseId,TissueTypeId,AnalysisTypeId,AnalysisDate,LaboratoryLocationId,LocationDetails,AnalyserStaffId,AnalyserStaffId2,AnalyserStaffId3,Comment,CreationDate,TmpId,AnalyzedByOld,LaboratoryIdOld")] AnalysisBase analysisBase)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(analysisBase);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AnalyserStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", analysisBase.AnalyserStaffId);
        //    ViewData["AnalyserStaffId2"] = new SelectList(_context.Staff, "StaffId", "CountryId", analysisBase.AnalyserStaffId2);
        //    ViewData["AnalyserStaffId3"] = new SelectList(_context.Staff, "StaffId", "CountryId", analysisBase.AnalyserStaffId3);
        //    ViewData["AnalysisTypeId"] = new SelectList(_context.AnalysisSampleType, "AnalysisTypeId", "AnalysisTypeId", analysisBase.AnalysisTypeId);
        //    ViewData["AnalysisTypeId"] = new SelectList(_context.AnalysisType, "AnalysisTypeId", "AnalysisTypeId", analysisBase.AnalysisTypeId);
        //    ViewData["LaboratoryLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId", analysisBase.LaboratoryLocationId);
        //    ViewData["SampleBaseId"] = new SelectList(_context.SampleBase, "SampleBaseId", "SampleNo", analysisBase.SampleBaseId);
        //    return View(analysisBase);
        //}

        //// GET: AnalysisBases/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var analysisBase = await _context.AnalysisBase.FindAsync(id);
        //    if (analysisBase == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["AnalyserStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", analysisBase.AnalyserStaffId);
        //    ViewData["AnalyserStaffId2"] = new SelectList(_context.Staff, "StaffId", "CountryId", analysisBase.AnalyserStaffId2);
        //    ViewData["AnalyserStaffId3"] = new SelectList(_context.Staff, "StaffId", "CountryId", analysisBase.AnalyserStaffId3);
        //    ViewData["AnalysisTypeId"] = new SelectList(_context.AnalysisSampleType, "AnalysisTypeId", "AnalysisTypeId", analysisBase.AnalysisTypeId);
        //    ViewData["AnalysisTypeId"] = new SelectList(_context.AnalysisType, "AnalysisTypeId", "AnalysisTypeId", analysisBase.AnalysisTypeId);
        //    ViewData["LaboratoryLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId", analysisBase.LaboratoryLocationId);
        //    ViewData["SampleBaseId"] = new SelectList(_context.SampleBase, "SampleBaseId", "SampleNo", analysisBase.SampleBaseId);
        //    return View(analysisBase);
        //}

        //// POST: AnalysisBases/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("AnalysisBaseId,SampleBaseId,TissueTypeId,AnalysisTypeId,AnalysisDate,LaboratoryLocationId,LocationDetails,AnalyserStaffId,AnalyserStaffId2,AnalyserStaffId3,Comment,CreationDate,TmpId,AnalyzedByOld,LaboratoryIdOld")] AnalysisBase analysisBase)
        //{
        //    if (id != analysisBase.AnalysisBaseId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(analysisBase);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AnalysisBaseExists(analysisBase.AnalysisBaseId))
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
        //    ViewData["AnalyserStaffId"] = new SelectList(_context.Staff, "StaffId", "CountryId", analysisBase.AnalyserStaffId);
        //    ViewData["AnalyserStaffId2"] = new SelectList(_context.Staff, "StaffId", "CountryId", analysisBase.AnalyserStaffId2);
        //    ViewData["AnalyserStaffId3"] = new SelectList(_context.Staff, "StaffId", "CountryId", analysisBase.AnalyserStaffId3);
        //    ViewData["AnalysisTypeId"] = new SelectList(_context.AnalysisSampleType, "AnalysisTypeId", "AnalysisTypeId", analysisBase.AnalysisTypeId);
        //    ViewData["AnalysisTypeId"] = new SelectList(_context.AnalysisType, "AnalysisTypeId", "AnalysisTypeId", analysisBase.AnalysisTypeId);
        //    ViewData["LaboratoryLocationId"] = new SelectList(_context.Location, "LocationId", "CountryId", analysisBase.LaboratoryLocationId);
        //    ViewData["SampleBaseId"] = new SelectList(_context.SampleBase, "SampleBaseId", "SampleNo", analysisBase.SampleBaseId);
        //    return View(analysisBase);
        //}

        //// GET: AnalysisBases/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var analysisBase = await _context.AnalysisBase
        //        .Include(a => a.AnalyserStaff)
        //        .Include(a => a.AnalyserStaffId2Navigation)
        //        .Include(a => a.AnalyserStaffId3Navigation)
        //        .Include(a => a.AnalysisSampleType)
        //        .Include(a => a.AnalysisType)
        //        .Include(a => a.LaboratoryLocation)
        //        .Include(a => a.SampleBase)
        //        .FirstOrDefaultAsync(m => m.AnalysisBaseId == id);
        //    if (analysisBase == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(analysisBase);
        //}

        //// POST: AnalysisBases/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var analysisBase = await _context.AnalysisBase.FindAsync(id);
        //    _context.AnalysisBase.Remove(analysisBase);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AnalysisBaseExists(int id)
        //{
        //    return _context.AnalysisBase.Any(e => e.AnalysisBaseId == id);
        //}
    }
}
