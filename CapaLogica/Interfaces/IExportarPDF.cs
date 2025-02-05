using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Interfaces
{
    public interface IExportarPDF
    {
        Task ExportarAPdf(string tabla, string rutaArchivo);
    }
}
