using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace Duckhunt2.visitors
{
    class DrawVisitor
    {
        public void Visit(Unit unit, double delta)
        {
            unit.state.Draw(unit, delta);
        }

        public void Visit(TextDisplay td, double delta)
        {
            td.textBlock.Text = td.text;
        }
    }
}
