using EventApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventApp.Controllers
{
    public class EventController : Controller
    {
        private readonly EventContext _context;

        public EventController(EventContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var events = _context.Events.ToList();
            return View(events);
        }
    }
}
