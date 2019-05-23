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
        public async Task<IActionResult> Index(int? AnalysisId)
        {
            if (AnalysisId == null)
            {
                var bioDaSysContext = _context.AnalysisQuantity
                    .Where(a => a.AnalysisBaseId > 111601)
                    .Where(a => a.AnalysisBaseId < 111611)
                    .Include(a => a.AnalysisType)
                    .Include(a => a.Analysis);
                return View(await bioDaSysContext.ToListAsync());

            }

            else 
            {
                var bioDaSysContext = _context.AnalysisQuantity
                    .Where(a => a.AnalysisBaseId == AnalysisId)
                    .Where(a => a.AnalysisBaseId > 111601)
                    .Where(a => a.AnalysisBaseId < 111611)
                    .Include(a => a.AnalysisType)
                    .Include(a => a.Analysis);
                return View(await bioDaSysContext.ToListAsync());

            }
        }

        // GET: AnalysisQuantities/Details/5
        public async Task<IActionResult> Details(int? QuantityId)
        {
            if (QuantityId == null)
            {
                return NotFound();
            }

            var analysisQuantity = await _context.AnalysisQuantity
                .Include(a => a.Analysis)
                .FirstOrDefaultAsync(m => m.AnalysisBaseId == QuantityId);
            if (analysisQuantity == null)
            {
                return NotFound();
            }

            return View(analysisQuantity);
        }
    }
}
