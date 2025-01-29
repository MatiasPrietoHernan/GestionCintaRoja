using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CapaDatos;
using CapaPresentación.SecondWindows;
using CapaDatos.Interfaces;
using CapaDatos.Repository;
using CapaDatos.Models;
using CapaLogica.Interfaces;
using CapaLogica.Servicios;
using CapaPresentación.SecondWindows.Pacientes;
namespace CapaPresentación
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// Este método se encarga de inicializar la aplicación.
        public static IServiceProvider ServiceProvider;
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
            RegisterServices(services);

            //Registrar los formularios. Todos los formularios que hagamos se tienen que registrar.
            services.AddTransient<Form1>();
            services.AddTransient<FPacientes>();
            services.AddTransient<FAgregarPaciente>();
            services.AddTransient<FConsultas>();
            services.AddTransient<FDiagnosticos>();
            services.AddTransient<FTratamientos>();
            services.AddTransient<FHistorialClinico>();
            services.AddTransient<FFacturacion>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            //Aqui se van a registrar los servicios, repositorios y demás.
            services.AddTransient<IGenericRepository<Consultas>, GenericRepository<Consultas>>();
            services.AddTransient<IGenericRepository<Diagnosticos>, GenericRepository<Diagnosticos>>();
            services.AddTransient<IGenericRepository<HistorialConsultas>, GenericRepository<HistorialConsultas>>();
            services.AddTransient<IGenericRepository<Pacientes>, GenericRepository<Pacientes>>();
            services.AddTransient<IGenericRepository<Pagos>, GenericRepository<Pagos>>();
            services.AddTransient<IGenericRepository<Tratamientos>, GenericRepository<Tratamientos>>();
            services.AddTransient<IGenericRelations<HistorialConsultas>, HistorialRepository>();
            services.AddTransient<IGenericRelations<Consultas>, ConsultaRepository>();
            services.AddTransient<IGenericRelations<Pagos>, PagoRepository>();
            services.AddTransient<IGenericRelations<Pacientes>, PacienteRepository>();
            services.AddTransient<IGenericRelations<Tratamientos>, TratamientosRepository>();


            //Aqui van los servicios
            services.AddTransient<IConsultasServices, ConsultasServices>();
            services.AddTransient<IDiagnosticosServices, DiagnosticosServices>();
            services.AddTransient<IHistorialServices, HistorialServices>();
            services.AddTransient<IPacientesServices, PacientesServices>();
            services.AddTransient<IPagosServices, PagosServices>();
            services.AddTransient<ITratamientosServices, TratamientosServices>();


        }
    }
}