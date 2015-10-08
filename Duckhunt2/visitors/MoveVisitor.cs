using Duckhunt2.containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.visitors
{
    class MoveVisitor
    {
        public void Visit(Unit unit, double delta){
            switch (unit._direction)
            {
                case Directions.TOP:
                    unit._y -= unit._speed * delta;
                    break;
                case Directions.TOP_RIGHT:
                    unit._y -= unit._dioSpeed * delta;
                    unit._x += unit._dioSpeed * delta;
                    break;
                case Directions.RIGHT:
                    unit._x += unit._speed * delta;
                    break;
                case Directions.BOTTOM_RIGHT:
                    unit._y += unit._dioSpeed * delta;
                    unit._x += unit._dioSpeed * delta;
                    break;
                case Directions.BOTTOM:
                    unit._y += unit._speed * delta;
                    break;
                case Directions.BOTTOM_LEFT:
                    unit._y += unit._dioSpeed * delta;
                    unit._x -= unit._dioSpeed * delta;
                    break;
                case Directions.LEFT:
                    unit._x -= unit._speed * delta;
                    break;
                case Directions.TOP_LEFT:
                    unit._y -= unit._dioSpeed * delta;
                    unit._x -= unit._dioSpeed * delta;
                    break;
            }
        }

        internal void Visit(TimedTextDisplay timedTextDisplay, double delta)
        {
            timedTextDisplay.eleapsedTime += delta;
            if (timedTextDisplay.eleapsedTime >= timedTextDisplay.maxTime)
            {
                DrawContainer.getInstance().Remove(timedTextDisplay);
                MoveContainer.getInstance().Remove(timedTextDisplay);
            }
        }
    }
}
