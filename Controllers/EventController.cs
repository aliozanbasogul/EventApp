using EventApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EventApp.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepository _repository;
        public EventController(IEventRepository repository){
            _repository = repository;
        }
        public IActionResult Index(){
            return View(_repository.Events.ToList());
        }
    }
}