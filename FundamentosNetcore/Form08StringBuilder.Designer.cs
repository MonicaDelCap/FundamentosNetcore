namespace FundamentosNetcore
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            btnInvertir = new Button();
            btnInvertirStringBuilder = new Button();
            label1 = new Label();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(24, 90);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(1050, 443);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "";
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(299, 544);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(175, 74);
            btnInvertir.TabIndex = 1;
            btnInvertir.Text = "Invertir texto";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(676, 544);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(173, 74);
            btnInvertirStringBuilder.TabIndex = 2;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 3;
            label1.Text = "Copie el texto";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(62, 573);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(65, 28);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "label2";
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(lblTiempo);
            Controls.Add(label1);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertir);
            Controls.Add(txtTexto);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTexto;
        private Button btnInvertir;
        private Button btnInvertirStringBuilder;
        private Label label1;
        private Label lblTiempo;
    }
}