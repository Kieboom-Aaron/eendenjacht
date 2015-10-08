using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duckhunt2.factories;

namespace Duckhunt2 {
    class Round {
        private List<Unit> units;
        private string name;
        private UnitFactory unitFactory;
        public Round(string name, List<Unit> units, UnitFactory unitFactory) {
            this.units = units;
            this.name = name;
            this.unitFactory = unitFactory;
        }

        public void start() {
            //Display name (pre-round)
            //Spawn units (during round)
            //Show something or just cleanup (post round)
        }


    }
}
