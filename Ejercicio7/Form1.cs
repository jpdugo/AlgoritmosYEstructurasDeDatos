using Microsoft.VisualBasic;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] valores = { "Uno", "Dos", "Tres" };
            listBox1.Items.AddRange(valores);

            string[] valores2 = { "Cuatro", "Cinco", "Seis" };
            listBox2.Items.AddRange(valores2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertar = Interaction.InputBox("Ingrese un valor", "1");
            listBox1.Items.Add(insertar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertar = Interaction.InputBox("Ingrese un valor", "1");
            listBox2.Items.Add(insertar);
        }

        private List<string> Aparear(int indice, List<string> AparearUno, List<string> AparearDos, List<string> acumulador)
        {
            if (indice > 0)
            {
                acumulador = Aparear(indice - 1, AparearUno, AparearDos, acumulador);
                acumulador.Add($"{AparearUno[indice - 1]},{AparearDos[indice - 1]} ");
            }

            return acumulador;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            List<string> lista1 = listBox1.Items.Cast<string>().ToList();
            List<string> lista2 = listBox2.Items.Cast<string>().ToList();

            List<string> resultado = Aparear(lista1.Count, lista1, lista2, new List<string>());

            listBox3.Items.Clear();

            foreach(string a in resultado)
            {
                listBox3.Items.Add(a);
            }
        }
    }
}
