namespace Parcial1
{
    public partial class Form1 : Form
    {
        Lista lista;
        Pila pila;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = new Lista();
            pila = new Pila();
            string[] palos = { "oro", "basto", "espada", "copa" };
            foreach (string palo in palos)
            {
                for (int i = 1; i <= 12; i++)
                {
                    Nodo nodo = new Nodo(palo, i);
                    lista.AgregarUltimo(nodo);
                }
            }


            Lista listaClonada = lista.CloneTipado();

            Nodo nodoAux = null;
            while ((nodoAux = listaClonada.BorrarUltimo()) != null)
            {
                pila.Apilar(nodoAux);
            }

            pila = MostrarPilaRecursivo(new Pila(), new Pila());

            string caca = "caca";

        }

        private Pila MostrarPilaRecursivo(Pila pilaAux, Pila pilaOriginalReconstruida)
        {
            Nodo nodo = pila.Desapilar();
            
            if (nodo != null)
            {
                listBox1.Items.Add($"{nodo.Palo} - {nodo.Numero}");
                MostrarPilaRecursivo(pilaAux, pilaOriginalReconstruida);
                pilaAux.Apilar(nodo);
                Nodo nodoAuxDesapilado = pilaAux.Desapilar();
                pilaOriginalReconstruida.Apilar(nodoAuxDesapilado);
            }
            return pilaOriginalReconstruida;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
