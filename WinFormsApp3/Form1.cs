using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton1.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString());
        }
    }
}