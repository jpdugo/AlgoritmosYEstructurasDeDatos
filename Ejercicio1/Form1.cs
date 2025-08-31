namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int SumarRecursivo(int N)
        {
            int resultado = N;
            if (N != 0)
            {
                resultado += SumarRecursivo(Math.Abs(N) - 1) * (Math.Abs(N) - Math.Abs(N - 1));
            }
            if (N == 0)
            {
                resultado = 0;
            }
            return resultado;


            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(numericUpDown1.Value);
            textBox1.Text = SumarRecursivo(numero).ToString();
        }
    }
}
