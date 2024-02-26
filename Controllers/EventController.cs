using System.Security.Claims;
using EventApp.Entity;
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
        public IActionResult CreateEvent(){
            return View();
        }
        [HttpPost]
        public IActionResult CreateEvent(Event model)
        {
            if(ModelState.IsValid)
            {
                    new Event {
                        EventName = model.EventName,
                        EventLocation = model.EventLocation,
                        EventPrice = model.EventPrice
                    };
                
                return RedirectToAction("Index");
            }
            return View(model);
        }  
    }
}
