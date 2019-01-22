namespace DependencyInjectionWithCastle.Migrations
{
    using DependencyInjectionWithCastle.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DependencyInjectionWithCastle.Models.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DependencyInjectionWithCastle.Models.MyContext context)
        {
            var gravity = new List<IranGravity>
            {
                new IranGravity { Title = "Ali-Sadr Cave",   Location = "Hamadan City",
                    Description ="is the world's largest water cave " },
                new IranGravity { Title = "Ganj Nameh",   Location = "Hamadan City",
                    Description =" is an ancient inscription, 5 km south-west of Hamedan" },
               new IranGravity { Title = "Eram Garden",   Location = "Shiraz City",
                    Description =" is a historic Persian garden in Shiraz" },
              new IranGravity { Title = "Tomb of Hafez",   Location = "Shiraz City",
                    Description ="in memory of the celebrated Persian poet Hafez" }

            };
            gravity.ForEach(s => context.IranGravity.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();
        }
    }
}
