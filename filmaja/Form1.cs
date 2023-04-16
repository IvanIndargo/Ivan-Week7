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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox();
            picture1.ImageLocation = ("D:\\Foto tugas uc\\958c37a2b915d983cd90a9d86a26af40.jpg");
            picture1.Location = new Point(60, 10);
            picture1.Size = new Size(120, 120);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture1);

            Label label1 = new Label();
            label1.Location = new Point(95, 130);
            label1.ForeColor = Color.Red;
            label1.Size = new Size(65, 20);
            label1.Text = "CHUCKY";
            this.Controls.Add(label1);

            Button button1 = new Button();
            button1.Size = new Size(60, 25);
            button1.Location = new Point(90, 150);
            button1.ForeColor = Color.Red;
            button1.Text = "Book";
            this.Controls.Add(button1);

            PictureBox picture2 = new PictureBox();
            picture2.Image = Image.FromFile("D:\\Foto tugas uc\\bb4af-the-grudge-poster.jpg");
            picture2.Location = new Point(245, 10);
            picture2.Size = new Size(120, 120);
            picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture2);

            Label label2 = new Label();
            label2.Size = new Size(100, 20);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(267, 130);
            label2.Text = "THE GRUDGE";
            this.Controls.Add(label2);

            Button button2 = new Button();
            button2.Size = new Size(60, 25);
            button2.Location = new Point(275, 150);
            button2.ForeColor = Color.Red;
            button2.Text = "Book";
            this.Controls.Add(button2);

            PictureBox picture3 = new PictureBox();
            picture3.Image = Image.FromFile("D:\\Foto tugas uc\\f4.jpg");
            picture3.Location = new Point(430, 10);
            picture3.Size = new Size(120, 120);
            picture3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture3);

            Label label3 = new Label();
            label3.Size = new Size(100, 20);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(457, 130);
            label3.Text = "INSIDIOUS";
            this.Controls.Add(label3);

            Button button3 = new Button();
            button3.Size = new Size(60, 25);
            button3.Location = new Point(458, 150);
            button3.ForeColor = Color.Red;
            button3.Text = "Book";
            this.Controls.Add(button3);

            PictureBox picture4 = new PictureBox();
            picture4.Image = Image.FromFile("D:\\Foto tugas uc\\ce3d6811da999a716a4f76ed795fa832.jpg");
            picture4.Location = new Point(620, 10);
            picture4.Size = new Size(120, 120);
            picture4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture4);

            Label label4 = new Label();
            label4.Size = new Size(100, 20);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(648, 130);
            label4.Text = "THE NUN";
            this.Controls.Add(label4);

            Button button4 = new Button();
            button4.Size = new Size(60, 25);
            button4.Location = new Point(647, 150);
            button4.ForeColor = Color.Red;
            button4.Text = "Book";
            this.Controls.Add(button4);

            PictureBox picture5 = new PictureBox();
            picture5.Image = Image.FromFile("D:\\Foto tugas uc\\R.jpg");
            picture5.Location = new Point(60, 240);
            picture5.Size = new Size(120, 120);
            picture5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture5);

            Label label5 = new Label();
            label5.Size = new Size(100, 20);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(86, 360);
            label5.Text = "ANNABELLE";
            this.Controls.Add(label5);

            Button button5 = new Button();
            button5.Size = new Size(60, 25);
            button5.Location = new Point(90, 380);
            button5.ForeColor = Color.Red;
            button5.Text = "Book";
            this.Controls.Add(button5);

            PictureBox picture6 = new PictureBox();
            picture6.Image = Image.FromFile("D:\\Foto tugas uc\\The_conjuring_l_evocazione_copertina.jpg");
            picture6.Location = new Point(245, 245);
            picture6.Size = new Size(115, 110);
            picture6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture6);

            Label label6 = new Label();
            label6.Size = new Size(100, 20);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(256, 360);
            label6.Text = "THE CONJURING";
            this.Controls.Add(label6);

            Button button6 = new Button();
            button6.Size = new Size(60, 25);
            button6.Location = new Point(270, 380);
            button6.ForeColor = Color.Red;
            button6.Text = "Book";
            this.Controls.Add(button6);

            PictureBox picture7 = new PictureBox();
            picture7.Image = Image.FromFile("D:\\Foto tugas uc\\rings_ukquad_feb3_l.jpg");
            picture7.Location = new Point(430, 245);
            picture7.Size = new Size(115, 110);
            picture7.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture7);

            Label label7 = new Label();
            label7.Size = new Size(100, 20);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(465, 360);
            label7.Text = "RINGS";
            this.Controls.Add(label7);

            Button button7 = new Button();
            button7.Size = new Size(60, 25);
            button7.Location = new Point(455, 380);
            button7.ForeColor = Color.Red;
            button7.Text = "Book";
            this.Controls.Add(button7);

            PictureBox picture8 = new PictureBox();
            picture8.Image = Image.FromFile("D:\\Foto tugas uc\\p18000487_p_v13_ac.jpg");
            picture8.Location = new Point(620, 245);
            picture8.Size = new Size(115, 110);
            picture8.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture8);

            Label label8 = new Label();
            label8.Size = new Size(80, 20);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(640, 360);
            label8.Text = "DON'T SPEAK";
            this.Controls.Add(label8);

            Button button8 = new Button();
            button8.Size = new Size(60, 25);
            button8.Location = new Point(645, 380);
            button8.ForeColor = Color.Red;
            button8.Text = "Book";
            this.Controls.Add(button8);


            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
            button6.Click += Button6_Click;
            button7.Click += Button7_Click;
            button8.Click += Button8_Click;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Movie1 movie1 = new Movie1();
            movie1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Movie2 movie2 = new Movie2();
            movie2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Movie3 movie3 = new Movie3();
            movie3.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Movie4 movie4 = new Movie4();
            movie4.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Movie5 movie5 = new Movie5();
            movie5.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Movie6 movie6 = new Movie6();
            movie6.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Movie7 movie7 = new Movie7();
            movie7.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Movie8 movie8 = new Movie8();
            movie8.Show();
        }
    }
}
