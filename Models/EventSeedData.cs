using EventApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace EventApp.Models
{
    public static class EventSeedData{
        public static void LoadTestData(IApplicationBuilder app){
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<EventContext>();
            if(context != null){
                if(context.Database.GetPendingMigrations().Any()){
                    context.Database.Migrate();
                }
                if(!context.Events.Any()){
                
                        context.Events.AddRange(
                        new Event{EventName = "Event A", EventLocation = "Ankara", EventPrice = 10, Image = "1.jpg"},
                        new Event{EventName = "Event B", EventLocation = "Istanbul", EventPrice = 20, Image = "2.jpg"},
                        new Event{EventName = "Event C", EventLocation = "Izmir", EventPrice = 30, Image = "3.jpg"}
                    );
                    
                    context.SaveChanges();
                }
                
            }
        }
    }
}