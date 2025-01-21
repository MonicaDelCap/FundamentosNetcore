namespace FundamentosNetcore
{
    partial class Form21Files
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
            txtContenido = new TextBox();
            Nombre = new Label();
            txtNombre = new TextBox();
            btnNuevoNombre = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            label3 = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 35);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Contenido";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(47, 69);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(394, 360);
            txtContenido.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(524, 35);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(50, 20);
            Nombre.TabIndex = 2;
            Nombre.Text = "label2";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(524, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 27);
            txtNombre.TabIndex = 3;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(524, 153);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(94, 55);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo Nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(524, 236);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(524, 294);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(94, 29);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(698, 35);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(698, 81);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(225, 344);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 441);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Controls.Add(txtContenido);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenido;
        private Label Nombre;
        private TextBox txtNombre;
        private Button btnNuevoNombre;
        private Button btnRead;
        private Button btnWrite;
        private Label label3;
        private ListBox lstNombres;
    }
}