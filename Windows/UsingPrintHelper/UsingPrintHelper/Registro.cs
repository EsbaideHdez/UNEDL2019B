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
    public partial class Registro : Form
    {
        public Registro(string nombre, string matricula, string grado, string grupo, string taller)
        {
            InitializeComponent();
        }

        public Registro()
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String matricula = txtMatricula.Text;
            String grado = cbxGrado.Text;
            String grupo = txtGrupo.Text;
            String taller = listTaller.Text;


            Registro rt = new Registro(nombre, matricula, grado,grupo,taller);
            rt.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
