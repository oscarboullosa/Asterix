using System;
using System.IO;
using System.Windows.Forms;

namespace Asterix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Inicializa la configuración de la aplicación
            ApplicationConfiguration.Initialize();

            // Crea una instancia de Form1
            Form1 form1 = new Form1();

            // Muestra el formulario
            Application.Run(form1);

            // Accede a la propiedad FilePath después de cerrar el formulario
            string filePath = form1.FilePath;

            // Ahora puedes leer el contenido del archivo utilizando filePath
            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    // Leer el contenido del archivo
                    byte[] fileBytes = File.ReadAllBytes(filePath);

                    // Llama al método en Form1 para mostrar el contenido en el TextBox
                    form1.MostrarContenidoEnTextBox(fileBytes);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer el archivo: " + ex.Message);
                }
            }
        }
    }
}
