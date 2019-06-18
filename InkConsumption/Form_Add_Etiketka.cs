using System.Windows.Forms;

namespace InkConsumption
{
    public partial class Form_Add_Etiketka : Form
    {
        public MainForm f1;
        public Form_Add_Etiketka()
        {
            f1 = (MainForm)this.Owner;
            InitializeComponent();
        }


        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            f1 = (MainForm)this.Owner;
            f1.comboBox1.SelectedIndex = 0;
            this.Close();
            //            MainForm f1 = new MainForm();
        }

        private void ButtonAdd_Click(object sender, System.EventArgs e)
        {
            f1 = (MainForm)this.Owner;
            //           f1 = this.f1;
            f1.comboBox1.Items.Add("...");
            f1.comboBox1.Items[f1.comboBox1.Items.Count - 2] = textBox1.Text;
            f1.comboBox1.SelectedIndex = f1.comboBox1.Items.Count-2;
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (textBox1.Text != "") buttonAdd.Enabled = true;
        }
    }
}
