﻿using ESX.Teste.Domain.Entities;
using ESX.Teste.Domain.Interfaces;
using ESX.Teste.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace ESX.Teste.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase<TEntity>
    {
        private readonly IRepository<TEntity> _repository;

        public ServiceBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual void Add(TEntity obj)
        {
            _repository.Add(obj);
            _repository.SaveChanges();
        }

        public virtual TEntity GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public virtual void Remove(Guid id)
        {
            _repository.Remove(id);
            _repository.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            _repository.Update(obj);
            _repository.SaveChanges();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
