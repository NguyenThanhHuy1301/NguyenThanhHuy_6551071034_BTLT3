namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHo_Click(object? sender, System.EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void btnTen_Click(object? sender, System.EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object? sender, System.EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void lblHoTen_DoubleClick(object? sender, System.EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void btnKetThuc_Click(object? sender, System.EventArgs e)
        {
            this.Close();
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblHo_Click(object sender, EventArgs e)
        {

        }
    }
}
