using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Duckhunt2.containers;
using Duckhunt2.factories;

namespace Duckhunt2 {
    class Round {
        private Dictionary<string, int> units;
        private string name;
        private UnitFactory unitFactory;
        private Game game;
        public Round(string name, Dictionary<string, int> units, Game game) {
            this.units = units;
            this.name = name;
            this.unitFactory = game.unitFactory;
            this.game = game;
        }

        public void start() {
            game.inputHandler.setState("duringroundstate");
            new TimedTextDisplay(270, 150, name, Colors.Yellow, 30, 3);
            //Display name (pre-round)
            //Spawn units (during round)
            foreach(KeyValuePair<string, int> entry in units) {
                for(int i = 0; i < entry.Value; i++) {
                    Unit unit = unitFactory.Create(entry.Key);
                    unit.subscribe();
                }
            }
            //Show something or just cleanup (post round)
        }

        public void endRound() {
            //CollisionContainer.getInstance();//TODO: end the round actually
            
        }


    }
}
