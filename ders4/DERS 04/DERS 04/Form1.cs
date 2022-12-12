using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vBasic = Microsoft.VisualBasic.Interaction;  // Visual basic kodları eklendi

namespace DERS_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            while (a < 10)
            {
                listBox1.Items.Add(a);    //Değeri listbox1 olan form elemanına aktardık.
                a++;  // değeri 1'er 1'er artırdık
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();  // listBox1 içerisindeki verileri temizle
            int sayac = 0;    // Sayac tanımı 
            int sayı = Convert.ToInt32(textBox1.Text); // Dışardan sayı değişkenine değer aldık
            while (sayı > sayac)
            {
                listBox1.Items.Add(sayac); //lisBbox1 form elemanına sayı değerleri eklendi 
                sayac++;  // sayac değeri artırıldı.
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2;
            int toplam = 0;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            while (sayı2 <= sayı1)
            {
                toplam += sayı2;
                sayı2++;
                listBox1.Items.Add(toplam);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplamdeger = 0, i = 0;

            while (i <= 20)
            {
                i++;
                if (i % 2 != 0)
                {
                    continue; // Döngü bu kısım hariç devam eder
                }
                toplamdeger += i;
            }
            listBox1.Items.Add(toplamdeger);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplamdeger = 0, i = 0;

            while (true)    // doğru olduğunca döndür
            {
                if (i > 20) // i 20 den büyükse 
                {
                    break; // döngüyü durdur
                }
                toplamdeger += i; // toplam i' yi ekle
                i += 2;  // i = i + 2  
            }
            listBox1.Items.Add(toplamdeger);  // form elamanına toplamdegeri ekle
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Do while ile şifre kontrolü 
            string kullaniciadi = "";
            string sifre = "";
            do
            {
                kullaniciadi = textBox1.Text;  // textbox1'e gelen değer alınır 
                sifre = textBox2.Text;  // textBox2 ' ye gelen değer alınır 
            } while (kullaniciadi != "ali" || sifre != "123");
            MessageBox.Show("Kullanıcı ve şifre doğru "); // mesajı göster komutu
        }

        private void Form1_Load(object sender, EventArgs e)
        {  // form açılış şifresi isteme
            string şifre;
            int i = 0;
            do
            {
                if (i > 4)
                {
                    MessageBox.Show("Üç hakkınızda bilemediniz"); // mesajı gösterir
                    this.Close(); // formu kapatır
                    break; //döngü bitti
                }

                şifre = vBasic.InputBox("Şifreyi girin", "ŞİFRE", "Şifre Girişi", 0, 0);  // dışardan şifre aldık visual basic ile
                i++;

            }
            while (şifre != "1234");


        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] sifreler = { "A", "B", "C" };
            foreach (string sifre in sifreler) {
                listBox1.Items.Add(sifre);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Tahmin bulma 
            listBox1.Items.Clear();
            textBox3.Text = "";
            int kalanhak = 10, puan = 110;
            textBox3.Text = kalanhak.ToString();
            string tahminMetin;
            int tahmin;
            Random rastgele = new Random();
            int tutulansayı = rastgele.Next(0, 100);

            do
            {
                tahminMetin = vBasic.InputBox("Tahmininizi girin..:", "TAhmin", "", 0, 0);
                if (tahminMetin != "")
                    tahmin = int.Parse(tahminMetin);
                else tahmin = 0;
                textBox3.Text += tahmin.ToString() + "\n";
                puan -= 10;
                if (tahmin > tutulansayı) MessageBox.Show("Aşağı sayı gir");
                else if (tahmin < tutulansayı) MessageBox.Show("Yukarı sayı gir");
                else if (tahmin == tutulansayı)
                {
                    MessageBox.Show("Tebrikler..." + puan);
                }
                kalanhak--;
                textBox3.Text = kalanhak.ToString();
                if (kalanhak == 0)
                {
                    MessageBox.Show("Hakkınız taze bitti");
                    listBox1.Items.Clear();
                    textBox3.Text = "";
                }
            } while (tahmin != tutulansayı && kalanhak > 0);


        }

        private void button9_Click(object sender, EventArgs e)
        {  // Foreach örneği 
            int[] dizielamanı = { 10, 20, 30, 50, 60, 70, 100, 21, 3, 2 };
            int diziToplam = 0;
            foreach (int toplam in dizielamanı)
            {
                diziToplam += toplam;
            }
            listBox2.Items.Add(diziToplam);
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string []  dizielamanı = new string[10] {"ali","veli","hasan","osman","turgut","alperen","halime","leyla","saime","serin"};
            foreach (string tekeleman in dizielamanı)
            {
                listBox3.Items.Add(tekeleman);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (object eleman in listBox3.Items)
            {
                listBox2.Items.Add(eleman);
            }
        }
    }
}
