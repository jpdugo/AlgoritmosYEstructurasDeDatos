using System.Diagnostics.CodeAnalysis;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> FibonacciRecursivo(int n)
        {
            List<int> l;
            if (n == 1)
            {
                l = [];
                l.Add(0);
                l.Add(1);
            }
            else
            {
                l = FibonacciRecursivo(n - 1);
                int suma = l[l.Count - 2] + l[l.Count - 1];
                l.Add(suma);
            }
            return l;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> resultado = FibonacciRecursivo((int)numericUpDown1.Value);

            foreach (int n in resultado)
            {
                listBox1.Items.Add(n.ToString());
            }
        }
    }
}
