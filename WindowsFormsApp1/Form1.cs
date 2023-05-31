using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ChildForm childForm;
        public Form1()
        {
            InitializeComponent();
            childForm = new ChildForm(this);
            childForm.Owner = this;
            childForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            childForm.textBox1.Text = this.textBox1.Text;
        }

        public void ChildForm_TextChanged(string newText)
        {
            this.textBox1.Text = newText;
        }
    }
}
