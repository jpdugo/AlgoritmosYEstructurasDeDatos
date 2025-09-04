namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        // Enumeración para representar el sexo
        public enum Sexo
        {
            Hombre,
            Mujer
        }

        // Clase para representar una persona en la cola
        public class Persona
        {
            public string Nombre { get; set; }
            public Sexo Sexo { get; set; }

            public Persona(string nombre, Sexo sexo)
            {
                Nombre = nombre;
                Sexo = sexo;
            }

            public override string ToString()
            {
                return $"{Nombre} ({(Sexo == Sexo.Hombre ? "Hombre" : "Mujer")})";
            }
        }

        private Queue<Persona> colaInicial;
        private Queue<Persona> colaHombres;
        private Queue<Persona> colaMujeres;

        public Form1()
        {
            InitializeComponent();
            
            // Asignar eventos
            btnSepararColas.Click += btnSepararColas_Click;
            btnReiniciar.Click += btnReiniciar_Click;
            
            InicializarCola();
        }

        private void InicializarCola()
        {
            // Crear cola inicial con personas de ambos sexos
            colaInicial = new Queue<Persona>();
            colaHombres = new Queue<Persona>();
            colaMujeres = new Queue<Persona>();

            // Agregar personas a la cola inicial (ejemplo de natatorio)
            colaInicial.Enqueue(new Persona("Carlos", Sexo.Hombre));
            colaInicial.Enqueue(new Persona("María", Sexo.Mujer));
            colaInicial.Enqueue(new Persona("José", Sexo.Hombre));
            colaInicial.Enqueue(new Persona("Ana", Sexo.Mujer));
            colaInicial.Enqueue(new Persona("Miguel", Sexo.Hombre));
            colaInicial.Enqueue(new Persona("Carmen", Sexo.Mujer));
            colaInicial.Enqueue(new Persona("Roberto", Sexo.Hombre));
            colaInicial.Enqueue(new Persona("Isabel", Sexo.Mujer));
            colaInicial.Enqueue(new Persona("Fernando", Sexo.Hombre));
            colaInicial.Enqueue(new Persona("Elena", Sexo.Mujer));
            colaInicial.Enqueue(new Persona("Diego", Sexo.Hombre));
            colaInicial.Enqueue(new Persona("Lucía", Sexo.Mujer));

            MostrarColaInicial();
            LimpiarColasGeneradas();
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

        private void LimpiarColasGeneradas()
        {
            lstColaHombres.Items.Clear();
            lstColaMujeres.Items.Clear();
            
            lstColaHombres.Items.Add("(Presione 'Separar Colas' para generar)");
            lstColaMujeres.Items.Add("(Presione 'Separar Colas' para generar)");
        }

        private void btnSepararColas_Click(object sender, EventArgs e)
        {
            SepararColasPorSexo();
        }

        private void SepararColasPorSexo()
        {
            // Limpiar las colas generadas
            colaHombres.Clear();
            colaMujeres.Clear();
            lstColaHombres.Items.Clear();
            lstColaMujeres.Items.Clear();

            // Crear una copia de la cola inicial para procesar
            var colaTemp = new Queue<Persona>(colaInicial);
            
            // Separar por sexo manteniendo el orden original
            while (colaTemp.Count > 0)
            {
                var persona = colaTemp.Dequeue();
                
                if (persona.Sexo == Sexo.Hombre)
                {
                    colaHombres.Enqueue(persona);
                }
                else
                {
                    colaMujeres.Enqueue(persona);
                }
            }

            MostrarColaHombres();
            MostrarColaMujeres();
            
            // Deshabilitar el botón después de separar
            btnSepararColas.Enabled = false;
        }

        private void MostrarColaHombres()
        {
            lstColaHombres.Items.Clear();
            
            // Crear una copia de la cola de hombres para mostrar
            var colaTemp = new Queue<Persona>(colaHombres);
            int posicion = 1;
            
            while (colaTemp.Count > 0)
            {
                var persona = colaTemp.Dequeue();
                lstColaHombres.Items.Add($"{posicion}. {persona.Nombre}");
                posicion++;
            }

            if (colaHombres.Count == 0)
            {
                lstColaHombres.Items.Add("(Sin hombres en cola)");
            }
        }

        private void MostrarColaMujeres()
        {
            lstColaMujeres.Items.Clear();
            
            // Crear una copia de la cola de mujeres para mostrar
            var colaTemp = new Queue<Persona>(colaMujeres);
            int posicion = 1;
            
            while (colaTemp.Count > 0)
            {
                var persona = colaTemp.Dequeue();
                lstColaMujeres.Items.Add($"{posicion}. {persona.Nombre}");
                posicion++;
            }

            if (colaMujeres.Count == 0)
            {
                lstColaMujeres.Items.Add("(Sin mujeres en cola)");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Reinicializar todo
            InicializarCola();
            
            // Habilitar el botón de separar
            btnSepararColas.Enabled = true;
        }
    }
}
