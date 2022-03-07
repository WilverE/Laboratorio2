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
        List<Direcciones> direc = new List<Direcciones>();
        public Navegador()
        {
            InitializeComponent();
        }
        private void Save(string fileName, string texto)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var p in direc)
            {
                writer.WriteLine(p.texto, p.veces, p.fecha);
            }
            writer.Close();
        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            int p = direc.FindIndex(t => t.texto == Buscador.Text);
            if (p == -1)
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

                webBrowser1.Navigate(new Uri(bus));
                Buscador.Items.Add(bus);//para ir agregando la busqueda que hemos realizado
                //Buscador.Text = " "; //sirve para eliminar lo que se busco y la barra quede en blanco 
                Direcciones dire = new Direcciones();
                dire.fecha = DateTime.Now;
                dire.veces++;
                dire.texto = Buscador.Text;

                direc.Add(dire);
                Save("H.txt", dire.texto);
            }
            else
            {
                direc[p].veces++;
                direc[p].fecha = DateTime.Now;
            }
            mostrar(); 
        }
        private void mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = direc;
            dataGridView1.Refresh();
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
        
        private void buscarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Navegador_Load(object sender, EventArgs e)
        {

        }
        private void Leer(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Buscador.Items.Add(reader.ReadLine());
            }

            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Leer("H.txt");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            direc = direc.OrderBy(p => p.fecha).ToList();
            mostrar();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string t = TextBox1.Text;
            direc.RemoveAll(p => p.texto == t);

            mostrar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            {
                direc = direc.OrderByDescending(p => p.veces).ToList();
                mostrar();
            }
        }
    }
}
