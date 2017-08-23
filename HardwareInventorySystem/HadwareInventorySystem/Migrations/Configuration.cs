namespace HadwareInventorySystem.Migrations
{
    using Core.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HadwareInventorySystem.Persistence.HardwareInventoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HadwareInventorySystem.Persistence.HardwareInventoryContext context)
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

            context.Component.AddOrUpdate(
               new Component { Description = "15 Inch LCD Monitor", SerialNumber = "11234A", ComponentType = new ComponentType() { Name = "Monitor" } },
               new Component { Description = "Toshiba Wireless Mouse", SerialNumber = "10934K", ComponentType = new ComponentType() { Name = "Mouse" } },
               new Component { Description = "Dell Keyboard", SerialNumber = "11104C", ComponentType = new ComponentType() { Name = "Keyboard" } },
                new Component { Description = "Hp Zbook", SerialNumber = "1123400J", ComponentType = new ComponentType() { Name = "Laptop" } },
               new Component { Description = "1T Lenovo HDD", SerialNumber = "11234443Y", ComponentType = new ComponentType() { Name = "External Hardrive" } }

             );


        }
    }
}
