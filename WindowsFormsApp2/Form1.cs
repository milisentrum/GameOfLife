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
        private bool[,] field;
        private Graphics graphics;
        private int rows;
        private int cols;

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

            rows = pictureBox1.Height / resolution;
            cols = pictureBox1.Width / resolution;

            field = new bool[cols, rows];

            //первое поколение
            Random rand = new Random();
            for (int x=0; x<cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = rand.Next((int)nudDancity.Value) == 0;
                    if (field[x, y])
                    {
                        //graphics.FillRectangle(Brushes.CornflowerBlue, x * resolution, y * resolution, resolution, resolution);
                    }
                }
            }

            timer1.Start();
        }

        private void NextGeneration()
        {
            graphics.Clear(Color.Black);

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (field[x, y])
                    {
                        //отрисовка живой клетки
                        graphics.FillRectangle(Brushes.CornflowerBlue, x * resolution, y * resolution, resolution, resolution);
                       
                    }
                }
            }

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

        //Обработка нажатия кнопки Stop
        private void btnstop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        //Обработка Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }       
    }
}