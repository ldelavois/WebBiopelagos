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
        public async Task<IActionResult> Index(int? AnalysisId)
        {
            if (AnalysisId == null)
            {
                var bioDaSysContext = _context.AnalysisBase
                    .Where(f => f.Comment != null && f.Comment.Contains("Wallalis"))
                    .Include(a => a.AnalyserStaff)
                    .Include(a => a.AnalyserStaffId2Navigation)
                    .Include(a => a.AnalyserStaffId3Navigation)
                    .Include(a => a.AnalysisSampleType)
                    .Include(a => a.AnalysisType)
                    .Include(a => a.LaboratoryLocation)
                    .Include(a => a.SampleBase)
                    .Include(a => a.TissueType);
                return View(await bioDaSysContext.ToListAsync());

            }

            else
            {
                var bioDaSysContext = _context.AnalysisBase
                                    .Where (f => f.AnalysisBaseId == AnalysisId)
                                    .Where(f => f.Comment != null && f.Comment.Contains("Wallalis"))
                                    .Include(a => a.AnalyserStaff)
                                    .Include(a => a.AnalyserStaffId2Navigation)
                                    .Include(a => a.AnalyserStaffId3Navigation)
                                    .Include(a => a.AnalysisSampleType)
                                    .Include(a => a.AnalysisType)
                                    .Include(a => a.LaboratoryLocation)
                                    .Include(a => a.SampleBase)
                                    .Include(a => a.TissueType);
                return View(await bioDaSysContext.ToListAsync());

            }
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
                .Include(a => a.TissueType)
                .FirstOrDefaultAsync(m => m.AnalysisBaseId == id);
            if (analysisBase == null)
            {
                return NotFound();
            }

            return View(analysisBase);
        }        
    }
}
