using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmaja
{
    public partial class Movie4 : Form
    {
        public Movie4()
        {
            InitializeComponent();
        }
        Panel satu = new Panel();
        List<Button> waktulist1 = new List<Button>();
        List<Button> waktulist2 = new List<Button>();
        List<Button> waktulist3 = new List<Button>();
        Random seat = new Random();
        int hehe = 0;
        int b = 0;
        int c = 0;
        int hihi = 0;
        int huhu = 0;
        private void Movie4_Load(object sender, EventArgs e)
        {
            Label movie1 = new Label();
            movie1.AutoSize = true;
            movie1.Location = new Point(620, 20);
            movie1.Tag = 1;
            movie1.ForeColor = Color.Red;
            movie1.Size = new Size(300, 300);
            movie1.Text = "CHUCKY";
            Controls.Add(movie1);

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.ImageLocation = ("D:\\Foto tugas uc\\ce3d6811da999a716a4f76ed795fa832.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Location = new Point(530, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 340);
            pictureBox1.TabStop = false;
            Controls.Add(pictureBox1);

            Button waktu1 = new Button();
            waktu1.Location = new Point(60, 50);
            waktu1.Name = "CHUCKY";
            waktu1.Size = new Size(100, 55);
            waktu1.Text = "11.00";
            Controls.Add(waktu1);
            waktu1.Click += Jam1_Click;

            Button waktu2 = new Button();
            waktu2.Location = new Point(205, 50);
            waktu2.Name = "CHUCKY";
            waktu2.Size = new Size(100, 55);
            waktu2.Text = "13.00";
            Controls.Add(waktu2);
            waktu2.Click += Jam2_Click;

            Button waktu3 = new Button();
            waktu3.Location = new Point(350, 50);
            waktu3.Name = "CHUCKY";
            waktu3.Size = new Size(100, 55);
            waktu3.Text = "15.00";
            Controls.Add(waktu3);
            waktu3.Click += Jam3_Click;

            Button kembali = new Button();
            kembali.Location = new Point(560, 410);
            kembali.Size = new Size(160, 20);
            kembali.Text = "BACK TO MOVIE MENU";
            Controls.Add(kembali);
            kembali.Click += Kembali_Click;

            Button book = new Button();
            book.Location = new Point(300, 420);
            book.Size = new Size(150, 24);
            book.Text = "BOOK";
            Controls.Add(book);
            book.Click += Reset_Click;

            satu.Location = new Point(125, 110);
            satu.Name = "panel1";
            satu.Size = new Size(280, 300);
            satu.TabIndex = 0;
            satu.BackColor = Color.Transparent;
            Controls.Add(satu);
            satu.Controls.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button3 = new Button();
                    button3.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button3.Size = new Size(27, 27);
                    button3.Location = new Point(4 + b, 8 + c);
                    button3.BackColor = Color.Gray;
                    button3.Click += Button3_Click;
                    waktulist3.Add(button3);
                    hehe++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            for (int i = 0; i < 70; i++)
            {
                int acak = seat.Next(0, 100);
                waktulist3[acak].BackColor = Color.Red;
                waktulist3[acak].Enabled = false;
            }

            b = 0;
            c = 0;
            satu.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button2 = new Button();
                    button2.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button2.Size = new Size(27, 27);
                    button2.Location = new Point(4 + b, 8 + c);
                    button2.BackColor = Color.Gray;
                    button2.Click += Button2_Click;
                    waktulist2.Add(button2);
                    hehe++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            for (int i = 0; i < 70; i++)
            {
                int acak = seat.Next(0, 100);
                waktulist2[acak].BackColor = Color.Red;
                waktulist2[acak].Enabled = false;
            }
            b = 0;
            c = 0;
            satu.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button1 = new Button();
                    button1.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button1.Size = new Size(27, 27);
                    button1.Location = new Point(4 + b, 8 + c);
                    button1.BackColor = Color.Gray;
                    button1.Click += Button1_Click;
                    waktulist1.Add(button1);
                    hehe++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            for (int i = 0; i < 70; i++)
            {
                int acak = seat.Next(0, 100);
                waktulist1[acak].BackColor = Color.Red;
                waktulist1[acak].Enabled = false;
            }
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            satu.Controls.Clear();

            foreach (Button seat in waktulist1)
            {
                satu.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.Gray)
            {
                button.BackColor = Color.Green;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            satu.Controls.Clear();

            foreach (Button seat in waktulist2)
            {
                satu.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.Gray)
            {
                button.BackColor = Color.Green;

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            satu.Controls.Clear();

            foreach (Button seat in waktulist3)
            {
                satu.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.Gray)
            {
                button.BackColor = Color.Green;

            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (huhu == 1)
            {
                foreach (Button button in waktulist1)
                {
                    if (button.BackColor == Color.Green)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            if (huhu == 2)
            {
                foreach (Button button in waktulist2)
                {
                    if (button.BackColor == Color.Green)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            if (huhu == 3)
            {
                foreach (Button button in waktulist3)
                {
                    if (button.BackColor == Color.Green)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
        }


        private void Jam3_Click(object sender, EventArgs e)
        {
            satu.Controls.Clear();
            huhu = 3;
            hihi = 3;
            foreach (Button seat in waktulist3)
            {
                satu.Controls.Add(seat);

            }
        }

        private void Jam2_Click(object sender, EventArgs e)
        {
            satu.Controls.Clear();
            huhu = 2;
            hihi = 2;
            foreach (Button seat in waktulist2)
            {
                satu.Controls.Add(seat);
            }
        }

        private void Jam1_Click(object sender, EventArgs e)
        {
            satu.Controls.Clear();
            huhu = 1;
            hihi = 1;
            foreach (Button seat in waktulist1)
            {
                satu.Controls.Add(seat);

            }
        }
    }

}
