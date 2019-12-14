using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace SpaceGame
{
    public partial class SpaceForm : Form
    {
        WindowsMediaPlayer oyunMuzigi;
        WindowsMediaPlayer vur;
        WindowsMediaPlayer patlama;
        PictureBox[] yildizlar; // arkaplandaki yukarıdan aşağıya doğru kayan yıldızlar 
        PictureBox[] dusmanlar;
        PictureBox[] mermiler;
        PictureBox[] dusmanMermi;
        Random rnd; // ekrandaki kayan yıldızların pozisyonu için bir random değer

        int arkaplanHiz; // görüleceği üzere arkaplan hareket ediyor.. Arkaplan hızını ArkaPlanHiz ile ayarlayacağız.    
        int mermiHizi;
        int uzayGemisiHizi;
        int dusmanHizi;
        int dusmanMermiHizi;    
        int skor;
        int seviye;
        int zorluk;
        bool durdur;
        bool oyunBitti;

        public SpaceForm()
        {
            InitializeComponent();
        }

        private void SpaceForm_Load(object sender, EventArgs e)
        {
            // değişkenler oluşturuluyor
            durdur = false; // oyun başlarken true olması yanlış olur.
            oyunBitti = false; // oyun başlarken true olması yanlış olur.
            arkaplanHiz = 3; // hızı set ettik
            dusmanMermiHizi = 4;
            mermiHizi = 20; // mermimizin hızı
            uzayGemisiHizi = 6; // gemimizin hızı
            dusmanHizi = 4;
            skor = 0; // düşman gemilerini vurdukça birer birer artar
            seviye = 1; 
            zorluk = 9; // zorluk seviyesi 9 dan 0 a doğru gidiyor. Yani en zor seviye 0. seviye

            // oyun müzikleri ve ses dosyaları oluşturuluyor
            oyunMuzigi = new WindowsMediaPlayer();
            vur = new WindowsMediaPlayer();
            patlama = new WindowsMediaPlayer();

            // oyun müzikleri ve ses dosyaları bilgisayardaki ses dosyalarıyla eşleştiriliyor
            oyunMuzigi.URL = "songs\\GameSong.mp3";
            vur.URL = "songs\\shoot.mp3";
            patlama.URL = "songs\\boom.mp3";

            // oyun müzikleri ve ses dosyaları ayarları
            oyunMuzigi.settings.setMode("loop", true);
            oyunMuzigi.settings.volume = 5;
            vur.settings.volume = 1;
            patlama.settings.volume = 6;

            // resim dosyaları
            Image dusman1 = Image.FromFile("asserts\\E1.png");
            Image dusman2 = Image.FromFile("asserts\\E2.png");
            Image dusman3 = Image.FromFile("asserts\\E3.png");
            Image boss1 = Image.FromFile("asserts\\Boss1.png");
            Image boss2 = Image.FromFile("asserts\\Boss2.png");
            Image mermi = Image.FromFile("asserts\\munition.png");

            // resim dosyaları için PictureBox arrayları oluşturuluyor
            yildizlar = new PictureBox[10];
            dusmanlar = new PictureBox[10];
            mermiler = new PictureBox[3];
            dusmanMermi = new PictureBox[10];
            
            rnd = new Random(); // arkaplan yıldızlarının rastgele ekrana dağılması için kullanılacak olan Random değişken

            // arkaplandaki yıldızların formasyonu ve renklerinin definasyonu
            for (int i = 0; i < yildizlar.Length; i++)
            {
                yildizlar[i] = new PictureBox(); // yıldızları nokta şeklinde gösteriyoruz. Yani bir resim dosyası kullanmıyoruz
                yildizlar[i].BorderStyle = BorderStyle.Fixed3D;
                yildizlar[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400)); // yıldızların lokasyonunun tanımlanması
                if (i % 2 == 1)
                {
                    yildizlar[i].Size = new Size(2, 2);
                    yildizlar[i].BackColor = Color.Wheat;
                }
                else
                {
                    yildizlar[i].Size = new Size(3, 3);
                    yildizlar[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(yildizlar[i]);
            }

            // düşmanlar[] picturebox arrayı initialize ediliyor
            for (int i = 0; i < dusmanlar.Length; i++)
            {
                dusmanlar[i] = new PictureBox(); // Picturebox class'ı kullanacağız. 
                dusmanlar[i].Size = new Size(40, 40);
                dusmanlar[i].SizeMode = PictureBoxSizeMode.Zoom;
                dusmanlar[i].BorderStyle = BorderStyle.None;
                dusmanlar[i].Visible = false;
                this.Controls.Add(dusmanlar[i]);
                dusmanlar[i].Location = new Point((i + 1) * 50, -50);
            }

            // düşmanlara farklı resim dosyaları dağıtıyoruz, bu yüzden yukarıdaki for döngüsü içinde yapmadık.
            dusmanlar[0].Image = boss1;
            dusmanlar[1].Image = dusman2;
            dusmanlar[2].Image = dusman3;
            dusmanlar[3].Image = dusman3;
            dusmanlar[4].Image = dusman1;
            dusmanlar[5].Image = dusman3;
            dusmanlar[6].Image = dusman2;
            dusmanlar[7].Image = dusman3;
            dusmanlar[8].Image = dusman2;
            dusmanlar[9].Image = boss2;

            for (int i = 0; i < dusmanMermi.Length; i++)
            {
                dusmanMermi[i] = new PictureBox();
                dusmanMermi[i].Size = new Size(2, 25);
                dusmanMermi[i].Visible = false;
                dusmanMermi[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                dusmanMermi[i].Location = new Point(dusmanlar[x].Location.X, dusmanlar[x].Location.Y - 20);
                this.Controls.Add(dusmanMermi[i]);
            }

            // mermiler[] arrayı initialize ediliyor
            for (int i = 0; i < mermiler.Length; i++)
            {
                mermiler[i] = new PictureBox();
                mermiler[i].Size = new Size(8, 8);
                mermiler[i].Image = mermi;
                mermiler[i].SizeMode = PictureBoxSizeMode.Zoom;
                mermiler[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(mermiler[i]);
            }
            oyunMuzigi.controls.play();
        }

        private void MoveBgTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < yildizlar.Length / 2; i++)
            {
                yildizlar[i].Top += arkaplanHiz;
                if (yildizlar[i].Top >= Height)
                {
                    yildizlar[i].Top = -yildizlar[i].Height;
                }
            }

            for (int i = yildizlar.Length / 2; i < yildizlar.Length; i++)
            {
                yildizlar[i].Top += arkaplanHiz - 2;
                if (yildizlar[i].Top >= Height)
                {
                    yildizlar[i].Top = -yildizlar[i].Height;
                }
            }
        }

        private void SpaceForm_KeyDown(object sender, KeyEventArgs e) // tuşa basarsa 
        {
            if (!durdur)
            {
                if (e.KeyCode == Keys.Right) // sağ yön tuşuna basmışsa
                {
                    MoveRigthTimer.Start();
                }
                if (e.KeyCode == Keys.Left) // sol yön...
                {
                    MoveLeftTimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    MoveDownTimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    MoveTopTimer.Start();
                }
            }
        }

        private void SpaceForm_KeyUp(object sender, KeyEventArgs e) // tuştan elini çekince
        {
            MoveRigthTimer.Stop();
            MoveLeftTimer.Stop();
            MoveDownTimer.Stop();
            MoveTopTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!oyunBitti)
                {
                    if (durdur)
                    {
                        StartTimers();
                        Text_lbl.Visible = false;
                        oyunMuzigi.controls.play(); ;
                        durdur = false;
                    }
                    else
                    {
                        Text_lbl.Location = new Point(20, 150);
                        Text_lbl.Text = "Oyun Durduruldu";
                        Text_lbl.Visible = true;
                        oyunMuzigi.controls.pause();
                        StopTimers();
                        durdur = true;
                    }
                }
            }
        }

        private void MoveLeftTimer_Tick(object sender, EventArgs e)
        {
            if (UzayGemisi.Left > 10) // soldan 10px
            {
                UzayGemisi.Left -= uzayGemisiHizi;
            }
        }

        private void MoveRigthTimer_Tick(object sender, EventArgs e)
        {
            if (UzayGemisi.Right < 573) // sağdan 573px
            {
                UzayGemisi.Left += uzayGemisiHizi; // Right property sini kullanamayız burada. Çünkü read-only. (Down property si de aynı şekilde)
            }
        }

        private void MoveTopTimer_Tick(object sender, EventArgs e)
        {
            if (UzayGemisi.Top > 10)
            {
                UzayGemisi.Top -= uzayGemisiHizi;
            }
        }

        private void MoveDownTimer_Tick(object sender, EventArgs e)
        {
            if (UzayGemisi.Top < 400)
            {
                UzayGemisi.Top += uzayGemisiHizi;
            }
        }

        private void MermiyiHareketEttirTimer_Tick(object sender, EventArgs e)
        {
            vur.controls.play();

            for (int i = 0; i < mermiler.Length; i++)
            {
                if (mermiler[i].Top > 0)
                {
                    mermiler[i].Visible = true;
                    mermiler[i].Top -= mermiHizi;

                    Carpisma();
                }
                else
                {
                    mermiler[i].Visible = false;
                    mermiler[i].Location = new Point(UzayGemisi.Location.X + 20, UzayGemisi.Location.Y - i * 30);
                }
            }
        }

        private void DusmanlarMermiTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (dusmanMermi.Length - zorluk); i++)
            {
                if (dusmanMermi[i].Top < this.Height)
                {
                    dusmanMermi[i].Visible = true;
                    dusmanMermi[i].Top += dusmanMermiHizi;
                    DusmanMermisiyleVurul();
                }
                else
                {
                    dusmanMermi[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    dusmanMermi[i].Location = new Point(dusmanlar[x].Location.X + 20, dusmanlar[x].Location.Y + 30);
                }
            }
        }

        private void DusmanlariHareketEttirTimer_Tick(object sender, EventArgs e)
        {
            DusmanlariHareketEttir(dusmanlar, dusmanHizi);
        }

        private void DusmanlariHareketEttir(PictureBox[] dusmanlar, int speed)
        {
            for (int i = 0; i < dusmanlar.Length; i++)
            {
                dusmanlar[i].Visible = true;
                dusmanlar[i].Top += speed;

                if (dusmanlar[i].Top > this.Height)
                {
                    this.dusmanlar[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        private void DusmanMermisiyleVurul()
        {
            for (int i = 0; i < dusmanMermi.Length; i++)
            {
                if (dusmanMermi[i].Bounds.IntersectsWith(UzayGemisi.Bounds))
                {
                    dusmanMermi[i].Visible = false;
                    patlama.settings.volume = 30;
                    patlama.controls.play();
                    UzayGemisi.Visible = false;
                    OyunBitti("Oyun Bitti :(");
                }
            }
        }

        private void Carpisma()
        {
            for (int i = 0; i < dusmanlar.Length; i++)
            {
                if (mermiler[0].Bounds.IntersectsWith(dusmanlar[i].Bounds) || mermiler[1].Bounds.IntersectsWith(dusmanlar[i].Bounds) || mermiler[2].Bounds.IntersectsWith(dusmanlar[i].Bounds))
                {
                    patlama.controls.play();
                    skor += 1;
                    scorelbl.Text = (skor < 10) ? "0" + skor.ToString() : skor.ToString();

                    if (skor % 30 == 0)
                    {
                        seviye += 1;
                        levelbl.Text = (seviye < 10) ? "0" + seviye.ToString() : seviye.ToString();

                        if (dusmanHizi <= 10 && dusmanMermiHizi <= 10 && zorluk >= 0)
                        {
                            zorluk--;
                            dusmanHizi++;
                            dusmanMermiHizi++;
                        }

                        if (seviye == 10)
                        {
                            OyunBitti("BAŞARDIN!");
                        }
                    }
                    dusmanlar[i].Location = new Point((i + 1) * 50, -100);
                }
                if (UzayGemisi.Bounds.IntersectsWith(dusmanlar[i].Bounds))
                {
                    patlama.settings.volume = 30;
                    patlama.controls.play();
                    UzayGemisi.Visible = false;
                    OyunBitti("Oyun Bitti");
                }
            }
        }

        private void OyunBitti(String str)
        {
            oyunMuzigi.controls.stop();
            Text_lbl.Location = new Point(60, 110);
            Text_lbl.Text = str.Trim();
            Text_lbl.Visible = true;
            oyunBitti = true;
            durdur = true;
            ReplayBtn.Text = "Tekrar Oyna";
            ReplayBtn.Visible = true;
            QuitBtn.Visible = true;
            StopTimers();
        }

        private void ReplayBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            SpaceForm_Load(e, e);
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void StopTimers()
        {
            MoveBgTimer.Stop();
            MoveEnemiesTimer.Stop();
            MoveMunitionTimer.Stop();
            EnemiesMunitionTimer.Stop();
        }

        private void StartTimers()
        {
            MoveBgTimer.Start();
            MoveEnemiesTimer.Start();
            MoveMunitionTimer.Start();
            EnemiesMunitionTimer.Start();
        }

        private void Aircraft_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void Text_lbl_Click(object sender, EventArgs e)
        {
        }
    }
}
