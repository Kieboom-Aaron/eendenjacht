using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Duckhunt2.factories {
    class UnitFactory {
        private Canvas c;
        private Dictionary<string, Unit> units;
        public UnitFactory(Canvas c) {
            units = new Dictionary<string, Unit>();
            this.c = c;
            fillUnits();
        }

        private void fillUnits() {
            units.Add("blackduck", new BlackDuck(c));
            units.Add("blueduck", new BlueDuck(c));
        }
        public Unit Create(String id, Round r) {
            Unit proto = units[id];
            if(proto != null) {
                return proto.Clone(r);
            } else {
                Debug.Fail("Not a valid id: " + id);
                return null;
            }
        }
    }
}
