namespace Finansy
{
    public partial class Form1 : Form
    {
        int account, add, subtr;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_add_Click(object sender, EventArgs e)
        {
            add = Convert.ToInt32(maskedTextBox1.Text);
            account = account + add;
            MessageBox.Show($"ƒенег на счете: {account}", "—чет", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void but_subtr_Click(object sender, EventArgs e)
        {
            subtr = Convert.ToInt32(maskedTextBox2.Text);
            account = account - subtr;
            MessageBox.Show($"ƒенег на счете: {account}", "—чет", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bank_account_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ƒенег на счете: {account}", "—чет", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
