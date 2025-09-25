using Microsoft.VisualBasic;

namespace Ej1ListaSE
{
    public partial class Form1 : Form
    {
        Lista lista;
        Lista listaAux;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = new Lista();
            listaAux = new Lista();
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }

        private void Mostrar()
        {
            listBox1.Items.Clear();
            Nodo nodoAux = new Nodo();
            listaAux = new Lista();
            while ((nodoAux = lista.BorrarPrimero()) != null)
            {
                listBox1.Items.Add(nodoAux.Descriptor);
                listaAux.AgregarPrimero(nodoAux);
            }
            while ((nodoAux = listaAux.BorrarPrimero()) != null)
            {
                lista.AgregarPrimero(nodoAux);
            }
        }

        private void MostrarBisBis()
        {
            listBox2.Items.Clear();
            Nodo nodoAux = new Nodo();
            listaAux = new Lista();
            while ((nodoAux = lista.BorrarPrimero()) != null)
            {
                listBox2.Items.Add(nodoAux.Descriptor);
                listaAux.AgregarUltimo(nodoAux);
            }
            lista = listaAux;
        }

        // Sin terminar!
        private void MostrarBis()
        {
            listBox2.Items.Clear();
            listaAux = new Lista();
            MostrarRecursivo();
        }

        private void MostrarRecursivo()
        {
            Nodo nodoAux;
            if ((nodoAux = lista.BorrarPrimero()) != null)
            {
                listBox2.Items.Add(nodoAux.Descriptor);
                listaAux.AgregarUltimo(nodoAux);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agregar al final
            string random = rand.Next(101).ToString();
            string descriptor = Interaction.InputBox("Ingresar Descriptor", "", $"ejemplo{random}");
            Nodo nodo = new Nodo(descriptor);
            lista.AgregarUltimo(nodo);
            Mostrar();
            MostrarBisBis();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Agregar al principio

            string descriptor = Interaction.InputBox("Ingresar Descriptor", "", "ejemplo");
            Nodo nodo = new Nodo(descriptor);
            lista.AgregarPrimero(nodo);
            Mostrar();
            MostrarBisBis();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nodo ultimoNodo = lista.BorrarUltimo();
            string mensaje;
            if (ultimoNodo != null)
            {
                mensaje = ultimoNodo.Descriptor;
            }
            else
            {
                mensaje = "No hay elementos en la lista";
            }
            MessageBox.Show(mensaje);
            Mostrar();
            MostrarBisBis();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nodo nodoBorrado = lista.BorrarPrimero();
            string mensaje = nodoBorrado != null ? nodoBorrado.Descriptor : "";
            MessageBox.Show(mensaje);
            Mostrar();
            MostrarBisBis();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string inputDescriptor = Interaction.InputBox("Ingresa el descriptor", "", "ejemplo");
            string inputIndice = Interaction.InputBox("Ingresa el indice", "", "1");
            int resultado;
            bool exito = int.TryParse(inputIndice, out resultado);
            if (exito && resultado >= 1)
            {
                bool pudoInsertar = lista.AgregarEnPosN(new Nodo(inputDescriptor), resultado);
                if (!pudoInsertar)
                {
                    MessageBox.Show("No se pudo insertar el valor");
                }
                else
                {
                    Mostrar();
                    MostrarBisBis();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un entero mayor a 1");
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            int seleccionado = listBox2.SelectedIndex;
            if (seleccionado == -1)
                MessageBox.Show("Debe seleccionar un elemento de la lista primero");

            else if (!lista.IntercambiarDerecha(seleccionado + 1))
            {
                MessageBox.Show("No se puede cambiar el elemento de la derecha en el ultimo indice");
            }

            Mostrar();
            MostrarBisBis();


        }
        private void button7_Click(object sender, EventArgs e)
        {
            int seleccionado = listBox2.SelectedIndex;
            if (seleccionado == -1)
                MessageBox.Show("Debe seleccionar un elemento de la lista primero");
            else if (!lista.IntercambiarIzquierda(seleccionado + 1))
            {
                MessageBox.Show("No se puede cambiar el elemento de la izquierda en el primer indice");
            }

            Mostrar();
            MostrarBisBis();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lista.Cantidad().ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {

            ListBox.SelectedIndexCollection seleccion = listBox2.SelectedIndices;
            if (seleccion.Count > 1)
            {
                bool exito = lista.Swap(seleccion[0] + 1, seleccion[1] + 1);
                if (!exito)
                    MessageBox.Show("no estan dadas las condiciones para hacer el swap");
            }

            Mostrar();
            MostrarBisBis();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string indice = Interaction.InputBox(
                "Ingresa un indice mayor que 0",
                "", rand.Next(lista.Cantidad() + 1).ToString()
             );

            int resultado;
            if (int.TryParse(indice, out resultado))
            {
                Nodo nodoBorrado = lista.BorrarEnPosN(resultado);
            }
            
            Mostrar();
            MostrarBisBis();
        }
    }
}
