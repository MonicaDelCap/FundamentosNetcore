namespace FundamentosNetcore
{
    partial class Form20TestClases
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
            lstClases = new ListBox();
            label1 = new Label();
            btnPersona = new Button();
            btnempleado = new Button();
            SuspendLayout();
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(12, 64);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(776, 364);
            lstClases.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Librerias";
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(12, 434);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(178, 55);
            btnPersona.TabIndex = 2;
            btnPersona.Text = "Persona";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // btnempleado
            // 
            btnempleado.Location = new Point(214, 434);
            btnempleado.Name = "btnempleado";
            btnempleado.Size = new Size(114, 55);
            btnempleado.TabIndex = 3;
            btnempleado.Text = "button1";
            btnempleado.UseVisualStyleBackColor = true;
            btnempleado.Click += btnempleado_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 501);
            Controls.Add(btnempleado);
            Controls.Add(btnPersona);
            Controls.Add(label1);
            Controls.Add(lstClases);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstClases;
        private Label label1;
        private Button btnPersona;
        private Button btnempleado;
    }
}