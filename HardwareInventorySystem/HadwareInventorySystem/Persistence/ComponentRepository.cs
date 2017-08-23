using HadwareInventorySystem.Core;
using HadwareInventorySystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HadwareInventorySystem.Persistence
{
    public class ComponentRepository : Repository<Component>, IComponentRepository
    {
        public HardwareInventoryContext HardwareInventoryContext
        {
            get { return Context as HardwareInventoryContext; }

        }

        public ComponentRepository(HardwareInventoryContext context) : base(context)
        {

        }
        public IEnumerable<Component> GetAllComponentsWithTypes()
        {
            return HardwareInventoryContext.Component.Include(x => x.ComponentType).ToList();
        }

        public IEnumerable<Component> GetFilteredComponentsWithTypes(string searchString)
        {
            var components = HardwareInventoryContext.Component.Include(x => x.ComponentType).ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                return components.Where(c => c.Description.ToUpper().StartsWith(searchString.ToUpper())
                                        || c.SerialNumber.ToUpper().StartsWith(searchString.ToUpper())
                                        || c.ComponentType.Name.ToUpper().StartsWith(searchString.ToUpper()));
            }
            return null;
        }

    }
}