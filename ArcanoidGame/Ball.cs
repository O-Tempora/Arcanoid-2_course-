
using System.Drawing;

namespace ArcanoidGame
{
    class Ball : GameObject
    {
        private int r;
        private int dx;
        private int dy;

        public Ball(int x, int y) : base (x, y)
        {
            ObjImg = new Bitmap(Properties.Resources.Ball);
            dy = dx = 5;
            width = height = 26;
            r = width;
        }
        public void ChangeDx() 
        { 
            dx = -dx; 
        }
        public void ChangeDy() 
        { 
            dy = -dy; 
        }
        public void SetDy(int k)
        {
            dy = k;
        }
        public void IncX() 
        { 
            x += dx;
        } 
        public void IncY() 
        { 
            y -= dy;
        }

        public int Brick_Coll(Brick obj, Ball ball) // Коллизия с блоками
        {
            int message = 0;
            if (((ball.Top() < obj.Bot() && ball.Top() > obj.Top()) || (ball.Bot() > obj.Top() && ball.Bot() < obj.Bot()))
            && ball.GetX() > obj.Left() && ball.GetX() < obj.Right())
            {
                message = 1;
                obj.ConfirmHit();
            }
            else if ((ball.Right() > obj.Left() && ball.Right() < obj.Right() || ball.Left() < obj.Right() && ball.Left() > obj.Left())
            && ball.GetY() > obj.Top() && ball.GetY() < obj.Bot())
            {
                message = 2;
                obj.ConfirmHit();
            }
            return message;
        }

        public int Platform_Coll(Platform obj, Ball ball) // Коллизия с платформой
        {
            int message = 0;
            if (ball.Bot() > obj.Top() && ball.GetX() > obj.Left() && ball.GetX() < obj.Right())
            {
                message = 1;
            }
            else if ((ball.Right() > obj.Left() && ball.Right() < obj.Right() || ball.Left() < obj.Right() && ball.Left() > obj.Left())
            && ball.GetY() > obj.Top() && ball.GetY() < obj.Bot())
            {
                message = 2;
            }
            return message;
        }
    }
}
