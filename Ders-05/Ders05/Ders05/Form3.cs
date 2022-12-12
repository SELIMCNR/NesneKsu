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
    public partial class Form3 : Form
    {
        public Form1 frm1;
        // Form3 frm3 = new Form3();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
