using System;

namespace HadwareInventorySystem.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IComponentRepository Components { get; }

        int Save();
    }
}