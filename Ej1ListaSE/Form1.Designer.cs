namespace Ej1ListaSE
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            listBox1 = new ListBox();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            button10 = new Button();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(171, 29);
            button1.TabIndex = 0;
            button1.Text = "Agregar Al Final";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 45);
            button2.Name = "button2";
            button2.Size = new Size(171, 29);
            button2.TabIndex = 1;
            button2.Text = "Agregar Al principio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 93);
            button3.Name = "button3";
            button3.Size = new Size(171, 29);
            button3.TabIndex = 2;
            button3.Text = "Borrar al Final";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 147);
            button4.Name = "button4";
            button4.Size = new Size(171, 29);
            button4.TabIndex = 3;
            button4.Text = "Borrar al Principio";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(0, 203);
            button5.Name = "button5";
            button5.Size = new Size(171, 29);
            button5.TabIndex = 4;
            button5.Text = "Agregar en Pos N";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(2, 347);
            button6.Name = "button6";
            button6.Size = new Size(171, 29);
            button6.TabIndex = 5;
            button6.Text = "intercambiar derecha";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(2, 399);
            button7.Name = "button7";
            button7.Size = new Size(171, 29);
            button7.TabIndex = 6;
            button7.Text = "intercambiar izquierda";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(456, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(131, 384);
            listBox1.TabIndex = 7;
            // 
            // button8
            // 
            button8.Location = new Point(195, 147);
            button8.Name = "button8";
            button8.Size = new Size(217, 29);
            button8.TabIndex = 8;
            button8.Text = " Cantidad Lista";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(195, 203);
            button9.Name = "button9";
            button9.Size = new Size(217, 29);
            button9.TabIndex = 9;
            button9.Text = "Borrar en pos N";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 274);
            label1.Name = "label1";
            label1.Size = new Size(173, 70);
            label1.TabIndex = 10;
            label1.Text = "Seleccione un item de la lista 2 para utilizar los botones de abajo:";
            // 
            // button10
            // 
            button10.Location = new Point(210, 347);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 11;
            button10.Text = "Swap";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label2
            // 
            label2.Location = new Point(210, 274);
            label2.Name = "label2";
            label2.Size = new Size(202, 61);
            label2.TabIndex = 12;
            label2.Text = "Debe elegir dos elementos de la lista 2 para que funcione swap";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(613, 40);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(137, 384);
            listBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 8);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 14;
            label3.Text = "Lista 1 (Mostrar)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(613, 4);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 15;
            label4.Text = "Lista 2 (MostrarBisBis)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 466);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(button10);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(listBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private ListBox listBox1;
        private Button button8;
        private Button button9;
        private Label label1;
        private Button button10;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Label label4;
    }
}
