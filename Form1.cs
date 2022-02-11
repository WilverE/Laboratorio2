using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            webBrowser1.Navigate(Buscador.Text);
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
    }
}
