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
using CapaPresentación.SecondWindows.Consultas;
using CapaPresentación.SecondWindows.Diagnosticos;
using CapaPresentación.SecondWindows.GlobalWidows;
using CapaPresentación.Factories;
using CapaPresentación.SecondWindows.Tratamientos;
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
            services.AddTransient<FAgregarConsulta>();
            services.AddTransient<FDiagnosticos>();
            services.AddTransient<FAgregarDiagnostico>();
            services.AddTransient<FTratamientos>();
            services.AddTransient<FAgregarTratamiento>();
            services.AddTransient<FHistorialClinico>();
            services.AddTransient<FFacturacion>();
            services.AddTransient<GlobalPacientes>();
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
            services.AddTransient<IPacienteRepository, PacienteRepository>();
            services.AddTransient<IConsultasRepository, ConsultaRepository>();
            services.AddTransient<IGenericRelations<Diagnosticos>, DiagnosticosRepository>();
            services.AddTransient<ITratamientosRepository, TratamientosRepository>();
            services.AddTransient<IDiagnosticosRepository, DiagnosticosRepository>();
            services.AddTransient<IPagosRepository, PagoRepository>();



            //Aqui van los servicios
            services.AddTransient<IConsultasServices, ConsultasServices>();
            services.AddTransient<IDiagnosticosServices, DiagnosticosServices>();
            services.AddTransient<IHistorialServices, HistorialServices>();
            services.AddTransient<IPacientesServices, PacientesServices>();
            services.AddTransient<IPagosServices, PagosServices>();
            services.AddTransient<ITratamientosServices, TratamientosServices>();

            //Aqui van los factories
            services.AddTransient<GlobalPacientesFactory>();


        }
    }
}