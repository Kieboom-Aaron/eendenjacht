using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Duckhunt2.states
{
    class DeadUnitState : UnitState
    {
        public void Draw(Unit unit, double delta)
        {
            unit._currentImage.Source = unit._imageSets[Directions.BOTTOM, unit._imageStep];
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
            unit._y += 100 * delta;
        }

        public UnitState Clone()
        {
            return (UnitState)this.MemberwiseClone();
        }
    }
}
