using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformsapp_1_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int age = int.Parse(tbAge.Text);
            
            string name = tbName.Text;

            if (age > 30)
            {
                MessageBox.Show($" Hello { name } you are {age} and you can enter");
            }
            else
            {
                MessageBox.Show($" Hello { name } you are you too young go home");
            }

            //MessageBox.Show($"Hello  {tbName.Text}");

            
        }
    }
}
