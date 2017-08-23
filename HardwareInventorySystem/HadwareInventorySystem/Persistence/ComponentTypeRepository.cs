using HadwareInventorySystem.Core;
using HadwareInventorySystem.Core.Models;

namespace HadwareInventorySystem.Persistence
{
    public class ComponentTypeRepository : Repository<ComponentType>, IComponentTypeRepository
    {
        public ComponentTypeRepository(HardwareInventoryContext context) : base(context)
        {

        }
    }
}