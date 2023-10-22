
using AvatarCollections.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace AvatarCollections.Controllers
{
    public class CollectablesController : Controller
    {
        private readonly AppDbContext _context;

        public CollectablesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allCollectables = await _context.Collectables.Include(n => n.Show).ToListAsync();
            return View(allCollectables);
        }
    }
}
