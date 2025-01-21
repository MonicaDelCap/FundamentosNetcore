namespace FundamentosNetcore
{
    partial class Form01SumarNumeros
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
            txtNum1 = new TextBox();
            label2 = new Label();
            txtNum2 = new TextBox();
            lblresultado = new Label();
            btnSumar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(67, 43);
            label1.Name = "label1";
            label1.Size = new Size(109, 46);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(67, 92);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(67, 134);
            label2.Name = "label2";
            label2.Size = new Size(109, 46);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(67, 186);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 3;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI", 20F);
            lblresultado.Location = new Point(67, 237);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(109, 46);
            lblresultado.TabIndex = 4;
            lblresultado.Text = "label3";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(376, 134);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(147, 79);
            btnSumar.TabIndex = 6;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSumar);
            Controls.Add(lblresultado);
            Controls.Add(txtNum2);
            Controls.Add(label2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private Label label2;
        private TextBox txtNum2;
        private Label lblresultado;
        private Button btnSumar;
    }
}