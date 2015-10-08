using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.containers {
    class UnitContainer {
        private static UnitContainer instance;

        public List<Unit> objects { get; private set; }

        private UnitContainer() {
            objects = new List<Unit>();
        }

        public static UnitContainer getInstance(){
            if(instance == null){
                instance = new UnitContainer();
            }
            return instance;
        }

        public void Add(Unit obj){
            //TODO: should we use lock(objects) everywhere?
            objects.Add(obj);
        }

        public void Remove(Unit obj) {
            objects.Remove(obj);
        }
    }
}
