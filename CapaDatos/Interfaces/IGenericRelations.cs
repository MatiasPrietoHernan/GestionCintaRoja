using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interfaces
{
    public interface IGenericRelations<T> where T: class
    {
        Task<IEnumerable<T>> GetAllRelationsAsync();
    }
}
