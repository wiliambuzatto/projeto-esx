using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESX.Teste.Domain.Entities
{
    public abstract class EntityBase<T> where T : EntityBase<T>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; protected set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as EntityBase<T>;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(EntityBase<T> a, EntityBase<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(EntityBase<T> a, EntityBase<T> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() * 907 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id = {Id}]";
        }
    }
}
