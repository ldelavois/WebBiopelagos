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
    }
}
