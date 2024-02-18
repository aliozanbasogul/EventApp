using EventApp.Entity;

namespace EventApp.Data.Abstract
{
    public interface IEventRepository{
        IQueryable<Event> Events {get;}

        void CreateEvent(Event evnt);
    }
}