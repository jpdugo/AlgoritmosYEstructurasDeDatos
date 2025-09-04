using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TorreHanoi
{
    public partial class Form1 : Form
    {
        private Stack<int> torre1;
        private Stack<int> torre2;
        private Stack<int> torre3;
        private int numeroDiscos;
        private int movimientos;
        private bool juegoIniciado;

        public Form1()
        {
            InitializeComponent();
            InicializarVariables();
            HabilitarBotones(false);
        }

        private void InicializarVariables()
        {
            torre1 = new Stack<int>();
            torre2 = new Stack<int>();
            torre3 = new Stack<int>();
            movimientos = 0;
            juegoIniciado = false;
            ActualizarLabelMovimientos();
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            numeroDiscos = (int)numericUpDownDiscos.Value;
            InicializarJuego();
        }

        private void InicializarJuego()
        {
            // Limpiar las torres
            torre1.Clear();
            torre2.Clear();
            torre3.Clear();

            // Colocar todos los discos en la torre 1 (del más grande al más pequeño)
            for (int i = numeroDiscos; i >= 1; i--)
            {
                torre1.Push(i);
            }

            movimientos = 0;
            juegoIniciado = true;
            ActualizarLabelMovimientos();
            HabilitarBotones(true);
            lblEstado.Text = "";
            
            // Refrescar la visualización
            RefrescarTorres();
        }

        private void HabilitarBotones(bool habilitar)
        {
            btnMover1a2.Enabled = habilitar;
            btnMover1a3.Enabled = habilitar;
            btnMover2a1.Enabled = habilitar;
            btnMover2a3.Enabled = habilitar;
            btnMover3a1.Enabled = habilitar;
            btnMover3a2.Enabled = habilitar;
        }

        private void ActualizarLabelMovimientos()
        {
            lblMovimientos.Text = $"Movimientos: {movimientos}";
        }

        private bool PuedeMover(Stack<int> origen, Stack<int> destino)
        {
            if (origen.Count == 0) return false;
            if (destino.Count == 0) return true;
            return origen.Peek() < destino.Peek();
        }

        private void MoverDisco(Stack<int> origen, Stack<int> destino)
        {
            if (PuedeMover(origen, destino))
            {
                int disco = origen.Pop();
                destino.Push(disco);
                movimientos++;
                ActualizarLabelMovimientos();
                RefrescarTorres();
                VerificarVictoria();
            }
            else
            {
                MessageBox.Show("Movimiento inválido: No se puede colocar un disco más grande sobre uno más pequeño.", 
                               "Movimiento Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VerificarVictoria()
        {
            if (torre3.Count == numeroDiscos)
            {
                lblEstado.Text = "¡FELICITACIONES! ¡HAS GANADO!";
                lblEstado.ForeColor = Color.Green;
                HabilitarBotones(false);
                MessageBox.Show($"¡Felicitaciones! Has completado el juego en {movimientos} movimientos.", 
                               "¡Victoria!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefrescarTorres()
        {
            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();
        }

        private void DibujarTorre(Graphics g, Stack<int> torre, int panelWidth, int panelHeight)
        {
            if (torre.Count == 0) return;

            var discos = torre.ToArray().Reverse().ToArray();
            int alturaBase = panelHeight - 20;
            int alturaDisco = 25;

            for (int i = 0; i < discos.Length; i++)
            {
                int tamañoDisco = discos[i];
                int anchoDisco = (tamañoDisco * 20) + 40; // Ancho proporcional al tamaño
                int x = (panelWidth - anchoDisco) / 2;
                int y = alturaBase - (i * alturaDisco);

                // Color del disco basado en su tamaño
                Color colorDisco = Color.FromArgb(255, 
                    Math.Min(255, 100 + tamañoDisco * 30),
                    Math.Min(255, 150 + tamañoDisco * 20),
                    Math.Min(255, 200 + tamañoDisco * 10));

                using (Brush brush = new SolidBrush(colorDisco))
                {
                    g.FillRectangle(brush, x, y, anchoDisco, alturaDisco - 2);
                }

                // Borde del disco
                g.DrawRectangle(Pens.Black, x, y, anchoDisco, alturaDisco - 2);

                // Número del disco
                string numero = tamañoDisco.ToString();
                SizeF medidaTexto = g.MeasureString(numero, this.Font);
                float xTexto = x + (anchoDisco - medidaTexto.Width) / 2;
                float yTexto = y + (alturaDisco - medidaTexto.Height) / 2;
                g.DrawString(numero, this.Font, Brushes.Black, xTexto, yTexto);
            }

            // Dibujar la base de la torre
            g.DrawLine(Pens.Black, 10, alturaBase + alturaDisco, panelWidth - 10, alturaBase + alturaDisco);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DibujarTorre(e.Graphics, torre1, panel1.Width, panel1.Height);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DibujarTorre(e.Graphics, torre2, panel2.Width, panel2.Height);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DibujarTorre(e.Graphics, torre3, panel3.Width, panel3.Height);
        }

        // Event handlers para los botones de movimiento
        private void btnMover1a2_Click(object sender, EventArgs e)
        {
            MoverDisco(torre1, torre2);
        }

        private void btnMover1a3_Click(object sender, EventArgs e)
        {
            MoverDisco(torre1, torre3);
        }

        private void btnMover2a1_Click(object sender, EventArgs e)
        {
            MoverDisco(torre2, torre1);
        }

        private void btnMover2a3_Click(object sender, EventArgs e)
        {
            MoverDisco(torre2, torre3);
        }

        private void btnMover3a1_Click(object sender, EventArgs e)
        {
            MoverDisco(torre3, torre1);
        }

        private void btnMover3a2_Click(object sender, EventArgs e)
        {
            MoverDisco(torre3, torre2);
        }
    }
}
