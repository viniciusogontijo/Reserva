

namespace Reserva.Domain.Locacoes
{
    public record TipoMoeda
    {
        internal static readonly TipoMoeda Nenhum = new("");
        public static readonly TipoMoeda Brl = new("BRL");
        public static readonly TipoMoeda Usd = new("USD");
        public static readonly TipoMoeda Eur = new("EUR");

        public string Code { get; init; }

        private TipoMoeda(string code) => Code = code;

        public static TipoMoeda BuscarCode(string code)
        {
            return Todos.FirstOrDefault(c => c.Code == code) ??
                throw new ApplicationException("O código da moeda é invalido");
        }

        public static readonly IReadOnlyCollection<TipoMoeda> Todos = new[]
        {
            Brl,
            Usd,
            Eur
        };
    }
}
