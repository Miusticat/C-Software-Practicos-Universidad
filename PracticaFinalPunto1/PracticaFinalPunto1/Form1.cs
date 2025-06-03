using System;
using System.IO;
using System.Windows.Forms;


namespace PracticaFinalPunto1
{
    public partial class lstPedidos : Form
    {
        public lstPedidos()
        {
            InitializeComponent();



        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valorPlato = 0;
            int valorBebida = 0;

            //  Obtener el valor del plato según selección
            if (cmbPlato.SelectedItem != null)
            {
                if (cmbPlato.SelectedItem.ToString().Contains("Desayuno"))
                    valorPlato = 10000;
                else if (cmbPlato.SelectedItem.ToString().Contains("Almuerzo"))
                    valorPlato = 15000;
                else if (cmbPlato.SelectedItem.ToString().Contains("Cena"))
                    valorPlato = 20000;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un plato fuerte.");
                return;
            }

            // Obtener valor de bebida según RadioButton
            if (rbCerveza.Checked)
                valorBebida = 5000;
            else if (rbJugo.Checked)
                valorBebida = 3000;
            else if (rbGaseosa.Checked)
                valorBebida = 2000;
            else
            {
                MessageBox.Show("Por favor seleccione una bebida.");
                return;
            }

            // Calcular subtotal
            double subtotal = valorPlato + valorBebida;

            // Calcular IVA
            double iva = subtotal * 0.19;

            // Calcular propina si aplica
            double propina = chkPropina.Checked ? subtotal * 0.10 : 0;

            // Total
            double total = subtotal + iva + propina;

            // Mostrar total en TextBox
            lblTotal.Text = total.ToString("C0");

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPlato.Items.Add("Desayuno - $10000");
            cmbPlato.Items.Add("Almuerzo - $15000");
            cmbPlato.Items.Add("Cena - $20000");
        }

        private void cmbPlato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar seleccion de ComboBox
            cmbPlato.SelectedIndex = -1;

            // Limpiar selección de RadioButtons
            rbCerveza.Checked = false;
            rbJugo.Checked = false;
            rbGaseosa.Checked = false;

            // Poner la propina como no seleccionada
            chkPropina.Checked = false;

            // Limpiar el total mostrado
            lblTotal.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //  Verificar que el usuario haya seleccionado un plato y una bebida
            if (cmbPlato.SelectedItem == null || (!rbCerveza.Checked && !rbJugo.Checked && !rbGaseosa.Checked))
            {
                MessageBox.Show("Por favor seleccione un plato fuerte y una bebida antes de guardar.");
                return;
            }

            // Obtener datos de la interfaz y almacenarlos en variables
            string plato = cmbPlato.SelectedItem.ToString();
            string bebida = rbCerveza.Checked ? "Cerveza" :
                            rbJugo.Checked ? "Jugo" : "Gaseosa";
            string total = lblTotal.Text;

            // Esto enruta a la carpeta de Documentos del usuario
            string carpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Registros";
            string ruta = carpeta + @"\Pedidos.txt";

            // Crear carpeta "Registros" si no existe
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            try
            {
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine($"{DateTime.Now:dd/MM/yyyy HH:mm} | {plato} | Bebida: {bebida} | Total: {total}");
                }

                MessageBox.Show("Pedido guardado correctamente en Documentos/Registros.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            {
                // Limpia la lista antes de cargar nuevos datos
                listPedidos.Items.Clear();

                // Ruta de la carpeta y archivo en Documentos
                string carpeta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Registros";
                string ruta = carpeta + @"\Pedidos.txt";

                // Verifica si el archivo existe
                if (!File.Exists(ruta))
                {
                    MessageBox.Show("No se encontraron pedidos guardados aún.");
                    return;
                }

                try
                {
                    string[] lineas = File.ReadAllLines(ruta);
                    foreach (string linea in lineas)
                    {
                        listPedidos.Items.Add(linea);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
}
