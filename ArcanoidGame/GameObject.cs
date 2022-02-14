
using System.Drawing;

namespace ArcanoidGame
{
    abstract class GameObject
    {
        protected int x;
        protected int y;

        protected int width;
        protected int height;

        protected Image ObjImg;
        public GameObject(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw(Graphics a)
        {
            a.DrawImage(ObjImg, new RectangleF(x, y, width, height));
        }
        public int GetX() { return x + width/2; }
        public int GetY() { return y + height/2; }
        public int Right() { return x + width; }
        public int Left() { return x; }
        public int Top() { return y; }
        public int Bot() { return y + height; }
    }
}
