using System;

namespace ESX.Teste.Domain.Entities
{
    public abstract class BaseEntity<T> where T : BaseEntity<T>
    {
        public Guid Id { get; protected set; }
        public bool Excluido { get; protected set; }
    }
}
