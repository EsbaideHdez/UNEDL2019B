using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_taller_esbaide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            apellido.Text = "";
            direccion.Text = "";
            masculino.Checked = true;
            personales.Enabled = false;

            cantidad.Text = "";
            consulta.Checked = true;
            bancarios.Enabled = false;
        }
    }
}
