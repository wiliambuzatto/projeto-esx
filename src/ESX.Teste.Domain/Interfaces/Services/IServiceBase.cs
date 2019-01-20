using ESX.Teste.Domain.Entities;
using System;
using System.Linq;

namespace ESX.Teste.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : EntityBase<TEntity>
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(Guid id);

        TEntity GetById(Guid id);

        IQueryable<TEntity> GetAll();
    }
}
