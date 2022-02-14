
using System.Drawing;

namespace ArcanoidGame
{
    class ReinforcedBrick : Brick
    {
        public ReinforcedBrick(int x, int y) : base (x, y)
        {
            ObjImg = new Bitmap(Properties.Resources.ReinforcedBrick);
            width = 100;
            height = 40;
            HP = 2;
        }

        public override void ConfirmHit() // Смена пикчи при ударе в укрепленный блок
        {
            HP--;
            if (HP == 1) { ObjImg = new Bitmap(Properties.Resources.HitReinforcedBrick); }
        }
    }
}
