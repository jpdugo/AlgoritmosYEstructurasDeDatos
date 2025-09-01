namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> DevolverParesRecursivo(int n)
        {

            if (n < 0)
                return new List<int>();

            // es interesante que la lista recien va a existir en el caso base
            var lista = DevolverParesRecursivo(n - 1);
            if (n % 2 == 0)
                lista.Add(n);

            return lista;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Join(
                ",",
                DevolverParesRecursivo(Convert.ToInt32(numericUpDown1.Value))
            );
        }
    }
}
