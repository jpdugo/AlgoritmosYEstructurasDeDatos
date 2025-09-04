namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        // Clase para representar una persona en la cola
        public class Persona
        {
            public string Nombre { get; set; }
            public bool TieneTicket { get; set; }

            public Persona(string nombre, bool tieneTicket)
            {
                Nombre = nombre;
                TieneTicket = tieneTicket;
            }

            public override string ToString()
            {
                return $"{Nombre} {(TieneTicket ? "(Con ticket)" : "(Sin ticket - Colado)")}";
            }
        }

        private Queue<Persona> colaInicial;
        private List<Persona> elementosRetirados;
        private Queue<Persona> colaFinal;

        public Form1()
        {
            InitializeComponent();
            
            // Asignar eventos
            btnProcesarCola.Click += btnProcesarCola_Click;
            btnReiniciar.Click += btnReiniciar_Click;
            
            InicializarCola();
        }

        private void InicializarCola()
        {
            // Crear cola inicial con personas, algunas con ticket y otras sin ticket (colados)
            colaInicial = new Queue<Persona>();
            elementosRetirados = new List<Persona>();
            colaFinal = new Queue<Persona>();

            // Agregar personas a la cola inicial (ejemplo)
            colaInicial.Enqueue(new Persona("Juan", true));
            colaInicial.Enqueue(new Persona("María", false)); // Colado
            colaInicial.Enqueue(new Persona("Pedro", true));
            colaInicial.Enqueue(new Persona("Ana", false));   // Colado
            colaInicial.Enqueue(new Persona("Luis", true));
            colaInicial.Enqueue(new Persona("Carmen", false)); // Colado
            colaInicial.Enqueue(new Persona("José", true));
            colaInicial.Enqueue(new Persona("Isabel", true));
            colaInicial.Enqueue(new Persona("Roberto", false)); // Colado
            colaInicial.Enqueue(new Persona("Elena", true));

            MostrarColaInicial();
        }

        private void MostrarColaInicial()
        {
            lstColaInicial.Items.Clear();
            
            // Crear una copia de la cola para mostrar sin modificar la original
            var colaTemp = new Queue<Persona>(colaInicial);
            int posicion = 1;
            
            while (colaTemp.Count > 0)
            {
                var persona = colaTemp.Dequeue();
                lstColaInicial.Items.Add($"{posicion}. {persona}");
                posicion++;
            }
        }

        private void btnProcesarCola_Click(object sender, EventArgs e)
        {
            ProcesarCola();
        }

        private void ProcesarCola()
        {
            // Limpiar listas de resultados
            elementosRetirados.Clear();
            lstElementosRetirados.Items.Clear();
            lstColaFinal.Items.Clear();
            
            // Crear nueva cola final
            colaFinal = new Queue<Persona>();

            // Procesar la cola inicial
            var colaTemp = new Queue<Persona>(colaInicial);
            
            while (colaTemp.Count > 0)
            {
                var persona = colaTemp.Dequeue();
                
                if (persona.TieneTicket)
                {
                    // Si tiene ticket, va a la cola final
                    colaFinal.Enqueue(persona);
                }
                else
                {
                    // Si no tiene ticket, es un colado y se retira
                    elementosRetirados.Add(persona);
                }
            }

            MostrarElementosRetirados();
            MostrarColaFinal();
            
            // Deshabilitar el botón después de procesar
            btnProcesarCola.Enabled = false;
        }

        private void MostrarElementosRetirados()
        {
            lstElementosRetirados.Items.Clear();
            
            for (int i = 0; i < elementosRetirados.Count; i++)
            {
                lstElementosRetirados.Items.Add($"{i + 1}. {elementosRetirados[i].Nombre}");
            }

            if (elementosRetirados.Count == 0)
            {
                lstElementosRetirados.Items.Add("No se retiraron elementos");
            }
        }

        private void MostrarColaFinal()
        {
            lstColaFinal.Items.Clear();
            
            // Crear una copia de la cola final para mostrar
            var colaTemp = new Queue<Persona>(colaFinal);
            int posicion = 1;
            
            while (colaTemp.Count > 0)
            {
                var persona = colaTemp.Dequeue();
                lstColaFinal.Items.Add($"{posicion}. {persona.Nombre}");
                posicion++;
            }

            if (colaFinal.Count == 0)
            {
                lstColaFinal.Items.Add("Cola vacía");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las listas
            lstElementosRetirados.Items.Clear();
            lstColaFinal.Items.Clear();
            
            // Reinicializar la cola
            InicializarCola();
            
            // Habilitar el botón de procesar
            btnProcesarCola.Enabled = true;
        }
    }
}
