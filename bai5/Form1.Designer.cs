namespace bai5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.Label lblNhapTenLabel;
        private System.Windows.Forms.Label lblLapTrinhLabel;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox groupBoxFont;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Button btnThoat;

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
            txtNhapTen = new TextBox();
            lblLapTrinh = new Label();
            groupBoxColor = new GroupBox();
            radRed = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            groupBoxFont = new GroupBox();
            chkBold = new CheckBox();
            chkItalic = new CheckBox();
            chkUnderline = new CheckBox();
            btnThoat = new Button();
            lblNhapTenLabel = new Label();
            lblLapTrinhLabel = new Label();
            groupBoxColor.SuspendLayout();
            groupBoxFont.SuspendLayout();
            SuspendLayout();
            // 
            // txtNhapTen
            // 
            txtNhapTen.BorderStyle = BorderStyle.FixedSingle;
            txtNhapTen.Font = new Font("Segoe UI", 9F);
            txtNhapTen.Location = new Point(150, 19);
            txtNhapTen.Margin = new Padding(4, 3, 4, 3);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(524, 27);
            txtNhapTen.TabIndex = 0;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BackColor = SystemColors.ButtonHighlight;
            lblLapTrinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLapTrinh.ForeColor = Color.Green;
            lblLapTrinh.Location = new Point(169, 256);
            lblLapTrinh.Margin = new Padding(4, 0, 4, 0);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(375, 22);
            lblLapTrinh.TabIndex = 2;
            lblLapTrinh.Click += lblLapTrinh_Click;
            // 
            // groupBoxColor
            // 
            groupBoxColor.BackColor = Color.LightBlue;
            groupBoxColor.Controls.Add(radRed);
            groupBoxColor.Controls.Add(radGreen);
            groupBoxColor.Controls.Add(radBlue);
            groupBoxColor.Controls.Add(radBlack);
            groupBoxColor.Location = new Point(25, 95);
            groupBoxColor.Margin = new Padding(4, 3, 4, 3);
            groupBoxColor.Name = "groupBoxColor";
            groupBoxColor.Padding = new Padding(4, 3, 4, 3);
            groupBoxColor.Size = new Size(250, 142);
            groupBoxColor.TabIndex = 3;
            groupBoxColor.TabStop = false;
            groupBoxColor.Text = "Color";
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(12, 19);
            radRed.Margin = new Padding(4, 3, 4, 3);
            radRed.Name = "radRed";
            radRed.Size = new Size(61, 23);
            radRed.TabIndex = 0;
            radRed.Text = "Red";
            radRed.CheckedChanged += radColor_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(12, 48);
            radGreen.Margin = new Padding(4, 3, 4, 3);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(80, 23);
            radGreen.TabIndex = 1;
            radGreen.Text = "Green";
            radGreen.CheckedChanged += radColor_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(12, 76);
            radBlue.Margin = new Padding(4, 3, 4, 3);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(65, 23);
            radBlue.TabIndex = 2;
            radBlue.Text = "Blue";
            radBlue.CheckedChanged += radColor_CheckedChanged;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            radBlack.ForeColor = Color.Black;
            radBlack.Location = new Point(12, 104);
            radBlack.Margin = new Padding(4, 3, 4, 3);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(74, 23);
            radBlack.TabIndex = 3;
            radBlack.Text = "Black";
            radBlack.CheckedChanged += radColor_CheckedChanged;
            // 
            // groupBoxFont
            // 
            groupBoxFont.BackColor = Color.PeachPuff;
            groupBoxFont.Controls.Add(chkBold);
            groupBoxFont.Controls.Add(chkItalic);
            groupBoxFont.Controls.Add(chkUnderline);
            groupBoxFont.Location = new Point(372, 95);
            groupBoxFont.Margin = new Padding(4, 3, 4, 3);
            groupBoxFont.Name = "groupBoxFont";
            groupBoxFont.Padding = new Padding(4, 3, 4, 3);
            groupBoxFont.Size = new Size(302, 142);
            groupBoxFont.TabIndex = 4;
            groupBoxFont.TabStop = false;
            groupBoxFont.Text = "Font";
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.ForeColor = Color.RoyalBlue;
            chkBold.Location = new Point(12, 19);
            chkBold.Margin = new Padding(4, 3, 4, 3);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(64, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm";
            chkBold.CheckedChanged += chkFont_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.ForeColor = Color.RoyalBlue;
            chkItalic.Location = new Point(12, 48);
            chkItalic.Margin = new Padding(4, 3, 4, 3);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(92, 24);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng";
            chkItalic.CheckedChanged += chkFont_CheckedChanged;
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderline.ForeColor = Color.RoyalBlue;
            chkUnderline.Location = new Point(12, 76);
            chkUnderline.Margin = new Padding(4, 3, 4, 3);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(105, 24);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Gạch Chân";
            chkUnderline.CheckedChanged += chkFont_CheckedChanged;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(551, 243);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 35);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // lblNhapTenLabel
            // 
            lblNhapTenLabel.AutoSize = true;
            lblNhapTenLabel.BackColor = Color.DarkGreen;
            lblNhapTenLabel.BorderStyle = BorderStyle.FixedSingle;
            lblNhapTenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNhapTenLabel.ForeColor = Color.White;
            lblNhapTenLabel.Location = new Point(25, 22);
            lblNhapTenLabel.Margin = new Padding(4, 0, 4, 0);
            lblNhapTenLabel.Name = "lblNhapTenLabel";
            lblNhapTenLabel.Padding = new Padding(8, 2, 8, 2);
            lblNhapTenLabel.Size = new Size(98, 26);
            lblNhapTenLabel.TabIndex = 0;
            lblNhapTenLabel.Text = "Nhập Tên:";
            // 
            // lblLapTrinhLabel
            // 
            lblLapTrinhLabel.AutoSize = true;
            lblLapTrinhLabel.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            lblLapTrinhLabel.ForeColor = Color.Red;
            lblLapTrinhLabel.Location = new Point(20, 259);
            lblLapTrinhLabel.Margin = new Padding(4, 0, 4, 0);
            lblLapTrinhLabel.Name = "lblLapTrinhLabel";
            lblLapTrinhLabel.Size = new Size(125, 19);
            lblLapTrinhLabel.TabIndex = 1;
            lblLapTrinhLabel.Text = "Lập Trình Bởi:";
            lblLapTrinhLabel.Click += lblLapTrinhLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 367);
            Controls.Add(lblNhapTenLabel);
            Controls.Add(txtNhapTen);
            Controls.Add(lblLapTrinhLabel);
            Controls.Add(lblLapTrinh);
            Controls.Add(groupBoxColor);
            Controls.Add(groupBoxFont);
            Controls.Add(btnThoat);
            Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Định Dạng (Formatter)";
            Load += Form1_Load;
            groupBoxColor.ResumeLayout(false);
            groupBoxColor.PerformLayout();
            groupBoxFont.ResumeLayout(false);
            groupBoxFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
