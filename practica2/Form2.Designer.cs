namespace practica2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            titulo = new Label();
            textBox1 = new TextBox();
            enviar = new Button();
            salir = new Button();
            Ingresotext = new Label();
            resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 33);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Location = new Point(295, 44);
            titulo.Name = "titulo";
            titulo.Size = new Size(53, 25);
            titulo.TabIndex = 1;
            titulo.Text = "titulo";
            titulo.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(308, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // enviar
            // 
            enviar.Location = new Point(332, 189);
            enviar.Name = "enviar";
            enviar.Size = new Size(112, 34);
            enviar.TabIndex = 3;
            enviar.Text = "enviar";
            enviar.UseVisualStyleBackColor = true;
            enviar.Click += button1_Click;
            // 
            // salir
            // 
            salir.Location = new Point(624, 371);
            salir.Name = "salir";
            salir.Size = new Size(112, 34);
            salir.TabIndex = 4;
            salir.Text = "salir";
            salir.UseVisualStyleBackColor = true;
            salir.Click += salir_Click;
            // 
            // Ingresotext
            // 
            Ingresotext.AutoSize = true;
            Ingresotext.Location = new Point(235, 79);
            Ingresotext.Name = "Ingresotext";
            Ingresotext.Size = new Size(101, 25);
            Ingresotext.TabIndex = 5;
            Ingresotext.Text = "Ingresotext";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(135, 332);
            resultado.Name = "resultado";
            resultado.Size = new Size(86, 25);
            resultado.TabIndex = 6;
            resultado.Text = "resultado";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado);
            Controls.Add(Ingresotext);
            Controls.Add(salir);
            Controls.Add(enviar);
            Controls.Add(textBox1);
            Controls.Add(titulo);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label titulo;
        private TextBox textBox1;
        private Button enviar;
        private Button salir;
        private Label Ingresotext;
        private Label resultado;
    }
}