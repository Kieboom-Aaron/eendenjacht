using Duckhunt2.objects;
using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Duckhunt2.containers
{
    class DrawContainer {
        private List<DrawableObject> objects;
        private List<DrawableObject> removeStack;
        private List<DrawableObject> addStack;
        private DrawVisitor mv;
        private bool isRunning;
        private static DrawContainer instance;

        private DrawContainer()
        {
            objects = new List<DrawableObject>();
            removeStack = new List<DrawableObject>();
            addStack = new List<DrawableObject>();
            mv = new DrawVisitor();
            isRunning = false;
        }

        public static DrawContainer getInstance()
        {
            if (instance == null)
            {
                instance = new DrawContainer();
            }
            return instance;
        }

        public void Add(DrawableObject mo)
        {
            addStack.Add(mo);
        }

        public void Remove(DrawableObject mo)
        {
                removeStack.Add(mo);
        }

        public void Draw(Canvas c, double delta)
        {
            foreach (DrawableObject mo in addStack)
            {
                objects.Add(mo);
                c.Children.Add(mo.getImage());
            }
            addStack.Clear();
            foreach (DrawableObject mo in objects)
            {
                mo.Accept(mv, delta);
            }
            isRunning = false;
            foreach (DrawableObject mo in removeStack)
            {
                objects.Remove(mo);
                c.Children.Remove(mo.getImage());
            }
            removeStack.Clear();
        }
    }
}
