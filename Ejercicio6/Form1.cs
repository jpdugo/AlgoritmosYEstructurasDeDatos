namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChequearImpar(int N)
        {
            if (N % 2 != 0)
                throw new ArgumentException("Ingresa un numero par por favor");
        }

        private int SumarParesRecursivo(int n) {

            try
            {
                ChequearImpar(n);
                if (n > 2)
                {
                    n += SumarParesRecursivo(n - 2);
                }
                return n;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No se pueden ingresar numeros impares");
                return -1;
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = SumarParesRecursivo((int)numericUpDown1.Value).ToString();
        }
    }
}
