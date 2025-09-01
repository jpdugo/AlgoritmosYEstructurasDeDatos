using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;

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
            }
            else if (n == 2)
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

        private int FibonacciTerminoN(int N)
        {
            int resultado = 0;
            
            if( N == 1)
            {
                resultado = 0;
            }

            if (N == 2) {
                resultado = 1;
            }

            if (N > 2)
            {
                resultado = FibonacciTerminoN(N - 2) + FibonacciTerminoN(N - 1);
            }

            return resultado;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int eleccion = (int)numericUpDown1.Value;

            List<int> resultado = FibonacciRecursivo(eleccion);

            foreach (int n in resultado)
            {
                listBox1.Items.Add(n.ToString());
            }

            textBox1.Text = FibonacciTerminoN(eleccion).ToString();
        }
    }
}
