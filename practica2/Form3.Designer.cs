namespace practica2
{
    partial class Form3
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
            resultado = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            suma = new Button();
            resta = new Button();
            multiplicación = new Button();
            division = new Button();
            SuspendLayout();
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(343, 199);
            resultado.Name = "resultado";
            resultado.Size = new Size(86, 25);
            resultado.TabIndex = 0;
            resultado.Text = "resultado";
            resultado.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(465, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // suma
            // 
            suma.Location = new Point(67, 260);
            suma.Name = "suma";
            suma.Size = new Size(112, 34);
            suma.TabIndex = 3;
            suma.Text = "suma";
            suma.UseVisualStyleBackColor = true;
            suma.Click += suma_Click;
            // 
            // resta
            // 
            resta.Location = new Point(241, 260);
            resta.Name = "resta";
            resta.Size = new Size(112, 34);
            resta.TabIndex = 4;
            resta.Text = "resta";
            resta.UseVisualStyleBackColor = true;
            resta.Click += resta_Click;
            // 
            // multiplicación
            // 
            multiplicación.Location = new Point(406, 260);
            multiplicación.Name = "multiplicación";
            multiplicación.Size = new Size(112, 34);
            multiplicación.TabIndex = 5;
            multiplicación.Text = "multiplicación";
            multiplicación.UseVisualStyleBackColor = true;
            multiplicación.Click += multiplicación_Click;
            // 
            // division
            // 
            division.Location = new Point(589, 260);
            division.Name = "division";
            division.Size = new Size(112, 34);
            division.TabIndex = 6;
            division.Text = "division";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(division);
            Controls.Add(multiplicación);
            Controls.Add(resta);
            Controls.Add(suma);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(resultado);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultado;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button suma;
        private Button resta;
        private Button multiplicación;
        private Button division;
    }
}