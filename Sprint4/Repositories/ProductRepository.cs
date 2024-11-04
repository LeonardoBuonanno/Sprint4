using Sprint4.Models;

namespace Sprint4.Repositories
{
    public class ProductRepository
    {
        private readonly List<Product> _produtos = new List<Product>
        {
            new Product { Id = 1, Nome = "Produto 1", Preco = 10.0m },
            new Product { Id = 2, Nome = "Produto 2", Preco = 20.0m }
        };

        public IEnumerable<Product> ObterTodos()
        {
            return _produtos;
        }
    }
}
