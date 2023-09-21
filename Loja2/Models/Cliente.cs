namespace Loja2.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Vendedor Vendedor { get; set; }
    }

    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Marca Marca { get; set; }
    }

}
