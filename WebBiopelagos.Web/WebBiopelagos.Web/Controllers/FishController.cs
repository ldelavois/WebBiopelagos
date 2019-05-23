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
        public async Task<IActionResult> Index(int? setBaseId, int? FishId)

        {
            if (FishId == null && setBaseId == null)
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
      .Include(f => f.WeightCode) ;

                return View(await bioDaSysContext.ToListAsync());
            }

            else if (setBaseId == null)
            {
                var bioDaSysContext = _context.Fish
                    .Where(f => f.FishId == FishId)
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

            else {
                var bioDaSysContext = _context.Fish
                    .Where(f => f.SetBaseId == setBaseId)
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
            public async Task<IActionResult> Details(int? FishId)
            {
                if (FishId == null)
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
                    .FirstOrDefaultAsync(m => m.FishId == FishId);

                if (fish == null)
                {
                    return NotFound();
                }

                return View(fish);
            }
        }
    }
