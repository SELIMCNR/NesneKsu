using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Dosya işlemleri giriş çıkış eklendi

namespace ders7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yer = -1;
        int ind;
        string aranan;
        int toplamind;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Dizi oluşturma
            string[] meslekler = { "Mühendis", "Öğretmen","Öğrenci","Müdür","Pazarlama","Memur","Tekniker","Sıvacı","Elektrikçi","Makinacı"};
            string[] birimler = { "Satış", "Eğitim", "Satın Alma", "Okul", "İdari Kadro", "Teknik eleman"};
            
            
            comboBox1.Items.AddRange(meslekler); // comboBoxa dizi elemanları eklendi
            comboBox2.Items.AddRange(birimler);

         try
            {
                System.IO.TextReader dosya = System.IO.File.OpenText("per.dat"); // per.data içerisine dosya yazılacak
                string satır;
                while ((satır = dosya.ReadLine())!=null)
                {
                    listBox1.Items.Add(satır);
                    satır = dosya.ReadLine();
                    listBox2.Items.Add(satır);
                    satır = dosya.ReadLine();
                    listBox3.Items.Add(satır);
                
                }
                dosya.Close();
            }

           catch
            {
                ;
            }

            label6.Text = listBox1.Items.Count.ToString();
            label8.Text = listBox1.SelectedIndex + 1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yer = listBox1.FindStringExact(textBox1.Text); // girilen bilgiyi ara 
            if(yer <0)  //listede yoksa
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(comboBox1.Text);
                listBox3.Items.Add(comboBox2.Text);
                label6.Text = listBox1.Items.Count.ToString(); // personel sayısı verir
            }
            else
            {
                listBox1.SelectedIndex = yer; // aynı elemanı ekletmez
                MessageBox.Show("Bu eleman daha önce kaydedildi...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.TextWriter dosya = System.IO.File.CreateText("per.dat"); // per.dat a kayıt yap 
            for (int i = 0; i < listBox1.Items.Count; i++) // listbox1 içerisini say 
            {

                dosya.WriteLine(listBox1.Items[i]); //  for döngüsünden gelen bilgileri dosya adı altında per.data kaydet
                dosya.WriteLine(listBox2.Items[i]);
                dosya.WriteLine(listBox3.Items[i]); 
            }
            dosya.Close();   // dosyayı kapat 
            textBox1.Text = "";    // içlerini boşalt                                       
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   // indexleme 
            ind = (sender as ListBox).SelectedIndex;   // üç listobaxa özelliklerden ekle 
            listBox1.SelectedIndex = ind;              //listBox1 seçili index hepsini seçer
            listBox2.SelectedIndex = ind;
            listBox3.SelectedIndex = ind;

            toplamind = (sender as ListBox).TopIndex;
            listBox3.TopIndex = toplamind;
            listBox2.TopIndex = toplamind;
            listBox1.TopIndex = toplamind;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ara bul 
            aranan = textBox2.Text;
            yer = listBox1.FindStringExact(aranan); // arama yapar 0 < ise bulamadı 0> ise buldu 
            if (yer < 0)
            {
                yer = listBox1.FindString(aranan);
                if(yer <0)
                {
                    MessageBox.Show("Aranan kayıt bulunamadı...");
                }
                
            }
            if (yer >= 0)
            {
                listBox1.SelectedIndex = yer; // aranan kayıt bulunduysa konumlanır...
               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (yer <listBox1.Items.Count-1)            
                yer = listBox1.FindString(aranan, yer);
            if (yer >= 0)
            {
                listBox1.SelectedIndex = yer;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Önce silinecek bir kayıt seçin");
                return;
                textBox1.Focus();
            }
            int indd;
            DialogResult sil;
            indd = listBox1.SelectedIndex;
            sil = MessageBox.Show(listBox1.SelectedItem+"Silinsin mi", "Sil", MessageBoxButtons.YesNo);
        if(sil == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(indd);
                listBox2.Items.RemoveAt(indd);
                listBox3.Items.RemoveAt(indd);
                label6.Text = listBox1.Items.Count.ToString();
            }
        
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.IO.TextWriter dosya = System.IO.File.CreateText("per.dat"); // per.dat a kayıt yap 
            for (int i = 0; i < listBox1.Items.Count; i++) // listbox1 içerisini say 
            {

                dosya.WriteLine(listBox1.Items[i]); //  for döngüsünden gelen bilgileri dosya adı altında per.data kaydet
                dosya.WriteLine(listBox2.Items[i]);
                dosya.WriteLine(listBox3.Items[i]);
            }
            dosya.Close();   // dosyayı kapat 
            textBox1.Text = "";    // içlerini boşalt                                       
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ind;
            string adsoyad, meslek, birim;
            adsoyad = textBox1.Text;
            meslek = comboBox1.Text;
            birim = comboBox2.Text;

            ind = listBox1.SelectedIndex;
            if(ind < 0)
            {
                MessageBox.Show("Bir kayıt seçin");
            }
            else
            {
                listBox1.Items[ind] = adsoyad;
                listBox2.Items[ind] = meslek;
                listBox3.Items[ind] = birim;
            }

        }
    }
}
