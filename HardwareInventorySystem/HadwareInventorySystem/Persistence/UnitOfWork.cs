
using HadwareInventorySystem.Core;
using HadwareInventorySystem.Persistence;

namespace HadwareInventorySystem.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HardwareInventoryContext _context;

        public UnitOfWork(HardwareInventoryContext context)
        {
            _context = context;
            Components = new ComponentRepository(_context);
            ComponentTypes = new ComponentTypeRepository(_context);
        }
        public IComponentRepository Components
        {
            get;
            private set;
        }
        public IComponentTypeRepository ComponentTypes
        {
            get;
            private set;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }

}