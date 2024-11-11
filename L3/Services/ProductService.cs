// Services/ProductService.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P04WeatherForecastWPF.Client.Models;

namespace P04WeatherForecastWPF.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new();

        public Task<IEnumerable<Product>> GetAllAsync() => Task.FromResult<IEnumerable<Product>>(_products);

        public Task<Product> GetByIdAsync(int id) => Task.FromResult(_products.FirstOrDefault(p => p.Id == id));

        public Task AddAsync(Product product)
        {
            product.Id = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
            return Task.CompletedTask;
        }
    }
}
