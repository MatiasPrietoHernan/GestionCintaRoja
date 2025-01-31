using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaDatos.Interfaces
{
    public interface IConsultasRepository
    {
        Task<IEnumerable<Consultas>> SearchByTermAsync(string term);
    }
}
