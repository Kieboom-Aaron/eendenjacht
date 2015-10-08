using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using Duckhunt2.objects;
using Duckhunt2.visitors;
using Duckhunt2.containers;

namespace Duckhunt2
{
    class TimedTextDisplay : TextDisplay, MoveableObject
    {
        public double eleapsedTime;
        public int maxTime;
        public TimedTextDisplay(int x, int y, String text, Color c, int size, int seconds):base(x, y, text, c, size){
            eleapsedTime = 0;
            maxTime = seconds;
            MoveContainer.getInstance().Add(this);
        }

        public void Accept(MoveVisitor mv, double delta)
        {
            mv.Visit(this, delta);
        }
    }
}
