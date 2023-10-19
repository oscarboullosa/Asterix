using System;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Asterix
{
    public partial class Form1 : Form
    {
        public string FilePath { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes realizar acciones cuando el formulario se carga
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Configura el OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos AST (*.ast)|*.ast|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Selecciona un archivo AST";

            // Muestra el diálogo y verifica si el usuario ha seleccionado un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                FilePath = openFileDialog.FileName;

                // Aquí puedes realizar las acciones que desees con el archivo seleccionado
                // En este ejemplo, simplemente mostraremos un mensaje con la ruta del archivo
                MessageBox.Show("Archivo seleccionado: " + FilePath, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void MostrarContenidoEnTextBox(byte[] fileBytes)
        {
            // Convierte los bytes a una cadena y muestra en el TextBox
            string content = Encoding.UTF8.GetString(fileBytes);
            textBox1.Text = content;
        }
    }
}
