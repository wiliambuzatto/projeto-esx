using System;

namespace ESX.Teste.Domain.Entities
{
    public class Marca : EntityBase<Marca>
    {
        public string Nome { get; protected set; }
    }
}
