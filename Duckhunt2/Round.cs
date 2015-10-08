using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duckhunt2.factories;

namespace Duckhunt2 {
    class Round {
        private Dictionary<string, int> units;
        private string name;
        private UnitFactory unitFactory;
        public Round(string name, Dictionary<string, int> units, UnitFactory unitFactory) {
            this.units = units;
            this.name = name;
            this.unitFactory = unitFactory;
        }

        public void start() {
            //Display name (pre-round)
            //Spawn units (during round)
            foreach(KeyValuePair<string, int> entry in units) {
                for(int i = 0; i < entry.Value; i++) {
                    unitFactory.Create(entry.Key);
                }
            }
            //Show something or just cleanup (post round)
        }


    }
}
