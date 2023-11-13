

using Reserva.Domain.Locacoes.Abstractions;

namespace Reserva.Domain.Locacoes
{
    public record Endereco(
        string Bairro,
        string Estado,
        string Cep,
        string Cidade,
        string Rua) : IValueObject;
}
