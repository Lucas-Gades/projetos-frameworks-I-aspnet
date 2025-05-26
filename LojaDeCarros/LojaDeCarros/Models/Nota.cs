namespace LojaDeCarros.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Garantia { get; set; }
        public decimal ValorVenda { get; set; }

        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public int? VendedorId { get; set; }
        public Vendedor? Vendedor { get; set; }

        public int? CarroId { get; set; }
        public Carro? Carro { get; set; }
    }
}
