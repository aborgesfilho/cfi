using CFI.DB;
using CFI.Models;
using CFI.Interfaces;
using CFI.Repositories;
using CFI.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CFI.Controllers.Interfaces;
using CFI.Controllers;

namespace CFI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Main>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<DbSession>();
                    services.AddScoped<ICategory, Category>();
                    services.AddScoped<IFinancialInstrument, FinancialInstrument>();
                    services.AddScoped<IFinancialInstrumentController, FinancialInstrumentController>();
                    services.AddScoped<IInstrumentOutput, InstrumentOutput>();
                    services.AddScoped<ICategoryController, CategoryController>();
                    services.AddTransient<Main>();
                    services.AddTransient<FormCategories>();
                    services.AddTransient<FormCategorizingProcess>();
                });
        }

    }
}
