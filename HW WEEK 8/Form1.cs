using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_WEEK_8
{
    public partial class Form1 : Form
    {
        int x2 = 0; int film = 0; int count = 0; int cek = 0;
        int x1 = 0; int x3 = 0;
        int loc = 0; int x = 0; int y = 0; int z = 0;
        string huruf = "SFBESFDSEFS";
        List<string> movie = new List<string>() {"The Avenger", "John Wick", "Mario Bros" };
        List<PictureBox> listgmbr = new List<PictureBox>();
        List<Control> pilihkursi = new List<Control>();
        List<List<Control>> kursijam = new List<List<Control>>();
        List<List<List<Control>>> kendali = new List<List<List<Control>>>();
        List<List<string>> jamfilm = new List<List<string>>();
        List<string> booking = new List<string>();
        List<string> jam1 = new List<string>() { "12:00 - 14:30", "15:00 - 17:30", "19:30 - 22:00" };
        List<string> jam2 = new List<string>() { "13:20 - 16:20", "17:35 - 18:35", "19:00 - 21:00" };
        List<string> jam3 = new List<string>() { "12:35 - 14:35", "17:35 - 18:35", "21:00 - 23:00" };
        List<string> jam4 = new List<string>() { "12:00 - 15:15", "16:45 - 19:45", "20:00 - 23:00" };
        List<string> jam5 = new List<string>() { "12:30 - 13:30", "15:15 - 16:55", "18:00 - 20:00" };
        List<string> jam6 = new List<string>() { "12:35 - 14:35", "13:20 - 16:20", "16:45 - 19:45" };
        List<string> jam7 = new List<string>() { "15:00 - 17:30", "17:35 - 18:35", "19:30 - 22:00" };
        List<string> jam8 = new List<string>() { "13:20 - 16:20", "15:15 - 16:55", "18:00 - 20:00" };
        public Form1()
        {
            InitializeComponent();
        }
        public void kursi()
        {
            for (int f = 0; f < 8; f++)
            {
                kursijam = new List<List<Control>>();
                for (int e = 0; e < 3; e++)
                {
                    pilihkursi = new List<Control>();
                    loc = 0;
                    x = 0;
                    y = 0;
                    z = 0;

                    Random rnd = new Random();
                    for (int i = 0; i < 14; i++)
                    {
                        if (i <= 8)
                        {
                            for (int j = 23; j >= 1; j--)
                            {
                                Button a = new Button();
                                a.Tag = (huruf[i] + j.ToString());
                                a.Size = new Size(37, 37);
                                a.BackColor = Color.Green;
                                a.Location = new Point(200 + x, 60 + loc);
                                pilihkursi.Add(a);
                                a.Click += kursi_click;
                                x += 40;
                            }
                            x = 0;
                            loc += 40;
                        }
                        if (i >= 9)
                        {
                            for (int j = 26; j >= 1; j--)
                            {
                                Button a = new Button();
                                a.Tag = (huruf[i] + j.ToString());
                                a.Size = new Size(37, 37);
                                a.BackColor = Color.Green;
                                a.Location = new Point(80 + y, 425 + z);
                                pilihkursi.Add(a);
                                a.Click += kursi_click;
                                y += 40;
                            }
                            y = 0;
                            z += 40;
                        }
                    }
                    for (int q = 0; q < 70; q++)
                    {
                        pilihkursi[rnd.Next(0, pilihkursi.Count)].BackColor = Color.Red;
                    }
                    loc = 0;
                    for (int r = 0; r < 14; r++)
                    {
                        Label hr = new Label();
                        hr.Text = huruf[r].ToString();
                        hr.Tag = "ngawur";
                        hr.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                        hr.Location = new Point(1120, 68 + loc);
                        pilihkursi.Add(hr);
                        loc += 40;
                    }

                    loc = 0;
                    for (int h = 26; h >= 1; h--)
                    {
                        Label k = new Label();
                        k.Text = h.ToString();
                        k.Tag = "males";
                        k.Size = new Size(37, 37);
                        k.AutoSize = false;
                        k.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                        k.TextAlign = ContentAlignment.MiddleCenter;
                        k.Location = new Point(80 + loc, 620);
                        pilihkursi.Add(k);
                        loc += 40;
                    }

                    Label pesan = new Label();
                    pesan.AutoSize = true;
                    pesan.Tag = "seats";
                    pesan.Location = new Point(80, 670);
                    pesan.Text = "Seats: ";
                    pesan.Font = new Font("Times New Roman", 10);
                    pilihkursi.Add(pesan);

                    Button kr = new Button();
                    kr.Text = "S C R E E N";
                    kr.Tag = "screen";
                    kr.Location = new Point(200, 10);
                    kr.Size = new Size(920, 35);
                    kr.AutoSize = true;
                    kr.Enabled = false;
                    pilihkursi.Add(kr);
                    kursijam.Add(pilihkursi);

                }
                kendali.Add(kursijam);
            }
        }
        private void gambar_click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            PictureBox p = sender as PictureBox;
            foreach (PictureBox a in listgmbr)
            {
                if (p.Tag == a.Tag)
                {
                    film = Convert.ToInt32(a.Tag);
                }
            }
            x3 = 0;
            for (int i = 0; i < jamfilm[film].Count; i++)
            {
                Button a = new Button();
                a.AutoSize = true;
                a.Size = new Size(50, 30);
                a.Location = new Point(2, 2 + x3);
                a.Tag = i.ToString();
                a.Text = jamfilm[film][i];
                panel3.Controls.Add(a);
                a.Click += a_click;
                x3 += 35;
            }

            Button capek = new Button();
            capek.AutoSize = true;
            capek.Text = "OK";
            capek.Location = new Point(5, 120);
            panel3.Controls.Add(capek);
            capek.Click += ok_click;

            Button reset = new Button();
            reset.AutoSize = true;
            reset.Text = "Reset";
            reset.Location = new Point(5, 145);
            panel3.Controls.Add(reset);
            reset.Click += reset_click;
        }

        private void reset_click(object sender, EventArgs e)
        {
            foreach (Control a in kendali[film][cek])
            {
                if (a is Button && a.Tag.ToString() != "screen")
                {
                    a.BackColor = Color.Green;
                }
            }
            booking.Clear();
        }


        private void a_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            cek = Convert.ToInt32(b.Tag);
            panel1.Controls.Clear();
            foreach (Control a in kendali[film][cek])
            {
                if (a is Button && a.BackColor == Color.Yellow)
                {
                    a.BackColor = Color.Green;
                }
            }
            foreach (Control a in kendali[film][cek])
            {
                panel1.Controls.Add(a);
            }
        }

        private void kursi_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            foreach (Control a in kendali[film][cek])
            {
                if (a is Button)
                {
                    if (a.Tag == b.Tag)
                    {
                        if (a.BackColor == Color.Green)
                        {
                            a.BackColor = Color.Yellow;
                            booking.Add(a.Tag.ToString());
                            count++;
                            MessageBox.Show("kontol");
                        }
                        else if (a.BackColor == Color.Yellow)
                        {
                            MessageBox.Show("anjing");
                            a.BackColor = Color.Green;
                            booking.Remove(a.Tag.ToString());
                            count--;
                        }
                    }
                }
                if (a is Label)
                {
                    if (a.Tag.ToString() == "seats")
                    {
                        a.Text = "Seats: ";
                        foreach (string print in booking)
                        {
                            a.Text += ", " + print;
                        }
                        if (booking.Count != 0)
                        {
                            a.Text = a.Text.Remove(7, 2);
                        }
                    }
                }
            }
        }

        private void ok_click(object sender, EventArgs e)
        {
            //MessageBox.Show(count + " tickets for " + listmovie[film] + "\nEnjoy your movie");
            for (int h = 0; h < kendali[film][cek].Count; h++)
            {
                if (kendali[film][cek][h].BackColor == Color.Yellow)
                {
                    kendali[film][cek][h].BackColor = Color.Red;
                }
            }
        }

        
private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                PictureBox gambar = new PictureBox();
                gambar.Tag = i.ToString();
                gambar.Image = imageList_fotoFilm.Images[i];
                gambar.Size = new Size(250, 300);
                gambar.SizeMode = PictureBoxSizeMode.StretchImage;
                gambar.Location = new Point(5, 5 + x2);
                listgmbr.Add(gambar);
                panel2.Controls.Add(gambar);
                gambar.Click += gambar_click;

                Label judul = new Label();
                judul.Text = movie[i];
                judul.AutoSize = true;
                judul.Location = new Point(260, 5 + x2);
                judul.Font = new Font("Times New Roman", 17, FontStyle.Bold);
                panel2.Controls.Add(judul);

                x2 += 320;
            }
            kursi();
            jamfilm.Add(jam1); jamfilm.Add(jam2); jamfilm.Add(jam3); jamfilm.Add(jam4); jamfilm.Add(jam5); jamfilm.Add(jam6); jamfilm.Add(jam7); jamfilm.Add(jam8);
        }
    }
}
