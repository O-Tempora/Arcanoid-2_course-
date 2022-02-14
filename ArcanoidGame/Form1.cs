using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ArcanoidGame
{
    public partial class Game : Form
    {
        static public Random rnd = new Random();
        static public Random rng = new Random();

        public static int TotalScore = 0;
        public static int CopyScore = 0;

        private bool _moveLeft;
        private bool _moveRight;
        private bool _gameOver;

        Platform platform;
        Ball ball;
        Brick[] Level;

        Menu menu = new Menu();

        private List <Records> RecordTable = new List <Records>();

        public string path = Path.GetFullPath("SaveFile.txt"); // Файл сохранения

        private delegate int Collision(Brick obj, Ball ball);
        private delegate int CollisionPlat(Platform obj, Ball ball);
        Collision col;
        CollisionPlat colp;
        public Game()
        {
            this.Width = 1000;
            this.Height = 800;
            InitializeComponent();
            this.BackgroundImage = new Bitmap(Properties.Resources.Back);
            Init();
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            col = ball.Brick_Coll;
            colp = ball.Platform_Coll;
            LoadRecords();
            Invalidate();
            this.KeyDown += new KeyEventHandler(Return_To_Menu); // Для закрытия формы
            Data.EventHandler = new Data.FormConnection(LvlDet);
        }

        private void Return_To_Menu(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue == 27) && _gameOver)
            {
                this.Dispose();
                menu.Show();
            }
        }

        private void LvlDet(int chosenlvl) // Обработчик выбора уровня
        {
            if (chosenlvl == 1)
            {
                this.Level = new Brick[27];
                for (int i = 0; i < 9; i++)
                    Level[i] = new Brick(40 + i * 100, 50);
                for (int i = 0; i < 9; i++)
                    Level[i + 9] = new Brick(40 + i * 100, 90);
                for (int i = 0; i < 9; i++)
                    Level[i + 18] = new Brick(40 + i * 100, 130);
            }
            
            if (chosenlvl == 2)
            {
                this.Level = new Brick[45];
                for (int i = 0; i < 9; i++)
                    Level[i] = new ReinforcedBrick(40 + i * 100, 50);
                for (int i = 0; i < 9; i++)
                    Level[i + 9] = new Brick(40 + i * 100, 90);
                for (int i = 0; i < 9; i++)
                    Level[i + 18] = new ReinforcedBrick(40 + i * 100, 130);
                for (int i = 0; i < 9; i++)
                    Level[i + 27] = new Brick(40 + i * 100, 170);
                for (int i = 0; i < 9; i++)
                    Level[i + 36] = new Brick(40 + i * 100, 210);
            }
        }

        private void LoadRecords()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                if (fs.Length != 0)
                {
                    object table = formatter.Deserialize(fs);
                    RecordTable = (table as List<ArcanoidGame.Records>);
                }
            }
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                _moveRight = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                _moveRight = false;
            }
        }

        public void Init()
        {
            platform = new Platform(Width / 2, Height - 100);
            ball = new Ball(Width / 2, 670);
        }

        private void Lvl1_Draw(Graphics a)
        {
            for (int i = 0; i < Level.Length; i++)
                if (Level[i] != null) { Level[i].Draw(a); } 
        }

        private void timer1_Tick(object sender, EventArgs e) // Таймер
        {
            ScoreOutput.Text = "Счет: " + TotalScore;
            ScoreOutput.Visible = true;

            ball.IncX();
            ball.IncY();

            if (_moveLeft == true && platform.Left() > 0)
            {
                platform.MoveLeft();
            }
            if (_moveRight == true && platform.Right() < Width)
            {
                platform.MoveRight();
            }

            if (ball.Right() > Width || ball.Left() < 0)
            {
                ball.ChangeDx();
            }
            if (ball.Top() < 16)
            {
                ball.ChangeDy();
            }
            Platform_Collision_Check();
            Brick_Collision_Check();
            Gameover_Check();

            Invalidate();
        }

        private void Brick_Collision_Check()
        {
            int message;
            for (int i = 0; i < Level.Length; i++)
                if (Level[i] != null)
                {
                    message = col(Level[i], ball);
                    if (message != 0 && Level[i].GetHP() == 0) 
                    { 
                        TotalScore++; 
                        Level[i] = null; 
                    }
                    switch (message)
                    {
                        case 1: ball.ChangeDy(); break;
                        case 2: ball.ChangeDx(); break;
                    }
                }
        }
        private void Platform_Collision_Check()
        {
            int message;
            message = colp(platform, ball);
            switch (message)
            {
                case 1: { ball.ChangeDy(); int k = rnd.Next(6, 10); ball.SetDy(k); } break;
                case 2: ball.ChangeDx(); break;
            }
        }

        private void Gameover_Check()
        {
            bool emptiness = true;
            for (int i = 0; i < Level.Length; i++)
            {
                if (Level[i] != null) { emptiness = false; }
            }

            if (emptiness)
            {
                GameOver("Вы победили!\n");
            }
            if (ball.Bot() > ClientRectangle.Height)
            {
                GameOver("Вы потерпели поражение!\n");
            }
        }

        private void OnPaint(object sender, PaintEventArgs e) // Рисование на форме
        {
            Graphics g = e.Graphics;
            platform.Draw(g);
            ball.Draw(g);
            Lvl1_Draw(g);
        }

        private void GameOver(string Result)
        {
            _gameOver = true;
            timer1.Stop();
            ScoreOutput.Location = new Point(200, 380);
            ScoreOutput.Text = Result + "Счет: " + TotalScore + "\nНажмите S, чтобы сохранить счет\n" + "Нажмите Esc, чтобы выйти в главное меню";
            CopyScore = TotalScore;
            TotalScore = 0;
            this.KeyDown += new KeyEventHandler(RecordSave);
        }

        private void RecordSave(object sender, KeyEventArgs e) // Сохранение информации о рекорде в файл
        {
            if (e.KeyValue == 83) 
            {
                string time = DateTime.Now.ToString("hh:mm:ss");
                string date = DateTime.Now.ToString("MM.dd.yyyy");
                Records rec = new Records(CopyScore, date, time);
                RecordTable.Add(rec);
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    formatter.Serialize(fs, RecordTable);
                }
            }
        }
    }
}
