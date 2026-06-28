using ECommerceShowcaseWeb.Models;

namespace ECommerceShowcaseWeb.Services
{
    public class ProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Wireless Headphones", Price = 79.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=400",
                    Description = "Premium wireless headphones with noise cancellation", Category = "Electronics" },
                new Product { Id = 2, Name = "Smart Watch", Price = 199.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=400",
                    Description = "Feature-rich smartwatch with health tracking", Category = "Electronics" },
                new Product { Id = 3, Name = "Laptop Backpack", Price = 49.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=400",
                    Description = "Durable backpack with laptop compartment", Category = "Accessories" },
                new Product { Id = 4, Name = "USB-C Hub", Price = 34.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1625948515291-69613efd103f?w=400",
                    Description = "Multi-port USB-C hub for modern devices", Category = "Electronics" },
                new Product { Id = 5, Name = "Desk Lamp", Price = 29.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1507473885765-e6ed057f782c?w=400",
                    Description = "LED desk lamp with adjustable brightness", Category = "Home" },
                new Product { Id = 6, Name = "Mechanical Keyboard", Price = 89.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1595225476474-87563907a212?w=400",
                    Description = "RGB mechanical keyboard for gaming", Category = "Electronics" }
            };
        }

        public List<Product> GetProducts() => _products;

        public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);
    }
}
