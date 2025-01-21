namespace FundamentosNetcore
{
    partial class Form13ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            lblDatos = new Button();
            txtSuma = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(54, 83);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(142, 264);
            lstNumeros.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(343, 83);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(150, 65);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblDatos
            // 
            lblDatos.Location = new Point(343, 154);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(150, 62);
            lblDatos.TabIndex = 2;
            lblDatos.Text = "Mostrar Datos";
            lblDatos.UseVisualStyleBackColor = true;
            lblDatos.Click += lblDatos_Click;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(343, 248);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(125, 27);
            txtSuma.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 249);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Suma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 290);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 5;
            label2.Text = "Pares";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 334);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Impares";
            // 
            // txtPares
            // 
            txtPares.Location = new Point(343, 290);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(125, 27);
            txtPares.TabIndex = 7;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(343, 327);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(125, 27);
            txtImpares.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 44);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 9;
            label4.Text = "Numeros";
            // 
            // Form13ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 434);
            Controls.Add(label4);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSuma);
            Controls.Add(lblDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Name = "Form13ColeccionNumeros";
            Text = "Form13ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button lblDatos;
        private TextBox txtSuma;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPares;
        private TextBox txtImpares;
        private Label label4;
    }
}