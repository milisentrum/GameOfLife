using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        private int resolution;

        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        //Начало игры
        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            nudResolution.Enabled = false;
            nudDancity.Enabled = false;

            resolution = (int)nudResolution.Value;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
                return;

            timer1.Enabled = false;
            nudDancity.Enabled = true;
            nudResolution.Enabled = true;
        }

        //Обработка нажатия кнопки "старт"
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }       
    }
}
