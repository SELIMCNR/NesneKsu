using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //parse = klavyeden girilen değeri sayıya dönüştürür.
        //convert = girilen değeri sayıya yada başka bir değere dönüştürür. 
        // int32,int64,int 16 = matematiksel işlemlerde buna çevrilir.
        // Convert.ToInt gibi vs
        private void button1_Click(object sender, EventArgs e)
        {     //sByte .....: -128-127 arası tam sayı saklamaya yarar.
            
            SByte kucuksayi;
            
            int değer = 501;
            kucuksayi = (SByte)değer;
            this.Text = kucuksayi.ToString();
            

            label1.Text = kucuksayi.ToString();

            textBox1.Text = kucuksayi.ToString();

            // mavi renkli olanlar değişkenler
            //siyah renki olan forma elemanları 
            //Sarı renkli olan yapısal eleman dönüştürme işlemi yapar.
            //ToString()  değeri metine çevirir ve bizr gösterir
        }

        private void button2_Click(object sender, EventArgs e)
        { //Byte 0-255 arası tam sayı değişken saklar 
            Byte değer;
            int tamsayi = 100;
            değer = (Byte)tamsayi;
            label1.Text = değer.ToString();
            textBox1.Text = değer.ToString();
            

            
        }

        private void Short_Click(object sender, EventArgs e)
        { //Short:-32768,+32767 arası tamsayı değer saklamaya yarar.
            short değer;
            int tamsayi;
            tamsayi = 257;
            değer = (short)tamsayi;
            label1.Text = değer.ToString();
            textBox1.Text = değer.ToString();


        }

        private void Int_Click(object sender, EventArgs e)
        {   // int: -2.147.483.648 -+ 2.147.483.647  arası değer alan tam sayı tipidir.
            int değer;
            double sayi = 100.85;
            değer = (int)sayi;
            textBox1.Text = değer.ToString();
            label1.Text = değer.ToString();

            // Uint yada başında U olursa pozitif sayılar olur.

        }

        private void Uınt_Click(object sender, EventArgs e)
        { //uint:0-4.294.967.295 arası pozitif tam sayılar
            
            uint deger;
            double sayi = 100.86;
            deger = Convert.ToUInt32(sayi);         //50den aşagı yada yukarı yuvarlar
            textBox1.Text = deger.ToString();
            label1.Text = deger.ToString();


        }

        private void Long_Click(object sender, EventArgs e)
        {
            // Long: uzun tamsayı değişkenler için kullanılır
            long deger;
            double sayi = 100.85;
            deger = Convert.ToUInt32(sayi);
            textBox1.Text=deger.ToString();
            label1.Text = deger.ToString();
        }

        private void Float_Click(object sender, EventArgs e)
        {  //Float...: Ondalıklı sayı tipi saklamaya yarar.
            float deger;
            int ilksayi = 20, sonsayi = 6;
            deger = (float) ilksayi / sonsayi;
            textBox1.Text = deger.ToString();
            label1.Text = deger.ToString();


        }

        private void decımal_Click(object sender, EventArgs e)
        {//decimal: ondalıklı sayı tanımlamak içindir.
            decimal deger;
            int ilksayi = 20, sonsayi = 6;
            deger = (decimal) ilksayi / sonsayi;
            textBox1.Text = deger.ToString();
            label1.Text = deger.ToString();
        }

        private void Double_Click(object sender, EventArgs e)
        { //Double : 64 bit ondalıklı değer saklar
            double deger;
            int ilksayi = 20, sonsayi = 6;
            deger =(double) ilksayi / sonsayi;
            textBox1.Text = deger.ToString();
            label1.Text = deger.ToString();

        }

        private void String_Click(object sender, EventArgs e)
        {  // string = alfasayısal değer tanımlamaya yarar
            string metin;
            metin = textBox1.Text; // textboxa yazılan metni kaydeder
            MessageBox.Show(metin + "Hoşgeldin");

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Girilen karakteri ascI kod karşılığı
            listBox1.Items.Clear();
            string değer;
            char[] karakter;
            byte[] numara;

            değer = textBox1.Text;
            karakter = değer.ToCharArray(); // karakter dizisinde değer döndürür.
            numara = System.Text.Encoding.UTF8.GetBytes(karakter);
           
            for (int  i = 0;  i <karakter.Length;  i++)
            {
                listBox1.Items.Add(karakter[i]+" = " + numara[i]);
                textBox1.Text = "";
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {   //Tarih Zaman 

            DateTime tarihsaat;
            tarihsaat = DateTime.Now;
            MessageBox.Show(tarihsaat.ToString());



        }

        private void Const_Click(object sender, EventArgs e)
        {
            //Const sabit tanımlamak için kullanılır
            const double pisayısı = Math.PI;
            double yarıcap, alan;
            yarıcap = Convert.ToDouble(textBox1.Text);
            alan = pisayısı *yarıcap * yarıcap;
            MessageBox.Show(alan.ToString());
            listBox1.Items.Add(alan.ToString());

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            //toplama
            int sayi1, sayi2;
            double sonuc = 0;
            sayi1= Convert.ToInt32(textBox2.Text);
            sayi2= Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 + sayi2;
            label1.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cikarma
            int sayi1, sayi2;
            double sonuc = 0;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 - sayi2;
            label1.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //carpma
            int sayi1, sayi2;
            double sonuc = 0;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 * sayi2;
            label1.Text = sonuc.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //bolme
            int sayi1, sayi2;
            double sonuc = 0;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            sonuc = sayi1 / sayi2;
            label1.Text = sonuc.ToString();
        }
    }
}
