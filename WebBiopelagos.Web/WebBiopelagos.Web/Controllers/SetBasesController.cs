using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
                .Include(s => s.Trip)
                .Include(s => s.SetBiologicalZooplankton)
                .Include(s => s.SetBiological);

                return View(await bioDaSysContext.ToListAsync());
            }

            else
            {
                var bioDaSysContext = _context.SetBase
                                .Where(s => s.SetBaseId == setBaseId)
                                .Where(s => s.TripId == 6440)
                                .Include(s => s.DayNight)
                                .Include(s => s.Gear)
                                .Include(s => s.Staff)
                                .Include(s => s.Trip)
                                .Include(s => s.SetBiologicalZooplankton)
                                .Include(s => s.SetBiological);

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
                .Include(s => s.SetBiological)
                .Include(s => s.SetBiologicalZooplankton)
                .FirstOrDefaultAsync(m => m.SetBaseId == id);
            if (setBase == null)
            {
                return NotFound();
            }

            return View(setBase);
        }

       
    }
}
