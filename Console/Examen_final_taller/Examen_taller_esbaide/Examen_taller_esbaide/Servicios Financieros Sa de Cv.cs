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

        private void femenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void edicion_Click(object sender, EventArgs e)
        {
            personales.Enabled = true;
            bancarios.Enabled = true;
            saldo.Enabled = false;
        }

        private void ejecutar_Click(object sender, EventArgs e)
        {
            String[] lineas = { nombre.Text, apellido.Text, Nacimiento.CustomFormat, sexo.Text, cantidad.Text, dateTimePickerEjecucion.CustomFormat, operacion.Text };

            //System.IO.File.WriteAllLines(@"C:\RutaArchivos\EscribeLineas.txt", lineas);

            string path = @"c:\temp\datos.txt";
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            apellido.Text = "";
            direccion.Text = "";
            masculino.Checked = true;

            cantidad.Text = "";
            consulta.Checked = true;
        }
    }
}
