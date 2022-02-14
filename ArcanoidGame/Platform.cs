
using System.Drawing;

namespace ArcanoidGame
{
    class Platform : GameObject
    {
        private int platSpeed;
        public Platform(int x, int y) : base (x, y)
        {
            ObjImg = new Bitmap(Properties.Resources.Platform);
            platSpeed = 7;
            height = 18;
            width = 140;
        }
        public void MoveLeft() 
        { 
            x -= platSpeed;
        } 
        public void MoveRight() 
        { 
            x += platSpeed; 
        }
    }
}
