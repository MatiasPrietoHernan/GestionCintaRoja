using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CapaPresentación.Helpers
{
    public static class ValidationHelper
    {
        // Validar campos vacíos
        public static bool AreFieldsNotEmpty(params string[] fields)
        {
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field))
                {
                    return false;
                }
            }
            return true;
        }

        // Validar que los campos numéricos contengan solo números
        public static bool AreFieldsNumeric(params string[] fields)
        {
            foreach (var field in fields)
            {
                if (!long.TryParse(field, out _))
                {
                    return false;
                }
            }
            return true;
        }

        // Validar formato de correo electrónico
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Validar formato de fecha
        public static bool IsValidDate(string date)
        {
            return DateTime.TryParse(date, out _);
        }

        public static bool IsValidDNI(string dni)
        {
            // Verificar que el DNI no sea nulo, vacío o tenga longitud incorrecta
            if (string.IsNullOrWhiteSpace(dni) || dni.Length < 7 || dni.Length > 8)
            {
                return false;
            }

            // Verificar que el DNI contenga solo números
            if (!long.TryParse(dni, out _))
            {
                return false;
            }

            // Verificar que el DNI no comience con 0
            if (dni.StartsWith("0"))
            {
                return false;
            }

            return true;
        }
    }
}
