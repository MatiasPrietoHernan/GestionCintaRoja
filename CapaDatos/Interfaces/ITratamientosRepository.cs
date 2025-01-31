using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaDatos.Interfaces
{
    public interface ITratamientosRepository
    {
        Task<IEnumerable<Tratamientos>> SearchByTermAsync(string term);
    }
}
