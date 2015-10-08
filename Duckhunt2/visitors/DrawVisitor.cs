using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Duckhunt2.visitors
{
    class DrawVisitor
    {
        public void Visit(Unit unit, double delta)
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

        public void Visit(TextDisplay td, double delta)
        {
            td.textBlock.Text = td.text;
        }
    }
}
