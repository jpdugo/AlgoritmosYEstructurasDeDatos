namespace Ejercicio_4
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
            lblTitulo = new Label();
            lblColaInicial = new Label();
            lstColaInicial = new ListBox();
            lblColaHombres = new Label();
            lstColaHombres = new ListBox();
            lblColaMujeres = new Label();
            lstColaMujeres = new ListBox();
            btnSepararColas = new Button();
            btnReiniciar = new Button();
            lblDescripcion = new Label();
            SuspendLayout();
            
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(456, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Natatorio - Separación de Colas por Sexo";
            
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F);
            lblDescripcion.Location = new Point(12, 45);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(520, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Cola para revisación médica antes del ingreso a la pileta - Separación por sexos";
            
            // 
            // lblColaInicial
            // 
            lblColaInicial.AutoSize = true;
            lblColaInicial.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblColaInicial.Location = new Point(12, 80);
            lblColaInicial.Name = "lblColaInicial";
            lblColaInicial.Size = new Size(92, 20);
            lblColaInicial.TabIndex = 2;
            lblColaInicial.Text = "Cola Inicial:";
            
            // 
            // lstColaInicial
            // 
            lstColaInicial.FormattingEnabled = true;
            lstColaInicial.ItemHeight = 15;
            lstColaInicial.Location = new Point(12, 103);
            lstColaInicial.Name = "lstColaInicial";
            lstColaInicial.Size = new Size(200, 184);
            lstColaInicial.TabIndex = 3;
            
            // 
            // lblColaHombres
            // 
            lblColaHombres.AutoSize = true;
            lblColaHombres.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblColaHombres.Location = new Point(230, 80);
            lblColaHombres.Name = "lblColaHombres";
            lblColaHombres.Size = new Size(122, 20);
            lblColaHombres.TabIndex = 4;
            lblColaHombres.Text = "Cola Hombres:";
            
            // 
            // lstColaHombres
            // 
            lstColaHombres.FormattingEnabled = true;
            lstColaHombres.ItemHeight = 15;
            lstColaHombres.Location = new Point(230, 103);
            lstColaHombres.Name = "lstColaHombres";
            lstColaHombres.Size = new Size(200, 184);
            lstColaHombres.TabIndex = 5;
            
            // 
            // lblColaMujeres
            // 
            lblColaMujeres.AutoSize = true;
            lblColaMujeres.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblColaMujeres.Location = new Point(448, 80);
            lblColaMujeres.Name = "lblColaMujeres";
            lblColaMujeres.Size = new Size(113, 20);
            lblColaMujeres.TabIndex = 6;
            lblColaMujeres.Text = "Cola Mujeres:";
            
            // 
            // lstColaMujeres
            // 
            lstColaMujeres.FormattingEnabled = true;
            lstColaMujeres.ItemHeight = 15;
            lstColaMujeres.Location = new Point(448, 103);
            lstColaMujeres.Name = "lstColaMujeres";
            lstColaMujeres.Size = new Size(200, 184);
            lstColaMujeres.TabIndex = 7;
            
            // 
            // btnSepararColas
            // 
            btnSepararColas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSepararColas.Location = new Point(12, 305);
            btnSepararColas.Name = "btnSepararColas";
            btnSepararColas.Size = new Size(160, 40);
            btnSepararColas.TabIndex = 8;
            btnSepararColas.Text = "Separar Colas";
            btnSepararColas.UseVisualStyleBackColor = true;
            
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Segoe UI", 10F);
            btnReiniciar.Location = new Point(190, 305);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(100, 40);
            btnReiniciar.TabIndex = 9;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 370);
            Controls.Add(btnReiniciar);
            Controls.Add(btnSepararColas);
            Controls.Add(lstColaMujeres);
            Controls.Add(lblColaMujeres);
            Controls.Add(lstColaHombres);
            Controls.Add(lblColaHombres);
            Controls.Add(lstColaInicial);
            Controls.Add(lblColaInicial);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Ejercicio 4 - Natatorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblColaInicial;
        private ListBox lstColaInicial;
        private Label lblColaHombres;
        private ListBox lstColaHombres;
        private Label lblColaMujeres;
        private ListBox lstColaMujeres;
        private Button btnSepararColas;
        private Button btnReiniciar;
    }
}
