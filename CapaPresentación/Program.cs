using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CapaDatos;

namespace CapaPresentación
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// Este método se encarga de inicializar la aplicación.
        private static IServiceProvider ServiceProvider;
        [STAThread]
        static void Main()
        {
            // Aqui vamos a configurar para la inyección de dependencias
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite("Data Source=CintaRoja.sqlite");
            });

            //Registrar servicios
            // RegisterServices(services); Desenmarcar esto cuando se hayan registrado los servicios.

            //Registrar los formularios. Todos los formularios que hagamos se tienen que registrar.
            services.AddTransient<Form1>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            //Aqui se van a registrar los servicios, repositorios y demás.
        }
    }
}