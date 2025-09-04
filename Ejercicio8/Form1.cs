namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string MayusculaRecursivo(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return "";

            // Procesa el primer carácter y concatena con el resultado recursivo del resto
            char primerCaracter = char.ToUpper(texto[0]);
            return primerCaracter + MayusculaRecursivo(texto.Substring(1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = MayusculaRecursivo(textBox1.Text);
        }
    }
}
