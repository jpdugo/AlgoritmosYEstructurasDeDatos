namespace Ejercicio_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblColaInicial = new Label();
            lstColaInicial = new ListBox();
            lblElementosRetirados = new Label();
            lstElementosRetirados = new ListBox();
            lblColaFinal = new Label();
            lstColaFinal = new ListBox();
            btnProcesarCola = new Button();
            btnReiniciar = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(422, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Cola - Eliminación de Colados";
            
            // 
            // lblColaInicial
            // 
            lblColaInicial.AutoSize = true;
            lblColaInicial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblColaInicial.Location = new Point(12, 50);
            lblColaInicial.Name = "lblColaInicial";
            lblColaInicial.Size = new Size(84, 19);
            lblColaInicial.TabIndex = 1;
            lblColaInicial.Text = "Cola Inicial:";
            
            // 
            // lstColaInicial
            // 
            lstColaInicial.FormattingEnabled = true;
            lstColaInicial.ItemHeight = 15;
            lstColaInicial.Location = new Point(12, 72);
            lstColaInicial.Name = "lstColaInicial";
            lstColaInicial.Size = new Size(200, 169);
            lstColaInicial.TabIndex = 2;
            
            // 
            // lblElementosRetirados
            // 
            lblElementosRetirados.AutoSize = true;
            lblElementosRetirados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblElementosRetirados.Location = new Point(230, 50);
            lblElementosRetirados.Name = "lblElementosRetirados";
            lblElementosRetirados.Size = new Size(142, 19);
            lblElementosRetirados.TabIndex = 3;
            lblElementosRetirados.Text = "Elementos Retirados:";
            
            // 
            // lstElementosRetirados
            // 
            lstElementosRetirados.FormattingEnabled = true;
            lstElementosRetirados.ItemHeight = 15;
            lstElementosRetirados.Location = new Point(230, 72);
            lstElementosRetirados.Name = "lstElementosRetirados";
            lstElementosRetirados.Size = new Size(200, 169);
            lstElementosRetirados.TabIndex = 4;
            
            // 
            // lblColaFinal
            // 
            lblColaFinal.AutoSize = true;
            lblColaFinal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblColaFinal.Location = new Point(448, 50);
            lblColaFinal.Name = "lblColaFinal";
            lblColaFinal.Size = new Size(78, 19);
            lblColaFinal.TabIndex = 5;
            lblColaFinal.Text = "Cola Final:";
            
            // 
            // lstColaFinal
            // 
            lstColaFinal.FormattingEnabled = true;
            lstColaFinal.ItemHeight = 15;
            lstColaFinal.Location = new Point(448, 72);
            lstColaFinal.Name = "lstColaFinal";
            lstColaFinal.Size = new Size(200, 169);
            lstColaFinal.TabIndex = 6;
            
            // 
            // btnProcesarCola
            // 
            btnProcesarCola.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProcesarCola.Location = new Point(12, 260);
            btnProcesarCola.Name = "btnProcesarCola";
            btnProcesarCola.Size = new Size(150, 35);
            btnProcesarCola.TabIndex = 7;
            btnProcesarCola.Text = "Procesar Cola";
            btnProcesarCola.UseVisualStyleBackColor = true;
            
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Segoe UI", 10F);
            btnReiniciar.Location = new Point(180, 260);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(100, 35);
            btnReiniciar.TabIndex = 8;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 320);
            Controls.Add(btnReiniciar);
            Controls.Add(btnProcesarCola);
            Controls.Add(lstColaFinal);
            Controls.Add(lblColaFinal);
            Controls.Add(lstElementosRetirados);
            Controls.Add(lblElementosRetirados);
            Controls.Add(lstColaInicial);
            Controls.Add(lblColaInicial);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Ejercicio 6 - Gestión de Cola";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblColaInicial;
        private ListBox lstColaInicial;
        private Label lblElementosRetirados;
        private ListBox lstElementosRetirados;
        private Label lblColaFinal;
        private ListBox lstColaFinal;
        private Button btnProcesarCola;
        private Button btnReiniciar;
    }
}
