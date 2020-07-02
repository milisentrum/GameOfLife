﻿using System;
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
        private int currentGeneration = 0;

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

            currentGeneration = 0;

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

            bool[,] newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int neighbours = CountNeighbours(x, y);
                    bool hasLife = field[x, y];

                    if (!hasLife && neighbours == 3)
                        newField[x, y] = true;
                    else
                    {
                        if (hasLife && (neighbours < 2 || neighbours > 3))
                            newField[x, y] = false;
                        else
                            newField[x, y] = field[x, y];
                    }

                    if (hasLife)
                    {
                        //отрисовка живой клетки
                        graphics.FillRectangle(Brushes.CornflowerBlue, x * resolution, y * resolution, resolution, resolution);
                       
                    }
                }
            }

            field = newField;
            pictureBox1.Refresh();
            Text = $"Generation {++currentGeneration}";
        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = (y + j + rows) % rows;

                    bool isSelfChecking = col == x && row == y;


                    bool hasLife = field[col, row];

                    if (hasLife && !isSelfChecking)
                        count++;
                }
            }
                
            return count;
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;



            if(e.Button==MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                bool validationPassed = ValidateMousePosition(x, y);
                if(validationPassed)
                 field[x, y] = true;

            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                bool validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                field[x, y] = false;

            }
        }


        private bool ValidateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Conway's Game Of Life";
        }
    }
}