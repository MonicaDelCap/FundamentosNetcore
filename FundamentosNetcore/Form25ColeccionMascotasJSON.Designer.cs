namespace FundamentosNetcore
{
    partial class Form25ColeccionMascotasJSON
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
            txtAnios = new TextBox();
            label4 = new Label();
            btnGuardarMascotas = new Button();
            lstMascotas = new ListBox();
            label3 = new Label();
            btnLeerMascotas = new Button();
            btnNuevaMascota = new Button();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtAnios
            // 
            txtAnios.Location = new Point(107, 203);
            txtAnios.Name = "txtAnios";
            txtAnios.Size = new Size(125, 27);
            txtAnios.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 180);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 29;
            label4.Text = "Años";
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(822, 252);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(129, 51);
            btnGuardarMascotas.TabIndex = 28;
            btnGuardarMascotas.Text = "Guardar Mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(403, 102);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(351, 304);
            lstMascotas.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 62);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 26;
            label3.Text = "Mascotas";
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(822, 149);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(129, 51);
            btnLeerMascotas.TabIndex = 25;
            btnLeerMascotas.Text = "LeerMascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(107, 299);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(129, 51);
            btnNuevaMascota.TabIndex = 24;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(107, 138);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(125, 27);
            txtRaza.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 115);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 22;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 20;
            label1.Text = "Nombre";
            // 
            // Form25ColeccionMascotasJSON
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 476);
            Controls.Add(txtAnios);
            Controls.Add(label4);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnLeerMascotas);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form25ColeccionMascotasJSON";
            Text = "Form25ColeccionMascotasJSON";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnios;
        private Label label4;
        private Button btnGuardarMascotas;
        private ListBox lstMascotas;
        private Label label3;
        private Button btnLeerMascotas;
        private Button btnNuevaMascota;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
}