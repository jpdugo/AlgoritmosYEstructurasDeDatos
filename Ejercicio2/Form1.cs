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
            List<int> resultado;
            if (n < 0)
            {
                resultado = [];
            }
            else
            {
                resultado = DevolverParesRecursivo(n - 1);
                if (n % 2 == 0)
                    resultado.Add(n);
            }
            return resultado;
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
