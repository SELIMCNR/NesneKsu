using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ufiyatı, adedi, kdv = 0, tutar, toplamtutar, a, x, y, z, b;

        private void radioButton4_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.Text = "Pesin";

            a = Convert.ToInt32(textBox5.Text);
            textBox8.Text = Convert.ToString(a);
            x = a * 0.05;
            textBox9.Text = Convert.ToString(x);
            y = a + x;
            textBox10.Text = Convert.ToString(y);
            z = y - (y * 0.05);
            textBox11.Text = Convert.ToString(z);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hesapla 
            ufiyatı = Convert.ToInt32(textBox1.Text);
            adedi = Convert.ToInt32(textBox2.Text);
            tutar = ufiyatı * adedi;
            if (radioButton1.Checked)
            {
                kdv = tutar * 0.01;
            }
            if (radioButton2.Checked)
            {
                kdv = tutar * 0.08;
            }
            if (radioButton2.Checked)
            {
                kdv = tutar * 0.18;
            }
            toplamtutar = kdv + tutar;
            textBox3.Text = kdv.ToString();
            textBox4.Text = toplamtutar.ToString("c");
         }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.Text = "Bonus";

            a = Convert.ToInt32(textBox5.Text);
            textBox8.Text = Convert.ToString(a);
            x = a * 0.18;
            textBox9.Text = Convert.ToString(x);
            y = a + x;
            textBox10.Text = Convert.ToString(y);
            z = y - (y * 0.15);
            textBox11.Text = Convert.ToString(z);
            b = z / 15;
            textBox7.Text = Convert.ToString(b);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.Text = "Acces";

            a = Convert.ToInt32(textBox5.Text);
            textBox8.Text = Convert.ToString(a);
            x = a * 0.18;
            textBox9.Text = Convert.ToString(x);
            y = a + x;
            textBox10.Text = Convert.ToString(y);
            z = y - (y * 0.10);
            textBox11.Text = Convert.ToString(z);
            b = z / 10;
            textBox7.Text = Convert.ToString(b);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.Text = "Word";

            a = Convert.ToInt32(textBox5.Text);
            textBox8.Text = Convert.ToString(a);
            x = a * 0.08;
            textBox9.Text=Convert.ToString(x);
            y = a + x;
            textBox10.Text=Convert.ToString(y);
            z = y - (y * 0.18);
            textBox11.Text =Convert.ToString(z);
            b = z / 18;
            textBox7.Text= Convert.ToString(b);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //form1 kapanırken
            DialogResult kapat;
            kapat = MessageBox.Show("kapanacaktır","dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(DialogResult.Yes== kapat)
            {
                Application.Exit();
            }
            else if(kapat == DialogResult.No)
            {
                e.Cancel= true;
                return;
            }
        }
    }
}
