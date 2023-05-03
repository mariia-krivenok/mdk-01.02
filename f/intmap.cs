using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "Финиш"; 
            panel2.Visible = true;
            label2.Visible = true;        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "МЦК Лужники";
            panel2.Visible = true;
            label2.Visible = true;        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "Новодевичей монастырь";           
            panel2.Visible = true;
            label2.Visible = true;        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = true;
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "МИД";
            panel2.Visible = true;
            label2.Visible = true;
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "Парк Горького";
            panel2.Visible = true;
            label2.Visible = true;
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "Здания РАН";
            panel2.Visible = true;
            label2.Visible = true;
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "Метро Воробьевы горы";
            panel2.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "Стадион Лужники";
            panel2.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Text = "Старт";
            panel2.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Text = "Старт";
            panel2.Visible = true;
            label2.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label2.Text = "Старт";
            panel2.Visible = true;
            label2.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label5.Text = "Напитки";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label5.Text = "Энергетические батончики";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label5.Text = "Информация";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label5.Text = "Туалет";
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            label5.Text = "Медицинские пункты";
        }
    }
}
