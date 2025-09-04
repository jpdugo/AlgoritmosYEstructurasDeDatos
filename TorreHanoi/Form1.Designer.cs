namespace TorreHanoi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownDiscos = new System.Windows.Forms.NumericUpDown();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblMovimientos = new System.Windows.Forms.Label();
            this.btnMover1a2 = new System.Windows.Forms.Button();
            this.btnMover1a3 = new System.Windows.Forms.Button();
            this.btnMover2a1 = new System.Windows.Forms.Button();
            this.btnMover2a3 = new System.Windows.Forms.Button();
            this.btnMover3a1 = new System.Windows.Forms.Button();
            this.btnMover3a2 = new System.Windows.Forms.Button();
            this.lblTorre1 = new System.Windows.Forms.Label();
            this.lblTorre2 = new System.Windows.Forms.Label();
            this.lblTorre3 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(50, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(300, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 300);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(550, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 300);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // numericUpDownDiscos
            // 
            this.numericUpDownDiscos.Location = new System.Drawing.Point(50, 30);
            this.numericUpDownDiscos.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            this.numericUpDownDiscos.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.numericUpDownDiscos.Name = "numericUpDownDiscos";
            this.numericUpDownDiscos.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDiscos.TabIndex = 3;
            this.numericUpDownDiscos.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Location = new System.Drawing.Point(190, 28);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(100, 27);
            this.btnIniciarJuego.TabIndex = 4;
            this.btnIniciarJuego.Text = "Iniciar Juego";
            this.btnIniciarJuego.UseVisualStyleBackColor = true;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(50, 10);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(120, 15);
            this.lblInstrucciones.TabIndex = 5;
            this.lblInstrucciones.Text = "Número de discos:";
            // 
            // lblMovimientos
            // 
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMovimientos.Location = new System.Drawing.Point(320, 30);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(123, 20);
            this.lblMovimientos.TabIndex = 6;
            this.lblMovimientos.Text = "Movimientos: 0";
            // 
            // btnMover1a2
            // 
            this.btnMover1a2.Location = new System.Drawing.Point(50, 440);
            this.btnMover1a2.Name = "btnMover1a2";
            this.btnMover1a2.Size = new System.Drawing.Size(80, 30);
            this.btnMover1a2.TabIndex = 7;
            this.btnMover1a2.Text = "Torre 1→2";
            this.btnMover1a2.UseVisualStyleBackColor = true;
            this.btnMover1a2.Click += new System.EventHandler(this.btnMover1a2_Click);
            // 
            // btnMover1a3
            // 
            this.btnMover1a3.Location = new System.Drawing.Point(140, 440);
            this.btnMover1a3.Name = "btnMover1a3";
            this.btnMover1a3.Size = new System.Drawing.Size(80, 30);
            this.btnMover1a3.TabIndex = 8;
            this.btnMover1a3.Text = "Torre 1→3";
            this.btnMover1a3.UseVisualStyleBackColor = true;
            this.btnMover1a3.Click += new System.EventHandler(this.btnMover1a3_Click);
            // 
            // btnMover2a1
            // 
            this.btnMover2a1.Location = new System.Drawing.Point(280, 440);
            this.btnMover2a1.Name = "btnMover2a1";
            this.btnMover2a1.Size = new System.Drawing.Size(80, 30);
            this.btnMover2a1.TabIndex = 9;
            this.btnMover2a1.Text = "Torre 2→1";
            this.btnMover2a1.UseVisualStyleBackColor = true;
            this.btnMover2a1.Click += new System.EventHandler(this.btnMover2a1_Click);
            // 
            // btnMover2a3
            // 
            this.btnMover2a3.Location = new System.Drawing.Point(370, 440);
            this.btnMover2a3.Name = "btnMover2a3";
            this.btnMover2a3.Size = new System.Drawing.Size(80, 30);
            this.btnMover2a3.TabIndex = 10;
            this.btnMover2a3.Text = "Torre 2→3";
            this.btnMover2a3.UseVisualStyleBackColor = true;
            this.btnMover2a3.Click += new System.EventHandler(this.btnMover2a3_Click);
            // 
            // btnMover3a1
            // 
            this.btnMover3a1.Location = new System.Drawing.Point(520, 440);
            this.btnMover3a1.Name = "btnMover3a1";
            this.btnMover3a1.Size = new System.Drawing.Size(80, 30);
            this.btnMover3a1.TabIndex = 11;
            this.btnMover3a1.Text = "Torre 3→1";
            this.btnMover3a1.UseVisualStyleBackColor = true;
            this.btnMover3a1.Click += new System.EventHandler(this.btnMover3a1_Click);
            // 
            // btnMover3a2
            // 
            this.btnMover3a2.Location = new System.Drawing.Point(610, 440);
            this.btnMover3a2.Name = "btnMover3a2";
            this.btnMover3a2.Size = new System.Drawing.Size(80, 30);
            this.btnMover3a2.TabIndex = 12;
            this.btnMover3a2.Text = "Torre 3→2";
            this.btnMover3a2.UseVisualStyleBackColor = true;
            this.btnMover3a2.Click += new System.EventHandler(this.btnMover3a2_Click);
            // 
            // lblTorre1
            // 
            this.lblTorre1.AutoSize = true;
            this.lblTorre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTorre1.Location = new System.Drawing.Point(120, 100);
            this.lblTorre1.Name = "lblTorre1";
            this.lblTorre1.Size = new System.Drawing.Size(60, 17);
            this.lblTorre1.TabIndex = 13;
            this.lblTorre1.Text = "Torre 1";
            // 
            // lblTorre2
            // 
            this.lblTorre2.AutoSize = true;
            this.lblTorre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTorre2.Location = new System.Drawing.Point(370, 100);
            this.lblTorre2.Name = "lblTorre2";
            this.lblTorre2.Size = new System.Drawing.Size(60, 17);
            this.lblTorre2.TabIndex = 14;
            this.lblTorre2.Text = "Torre 2";
            // 
            // lblTorre3
            // 
            this.lblTorre3.AutoSize = true;
            this.lblTorre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTorre3.Location = new System.Drawing.Point(620, 100);
            this.lblTorre3.Name = "lblTorre3";
            this.lblTorre3.Size = new System.Drawing.Size(60, 17);
            this.lblTorre3.TabIndex = 15;
            this.lblTorre3.Text = "Torre 3";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(50, 70);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 20);
            this.lblEstado.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTorre3);
            this.Controls.Add(this.lblTorre2);
            this.Controls.Add(this.lblTorre1);
            this.Controls.Add(this.btnMover3a2);
            this.Controls.Add(this.btnMover3a1);
            this.Controls.Add(this.btnMover2a3);
            this.Controls.Add(this.btnMover2a1);
            this.Controls.Add(this.btnMover1a3);
            this.Controls.Add(this.btnMover1a2);
            this.Controls.Add(this.lblMovimientos);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.numericUpDownDiscos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Torre de Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscos;
        private System.Windows.Forms.Button btnIniciarJuego;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblMovimientos;
        private System.Windows.Forms.Button btnMover1a2;
        private System.Windows.Forms.Button btnMover1a3;
        private System.Windows.Forms.Button btnMover2a1;
        private System.Windows.Forms.Button btnMover2a3;
        private System.Windows.Forms.Button btnMover3a1;
        private System.Windows.Forms.Button btnMover3a2;
        private System.Windows.Forms.Label lblTorre1;
        private System.Windows.Forms.Label lblTorre2;
        private System.Windows.Forms.Label lblTorre3;
        private System.Windows.Forms.Label lblEstado;
    }
}
