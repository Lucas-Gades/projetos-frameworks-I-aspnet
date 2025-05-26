namespace LojaDeCarros.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }

        public ICollection<Nota> Vendas { get; set; } = new List<Nota>();

        public decimal CalcularComissao(decimal valorVenda)
        {
            return valorVenda * 0.05m;
        }
    }

}
