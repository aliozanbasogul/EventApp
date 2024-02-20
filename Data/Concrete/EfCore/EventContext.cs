using EventApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace EventApp.Data.Concrete.EfCore
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options) : base(options){

        }
        public DbSet<Event> Events => Set<Event>();
        
    }
}