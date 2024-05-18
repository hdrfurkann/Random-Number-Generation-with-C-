using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furkanhidirCProje
{
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += .02;
            }

            int y = Form1.parentY += 3;
            this.Location = new Point(Form1.parentX + 220,y);
            if(y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }
        int i;
        private void AboutMe_Load(object sender, EventArgs e)
        {
            i = Form1.parentY + 150;
            this.Location = new Point(Form1.parentX + 220, Form1.parentY + 150);

            string hexColorButton1 = "#2b3137";
            string hexColorButton2 = "#ff813f";
            string hexColorButton3 = "#1877f2";
            string hexColorButton4 = "#dc2743";
            string hexColoroky_btn = "#1677ff";

            Color colorButton1 = System.Drawing.ColorTranslator.FromHtml(hexColorButton1);
            Color colorButton2 = System.Drawing.ColorTranslator.FromHtml(hexColorButton2);
            Color colorButton3 = System.Drawing.ColorTranslator.FromHtml(hexColorButton3);
            Color colorButton4 = System.Drawing.ColorTranslator.FromHtml(hexColorButton4);
            Color colorOky_btn = System.Drawing.ColorTranslator.FromHtml(hexColoroky_btn);

            github_btn.BackColor = colorButton1;
            buymecoffee.BackColor = colorButton2;
            linkedln.BackColor = colorButton3;
            instagram.BackColor = colorButton4;
            Oky_btn.BackColor = colorOky_btn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hdrfurkann");
        }

        private void buymecoffee_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://buymeacoffee.com/hdrfurkann");
        }

        private void linkedln_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/hdrfurkann/");
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/premadesoft");
        }

        private void Oky_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
