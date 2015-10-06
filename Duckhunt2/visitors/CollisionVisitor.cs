using Duckhunt2.containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.visitors
{
    class CollisionVisitor
    {
        Random r;

        public CollisionVisitor()
        {
            r = new Random();
        }
        public void Visit(Unit unit)
        {
            if (unit._maxCollisions < 1)
            {
                if (unit._x + unit._imageW < 0 ||
                    unit._x > unit._canvasW ||
                    unit._y + unit._imageH < 0 ||
                    unit._y > unit._canvasH)
                {
                    MoveContainer.getInstance().Remove(unit);
                    CollisionContainer.getInstance().Remove(unit);
                    DrawContainer.getInstance().Remove(unit);
                }
            }
            else
            {
                if (unit._x < 0)
                {
                    unit._maxCollisions--;
                    unit._direction = Directions.RIGHT_DIRECTIONS[r.Next(3)];
                }
                if (unit._x + unit._imageW > unit._canvasW)
                {
                    unit._maxCollisions--;
                    unit._direction = Directions.LEFT_DIRECTIONS[r.Next(3)];
                }
                if (unit._y < 0)
                {
                    unit._maxCollisions--;
                    unit._direction = Directions.BOTTOM_DIRECTIONS[r.Next(3)];
                }
                if (unit._y + unit._imageH > unit._canvasH)
                {
                    unit._maxCollisions--;
                    unit._direction = Directions.TOP_DIRECTIONS[r.Next(3)];
                }
            }
        }
    }
}
