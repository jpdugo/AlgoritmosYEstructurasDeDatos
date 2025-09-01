namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> DevolverParesRecursivo(int n, List<int> listaAcumuladora)
        {

            if (n < 0)
                return listaAcumuladora;

            if (n % 2 == 0)
            {
                listaAcumuladora.Add(n);
            }

            return DevolverParesRecursivo(n - 1, listaAcumuladora);
                
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            List<int> list = new List<int>();
            DevolverParesRecursivo(Convert.ToInt32(numericUpDown1.Value), list);

            textBox1.Text = string.Join(",", list);
        }
    }
}
