namespace FundamentosNetcore
{
    partial class Form23ObjetoXMLMascota
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
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            txtAnios = new TextBox();
            Nombre = new Label();
            Raza = new Label();
            Año = new Label();
            btnLeerDato = new Button();
            btnGuardarDato = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(69, 189);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(125, 27);
            txtRaza.TabIndex = 1;
            // 
            // txtAnios
            // 
            txtAnios.Location = new Point(69, 305);
            txtAnios.Name = "txtAnios";
            txtAnios.Size = new Size(125, 27);
            txtAnios.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(69, 49);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Location = new Point(69, 155);
            Raza.Name = "Raza";
            Raza.Size = new Size(41, 20);
            Raza.TabIndex = 4;
            Raza.Text = "Raza";
            // 
            // Año
            // 
            Año.AutoSize = true;
            Año.Location = new Point(69, 265);
            Año.Name = "Año";
            Año.Size = new Size(42, 20);
            Año.TabIndex = 5;
            Año.Text = "Años";
            // 
            // btnLeerDato
            // 
            btnLeerDato.Location = new Point(329, 110);
            btnLeerDato.Name = "btnLeerDato";
            btnLeerDato.Size = new Size(138, 65);
            btnLeerDato.TabIndex = 6;
            btnLeerDato.Text = "Leer Dato";
            btnLeerDato.UseVisualStyleBackColor = true;
            btnLeerDato.Click += btnLeerDato_Click;
            // 
            // btnGuardarDato
            // 
            btnGuardarDato.Location = new Point(329, 223);
            btnGuardarDato.Name = "btnGuardarDato";
            btnGuardarDato.Size = new Size(138, 62);
            btnGuardarDato.TabIndex = 7;
            btnGuardarDato.Text = "Guardar Dato";
            btnGuardarDato.UseVisualStyleBackColor = true;
            btnGuardarDato.Click += btnGuardarDato_Click;
            // 
            // Form23ObjetoXMLMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarDato);
            Controls.Add(btnLeerDato);
            Controls.Add(Año);
            Controls.Add(Raza);
            Controls.Add(Nombre);
            Controls.Add(txtAnios);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Name = "Form23ObjetoXMLMascota";
            Text = "Form23ObjetoXMLMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtRaza;
        private TextBox txtAnios;
        private Label Nombre;
        private Label Raza;
        private Label Año;
        private Button btnLeerDato;
        private Button btnGuardarDato;
    }
}