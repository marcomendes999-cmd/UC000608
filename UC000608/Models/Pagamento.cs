namespace UC000608.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Decimal Valor { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

    }
}
