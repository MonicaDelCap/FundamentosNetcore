namespace FundamentosNetcore
{
    partial class Form15Metodos
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
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            txtNumero = new TextBox();
            label2 = new Label();
            txtLetras = new TextBox();
            label3 = new Label();
            lblRaton = new Label();
            txtNumeros = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(50, 125);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "label2";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(50, 199);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(94, 29);
            btnDobleValor.TabIndex = 2;
            btnDobleValor.Text = "Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(50, 254);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(94, 29);
            btnDobleReferencia.TabIndex = 3;
            btnDobleReferencia.Text = "Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(50, 320);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(94, 29);
            btnObjetoReferencia.TabIndex = 4;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click_1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(50, 79);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 39);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 6;
            label2.Text = "Solo Numeros";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(310, 169);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(125, 27);
            txtLetras.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 125);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 8;
            label3.Text = "Solo Letras";
            // 
            // lblRaton
            // 
            lblRaton.Location = new Point(310, 225);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(293, 162);
            lblRaton.TabIndex = 9;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(310, 79);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(125, 27);
            txtNumeros.TabIndex = 10;
            txtNumeros.KeyPress += txtNumeros_KeyPress;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumeros);
            Controls.Add(lblRaton);
            Controls.Add(label3);
            Controls.Add(txtLetras);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            FormClosed += Form15Metodos_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtLetras;
        private Label label3;
        private Label lblRaton;
        private TextBox txtNumeros;
    }
}