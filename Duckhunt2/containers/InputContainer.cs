using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duckhunt2.objects;

namespace Duckhunt2.containers {
    class InputContainer {
        private List<InputObject> objects;
        private List<InputObject> removeStack;
        private List<InputObject> addStack;
        private static InputContainer instance;

        private bool isRunning;

        private InputContainer() {
            objects = new List<InputObject>();
            removeStack = new List<InputObject>();
            addStack = new List<InputObject>();
            isRunning = false;
        }

        public static InputContainer getInstance() {
            if(instance == null) {
                instance = new InputContainer();
            }
            return instance;
        }

        public void Add(InputObject obj) {
            if(isRunning) {
                addStack.Add(obj);
            } else {
                objects.Add(obj);
            }
        }

        public void Remove(InputObject obj) {
            if(isRunning) {
                removeStack.Add(obj);
            } else {
                objects.Remove(obj);
            }
        }

        public void Execute() {
            isRunning = true;
            foreach(InputObject input in objects) {
                input.Execute();
            }
            objects.Clear();
            isRunning = false;
            addDelayedObjects();
            removeDelayedObjects();
        }


        //Add the items that were stored temporarily while Execute was running.
        private void addDelayedObjects() {
            if(addStack.Count > 0) {
                foreach(InputObject input in addStack) {
                    objects.Add(input);
                }
                addStack.Clear();
            }
        }

        //Remove the items that were stored temporarily while Execute was running.
        private void removeDelayedObjects() {
            if(removeStack.Count > 0) {
                foreach(InputObject input in removeStack) {
                    objects.Remove(input);
                }
                removeStack.Clear();
            }
        }
    }
}
