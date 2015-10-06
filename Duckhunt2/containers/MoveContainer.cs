using Duckhunt2.objects;
using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.containers
{
    class MoveContainer
    {
        private List<MoveableObject> objects;
        private List<MoveableObject> removeStack;
        private MoveVisitor mv;
        private bool isRunning;
        private static MoveContainer instance;

        private MoveContainer()
        {
            objects = new List<MoveableObject>();
            removeStack = new List<MoveableObject>();
            mv = new MoveVisitor();
            isRunning = false;
        }

        public static MoveContainer getInstance()
        {
            if (instance == null)
            {
                instance = new MoveContainer();
            }
            return instance;
        }

        public void Add(MoveableObject mo)
        {
            objects.Add(mo);
        }

        public void Remove(MoveableObject mo)
        {
            if (isRunning)
            {
                removeStack.Add(mo);
            }
            else
            {
                objects.Remove(mo);
            }
        }

        public void Move(double delta)
        {
            isRunning = true;
            foreach (MoveableObject mo in objects)
            {
                mo.Accept(mv, delta);
            }
            isRunning = false;
            foreach (MoveableObject mo in removeStack)
            {
                objects.Remove(mo);
            }
            removeStack.Clear();
        }
    }
}
