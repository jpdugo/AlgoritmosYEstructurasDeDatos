namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int ElevarRecursivo(int n, int p)
        {
            if (p > 0)
                n *= ElevarRecursivo(n, p - 1);

            if (p == 0)
                n = 1;

            return n;
        }

        private void LlamarElevarRecursivo()
        {
            int res = ElevarRecursivo(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
            textBox1.Text = res.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LlamarElevarRecursivo();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            LlamarElevarRecursivo();
        }
    }
}
