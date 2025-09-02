namespace Ejercicio5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label4 = new Label();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 143);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 21;
            label4.Text = "desde: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 143);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 20;
            label3.Text = "N: ";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(242, 137);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 19;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 178);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 18;
            label2.Text = "Resultado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(669, 75);
            label1.TabIndex = 16;
            label1.Text = resources.GetString("label1.Text");
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(66, 135);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
    }
}
