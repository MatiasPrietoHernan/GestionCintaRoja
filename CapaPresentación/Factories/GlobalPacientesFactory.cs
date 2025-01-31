using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPresentación.DTO;
using CapaPresentación.SecondWindows.GlobalWidows;
using Microsoft.Extensions.DependencyInjection;

namespace CapaPresentación.Factories
{
    public class GlobalPacientesFactory
    {
        private readonly IServiceProvider serviceProvider;

        public GlobalPacientesFactory(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
        }

        public GlobalPacientes Crear(ModoFormularioPacientes modo)
        {
            var globalPacientes = serviceProvider.GetRequiredService<GlobalPacientes>();
            globalPacientes.SetModo(modo);
            return globalPacientes;
        }
    }
}
