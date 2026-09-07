namespace bai3
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
            lblHoTen = new Label();
            lblHo = new Label();
            lblTen = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.Window;
            lblHoTen.BorderStyle = BorderStyle.FixedSingle;
            lblHoTen.Location = new Point(36, 12);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(515, 58);
            lblHoTen.TabIndex = 0;
            lblHoTen.Click += lblHoTen_Click;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new Point(36, 85);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(51, 20);
            lblHo.TabIndex = 1;
            lblHo.Text = "Họ lót";
            lblHo.Click += lblHo_Click;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(36, 135);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 3;
            lblTen.Text = "Tên";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(116, 85);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(358, 27);
            txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(116, 135);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(358, 27);
            txtTen.TabIndex = 4;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(441, 210);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(120, 30);
            btnHo.TabIndex = 5;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(235, 210);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(120, 30);
            btnTen.TabIndex = 6;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(36, 210);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(120, 30);
            btnHoTen.TabIndex = 7;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(194, 276);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(211, 62);
            btnKetThuc.TabIndex = 8;
            btnKetThuc.Text = "Thoát Chương Trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 377);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(txtHo);
            Controls.Add(lblHo);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Bài Tập Họ Tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblHo;
        private Label lblTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
    }
}
