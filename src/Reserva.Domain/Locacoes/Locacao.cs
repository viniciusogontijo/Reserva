

using Reserva.Domain.Locacoes.Abstractions;

namespace Reserva.Domain.Locacoes
{
    public sealed class Locacao : Entity
    {
        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Descricao Descricao { get; private set; }
        public Endereco Endereco { get; private set; }
        public Moeda Preco { get; private set; }
        public Moeda Limpeza { get; private set; }
        public DateTime? UltimaReservaUtc { get; private set; }
        public IList<Comodidade> Comodidades { get; private set; }

        public Locacao(
            Guid id,
            Nome nome,
            Descricao descricao,
            Endereco endereco,
            Moeda preco,
            Moeda limpeza,
            List<Comodidade> comodidades): base(id)
        {
            Nome = nome;
            Descricao = descricao;
            Endereco = endereco;
            Preco = preco;
            Limpeza = limpeza;
            Comodidades = comodidades;

        }

    }
}
