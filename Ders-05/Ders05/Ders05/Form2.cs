using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders05
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        Form3 frm3 = new Form3();
        public Form2()
        {
            InitializeComponent();
            frm3 = new Form3();
            // frm3.frm3 = this;
        }
        int fiyat, adet, peşinat, toplam, taksit, tutar, stok,
       i, a;

        private void button4_Click(object sender, EventArgs e)
        {
            //form2 yi kapat
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {//hesapla
                try
                {
                    fiyat = int.Parse(textBox1.Text);
                    peşinat = int.Parse(textBox2.Text);
                    adet = int.Parse(textBox3.Text);
                    taksit = int.Parse(comboBox3.Text);
                    if (taksit > 0)
                    {
                        label10.Text = "Aylık Tutar";
                        toplam = (fiyat * adet) - peşinat;
                        textBox5.Text = (peşinat +
                       toplam).ToString("C");
                        tutar = (toplam / taksit);
                        textBox4.Text = tutar.ToString("C");
                    }
                    else if (taksit == 0)
                    {
                        label10.Text = "Bakiye";
                        toplam = (fiyat * adet);
                        tutar = (toplam - peşinat);
                        textBox4.Text = tutar.ToString("C");
                        textBox5.Text = toplam.ToString("C");
                    }
                }
                catch
                {
                    MessageBox.Show("Alanları boş bırakmayın ve sayı girin");
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bilgisayar")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Vestel");
                comboBox2.Items.Add("Lenovo");
                comboBox2.Items.Add("Toshiba");
                comboBox2.Items.Add("Asus");
            }

            if (comboBox1.Text == "Cep Telefonu")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Samsung");
                comboBox2.Items.Add("LG");
                comboBox2.Items.Add("Asus");
                comboBox2.Items.Add("Lenovo");
                comboBox2.Items.Add("Iphone");
            }
            if (comboBox1.Text == "Kamera")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Panasonic");
                comboBox2.Items.Add("JVC");
                comboBox2.Items.Add("Sony");
                comboBox2.Items.Add("Canon");
            }
        }

       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.Text == "Vestel")
                {
                    textBox1.Text = "11500";
                    label9.Text = "10";
                }
                if (comboBox2.Text == "Lenovo")
                {
                    textBox1.Text = "15000";
                    label9.Text = "9";
                }
                if (comboBox2.Text == "Toshiba")
                 
 {
                    textBox1.Text = "12000";
                    label9.Text = "8";
                }
                if (comboBox2.Text == "Asus")
                {
                    textBox1.Text = "15600";
                    label9.Text = "5";
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.Text == "Samsung")
                {
                    textBox1.Text = "5000";
                }
                if (comboBox2.Text == "LG")
                {
                    textBox1.Text = "4000";
                }
                if (comboBox2.Text == "Asus")
                {
                    textBox1.Text = "3500";
                }
                if (comboBox2.Text == "Lenovo")
                {
                    textBox1.Text = "3000";
                }
                if (comboBox2.Text == "Iphone")
                {
                    textBox1.Text = "15000";
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.Text == "Panasonic")
                {
                    textBox1.Text = "1000";
                    label9.Text = "3";
                }
                if (comboBox2.Text == "JVC")
                {
                    textBox1.Text = "9000";
                    label9.Text = "2";
                }
            
            if (comboBox2.Text == "Sony")
                {
                    textBox1.Text = "1500";
                    label9.Text = "5";
                }
                if (comboBox2.Text == "Canon")
                {
                    textBox1.Text = "11000";
                    label9.Text = "6";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3.listBox1.Items.Add(textBox6.Text);
            frm3.listBox2.Items.Add(comboBox4.SelectedItem);
            frm3.listBox3.Items.Add(comboBox5.SelectedItem);
            if (checkBox1.Checked == true)
                frm3.listBox4.Items.Add("1. Sınıf");
            else if (checkBox2.Checked == true)
                frm3.listBox4.Items.Add("2. Sınıf");
            MessageBox.Show("Kayıt Eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frm3 aç
            frm3.Show();
            this.Hide();
        }
    }
    }
