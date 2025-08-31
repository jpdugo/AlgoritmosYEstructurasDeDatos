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
            if (N != 0)
                N += SumarRecursivo(Math.Abs(N) - 1) * (Math.Abs(N) - Math.Abs(N - 1));
            return N;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(numericUpDown1.Value);
            textBox1.Text = SumarRecursivo(numero).ToString();
        }
    }
}
