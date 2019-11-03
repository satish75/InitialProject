using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<UserContext>();
                context.Database.EnsureCreated();
                if(context.registrations !=null && context.registrations.Any())
                    return;

                var register = GetRegistrations().ToArray();
                context.registrations.AddRange(register);
                context.SaveChanges();
            }
        }
        public static List<Registration> GetRegistrations()
        {
            List<Registration> users = new List<Registration>() {
              new Registration { Age=101,Name="Satya"},
               new Registration { Age=102,Name="Raj"},
                new Registration { Age=103,Name="Guru"},
                 new Registration { Age=111,Name="Sagar"}
            };
            return users;
          
        }
    }
}
