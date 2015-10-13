using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Duckhunt2.objects
{
    interface DrawableObject
    {
        void Accept(DrawVisitor dv, double delta);
        void init();
        UIElement getDrawable();
    }
}
