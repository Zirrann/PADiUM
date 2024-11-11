// ViewModels/MainViewModelV3.cs
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P04WeatherForecastWPF.Client.Models;
using P04WeatherForecastWPF.Client.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P04WeatherForecastWPF.Client.ViewModels
{
    public partial class MainViewModelV3 : ObservableObject, IMainViewModel
    {
        private readonly IProductService _productService;

        [ObservableProperty]
        private ObservableCollection<Product> products;

        [ObservableProperty]
        private Product selectedProduct;

        [ObservableProperty]
        private string name;
        [ObservableProperty]
        private string description;
        [ObservableProperty]
        private decimal price;

        public MainViewModelV3(IProductService productService)
        {
            _productService = productService;
            LoadProductsCommand = new RelayCommand(async () => await LoadProducts());
            AddProductCommand = new RelayCommand(async () => await AddProduct());
            UpdateProductCommand = new RelayCommand(async () => await UpdateProduct());
            DeleteProductCommand = new RelayCommand(async () => await DeleteProduct());
        }

        public ICommand LoadProductsCommand { get; }
        public ICommand AddProductCommand { get; }
        public ICommand UpdateProductCommand { get; }
        public ICommand DeleteProductCommand { get; }

        public async Task LoadProducts()
        {
            var products = await _productService.GetAllAsync();
            Products = new ObservableCollection<Product>(products);
        }

        public async Task AddProduct()
        {
            var newProduct = new Product { Name = Name, Description = Description, Price = Price };
            await _productService.AddAsync(newProduct);
            await LoadProducts();
        }

        public async Task UpdateProduct()
        {
            if (SelectedProduct != null)
            {
                SelectedProduct.Name = Name;
                SelectedProduct.Description = Description;
                SelectedProduct.Price = Price;
                await _productService.UpdateAsync(SelectedProduct);
                await LoadProducts();
            }
        }

        public async Task DeleteProduct()
        {
            if (SelectedProduct != null)
            {
                await _productService.DeleteAsync(SelectedProduct.Id);
                await LoadProducts();
            }
        }
    }
}
