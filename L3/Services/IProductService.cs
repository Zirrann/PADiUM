// Services/IProductService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using P04WeatherForecastWPF.Client.Models;

namespace P04WeatherForecastWPF.Client.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
