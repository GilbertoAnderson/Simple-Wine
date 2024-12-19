namespace SimpleWine.Models
{
    public class VinhoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Origem { get; set; } = string.Empty;
        public string Variedade { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public int Safra  { get; set; }
        public string? Maturacao { get; set; }
        public string? Graduacaoalcoolica { get; set; }
        public string? Produtor { get; set; }
        public decimal Valor { get; set; }
        public int Promocao { get; set; }

    }
}
