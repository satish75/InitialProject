using FandooApp.CommonLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FandooApp.RepositoryLayer
{
    public class DummyData
    {
        /// <summary>
        /// Initializes the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<UserContext>();
                context.Database.EnsureCreated();
                if (context.Register != null && context.Register.Any())
                    return;

                var register = GetRegistrations().ToArray();
                context.Register.AddRange(register);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Gets the registrations.
        /// </summary>
        /// <returns></returns>
        public static List<Register> GetRegistrations()
        {
            List<Register> users = new List<Register>() {
              new Register {FirstName="Satya",LastName="Dodake",Mobile="9642472530",Email="satishdodake100@gmail.com",UserName="Satya1",Password="sat1"},
           new Register {FirstName="Satish",LastName="Dodake",Mobile="7030668546",Email="sonapapadi1993@gmail.com",UserName="Satya2",Password="sat2"},
             new Register {FirstName="Raju",LastName="Wagh",Mobile="8552046090",Email="rajuwagh1993@gmail.com",UserName="Satya3",Password="sat3"}
           };
            return users;

        }
    }
}
