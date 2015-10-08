using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duckhunt2.objects;
using Duckhunt2.containers;
using Duckhunt2.visitors;
using System.Windows.Input;
using System.Windows;
using System.Diagnostics;

namespace Duckhunt2.inputs {
    class ShootInput : InputObject{
        private ShootCollision sc;
        public ShootInput(Game game, List<Unit> objects) {
            Point p = Mouse.GetPosition(game.canvas);
            sc = new ShootCollision(p.X, p.Y, objects); 
        }

        public void Execute() {
            CollisionContainer.getInstance().Add(sc);
            sc = null; //Clean up reference for garbage collection
        }
    }
}
