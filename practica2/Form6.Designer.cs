namespace Practica2
{
    partial class Form6
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
            iblEmpresa = new Label();
            txtEmpresa = new TextBox();
            iblMonto = new Label();
            txtMonto = new TextBox();
            iblTiempo = new Label();
            iblTasaInter = new Label();
            txtTiempo = new TextBox();
            rdbInteres1 = new RadioButton();
            rdbInteres2 = new RadioButton();
            rdbInteres3 = new RadioButton();
            textTasaInterEX = new TextBox();
            instResul = new ListBox();
            btnAnalisis = new Button();
            btnFin = new Button();
            SuspendLayout();
            // 
            // iblEmpresa
            // 
            iblEmpresa.AutoSize = true;
            iblEmpresa.Location = new Point(52, 61);
            iblEmpresa.Name = "iblEmpresa";
            iblEmpresa.Size = new Size(180, 25);
            iblEmpresa.TabIndex = 0;
            iblEmpresa.Text = "Nombre de Empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(231, 65);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(594, 31);
            txtEmpresa.TabIndex = 1;
            // 
            // iblMonto
            // 
            iblMonto.AutoSize = true;
            iblMonto.Location = new Point(52, 164);
            iblMonto.Name = "iblMonto";
            iblMonto.Size = new Size(147, 25);
            iblMonto.TabIndex = 2;
            iblMonto.Text = "Monto prestamo";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(205, 164);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 31);
            txtMonto.TabIndex = 3;
            // 
            // iblTiempo
            // 
            iblTiempo.AutoSize = true;
            iblTiempo.Location = new Point(485, 170);
            iblTiempo.Name = "iblTiempo";
            iblTiempo.Size = new Size(120, 25);
            iblTiempo.TabIndex = 4;
            iblTiempo.Text = "Tiempo(años)";
            // 
            // iblTasaInter
            // 
            iblTasaInter.AutoSize = true;
            iblTasaInter.Location = new Point(52, 263);
            iblTasaInter.Name = "iblTasaInter";
            iblTasaInter.Size = new Size(127, 25);
            iblTasaInter.TabIndex = 5;
            iblTasaInter.Text = "Tasa de interes";
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(618, 167);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(150, 31);
            txtTiempo.TabIndex = 6;
            // 
            // rdbInteres1
            // 
            rdbInteres1.AutoSize = true;
            rdbInteres1.Location = new Point(62, 329);
            rdbInteres1.Name = "rdbInteres1";
            rdbInteres1.Size = new Size(72, 29);
            rdbInteres1.TabIndex = 7;
            rdbInteres1.TabStop = true;
            rdbInteres1.Text = "12%";
            rdbInteres1.UseVisualStyleBackColor = true;
            rdbInteres1.Click += rdbInteres1_Click;
            // 
            // rdbInteres2
            // 
            rdbInteres2.AutoSize = true;
            rdbInteres2.Location = new Point(255, 329);
            rdbInteres2.Name = "rdbInteres2";
            rdbInteres2.Size = new Size(86, 29);
            rdbInteres2.TabIndex = 8;
            rdbInteres2.TabStop = true;
            rdbInteres2.Text = "23.5%";
            rdbInteres2.UseVisualStyleBackColor = true;
            rdbInteres2.Click += rdbInteres2_Click;
            // 
            // rdbInteres3
            // 
            rdbInteres3.AutoSize = true;
            rdbInteres3.Location = new Point(454, 329);
            rdbInteres3.Name = "rdbInteres3";
            rdbInteres3.Size = new Size(151, 29);
            rdbInteres3.TabIndex = 9;
            rdbInteres3.TabStop = true;
            rdbInteres3.Text = "Otro, indeque:";
            rdbInteres3.UseVisualStyleBackColor = true;
            rdbInteres3.CheckedChanged += rdbInteres3_CheckedChanged;
            // 
            // textTasaInterEX
            // 
            textTasaInterEX.Enabled = false;
            textTasaInterEX.Location = new Point(676, 335);
            textTasaInterEX.Name = "textTasaInterEX";
            textTasaInterEX.Size = new Size(150, 31);
            textTasaInterEX.TabIndex = 10;
            // 
            // instResul
            // 
            instResul.Enabled = false;
            instResul.FormattingEnabled = true;
            instResul.ItemHeight = 25;
            instResul.Items.AddRange(new object[] { "Resultado" });
            instResul.Location = new Point(62, 372);
            instResul.Name = "instResul";
            instResul.Size = new Size(753, 179);
            instResul.TabIndex = 11;
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(215, 564);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(112, 34);
            btnAnalisis.TabIndex = 12;
            btnAnalisis.Text = "Analisis Financiero";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(602, 564);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(112, 34);
            btnFin.TabIndex = 13;
            btnFin.Text = "Salir del programa";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 611);
            Controls.Add(btnFin);
            Controls.Add(btnAnalisis);
            Controls.Add(instResul);
            Controls.Add(textTasaInterEX);
            Controls.Add(rdbInteres3);
            Controls.Add(rdbInteres2);
            Controls.Add(rdbInteres1);
            Controls.Add(txtTiempo);
            Controls.Add(iblTasaInter);
            Controls.Add(iblTiempo);
            Controls.Add(txtMonto);
            Controls.Add(iblMonto);
            Controls.Add(txtEmpresa);
            Controls.Add(iblEmpresa);
            Name = "Form6";
            Text = "Calculo de monto a pagar por un Prestamo";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label iblEmpresa;
        private TextBox txtEmpresa;
        private Label iblMonto;
        private TextBox txtMonto;
        private Label iblTiempo;
        private Label iblTasaInter;
        private TextBox txtTiempo;
        private RadioButton rdbInteres1;
        private RadioButton rdbInteres2;
        private RadioButton rdbInteres3;
        private TextBox textTasaInterEX;
        private ListBox instResul;
        private Button btnAnalisis;
        private Button btnFin;
    }
}