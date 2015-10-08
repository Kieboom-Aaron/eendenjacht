using Duckhunt2.objects;
using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.containers
{
    class CollisionContainer
    {
        private List<CollisionObject> objects;
        private List<CollisionObject> removeStack;
        private List<CollisionObject> addStack;
        private CollisionVisitor cv;
        private bool isRunning;
        private static CollisionContainer instance;

        private CollisionContainer()
        {
            objects = new List<CollisionObject>();
            removeStack = new List<CollisionObject>();
            addStack = new List<CollisionObject>();
            cv = new CollisionVisitor();
            isRunning = false;
        }

        public static CollisionContainer getInstance()
        {
            if (instance == null)
            {
                instance = new CollisionContainer();
            }
            return instance;
        }

        public void Add(CollisionObject mo)
        {
            if(isRunning) {
                addStack.Add(mo);
            } else {
                objects.Add(mo);
            }
            } 

        public void Remove(CollisionObject mo)
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

        public void CheckCollision()
        {
            isRunning = true;
            lock(objects) {
                foreach(CollisionObject mo in objects) {
                        mo.Accept(cv);
                }
            }
            isRunning = false;
            foreach (CollisionObject mo in removeStack)
            {
                objects.Remove(mo);
            }
            removeStack.Clear();
            foreach(CollisionObject mo in addStack) {
                objects.Add(mo);
            }
            addStack.Clear();
        }
    }
}
