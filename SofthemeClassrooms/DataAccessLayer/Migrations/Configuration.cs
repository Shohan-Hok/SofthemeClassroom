namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Roles.AddOrUpdate(
                r => r.Name,
                new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "user"},
                new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "admin" }
            );


            context.ClassRoom.AddOrUpdate(
                c => c.Title,
                new ClassRoom { Title = "Einstein", Capacity = 10, IsBookable = true},
                new ClassRoom { Title = "Tesla", Capacity = 10, IsBookable = true },
                new ClassRoom { Title = "Newton", Capacity = 10, IsBookable = true },
                new ClassRoom { Title = "English", Capacity = 10, IsBookable = true }, 
                new ClassRoom { Title = "HR", Capacity = 10, IsBookable = true}
            );


        }
    }
}
