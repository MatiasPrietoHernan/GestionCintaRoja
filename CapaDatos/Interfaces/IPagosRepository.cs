using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaDatos.Interfaces
{
    public interface IPagosRepository
    {
        Task<IEnumerable<Pagos>> GetPagosPacientesAsync(int id);
    }
}
