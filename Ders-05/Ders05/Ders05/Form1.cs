using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders05
{
    public partial class Form1 : Form
    {
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();

        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm2.frm1 = this;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 10 &&
textBox1.Text.Length < 12)
            {
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC Kimlik No boş yada 11 haneden büyük yada küçük olmamaz");
               
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kapat
            this.Close();
            Application.Exit();

        }
    }
}
