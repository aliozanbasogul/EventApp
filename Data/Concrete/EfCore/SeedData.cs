using EventApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace EventApp.Data.Concrete.EfCore
{
    public static class SeedData{
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
                if(!context.Users.Any()){
                    context.Users.AddRange(
                        new User{Name = "Ozan" , Surname = "Basogul", Age = 23, Email = "a.ozanbasogul@gmail.com", Password = "123"},
                        new User{Name = "Duru" , Surname = "Basogul", Age = 12, Email = "durubasogul@gmail.com", Password = "123"}
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}