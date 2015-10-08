using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duckhunt2.objects;
using Duckhunt2.visitors;

namespace Duckhunt2 {
    class ShootCollision : CollisionObject{

        public double x { get; private set; }
        public double y { get; private set; }
        public List<Unit> objects { get; private set; }

        public ShootCollision(double x, double y, List<Unit> objects) {
            this.x = x;
            this.y = y;
            this.objects = objects;
        }


        public void Accept(CollisionVisitor cv) {
            cv.Visit(this);
        }
    }
}
