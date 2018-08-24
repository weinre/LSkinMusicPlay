using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LSkin
{
    public partial class InputDiolog : Form
    {
        public InputDiolog()
        {
            InitializeComponent();
        }
        public string inputStr="";
        private void button1_Click(object sender, EventArgs e)
        {
            inputStr =textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(null,null);
        }
        private void InputDiolog_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
        }
    }
}

