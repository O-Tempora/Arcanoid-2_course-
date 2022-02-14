
using System.Drawing;

namespace ArcanoidGame
{
    class Brick : GameObject
    {
        protected int value;
        protected int HP;
        public Brick(int x, int y) : base (x, y)
        {
            value = Game.rnd.Next(1, 4); // Рандомная генерация числа
            switch (value)
            {
                case 1: ObjImg = new Bitmap(Properties.Resources.BrickGray); break;
                case 2: ObjImg = new Bitmap(Properties.Resources.BrickBrown); break;
                case 3: ObjImg = new Bitmap(Properties.Resources.BrickGreen); break;
            }
            width = 100;
            height = 40;
            HP = 1;
        }
        virtual public void ConfirmHit() 
        { 
            HP--; 
        }
        public int GetHP()
        {
            return HP;
        }
    }
}
