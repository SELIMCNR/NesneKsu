using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                textBox1.Text = i.ToString();
                listBox1.Items.Add(i);
            }

          
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < 15; i++)
            {
                listBox1.Items.Add(i);
                toplam += i; 
            }
            listBox1.Items.Add("====");
            listBox1.Items.Add(toplam);

            
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // listeyi temizler
            string mesaj = textBox1.Text;
            for (int i = 0; i < 15; i++)
            {
                listBox1.Items.Add(mesaj);
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            int toplam=0 ;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            for (int i = sayi1; i < sayi2; i++)
            {
             
                listBox1.Items.Add(i);
                    toplam += i;
                
            }
            listBox1.Items.Add("toplam : "+toplam);
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            //Tek ve çift sayı üretmek 
            comboBox1.Items.Clear ();
            comboBox2.Items.Clear();
            int tekToplam=0, çiftToplam = 0;
            int sayı1, sayı2;
            textBox4.Text = "";
            textBox5.Text = "";
            sayı1 = Convert.ToInt32(textBox6.Text.ToString());
            sayı2 = Convert.ToInt32(textBox7.Text.ToString());


            for (int i= sayı1;  i<=sayı2; i++)
            {
               if(i % 2 != 0)
                {
                    comboBox1.Items.Add(i);
                    tekToplam += i;
                }
               else
                {
                    comboBox2.Items.Add(i);
                    çiftToplam += i;
                }
                textBox4.Text = tekToplam.ToString();
                textBox5.Text = çiftToplam.ToString();

                
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            char i;
            for ( i = 'a'; i < 'z'; i++) { 
                listBox1.Items.Add(i);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i, j;
            for ( i = 1; i <=10; i++)
            {           
                for(j= 1; j <= 10; j++)
                {

                
                    listBox1.Items.Add(i+"*"+j+"="+i * j);
                }

            }
        }

     

        private void button8_Click(object sender, EventArgs e)
        {
            //break for döngüsünü kırar tekrar başa döner
            listBox1.Items.Clear();
            int toplam = 0;
            int i = 0;
            for (; ; ) //sonsuz döngü
            {
                if (i > 50)
                {
                    break; // durdurur
                }
                toplam += i;
                i++;
                listBox1.Items.Add(i);

            }
            listBox1.Items.Add("Toplam : " + toplam);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for(; ; ) // sonsuz döngü
            {
                //listBox1.Items.Add();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int baslangıc, bitis, i;

            listBox2.BackColor = Color.BlueViolet;

            baslangıc = int.Parse(textBox8.Text);
            bitis = int.Parse(textBox9.Text);
            
            if(checkBox1.Checked==true && checkBox2.Checked == false)
            {
                for (i = baslangıc; i <= bitis;i ++)
                {
                    if (i % 2 == 1)
                    {
                        listBox2.Items.Add(i);
                    }
                }
            }
            if(checkBox2.Checked == false && checkBox1.Checked == true)
            {
                for (i = baslangıc;  i<=bitis; i++)
                {
                    if (i % 2 == 0)
                    {
                        listBox2.Items.Add(i);
                    }
                }
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                for (i = 0; i <= bitis; i++)
                {
                    listBox2.Items.Add(i);
                }
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = 26;
            int b;


            textBox10.Text = a.ToString();
            b = int.Parse(textBox10.Text);
            label7.Text= b.ToString();
        }
    }
}
