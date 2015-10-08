using Duckhunt2.containers;
using Duckhunt2.objects;
using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Duckhunt2
{
    class TextDisplay : DrawableObject
    {
        private TextBlock textBlock;
        public TextDisplay(int x, int y, String text, Color c, int size)
        {

            textBlock = new TextBlock();
            textBlock.FontFamily = new FontFamily("Arial");
            textBlock.FontSize = size;
            textBlock.Text = text;
            textBlock.Foreground = new SolidColorBrush(c);
            Canvas.SetLeft(textBlock, x);
            Canvas.SetTop(textBlock, y);
            DrawContainer.getInstance().Add(this);
        }

        public void Accept(DrawVisitor dv, double delta)
        {
            //not needed automatich updating
        }

        public UIElement getDrawable()
        {
            return textBlock;
        }

        public void setText(String text)
        {
            textBlock.Text = text;
        }
    }
}
