﻿using Duckhunt2.containers;
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
        public TextBlock textBlock;
        public String text;
        public int x, y, size;
        public Color color;
        public TextDisplay(int x, int y, String text, Color c, int size)
        {
            this.text = text;
            this.size = size;
            this.y = y;
            this.x = x;
            this.color = c;
            DrawContainer.getInstance().Add(this);
        }


        public void init()
        {
            textBlock = new TextBlock();
            textBlock.FontFamily = new FontFamily("Arial");
            textBlock.FontSize = size;

            textBlock.Text = text;
            textBlock.Foreground = new SolidColorBrush(color);
            Canvas.SetLeft(textBlock, x);
            Canvas.SetTop(textBlock, y);
        }
        public void Accept(DrawVisitor dv, double delta)
        {
            dv.Visit(this, delta);
        }

        public UIElement getDrawable()
        {
            return textBlock;
        }

        public void setText(String text)
        {
            this.text = text;
        }
    }
}
