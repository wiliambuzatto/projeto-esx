using System;

namespace ESX.Teste.Domain.Entities
{
    public class Marca : EntityBase<Marca>
    {
        private Marca() { }

        public string Nome { get; set; }
    }
}
