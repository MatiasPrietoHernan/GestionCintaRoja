using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentación.Helpers
{
    public static class AggStyles
    {
        public static void ApplyPlaceholder(TextBox textBox, string placeholderText)
        {
            // Establecer el texto inicial y el color
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            // Evento para cuando el TextBox gana el foco
            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = ""; // Limpiar el campo
                    textBox.ForeColor = Color.Black; // Cambiar el color del texto
                }
            };

            // Evento para cuando el TextBox pierde el foco
            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText; // Restaurar el placeholder
                    textBox.ForeColor = Color.Gray; // Cambiar el color del texto a gris
                }
            };
        }
    }
}
