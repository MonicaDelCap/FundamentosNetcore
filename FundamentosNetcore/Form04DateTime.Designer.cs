namespace FundamentosNetcore
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkFormato = new CheckBox();
            groupBox1 = new GroupBox();
            rdbAnio = new RadioButton();
            rdbMeses = new RadioButton();
            btnIncrementar = new Button();
            rdbDias = new RadioButton();
            label2 = new Label();
            txtIncremento = new TextBox();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 40);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(58, 84);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(367, 27);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(58, 133);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(185, 24);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato fecha";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbAnio);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(58, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 146);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rdbAnio
            // 
            rdbAnio.AutoSize = true;
            rdbAnio.Location = new Point(6, 86);
            rdbAnio.Name = "rdbAnio";
            rdbAnio.Size = new Size(63, 24);
            rdbAnio.TabIndex = 2;
            rdbAnio.TabStop = true;
            rdbAnio.Text = "Años";
            rdbAnio.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(6, 56);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(71, 24);
            rdbMeses.TabIndex = 1;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(347, 101);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(94, 29);
            btnIncrementar.TabIndex = 6;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(6, 26);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(59, 24);
            rdbDias.TabIndex = 0;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 26);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(237, 250);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(367, 27);
            txtIncremento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 360);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 7;
            label3.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(58, 392);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(367, 27);
            txtNuevaFecha.TabIndex = 8;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(txtIncremento);
            Controls.Add(groupBox1);
            Controls.Add(chkFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private GroupBox groupBox1;
        private RadioButton rdbAnio;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}