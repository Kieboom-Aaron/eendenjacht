using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Duckhunt2.states
{
    class AliveUnitState : UnitState
    {

        public void Draw(Unit unit, double delta)
        {
            unit._currentImage.Source = unit._imageSets[unit._direction, unit._imageStep];
            unit._imageTimer += delta;
            Canvas.SetLeft(unit._currentImage, unit._x);
            Canvas.SetTop(unit._currentImage, unit._y);
            if (unit._imageTimer > unit._imageInterval)
            {
                unit._imageTimer = 0;
                unit._imageStep++;
                if (unit._imageStep > 2)
                {
                    unit._imageStep = 0;
                }
            }
        }

        public void Move(Unit unit, double delta)
        {
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

        public UnitState Clone()
        {
            return (UnitState)this.MemberwiseClone();
        }
    }
}
