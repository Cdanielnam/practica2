namespace Practica2
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            tbresult = new TextBox();
            lbresultado = new Label();
            btnclean = new Button();
            btnsuma = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnsuma);
            groupBox1.Controls.Add(btnclean);
            groupBox1.Controls.Add(num2);
            groupBox1.Controls.Add(num1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingreso de datos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbresultado);
            groupBox2.Controls.Add(tbresult);
            groupBox2.Location = new Point(33, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 150);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // num1
            // 
            num1.Location = new Point(155, 39);
            num1.Name = "num1";
            num1.Size = new Size(150, 31);
            num1.TabIndex = 2;
            // 
            // num2
            // 
            num2.Location = new Point(155, 95);
            num2.Name = "num2";
            num2.Size = new Size(150, 31);
            num2.TabIndex = 3;
            // 
            // tbresult
            // 
            tbresult.Location = new Point(172, 91);
            tbresult.Name = "tbresult";
            tbresult.Size = new Size(150, 31);
            tbresult.TabIndex = 0;
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(58, 104);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(101, 25);
            lbresultado.TabIndex = 1;
            lbresultado.Text = "lbresultado";
            // 
            // btnclean
            // 
            btnclean.Location = new Point(58, 150);
            btnclean.Name = "btnclean";
            btnclean.Size = new Size(112, 34);
            btnclean.TabIndex = 4;
            btnclean.Text = "btnclean";
            btnclean.UseVisualStyleBackColor = true;
            btnclean.Click += btnclean_Click;
            // 
            // btnsuma
            // 
            btnsuma.Location = new Point(338, 89);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(112, 34);
            btnsuma.TabIndex = 5;
            btnsuma.Text = "btnsuma";
            btnsuma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnclean;
        private TextBox num2;
        private TextBox num1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label lbresultado;
        private TextBox tbresult;
        private Button btnsuma;
    }
}
