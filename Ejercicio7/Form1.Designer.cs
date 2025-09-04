namespace Ejercicio7
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
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(64, 22);
            label1.Name = "label1";
            label1.Size = new Size(636, 76);
            label1.TabIndex = 8;
            label1.Text = resources.GetString("label1.Text");
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(97, 164);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 274);
            listBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(97, 123);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 9;
            button1.Text = "Agregar a Lista 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(242, 123);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 10;
            button2.Text = "Agregar a Lista 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(493, 123);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Aparear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(242, 164);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 274);
            listBox2.TabIndex = 12;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(469, 164);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 274);
            listBox3.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}
