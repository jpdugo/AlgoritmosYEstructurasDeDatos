namespace Ejercicio_5
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
            grpAgregarCliente = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPrioridad = new Label();
            cmbPrioridad = new ComboBox();
            btnAgregar = new Button();
            grpCola = new GroupBox();
            lstCola = new ListBox();
            btnAtender = new Button();
            grpAtendidos = new GroupBox();
            lstAtendidos = new ListBox();
            btnLimpiar = new Button();
            lblInfo = new Label();
            grpAgregarCliente.SuspendLayout();
            grpCola.SuspendLayout();
            grpAtendidos.SuspendLayout();
            SuspendLayout();
            
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cola con Prioridad";
            
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 9F);
            lblInfo.Location = new Point(12, 45);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(481, 15);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Prioridad: 1 = Alta, 2 = Media, 3 = Baja. Los clientes se ubican según su prioridad.";
            
            // 
            // grpAgregarCliente
            // 
            grpAgregarCliente.Controls.Add(lblNombre);
            grpAgregarCliente.Controls.Add(txtNombre);
            grpAgregarCliente.Controls.Add(lblPrioridad);
            grpAgregarCliente.Controls.Add(cmbPrioridad);
            grpAgregarCliente.Controls.Add(btnAgregar);
            grpAgregarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAgregarCliente.Location = new Point(12, 75);
            grpAgregarCliente.Name = "grpAgregarCliente";
            grpAgregarCliente.Size = new Size(250, 140);
            grpAgregarCliente.TabIndex = 2;
            grpAgregarCliente.TabStop = false;
            grpAgregarCliente.Text = "Agregar Cliente";
            
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F);
            lblNombre.Location = new Point(10, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(10, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 1;
            
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Font = new Font("Segoe UI", 9F);
            lblPrioridad.Location = new Point(10, 72);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(61, 15);
            lblPrioridad.TabIndex = 2;
            lblPrioridad.Text = "Prioridad:";
            
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridad.Font = new Font("Segoe UI", 9F);
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Location = new Point(10, 90);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(120, 23);
            cmbPrioridad.TabIndex = 3;
            
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.Location = new Point(150, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(80, 25);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            
            // 
            // grpCola
            // 
            grpCola.Controls.Add(lstCola);
            grpCola.Controls.Add(btnAtender);
            grpCola.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpCola.Location = new Point(280, 75);
            grpCola.Name = "grpCola";
            grpCola.Size = new Size(250, 240);
            grpCola.TabIndex = 3;
            grpCola.TabStop = false;
            grpCola.Text = "Cola de Espera";
            
            // 
            // lstCola
            // 
            lstCola.Font = new Font("Segoe UI", 9F);
            lstCola.FormattingEnabled = true;
            lstCola.ItemHeight = 15;
            lstCola.Location = new Point(10, 25);
            lstCola.Name = "lstCola";
            lstCola.Size = new Size(230, 169);
            lstCola.TabIndex = 0;
            
            // 
            // btnAtender
            // 
            btnAtender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtender.Location = new Point(10, 205);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(100, 25);
            btnAtender.TabIndex = 1;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            
            // 
            // grpAtendidos
            // 
            grpAtendidos.Controls.Add(lstAtendidos);
            grpAtendidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAtendidos.Location = new Point(548, 75);
            grpAtendidos.Name = "grpAtendidos";
            grpAtendidos.Size = new Size(250, 240);
            grpAtendidos.TabIndex = 4;
            grpAtendidos.TabStop = false;
            grpAtendidos.Text = "Clientes Atendidos";
            
            // 
            // lstAtendidos
            // 
            lstAtendidos.Font = new Font("Segoe UI", 9F);
            lstAtendidos.FormattingEnabled = true;
            lstAtendidos.ItemHeight = 15;
            lstAtendidos.Location = new Point(10, 25);
            lstAtendidos.Name = "lstAtendidos";
            lstAtendidos.Size = new Size(230, 199);
            lstAtendidos.TabIndex = 0;
            
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(12, 230);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 340);
            Controls.Add(btnLimpiar);
            Controls.Add(grpAtendidos);
            Controls.Add(grpCola);
            Controls.Add(grpAgregarCliente);
            Controls.Add(lblInfo);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Ejercicio 5 - Cola con Prioridad";
            grpAgregarCliente.ResumeLayout(false);
            grpAgregarCliente.PerformLayout();
            grpCola.ResumeLayout(false);
            grpAtendidos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblInfo;
        private GroupBox grpAgregarCliente;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblPrioridad;
        private ComboBox cmbPrioridad;
        private Button btnAgregar;
        private GroupBox grpCola;
        private ListBox lstCola;
        private Button btnAtender;
        private GroupBox grpAtendidos;
        private ListBox lstAtendidos;
        private Button btnLimpiar;
    }
}
