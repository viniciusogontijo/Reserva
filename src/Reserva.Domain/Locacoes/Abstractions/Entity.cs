

namespace Reserva.Domain.Locacoes.Abstractions
{
    public abstract class Entity
    {
        public Guid Id { get; init; }
        protected Entity(Guid id) 
        {
            Id = id; 
        }
    }
}
