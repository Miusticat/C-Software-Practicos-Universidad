using System;
using System.Windows.Forms;

namespace PracticaFinalPunto2
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void test_Load(object sender, EventArgs e)
        {
            // Estado civil
            cmbEstadoCivil.Items.Add("Soltero");
            cmbEstadoCivil.Items.Add("Casado");
            cmbEstadoCivil.Items.Add("Unión Libre");
            cmbEstadoCivil.Items.Add("Viudo");
            cmbEstadoCivil.Items.Add("Otros");

            // Bebida
            cmbBebida.Items.Add("Gaseosa");
            cmbBebida.Items.Add("Cerveza");
            cmbBebida.Items.Add("Jugo");
            cmbBebida.Items.Add("Otros");
        }

        private void btnDato1_Click(object sender, EventArgs e)
        {
            bool condiciones = cmbBebida.Text == "Gaseosa" &&
                               rbMayorEdad.Checked &&
                               chkMasculino.Checked &&
                               cmbEstadoCivil.Text == "Soltero";

            if (condiciones)
            {
                MessageBox.Show(" Cumple: Es hombre, mayor de edad, soltero y toma gaseosa.");
            }
            else
            {
                MessageBox.Show("No cumple todas las condiciones: debe ser hombre, mayor de edad, soltero y tomar gaseosa.");
            }
        }



        private void btnDato2_Click(object sender, EventArgs e)
        {
            bool condiciones = cmbBebida.Text == "Cerveza" &&
                               !chkMasculino.Checked &&
                               cmbEstadoCivil.Text == "Casado";

            if (condiciones)
            {
                MessageBox.Show("Cumple: Es mujer, casada y toma cerveza.");
            }
            else
            {
                MessageBox.Show("No cumple todas las condiciones: debe ser mujer, casada y tomar cerveza.");
            }
        }




        private void btnDato3_Click(object sender, EventArgs e)
        {
            bool condiciones = !chkMasculino.Checked &&
                               cmbEstadoCivil.Text == "Casado" &&
                               cmbBebida.Text == "Jugo";

            if (condiciones)
            {
                MessageBox.Show("Cumple: Es mujer, casada y toma jugo.");
            }
            else
            {
                MessageBox.Show("No cumple todas las condiciones: debe ser mujer, casada y tomar jugo.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
