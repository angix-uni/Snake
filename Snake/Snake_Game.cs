using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Snake_Game : Form
    {
        public Snake_Game()
        {
            InitializeComponent();
            KeyPreview = true;
            
        }
        Zapisz_Wynik form2 = new Zapisz_Wynik();
        Timer timer;
        Timer timer2;
        int size;
        int[,] box;
        SnakeDirection snakeDirection;
        public static int lastSegment;
        public Stopwatch sw;
        Random random;
        


        enum GameObjects
        {
            food = -1,
            spike = -2
        }

        enum SnakeDirection
        {
            Up,
            Right,
            Down,
            Left

        }

        public void Form1_Load(object sender, EventArgs e) // co się dzieje po odpaleniu aplikacji
        {
            File.AppendAllText((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\highscore.txt"),"");
            random = new Random();
            timer = new Timer();
            timer.Interval = 150;
            timer.Tick += Timer_Tick;
            timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Tick += Timer_Tick2;
            size = 20;
            box = new int[size, size];
            sw = new Stopwatch();
            highlbl.Text = (File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\highscore.txt"));
        }

        private void Timer_Tick2(object sender, EventArgs e)
        {
            sw.Start();
            timelbl.Text = "Running for " + sw.Elapsed.Seconds.ToString() + " seconds";
        }

        public void Initialize()
        {
            timer.Start();
            timer2.Start();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    box[i, j] = 0;
                 
                }
            }

            GenerateFood();
            box[5, 5] = 1;
            box[6, 5] = 2;
            box[7, 5] = 3;
            snakeDirection = SnakeDirection.Left;
            lastSegment = 3;
            
        }


        public void Timer_Tick(object sender, EventArgs e) // generowanie planszy 
        {
            GameLogic();

            lenghtlbl.Text = lastSegment.ToString();

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);


            graphics.FillRectangle(Brushes.Gray, 0, 0, pictureBox1.Width, pictureBox1.Height);

            SizeF siezeCell = new SizeF((float)pictureBox1.Width / size, (float)pictureBox1.Height / size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (box[i, j] == 0)
                    {
                        graphics.FillRectangle(Brushes.White, i * siezeCell.Width + 1, j * siezeCell.Height + 1, siezeCell.Width - 2, siezeCell.Height - 2);

                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.Green, i * siezeCell.Width + 1, j * siezeCell.Height + 1, siezeCell.Width - 2, siezeCell.Height - 2);
                    }
                    if (box[i, j] == (int)GameObjects.food)
                    {
                        graphics.FillRectangle(Brushes.Yellow, i * siezeCell.Width + 1, j * siezeCell.Height + 1, siezeCell.Width - 2, siezeCell.Height - 2);
                    }

                }
            }

            pictureBox1.BackgroundImage = bitmap;
        }

        public void GameLogic() // poruszanie sie weza
        {
            bool headMove = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (box[i, j] == lastSegment)
                    {
                        
                        box[i, j] = 0;

                    }
                    if (box[i, j] > 1)
                        {
                        box[i, j]++;
                    }
                    else if (box[i,j] == 1 && !headMove)
                    {
                        Point walkPosition;

                        switch(snakeDirection) // w która strone idzie snake
                        {
                            case SnakeDirection.Up:
                                walkPosition = new Point(i, j - 1);
                            break;
                            case SnakeDirection.Right:
                                walkPosition = new Point(i+1, j);
                                break;
                            case SnakeDirection.Down:
                                walkPosition = new Point(i, j + 1);
                                break;
                            case SnakeDirection.Left:
                                walkPosition = new Point(i-1, j);
                                break;
                            default:
                                throw new Exception("snake musi sie ruszac");
                        }
                        if (walkPosition.X < 0 || walkPosition.Y < 0 || walkPosition.X == size || walkPosition.Y == size || box[walkPosition.X, walkPosition.Y] > 0) //przegrana
                        {
                            timer.Stop();
                            timer2.Stop();
                            sw.Stop();
                            form2.Show();
                            form2.Wyniklbl.Text = lastSegment.ToString("D3");
                            this.Hide();
                            return;
                        }
                        if (box[walkPosition.X, walkPosition.Y] == (int)GameObjects.food) // generowanie nowego jedzenia
                        {
                            lastSegment++;
                            GenerateFood();

                        }
                        box[walkPosition.X, walkPosition.Y] = 1;
                        box[i, j]++;
                        headMove = true;
                    }

                }
            }
        }

        public void Form1_KeyPress(object sender, KeyPressEventArgs e) // ustawienei wasd na chodzenia
        {
            switch (e.KeyChar)
            {
                case 'w':
                    if (snakeDirection != SnakeDirection.Down)
                        snakeDirection = SnakeDirection.Up;
                    break;
                case 'a':
                    if (snakeDirection != SnakeDirection.Right)
                        snakeDirection = SnakeDirection.Left;
                    break;
                case 's':
                    if (snakeDirection != SnakeDirection.Up)
                        snakeDirection = SnakeDirection.Down;
                    break;
                case 'd':
                    if (snakeDirection != SnakeDirection.Left)
                        snakeDirection = SnakeDirection.Right;
                    break;

            }
        }
        
        public void GenerateFood() // generowanie jedzenia
        {
            Point foodPos;
            do
            {
                foodPos = new Point(random.Next() % size, random.Next() % size);

            } while (box[foodPos.X, foodPos.Y] != 0);

            box[foodPos.X, foodPos.Y] = (int)GameObjects.food;
        }
        public void Startbtn_Click(object sender, EventArgs e) //przycisk start
        {
            Initialize();
            sw.Restart();
        }
    }
}
