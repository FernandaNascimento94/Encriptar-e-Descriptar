namespace EncriptarDesencriptar
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
            buttonAbrir = new Button();
            buttonSalvar = new Button();
            buttonEncriptar = new Button();
            buttonDesencriptar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonAbrir
            // 
            buttonAbrir.Location = new Point(1, 0);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(132, 49);
            buttonAbrir.TabIndex = 0;
            buttonAbrir.Text = "Abrir";
            buttonAbrir.UseVisualStyleBackColor = true;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(139, 0);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(118, 49);
            buttonSalvar.TabIndex = 1;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonEncriptar
            // 
            buttonEncriptar.Location = new Point(263, 0);
            buttonEncriptar.Name = "buttonEncriptar";
            buttonEncriptar.Size = new Size(123, 49);
            buttonEncriptar.TabIndex = 2;
            buttonEncriptar.Text = "Encriptar";
            buttonEncriptar.UseVisualStyleBackColor = true;
            buttonEncriptar.Click += buttonEncriptar_Click;
            // 
            // buttonDesencriptar
            // 
            buttonDesencriptar.Location = new Point(392, 0);
            buttonDesencriptar.Name = "buttonDesencriptar";
            buttonDesencriptar.Size = new Size(138, 49);
            buttonDesencriptar.TabIndex = 3;
            buttonDesencriptar.Text = "Desencriptar";
            buttonDesencriptar.UseVisualStyleBackColor = true;
            buttonDesencriptar.Click += buttonDesencriptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(548, 28);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(796, 388);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonDesencriptar);
            Controls.Add(buttonEncriptar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAbrir;
        private Button buttonSalvar;
        private Button buttonEncriptar;
        private Button buttonDesencriptar;
        private Label label1;
        private TextBox textBox1;
    }
}
