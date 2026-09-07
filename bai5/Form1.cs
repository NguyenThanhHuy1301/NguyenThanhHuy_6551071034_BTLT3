using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // default: Red selected and focus on input
            this.radRed.Checked = true;
            this.txtNhapTen.Focus();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            this.lblLapTrinh.Text = this.txtNhapTen.Text;
        }

        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            Color c = Color.Black;
            if (radRed.Checked) c = Color.Red;
            else if (radGreen.Checked) c = Color.Green;
            else if (radBlue.Checked) c = Color.Blue;
            else if (radBlack.Checked) c = Color.Black;

            // Only update the display label; do not change the input textbox appearance
            this.lblLapTrinh.ForeColor = c;
        }

        private void chkFont_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked) style |= FontStyle.Bold;
            if (chkItalic.Checked) style |= FontStyle.Italic;
            if (chkUnderline.Checked) style |= FontStyle.Underline;

            // Only update the display label's font; do not change the input textbox font
            this.lblLapTrinh.Font = new Font(this.lblLapTrinh.Font.FontFamily, this.lblLapTrinh.Font.Size, style);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLapTrinh_Click(object sender, EventArgs e)
        {

        }

        private void lblLapTrinhLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
