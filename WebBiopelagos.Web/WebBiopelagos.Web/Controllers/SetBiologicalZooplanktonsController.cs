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
   }
}
