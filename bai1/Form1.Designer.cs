namespace demo
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
            btnHienThi = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNhapPassword = new TextBox();
            txtHienThi = new TextBox();
            btnTiep = new Button();
            btnDung = new Button();
            SuspendLayout();
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(136, 250);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 0;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(184, 75);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 3;
            label1.Text = "Nhập password:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(187, 122);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "Hiển thị: ";
            // 
            // txtNhapPassword
            // 
            txtNhapPassword.Location = new Point(316, 72);
            txtNhapPassword.Name = "txtNhapPassword";
            txtNhapPassword.PasswordChar = '*';
            txtNhapPassword.Size = new Size(192, 27);
            txtNhapPassword.TabIndex = 5;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(316, 122);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(192, 27);
            txtHienThi.TabIndex = 7;
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(302, 250);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(94, 29);
            btnTiep.TabIndex = 8;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += button1_Click;
            // 
            // btnDung
            // 
            btnDung.Location = new Point(477, 250);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(94, 29);
            btnDung.TabIndex = 9;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            btnDung.Click += btnDung_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 366);
            Controls.Add(btnDung);
            Controls.Add(btnTiep);
            Controls.Add(txtHienThi);
            Controls.Add(txtNhapPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHienThi);
            Name = "Form1";
            Text = "Sử Dụng ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHienThi;
        private Label label1;
        private Label label2;
        private TextBox txtNhapPassword;
        private TextBox txtHienThi;
        private Button btnTiep;
        private Button btnDung;
    }
}
