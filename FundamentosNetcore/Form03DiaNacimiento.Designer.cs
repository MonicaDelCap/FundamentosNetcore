namespace FundamentosNetcore
{
    partial class Form03DiaNacimiento
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
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcularDia = new Button();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // txtDia
            // 
            txtDia.Location = new Point(48, 86);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(125, 27);
            txtDia.TabIndex = 0;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(48, 208);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(125, 27);
            txtMes.TabIndex = 1;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(48, 337);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(125, 27);
            txtAnio.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 44);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 3;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 170);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 4;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 303);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 5;
            label3.Text = "Año";
            // 
            // btnCalcularDia
            // 
            btnCalcularDia.Location = new Point(436, 136);
            btnCalcularDia.Name = "btnCalcularDia";
            btnCalcularDia.Size = new Size(151, 54);
            btnCalcularDia.TabIndex = 6;
            btnCalcularDia.Text = "Calcular Dia";
            btnCalcularDia.UseVisualStyleBackColor = true;
            btnCalcularDia.Click += btnCalcularDia_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Font = new Font("Segoe UI", 20F);
            lblDiaSemana.Location = new Point(417, 253);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(192, 46);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "Dia semana";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnCalcularDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAnio);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcularDia;
        private Label lblDiaSemana;
    }
}