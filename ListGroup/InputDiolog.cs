using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListGroup
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
            inputStr = textBox1.Text;
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
