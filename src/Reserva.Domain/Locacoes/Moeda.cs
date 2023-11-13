using Reserva.Domain.Locacoes.Abstractions;


namespace Reserva.Domain.Locacoes
{
    public record Moeda(decimal Valor, TipoMoeda TipoMoeda) : IValueObject
    {
        public static Moeda operator +(Moeda primeiro, Moeda segundo) 
        {
            if(primeiro.TipoMoeda != segundo.TipoMoeda)
            {
                throw new InvalidOperationException("As moedas têm que ser iguais!");
            }

            return new Moeda(primeiro.Valor + segundo.Valor, primeiro.TipoMoeda);
        }

        public static Moeda Zero() => new(0, TipoMoeda.Nenhum);
    }
}
