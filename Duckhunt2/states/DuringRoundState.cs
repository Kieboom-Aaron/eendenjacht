using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duckhunt2.containers;
using Duckhunt2.inputs;
using System.Windows.Media;

namespace Duckhunt2 {
    class DuringRoundState  : RoundState{

        public void doAction(Game game) {
            InputContainer.getInstance().Add(new ShootInput(game, UnitContainer.getInstance().objects));
        }
        public void spawnUnits(Round r, double delta)
        {
            //DO NOTHING
        }
        public RoundState Clone() {
            return (RoundState)this.MemberwiseClone();
        }
    }
}
