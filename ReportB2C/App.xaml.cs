using Microsoft.Extensions.DependencyInjection;
using ReportB2C.Models;
using ReportB2C.ModelsLocal;
using ReportB2C.Tools;
using ReportB2C.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReportB2C
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddDbContext<NewB2cContext>();
            services.AddSingleton<IBaseTool, BaseTool>();
            services.AddSingleton<IMailTools, MailTools>();
            services.AddSingleton<IApiTools, ApiTools>();
            services.AddSingleton<MainWindowVM>();
            services.AddSingleton<DeliveryRaportVM>();
            services.AddSingleton<EpuVM>();
            services.AddSingleton<EpuMailVM>();
            services.AddSingleton<GeneratorAisocrVM>();
            services.AddSingleton<ISmptClientAccess, SmptClientAccess>();
            services.AddSingleton<ISqliteTools, SqliteTools>();
            services.AddSingleton<IGeneratorAiscTools, GeneratorAiscTools>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
