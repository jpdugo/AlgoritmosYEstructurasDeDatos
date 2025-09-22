using Microsoft.VisualBasic;
using NodoGenerico;

namespace Ej16ColaSuperMercado
{
    public partial class Form1 : Form
    {
        ColaClientes colaClientes;
        ColaClientes colaClientesAux;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {

            label1.Text = Convert.ToString(colaClientes.PorCobrar());
            label2.Text = Convert.ToString(colaClientes.Largo());

            listBox1.Items.Clear();
            Nodo<Cliente> nodoAux = null;
            while ((nodoAux = colaClientes.Desencolar()) != null)
            {
                listBox1.Items.Add(nodoAux.Contenido.Id);
                colaClientesAux.Encolar(nodoAux);
            }
            while ((nodoAux = colaClientesAux.Desencolar()) != null)
            {
                colaClientes.Encolar(nodoAux);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(
                Interaction.InputBox("Id", "", Convert.ToString(rnd.Next(1, 10)))
            );
            int importe = Convert.ToInt32(
                Interaction.InputBox("Importe", "", Convert.ToString(rnd.Next(1, 10)))
            );

            Nodo<Cliente> nuevoNodo = new Nodo<Cliente>(
                new Cliente() { Id = id, Importe = importe }
            );

            colaClientes.Encolar(nuevoNodo);



            Mostrar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colaClientes = new ColaClientes();
            colaClientesAux = new ColaClientes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nodo<Cliente> desencolado = colaClientes.Desencolar();

            MessageBox.Show(desencolado.Contenido.Id.ToString(), "el nodo desencolado fue: ");

            Mostrar();
        }
    }
}
