using System;
using System.Windows.Forms;

namespace InkConsumption
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.Items.Count - 1)
            {
                Form_Add_Etiketka f2 = new Form_Add_Etiketka();
                f2.Owner = this;
                f2.ShowDialog();
            }
            //MessageBox.Show("Hello","World",MessageBoxButtons.OK);
        }
    }
}
