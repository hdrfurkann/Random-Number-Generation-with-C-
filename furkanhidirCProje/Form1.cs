using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furkanhidirCProje
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public static int parentX, parentY;

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            int numberOfLabels;
            if (int.TryParse(textBox1.Text, out numberOfLabels))
            {
                for (int i = 1; i <= numberOfLabels; i++)
                {
                    Label newLabel = new Label();
                    newLabel.AutoSize = true;
                    newLabel.Location = new Point(10, (i - 1) * 30);
                    newLabel.Text = i.ToString() + ". Sayı = " + random.Next(1, 101).ToString();

                    // Panel'e label'ı ekle
                    panel1.Controls.Add(newLabel);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hexColorButton1 = "#1677ff";

            Color colorButton1 = System.Drawing.ColorTranslator.FromHtml(hexColorButton1);

            about_me_btn.BackColor = colorButton1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = random.Next(1, 101).ToString();
            label2.Text = random.Next(1, 101).ToString();
            label3.Text = random.Next(1, 101).ToString();
            label4.Text = random.Next(1, 101).ToString();
            label5.Text = random.Next(1, 101).ToString();
            label6.Text = random.Next(1, 101).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (AboutMe modal = new AboutMe())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;
                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }
    }
}
