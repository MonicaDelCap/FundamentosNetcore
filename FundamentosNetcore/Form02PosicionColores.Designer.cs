namespace FundamentosNetcore
{
    partial class Form02PosicionColores
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
            label2 = new Label();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            btnPosicion = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnColor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 53);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Posicion X: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 122);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Posicion Y: ";
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(131, 53);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(125, 27);
            txtPosX.TabIndex = 2;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(131, 119);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(125, 27);
            txtPosY.TabIndex = 3;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(58, 192);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(165, 61);
            btnPosicion.TabIndex = 4;
            btnPosicion.Text = "Cambiar posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 60);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "ROJO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 176);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "AZUL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 119);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 7;
            label5.Text = "VERDE";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(531, 60);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(125, 27);
            txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(531, 115);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(125, 27);
            txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(531, 173);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(125, 27);
            txtAzul.TabIndex = 10;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(484, 228);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(154, 63);
            btnColor.TabIndex = 11;
            btnColor.Text = "Cambiar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnColor);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnPosicion);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private Button btnPosicion;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnColor;
    }
}