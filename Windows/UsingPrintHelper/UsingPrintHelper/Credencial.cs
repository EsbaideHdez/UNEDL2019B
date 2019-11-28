using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingPrintHelper
{
    public partial class Credencial : Form
    {
        public Credencial()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Credencial_Load(object sender, EventArgs e)
        {

        }
        public Credencial(string nombre, String matricula,String grado,String grupo ,String taller)
        {
            InitializeComponent();
            lblCredencial.Text = "Tu credencial es : \n\n\t" + nombre;
            lblCredencial.Text = "\n\n\t" + matricula;
            lblCredencial.Text = "\n\n\t" + grado;
            lblCredencial.Text = "\n\n\t" + grupo;
            lblCredencial.Text = "\n\n\t" + taller;
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
