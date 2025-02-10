namespace Practica2
{
    partial class Form10
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
            lbltipo = new GroupBox();
            btnSalir = new Button();
            txtcrearturno = new TextBox();
            lBturno = new ListBox();
            btncreartur = new Button();
            comboBox1 = new ComboBox();
            lblturno = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblmostrar = new RichTextBox();
            btnasignar = new Button();
            tbnombre = new TextBox();
            lblnombre = new Label();
            cbasignarturno = new ComboBox();
            lblasignarturno = new Label();
            lbltipo.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbltipo
            // 
            lbltipo.Controls.Add(btnSalir);
            lbltipo.Controls.Add(txtcrearturno);
            lbltipo.Controls.Add(lBturno);
            lbltipo.Controls.Add(btncreartur);
            lbltipo.Controls.Add(comboBox1);
            lbltipo.Controls.Add(lblturno);
            lbltipo.Controls.Add(label1);
            lbltipo.Location = new Point(25, 13);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(1347, 310);
            lbltipo.TabIndex = 0;
            lbltipo.TabStop = false;
            lbltipo.Text = "creacion de turnos";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(682, 226);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(163, 39);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "&salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtcrearturno
            // 
            txtcrearturno.Location = new Point(213, 157);
            txtcrearturno.Name = "txtcrearturno";
            txtcrearturno.Size = new Size(150, 31);
            txtcrearturno.TabIndex = 5;
            // 
            // lBturno
            // 
            lBturno.FormattingEnabled = true;
            lBturno.ItemHeight = 25;
            lBturno.Location = new Point(952, 36);
            lBturno.Name = "lBturno";
            lBturno.Size = new Size(347, 254);
            lBturno.TabIndex = 4;
            // 
            // btncreartur
            // 
            btncreartur.Location = new Point(564, 47);
            btncreartur.Name = "btncreartur";
            btncreartur.Size = new Size(112, 34);
            btncreartur.TabIndex = 3;
            btncreartur.Text = "btncreartur";
            btncreartur.UseVisualStyleBackColor = true;
            btncreartur.Click += btncreartur_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Matutino", "Vespertino" });
            comboBox1.Location = new Point(154, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            // 
            // lblturno
            // 
            lblturno.AutoSize = true;
            lblturno.Location = new Point(66, 140);
            lblturno.Name = "lblturno";
            lblturno.Size = new Size(74, 25);
            lblturno.TabIndex = 1;
            lblturno.Text = "lblturno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblmostrar);
            groupBox2.Controls.Add(btnasignar);
            groupBox2.Controls.Add(tbnombre);
            groupBox2.Controls.Add(lblnombre);
            groupBox2.Controls.Add(cbasignarturno);
            groupBox2.Controls.Add(lblasignarturno);
            groupBox2.Location = new Point(25, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1347, 383);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Asignar turno a doctor";
            // 
            // lblmostrar
            // 
            lblmostrar.Location = new Point(774, 71);
            lblmostrar.Name = "lblmostrar";
            lblmostrar.Size = new Size(435, 283);
            lblmostrar.TabIndex = 6;
            lblmostrar.Text = "";
            // 
            // btnasignar
            // 
            btnasignar.Location = new Point(224, 314);
            btnasignar.Name = "btnasignar";
            btnasignar.Size = new Size(112, 34);
            btnasignar.TabIndex = 5;
            btnasignar.Text = "asignar";
            btnasignar.UseVisualStyleBackColor = true;
            btnasignar.Click += btnasignar_Click;
            // 
            // tbnombre
            // 
            tbnombre.Location = new Point(190, 243);
            tbnombre.Name = "tbnombre";
            tbnombre.Size = new Size(150, 31);
            tbnombre.TabIndex = 3;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(181, 179);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(165, 25);
            lblnombre.TabIndex = 2;
            lblnombre.Text = "Nombre de dcotor:";
            // 
            // cbasignarturno
            // 
            cbasignarturno.FormattingEnabled = true;
            cbasignarturno.Location = new Point(176, 111);
            cbasignarturno.Name = "cbasignarturno";
            cbasignarturno.Size = new Size(182, 33);
            cbasignarturno.TabIndex = 1;
            cbasignarturno.Text = "asignar turno";
            // 
            // lblasignarturno
            // 
            lblasignarturno.AutoSize = true;
            lblasignarturno.Location = new Point(161, 59);
            lblasignarturno.Name = "lblasignarturno";
            lblasignarturno.Size = new Size(177, 25);
            lblasignarturno.TabIndex = 0;
            lblasignarturno.Text = "asignacion de turnos";
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 748);
            Controls.Add(groupBox2);
            Controls.Add(lbltipo);
            Name = "Form10";
            Text = "Form10";
            lbltipo.ResumeLayout(false);
            lbltipo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox lbltipo;
        private ComboBox comboBox1;
        private Label lblturno;
        private Label label1;
        private GroupBox groupBox2;
        private ListBox lBturno;
        private Button btncreartur;
        private Label lblasignarturno;
        private TextBox txtcrearturno;
        private TextBox tbnombre;
        private Label lblnombre;
        private ComboBox cbasignarturno;
        private Button btnSalir;
        private Button btnasignar;
        private RichTextBox lblmostrar;
    }
}