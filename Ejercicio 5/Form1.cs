namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        // Clase para representar un cliente con prioridad
        public class Cliente
        {
            public string Nombre { get; set; }
            public int Prioridad { get; set; }
            public DateTime HoraLlegada { get; set; }

            public Cliente(string nombre, int prioridad)
            {
                Nombre = nombre;
                Prioridad = prioridad;
                HoraLlegada = DateTime.Now;
            }

            public string ObtenerDescripcionPrioridad()
            {
                return Prioridad switch
                {
                    1 => "Alta",
                    2 => "Media",
                    3 => "Baja",
                    _ => "Desconocida"
                };
            }

            public override string ToString()
            {
                return $"{Nombre} - Prioridad {Prioridad} ({ObtenerDescripcionPrioridad()})";
            }
        }

        private List<Cliente> colaConPrioridad;
        private List<Cliente> clientesAtendidos;

        public Form1()
        {
            InitializeComponent();
            
            // Asignar eventos
            btnAgregar.Click += btnAgregar_Click;
            btnAtender.Click += btnAtender_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            
            InicializarAplicacion();
        }

        private void InicializarAplicacion()
        {
            // Inicializar listas
            colaConPrioridad = new List<Cliente>();
            clientesAtendidos = new List<Cliente>();

            // Configurar combo de prioridades
            cmbPrioridad.Items.Clear();
            cmbPrioridad.Items.Add("1 - Alta");
            cmbPrioridad.Items.Add("2 - Media");
            cmbPrioridad.Items.Add("3 - Baja");
            cmbPrioridad.SelectedIndex = 0;

            // Limpiar campos
            txtNombre.Clear();
            txtNombre.Focus();

            ActualizarVisualizacion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }

        private void AgregarCliente()
        {
            // Validar entrada
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre para el cliente.", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (cmbPrioridad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una prioridad.", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPrioridad.Focus();
                return;
            }

            // Crear nuevo cliente
            int prioridad = cmbPrioridad.SelectedIndex + 1; // 0->1, 1->2, 2->3
            var nuevoCliente = new Cliente(txtNombre.Text.Trim(), prioridad);

            // Insertar en la posición correcta según prioridad
            InsertarEnColaConPrioridad(nuevoCliente);

            // Limpiar campos
            txtNombre.Clear();
            txtNombre.Focus();

            // Actualizar visualización
            ActualizarVisualizacion();
        }

        private void InsertarEnColaConPrioridad(Cliente nuevoCliente)
        {
            // Buscar la posición correcta para insertar
            int posicionInsercion = colaConPrioridad.Count;

            for (int i = 0; i < colaConPrioridad.Count; i++)
            {
                // Si el nuevo cliente tiene mayor prioridad (número menor)
                // o igual prioridad pero llegó después, se inserta en esta posición
                if (nuevoCliente.Prioridad < colaConPrioridad[i].Prioridad)
                {
                    posicionInsercion = i;
                    break;
                }
            }

            // Insertar en la posición encontrada
            colaConPrioridad.Insert(posicionInsercion, nuevoCliente);
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            AtenderCliente();
        }

        private void AtenderCliente()
        {
            if (colaConPrioridad.Count == 0)
            {
                MessageBox.Show("No hay clientes en la cola para atender.", 
                               "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Atender al primer cliente de la cola (mayor prioridad)
            var clienteAtendido = colaConPrioridad[0];
            colaConPrioridad.RemoveAt(0);

            // Agregar a la lista de atendidos
            clientesAtendidos.Add(clienteAtendido);

            // Actualizar visualización
            ActualizarVisualizacion();

            // Mostrar mensaje
            MessageBox.Show($"Cliente atendido: {clienteAtendido.Nombre}", 
                           "Cliente Atendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            var resultado = MessageBox.Show("¿Está seguro que desea limpiar todas las colas?", 
                                           "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                colaConPrioridad.Clear();
                clientesAtendidos.Clear();
                ActualizarVisualizacion();
            }
        }

        private void ActualizarVisualizacion()
        {
            // Actualizar lista de cola con prioridad
            lstCola.Items.Clear();
            for (int i = 0; i < colaConPrioridad.Count; i++)
            {
                lstCola.Items.Add($"{i + 1}. {colaConPrioridad[i]}");
            }

            if (colaConPrioridad.Count == 0)
            {
                lstCola.Items.Add("(Cola vacía)");
            }

            // Actualizar lista de clientes atendidos
            lstAtendidos.Items.Clear();
            for (int i = 0; i < clientesAtendidos.Count; i++)
            {
                lstAtendidos.Items.Add($"{i + 1}. {clientesAtendidos[i].Nombre} (Prioridad {clientesAtendidos[i].Prioridad})");
            }

            if (clientesAtendidos.Count == 0)
            {
                lstAtendidos.Items.Add("(Ningún cliente atendido)");
            }

            // Habilitar/deshabilitar botón de atender
            btnAtender.Enabled = colaConPrioridad.Count > 0;
        }
    }
}
