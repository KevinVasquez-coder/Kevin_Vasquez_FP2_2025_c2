namespace loto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNum = new TextBox();
            txtDinero = new TextBox();
            btnJugar = new Button();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            txtPremio = new TextBox();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(55, 35);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(125, 27);
            txtNum.TabIndex = 0;
            // 
            // txtDinero
            // 
            txtDinero.Location = new Point(55, 68);
            txtDinero.Name = "txtDinero";
            txtDinero.Size = new Size(125, 27);
            txtDinero.TabIndex = 1;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(251, 35);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(94, 29);
            btnJugar.TabIndex = 2;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(29, 153);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(56, 20);
            lblNum1.TabIndex = 3;
            lblNum1.Text = "Primer ";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(119, 151);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(68, 20);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Segundo";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(207, 151);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(49, 20);
            lblNum3.TabIndex = 5;
            lblNum3.Text = "Tercer";
            // 
            // txtPremio
            // 
            txtPremio.Location = new Point(137, 218);
            txtPremio.Name = "txtPremio";
            txtPremio.Size = new Size(125, 27);
            txtPremio.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 330);
            Controls.Add(txtPremio);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(btnJugar);
            Controls.Add(txtDinero);
            Controls.Add(txtNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private TextBox txtDinero;
        private Button btnJugar;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private TextBox txtPremio;
    }
}
