using HadwareInventorySystem.Core.Models;
using System.Data.Entity;

namespace HadwareInventorySystem.Persistence
{
    public class HardwareInventoryContext : DbContext
    {

        public HardwareInventoryContext() : base("name=HadwareInventoryConnection")
        {

        }

        public DbSet<Component> Component { get; set; }
        public DbSet<ComponentType> ComponentType { get; set; }
    }
}
