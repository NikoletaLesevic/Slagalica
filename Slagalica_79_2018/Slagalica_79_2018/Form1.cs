using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;

namespace Slagalica_79_2018
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        Slagalica s = new Slagalica();
        RezultatiDB db = new RezultatiDB();
        Image muzika1 = Image.FromFile("muzika1.bmp");
        Image muzika0 = Image.FromFile("muzika0.bmp");
        private int brojac = 0;
        private int sec=0;
        private int min = 0;
        private int hour = 0;
        private string ime;
        private int mute = -1;
        private List<int> slicice = new List<int>();
        public Form1(string ime)
        {
            this.ime = ime;
            InitializeComponent();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "muzika.wav";
            player.Play();
            init();
        }
        private Image dajZnak(List<int> listaZnakova)
        {
            Random random = new Random();
            Image slicica;

            int pozicija = random.Next(listaZnakova.Count());
            int znak = listaZnakova[pozicija];
            listaZnakova.RemoveAt(pozicija);
            if (znak == 1)
            {
                slicica = s.srce;
            }
            else if (znak == 2)
            {
                slicica = s.karo;
            }
            else if (znak == 3)
            {
                slicica = s.tref;
            }
            else
            {
                slicica = s.pik;
            }
            return slicica;
        }
        private void init()
        {
            resetujTajmer();
            List<int> listaZnakova = new List<int>();

            for(int i=1;i<=4;i++)
            {
                listaZnakova.Add(i);
                listaZnakova.Add(i);
                listaZnakova.Add(i);
                listaZnakova.Add(i);
            }
            
            
            pictureBox1.Image = dajZnak(listaZnakova);
            pictureBox2.Image = dajZnak(listaZnakova);
            pictureBox3.Image = dajZnak(listaZnakova);
            pictureBox4.Image = dajZnak(listaZnakova);
            pictureBox5.Image = dajZnak(listaZnakova);
            pictureBox6.Image = dajZnak(listaZnakova);
            pictureBox7.Image = dajZnak(listaZnakova);
            pictureBox8.Image = dajZnak(listaZnakova);
            pictureBox9.Image = dajZnak(listaZnakova);
            pictureBox10.Image = dajZnak(listaZnakova);
            pictureBox11.Image = dajZnak(listaZnakova);
            pictureBox12.Image = dajZnak(listaZnakova);
            pictureBox13.Image = dajZnak(listaZnakova);
            pictureBox14.Image = dajZnak(listaZnakova);
            pictureBox15.Image = dajZnak(listaZnakova);
            pictureBox16.Image = dajZnak(listaZnakova);

            Random r = new Random();
            int prazno = r.Next(1, 17);

            if(prazno==1)
            {
                pictureBox1.Image = s.prazno;
            }
            if (prazno == 2)
            {
                pictureBox2.Image = s.prazno;
            }
            if (prazno == 3)
            {
                pictureBox3.Image = s.prazno;
            }
            if (prazno == 4)
            {
                pictureBox4.Image = s.prazno;
            }
            if (prazno == 5)
            {
                pictureBox5.Image = s.prazno;
            }
            if (prazno == 6)
            {
                pictureBox6.Image = s.prazno;
            }
            if (prazno == 7)
            {
                pictureBox7.Image = s.prazno;
            }
            if (prazno == 8)
            {
                pictureBox8.Image = s.prazno;
            }
            if (prazno == 9)
            {
                pictureBox9.Image = s.prazno;
            }
            if (prazno == 10)
            {
                pictureBox10.Image = s.prazno;
            }
            if (prazno == 11)
            {
                pictureBox11.Image = s.prazno;
            }
            if (prazno == 12)
            {
                pictureBox12.Image = s.prazno;
            }
            if (prazno == 13)
            {
                pictureBox13.Image = s.prazno;
            }
            if (prazno == 14)
            {
                pictureBox14.Image = s.prazno;
            }
            if (prazno == 15)
            {
                pictureBox15.Image = s.prazno;
            }
            if (prazno == 16)
            {
                pictureBox16.Image = s.prazno;
            }

            brojac = 0;
            label2.Text = brojac.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init();
        }
        private void kockica1()
        {
            if (pictureBox2.Image == s.prazno)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox1.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox5.Image == s.prazno)
            {
                pictureBox5.Image = pictureBox1.Image;
                pictureBox1.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica2()
        {
            if (pictureBox1.Image == s.prazno)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox2.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox3.Image == s.prazno)
            {
                pictureBox3.Image = pictureBox2.Image;
                pictureBox2.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox6.Image == s.prazno)
            {
                pictureBox6.Image = pictureBox2.Image;
                pictureBox2.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica3()
        {
            if (pictureBox2.Image == s.prazno)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox3.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox4.Image == s.prazno)
            {
                pictureBox4.Image = pictureBox3.Image;
                pictureBox3.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox7.Image == s.prazno)
            {
                pictureBox7.Image = pictureBox3.Image;
                pictureBox3.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica4()
        {
            if (pictureBox3.Image == s.prazno)
            {
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox8.Image == s.prazno)
            {
                pictureBox8.Image = pictureBox4.Image;
                pictureBox4.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica5()
        {
            if (pictureBox1.Image == s.prazno)
            {
                pictureBox1.Image = pictureBox5.Image;
                pictureBox5.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox9.Image == s.prazno)
            {
                pictureBox9.Image = pictureBox5.Image;
                pictureBox5.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox6.Image == s.prazno)
            {
                pictureBox6.Image = pictureBox5.Image;
                pictureBox5.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica6()
        {
            if (pictureBox2.Image == s.prazno)
            {
                pictureBox2.Image = pictureBox6.Image;
                pictureBox6.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox5.Image == s.prazno)
            {
                pictureBox5.Image = pictureBox6.Image;
                pictureBox6.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox7.Image == s.prazno)
            {
                pictureBox7.Image = pictureBox6.Image;
                pictureBox6.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox10.Image == s.prazno)
            {
                pictureBox10.Image = pictureBox6.Image;
                pictureBox6.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica7()
        {
            if (pictureBox3.Image == s.prazno)
            {
                pictureBox3.Image = pictureBox7.Image;
                pictureBox7.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox6.Image == s.prazno)
            {
                pictureBox6.Image = pictureBox7.Image;
                pictureBox7.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox8.Image == s.prazno)
            {
                pictureBox8.Image = pictureBox7.Image;
                pictureBox7.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox11.Image == s.prazno)
            {
                pictureBox11.Image = pictureBox7.Image;
                pictureBox7.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica8()
        {
            if (pictureBox4.Image == s.prazno)
            {
                pictureBox4.Image = pictureBox8.Image;
                pictureBox8.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox7.Image == s.prazno)
            {
                pictureBox7.Image = pictureBox8.Image;
                pictureBox8.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox12.Image == s.prazno)
            {
                pictureBox12.Image = pictureBox8.Image;
                pictureBox8.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica9()
        {
            if (pictureBox5.Image == s.prazno)
            {
                pictureBox5.Image = pictureBox9.Image;
                pictureBox9.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox10.Image == s.prazno)
            {
                pictureBox10.Image = pictureBox9.Image;
                pictureBox9.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox13.Image == s.prazno)
            {
                pictureBox13.Image = pictureBox9.Image;
                pictureBox9.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica10()
        {
            if (pictureBox6.Image == s.prazno)
            {
                pictureBox6.Image = pictureBox10.Image;
                pictureBox10.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox9.Image == s.prazno)
            {
                pictureBox9.Image = pictureBox10.Image;
                pictureBox10.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox11.Image == s.prazno)
            {
                pictureBox11.Image = pictureBox10.Image;
                pictureBox10.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox14.Image == s.prazno)
            {
                pictureBox14.Image = pictureBox10.Image;
                pictureBox10.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica11()
        {
            if (pictureBox7.Image == s.prazno)
            {
                pictureBox7.Image = pictureBox11.Image;
                pictureBox11.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox10.Image == s.prazno)
            {
                pictureBox10.Image = pictureBox11.Image;
                pictureBox11.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox12.Image == s.prazno)
            {
                pictureBox12.Image = pictureBox11.Image;
                pictureBox11.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox15.Image == s.prazno)
            {
                pictureBox15.Image = pictureBox11.Image;
                pictureBox11.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica12()
        {
            if (pictureBox8.Image == s.prazno)
            {
                pictureBox8.Image = pictureBox12.Image;
                pictureBox12.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox11.Image == s.prazno)
            {
                pictureBox11.Image = pictureBox12.Image;
                pictureBox12.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox16.Image == s.prazno)
            {
                pictureBox16.Image = pictureBox12.Image;
                pictureBox12.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica13()
        {
            if (pictureBox9.Image == s.prazno)
            {
                pictureBox9.Image = pictureBox13.Image;
                pictureBox13.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox14.Image == s.prazno)
            {
                pictureBox14.Image = pictureBox13.Image;
                pictureBox13.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica14()
        {
            if (pictureBox13.Image == s.prazno)
            {
                pictureBox13.Image = pictureBox14.Image;
                pictureBox14.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox10.Image == s.prazno)
            {
                pictureBox10.Image = pictureBox14.Image;
                pictureBox14.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox15.Image == s.prazno)
            {
                pictureBox15.Image = pictureBox14.Image;
                pictureBox14.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica15()
        {
            if (pictureBox11.Image == s.prazno)
            {
                pictureBox11.Image = pictureBox15.Image;
                pictureBox15.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox14.Image == s.prazno)
            {
                pictureBox14.Image = pictureBox15.Image;
                pictureBox15.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox16.Image == s.prazno)
            {
                pictureBox16.Image = pictureBox15.Image;
                pictureBox15.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }
        private void kockica16()
        {
            if (pictureBox12.Image == s.prazno)
            {
                pictureBox12.Image = pictureBox16.Image;
                pictureBox16.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
            if (pictureBox15.Image == s.prazno)
            {
                pictureBox15.Image = pictureBox16.Image;
                pictureBox16.Image = s.prazno;
                brojac++;
                label2.Text = brojac.ToString();
                provera();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            kockica1();
            
        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            kockica2();
        }
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            kockica3();
        }
        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            kockica4();
        }
        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            kockica5();
        }
        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            kockica6();
        }
        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            kockica7();
        }
        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            kockica8();
        }
        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            kockica9();
        }
        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            kockica10();
        }
        private void pictureBox11_DoubleClick(object sender, EventArgs e)
        {
            kockica11();
        }
        private void pictureBox12_DoubleClick(object sender, EventArgs e)
        {
            kockica12();
        }
        private void pictureBox13_DoubleClick(object sender, EventArgs e)
        {
            kockica13();
        }
        private void pictureBox14_DoubleClick(object sender, EventArgs e)
        {
            kockica14();
        }
        private void pictureBox15_DoubleClick(object sender, EventArgs e)
        {
            kockica15();
        }
        private void pictureBox16_DoubleClick(object sender, EventArgs e)
        {
            kockica16();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Želite da napustite igru?", "Slagalica", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void provera()
        {
            if(jeKraj()==1)
            {
                int brPoteza = int.Parse(label2.Text);
                int vreme = int.Parse(sekunde.Text) + int.Parse(minuti.Text) * 60 + int.Parse(sati.Text) * 3600;
                db.upisiRezultat(this.ime, brPoteza,vreme);
                DialogResult dR = MessageBox.Show("Uspešno ste završili igru. Da li želite da počnete novu?", "Slagalica", MessageBoxButtons.YesNo);
                if (dR == DialogResult.Yes)
                {
                    init();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private int jeKraj()
        {
            Image a = pictureBox1.Image;
            Image b = pictureBox2.Image;
            Image c = pictureBox3.Image;
            Image d = pictureBox4.Image;
            Image e = pictureBox5.Image;
            Image f = pictureBox6.Image;
            Image g = pictureBox7.Image;
            Image h = pictureBox8.Image;
            Image i = pictureBox9.Image;
            Image j = pictureBox10.Image;
            Image k = pictureBox11.Image;
            Image l = pictureBox12.Image;
            Image m = pictureBox13.Image;
            Image n = pictureBox14.Image;
            Image o = pictureBox15.Image;
            Image pp = pictureBox16.Image;
            Image p = s.prazno;

            int flag = 0;

            //provera prve kolone
            if(a==p | e==p | i==p | m==p)
            {
                if (a == e && e == i) flag = 1;
                if (a == e && e == m) flag = 1;
                if (a == i && i == m) flag = 1;
                if (e == i && i == m) flag = 1;

                if (flag == 0) return 0;
            }
            else
            {
                if(a==e && e==i && i==m)
                {
                    flag = 1;
                }
                else
                {
                    return 0;
                }
            }

            //provera druge kolone
            if (b == p | f == p | j == p | n == p)
            {
                if (b == f && f == j) flag = 1;
                if (b == f && f == n) flag = 1;
                if (b == j && j == n) flag = 1;
                if (f == j && j == n) flag = 1;

                if (flag == 0) return 0;
            }
            else
            {
                if (b == f && f == j && j == n)
                {
                    flag = 1;
                }
                else
                {
                    return 0;
                }
            }

            //provera trece kolone
            if (c == p | g == p | k == p | o == p)
            {
                if (c == g && g == k) flag = 1;
                if (c == g && g == o) flag = 1;
                if (c == k && k == o) flag = 1;
                if (g == k && k == o) flag = 1;

                if (flag == 0) return 0;
            }
            else
            {
                if (c == g && g == k && k == o)
                {
                    flag = 1;
                }
                else
                {
                    return 0;
                }
            }

            //provera cetvrte kolone
            if (d == p | h == p | l == p | pp == p)
            {
                if (d == h && h == l) flag = 1;
                if (d == h && h == pp) flag = 1;
                if (d == l && l == pp) flag = 1;
                if (h == l && l == pp) flag = 1;

                if (flag == 0) return 0;
            }
            else
            {
                if (d == h && h == l && l == pp)
                {
                    flag = 1;
                }
                else
                {
                    return 0;
                }
            }

            return flag;
        }

        private void resetujTajmer()
        {
            sec = 0;
            min = 0;
            hour = 0;
            sekunde.Text = sec.ToString();
            minuti.Text = min.ToString();
            sati.Text = hour.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            sekunde.Text = sec.ToString();
            if(sec==60)
            {
                min++;
                minuti.Text = min.ToString();
                sec = 0;
                sekunde.Text = sec.ToString();
            }
            if(min==60)
            {
                hour++;
                sati.Text = hour.ToString();
                min = 0;
                minuti.Text = min.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 rezultati = new Form3();
            rezultati.ShowDialog();
        }

        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica1();
        }

        private void pictureBox2_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica2();
        }

        private void pictureBox3_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica3();
        }

        private void pictureBox4_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica4();
        }

        private void pictureBox5_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica5();
        }

        private void pictureBox6_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica6();
        }

        private void pictureBox7_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica7();
        }

        private void pictureBox8_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica8();
        }

        private void pictureBox9_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica9();
        }

        private void pictureBox10_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica10();
        }

        private void pictureBox11_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica11();
        }

        private void pictureBox12_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica12();
        }

        private void pictureBox13_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica13();
        }

        private void pictureBox14_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica14();
        }

        private void pictureBox15_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica15();
        }

        private void pictureBox16_MouseCaptureChanged(object sender, EventArgs e)
        {
            kockica16();
        }
        private int kodirajSlicicu(Image i)
        {
            if (i == s.srce) return 1;
            if (i == s.karo) return 2;
            if (i == s.tref) return 3;
            if (i == s.pik) return 4;
            if (i == s.prazno) return 5;

            return 0;
        }
        private void sacuvajSlicice()
        {
            slicice.Add(kodirajSlicicu(pictureBox1.Image));
            slicice.Add(kodirajSlicicu(pictureBox2.Image));
            slicice.Add(kodirajSlicicu(pictureBox3.Image));
            slicice.Add(kodirajSlicicu(pictureBox4.Image));
            slicice.Add(kodirajSlicicu(pictureBox5.Image));
            slicice.Add(kodirajSlicicu(pictureBox6.Image));
            slicice.Add(kodirajSlicicu(pictureBox7.Image));
            slicice.Add(kodirajSlicicu(pictureBox8.Image));
            slicice.Add(kodirajSlicicu(pictureBox9.Image));
            slicice.Add(kodirajSlicicu(pictureBox10.Image));
            slicice.Add(kodirajSlicicu(pictureBox11.Image));
            slicice.Add(kodirajSlicicu(pictureBox12.Image));
            slicice.Add(kodirajSlicicu(pictureBox13.Image));
            slicice.Add(kodirajSlicicu(pictureBox14.Image));
            slicice.Add(kodirajSlicicu(pictureBox15.Image));
            slicice.Add(kodirajSlicicu(pictureBox16.Image));
        }
        private Image dekodirajSlicicu(int i)
        {
            if (i == 1) return s.srce;
            if (i == 2) return s.karo;
            if (i == 3) return s.tref;
            if (i == 4) return s.pik;
            if (i == 5) return s.prazno;

            return null;
        }
        private void ucitajSlicice(List<int> slicice)
        {
            pictureBox1.Image = dekodirajSlicicu(slicice[0]);
            pictureBox2.Image = dekodirajSlicicu(slicice[1]);
            pictureBox3.Image = dekodirajSlicicu(slicice[2]);
            pictureBox4.Image = dekodirajSlicicu(slicice[3]);
            pictureBox5.Image = dekodirajSlicicu(slicice[4]);
            pictureBox6.Image = dekodirajSlicicu(slicice[5]);
            pictureBox7.Image = dekodirajSlicicu(slicice[6]);
            pictureBox8.Image = dekodirajSlicicu(slicice[7]);
            pictureBox9.Image = dekodirajSlicicu(slicice[8]);
            pictureBox10.Image = dekodirajSlicicu(slicice[9]);
            pictureBox11.Image = dekodirajSlicicu(slicice[10]);
            pictureBox12.Image = dekodirajSlicicu(slicice[11]);
            pictureBox13.Image = dekodirajSlicicu(slicice[12]);
            pictureBox14.Image = dekodirajSlicicu(slicice[13]);
            pictureBox15.Image = dekodirajSlicicu(slicice[14]);
            pictureBox16.Image = dekodirajSlicicu(slicice[15]);
        }

        //serijalizacija igre
        private void button4_Click(object sender, EventArgs e)
        {
            slicice.Clear();
            sacuvajSlicice();
            Sacuvano s = new Sacuvano(brojac, sec, min, hour, slicice);
            IFormatter f = new BinaryFormatter();
            Stream st = new FileStream(@"../../Serijalizacija/serijalizacija.txt", FileMode.Create, FileAccess.Write);
            st.Flush();
            f.Serialize(st, s);
            st.Close();
            MessageBox.Show("Igra je uspešno sačuvana.");
            this.Close();
            
        }
        //deserijalizacija igre
        private void button5_Click(object sender, EventArgs e)
        {
            IFormatter f = new BinaryFormatter();
            if (File.Exists(@"../../Serijalizacija/serijalizacija.txt"))
            {
                Stream st = new FileStream(@"../../Serijalizacija/serijalizacija.txt", FileMode.Open, FileAccess.Read);
                Sacuvano s = (Sacuvano)f.Deserialize(st);
                brojac = s.brPoteza;
                label2.Text = brojac.ToString();
                sec = s.sekunde;
                sekunde.Text = sec.ToString();
                min = s.minuti;
                minuti.Text = min.ToString();
                hour = s.sati;
                sati.Text = hour.ToString();

                ucitajSlicice(s.slicice);
                st.Close();
            }
            else
            {
                MessageBox.Show("Trenutno nemate sačuvanu igru.");
            }

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (mute == -1)
            {
                pictureBox17.Image = muzika0;
                player.Stop();
            }
            else
            {
                pictureBox17.Image = muzika1;
                player.Play();
            }
            mute *= -1;
        }
    }
}
