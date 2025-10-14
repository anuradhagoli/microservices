using ProductService.Models;

namespace ProductService.Repositories
{
    public class ProductRepository
    {
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 899.99M },
            new Product { Id = 2, Name = "Headphones", Price = 199.99M }
        };

        public IEnumerable<Product> GetAll() => Products;

        public Product? GetById(int id) => Products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            product.Id = Products.Max(p => p.Id) + 1;
            Products.Add(product);
        }
    }
}
