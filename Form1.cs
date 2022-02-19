using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Laboratorio2
{
    public partial class Navegador : Form
    {
        public Navegador()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate(Buscador.Text); sirve solo para buscar al precionar el boton
            string bus = " ";
            if (Buscador.Text != null)
                bus = Buscador.Text;
            else if (Buscador.SelectedItem != null)
                bus = Buscador.SelectedItem.ToString();
            if (!bus.Contains("."))
                bus = "https://www.google.com/search?q=" + bus;
            if (!bus.Contains("https://"))
                bus = "https://" + bus;

            Buscador.Items.Add(Buscador.Text);//para ir agregando la busqueda que hemos realizado
            Buscador.Text = " "; //sirve para eliminar lo que se busco y la barra quede en blanco 
            webBrowser1.Navigate(new Uri(bus));
            Save(@"C:\Users\LuisDa GóMo777\Desktop\Mesoamericana\Historial.txt", Buscador.Text);


        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack(); 
        }

        private void Adelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward(); 
        }

        private void Recargar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(); 
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop(); 
        }

        private void Home_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome(); 
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Save(string fileName, string texto)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(texto);
            writer.Close();
        }

        private void buscarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Navegador_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\LuisDa GóMo777\Desktop\Mesoamericana\Historial.txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)

                {
                    historial.AppendText(reader.ReadLine());
                }

                reader.Close();
            }
        }
    }
}
