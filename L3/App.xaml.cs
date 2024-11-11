using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastWPF.Client.Services;
using P04WeatherForecastWPF.Client.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace P04WeatherForecastWPF.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>(); // Add the ProductService
            services.AddSingleton<IMainViewModel, MainViewModelV3>();
            services.AddTransient<MainWindow>();
            services.AddTransient<SecondWindow>();
        }


        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }

}
