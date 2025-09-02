namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int SumaHasta(int n, int desde)
        {
            if (n > 1)
                desde += SumaHasta(n - 1, desde + 1);
            return desde;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = SumaHasta(
                (int)numericUpDown1.Value, (int)numericUpDown2.Value
            ).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = SumaHasta(
                (int)numericUpDown1.Value, (int)numericUpDown2.Value
            ).ToString();
        }
    }
}
