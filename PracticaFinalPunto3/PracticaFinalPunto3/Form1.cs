using System;
using System.Windows.Forms;

namespace PracticaFinalPunto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar los productos en el ListBox lstOrigen
            string[] productos = { "Cerveza", "Frijol", "Gaseosas", "Papas fritas", "Arroz el bueno" };

            for (int i = 0; i < productos.Length; i++)
            {
                lstOrigen.Items.Add(productos[i]);
            }
        }

        private void btnPasarUno_Click(object sender, EventArgs e)
        {
            // Verificar que algo esté seleccionado
            if (lstOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona un producto para pasar.");
                return;
            }

            // Aquí Guardo el producto que fue seleccionado, lo voy a mover al otro ListBox.
            string seleccionado = lstOrigen.SelectedItem.ToString();

            // Este es un nuevo arreglo para guardar los productos que se quedan en el origen.
            // Este arreglo tiene un tamaño menor, porque voy a quitar el producto que se movió
            string[] nuevoOrigen = new string[lstOrigen.Items.Count - 1];
            int j = 0;
            for (int i = 0; i < lstOrigen.Items.Count; i++)
            {
                string item = lstOrigen.Items[i].ToString();
                if (item != seleccionado)
                {
                    nuevoOrigen[j] = item;
                    j++;
                }
            }

            // Aqui otro arreglo con los elementos actuales del destino a un array + el nuevo producto
            string[] nuevoDestino = new string[lstDestino.Items.Count + 1];
            for (int i = 0; i < lstDestino.Items.Count; i++)
            {
                nuevoDestino[i] = lstDestino.Items[i].ToString();
            }
            nuevoDestino[nuevoDestino.Length - 1] = seleccionado;

            // Funciona para limpiar ambos listbox
            lstOrigen.Items.Clear();
            lstDestino.Items.Clear();

            // Por ultimo, un for para llenar el ListBox de origen con el nuevo arreglo
            for (int i = 0; i < nuevoOrigen.Length; i++)
            {
                lstOrigen.Items.Add(nuevoOrigen[i]);
            }

            // Lo mismo de arriba, pero para el destino
            for (int i = 0; i < nuevoDestino.Length; i++)
            {
                lstDestino.Items.Add(nuevoDestino[i]);
            }
        }

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {

            if (lstOrigen.Items.Count == 0)
            {
                MessageBox.Show("No hay productos para mover.");
                return;
            }

            // For para copiar todos los productos que están en el ListBox origen
            string[] productosOrigen = new string[lstOrigen.Items.Count];
            for (int i = 0; i < lstOrigen.Items.Count; i++)
            {
                productosOrigen[i] = lstOrigen.Items[i].ToString();
            }

            // Lo mismo para el destino, pero este ya tiene productos
            string[] productosDestino = new string[lstDestino.Items.Count];
            for (int i = 0; i < lstDestino.Items.Count; i++)
            {
                productosDestino[i] = lstDestino.Items[i].ToString();
            }

            // Arreglo nuevo que contiene todos los productos del origen y del destino
            string[] nuevoDestino = new string[productosOrigen.Length + productosDestino.Length];

            // Es para leer los productos del destino y copiarlos al nuevo arreglo
            for (int i = 0; i < productosDestino.Length; i++)
            {
                nuevoDestino[i] = productosDestino[i];
            }


            int j = productosDestino.Length;
            for (int i = 0; i < productosOrigen.Length; i++)
            {
                nuevoDestino[j] = productosOrigen[i];
                j++;
            }


            lstOrigen.Items.Clear();
            lstDestino.Items.Clear();

            // Solo vuelvo a llenar el destino con todos los productos nuevos
            for (int i = 0; i < nuevoDestino.Length; i++)
            {
                lstDestino.Items.Add(nuevoDestino[i]);
            }


        }

        private void btnRegresarUno_Click(object sender, EventArgs e)
        {

            if (lstDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona un producto para regresar.");
                return;
            }

            // A la inversa del botón anterior, aquí voy a regresar un producto del destino al origen
            string seleccionado = lstDestino.SelectedItem.ToString();


            string[] nuevoDestino = new string[lstDestino.Items.Count - 1];
            int j = 0;
            for (int i = 0; i < lstDestino.Items.Count; i++)
            {
                string item = lstDestino.Items[i].ToString();
                if (item != seleccionado)
                {
                    nuevoDestino[j] = item;
                    j++;
                }
            }


            string[] nuevoOrigen = new string[lstOrigen.Items.Count + 1];
            for (int i = 0; i < lstOrigen.Items.Count; i++)
            {
                nuevoOrigen[i] = lstOrigen.Items[i].ToString();
            }
            nuevoOrigen[nuevoOrigen.Length - 1] = seleccionado;


            lstOrigen.Items.Clear();
            lstDestino.Items.Clear();


            for (int i = 0; i < nuevoOrigen.Length; i++)
            {
                lstOrigen.Items.Add(nuevoOrigen[i]);
            }

            for (int i = 0; i < nuevoDestino.Length; i++)
            {
                lstDestino.Items.Add(nuevoDestino[i]);
            }
        }

        private void btnRegresarTodo_Click(object sender, EventArgs e)
        {

            if (lstDestino.Items.Count == 0)
            {
                MessageBox.Show("No hay productos para regresar.");
                return;
            }

            // A la inversa de nuevo , aquí voy a regresar todos los productos del destino al origen
            string[] productosOrigen = new string[lstOrigen.Items.Count + lstDestino.Items.Count];
            for (int i = 0; i < lstOrigen.Items.Count; i++)
            {
                productosOrigen[i] = lstOrigen.Items[i].ToString();
            }

            // sirve para guardar los productos que están en el destino
            int j = lstOrigen.Items.Count;
            for (int i = 0; i < lstDestino.Items.Count; i++)
            {
                productosOrigen[j] = lstDestino.Items[i].ToString();
                j++;
            }


            lstOrigen.Items.Clear();
            lstDestino.Items.Clear();

            // sirve para llenar el ListBox de origen con todos los productos
            for (int i = 0; i < productosOrigen.Length; i++)
            {
                lstOrigen.Items.Add(productosOrigen[i]);
            }


        }

    }
}
