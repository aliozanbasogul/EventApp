using EventApp.Data.Abstract;
using EventApp.Data.Concrete.EfCore;
using EventApp.Entity;

namespace EventApp.Data.Concrete
{
    public class EfEventRepository : IEventRepository
    {
        private EventContext _context;
        public EfEventRepository(EventContext context){
            _context = context;
        }
        IQueryable<Event> IEventRepository.Events => _context.Events;

        public void CreateEvent(Event evnt){
            _context.Events.Add(evnt);
            _context.SaveChanges();
        }
    }
}