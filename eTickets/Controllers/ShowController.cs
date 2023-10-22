using AvatarCollections.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace AvatarCollections.Controllers
{
    public class ShowController : Controller
    {
        private readonly AppDbContext _context;

        public ShowController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allShows = await _context.Shows.ToListAsync();
            return View(allShows);
        }
    }
}
