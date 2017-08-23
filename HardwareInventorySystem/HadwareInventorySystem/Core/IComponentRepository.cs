using HadwareInventorySystem.Core.Models;
using System.Collections.Generic;

namespace HadwareInventorySystem.Core
{
    public interface IComponentRepository : IRepository<Component>
    {
        IEnumerable<Component> GetAllComponentsWithTypes();
        IEnumerable<Component> GetFilteredComponentsWithTypes(string searchString);


    }
}