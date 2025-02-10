namespace Practica2
{
    partial class Form7
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
            lbltitle = new Label();
            iblseleccion = new Label();
            lblresult = new Label();
            btniniciar = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Location = new Point(89, 24);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(134, 25);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Inicio de sesión";
            // 
            // iblseleccion
            // 
            iblseleccion.AutoSize = true;
            iblseleccion.Location = new Point(52, 92);
            iblseleccion.Name = "iblseleccion";
            iblseleccion.Size = new Size(173, 25);
            iblseleccion.TabIndex = 1;
            iblseleccion.Text = "Seleccion de usuario";
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(89, 260);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(94, 25);
            lblresult.TabIndex = 2;
            lblresult.Text = "Resultado:";
            lblresult.Click += lblresult_Click;
            // 
            // btniniciar
            // 
            btniniciar.Location = new Point(491, 92);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(112, 34);
            btniniciar.TabIndex = 3;
            btniniciar.Text = "Iniciar sesión";
            btniniciar.UseVisualStyleBackColor = true;
            btniniciar.Click += btniniciar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 320);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(501, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 33);
            comboBox1.TabIndex = 5;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(btniniciar);
            Controls.Add(lblresult);
            Controls.Add(iblseleccion);
            Controls.Add(lbltitle);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label iblseleccion;
        private Label lblresult;
        private Button btniniciar;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}