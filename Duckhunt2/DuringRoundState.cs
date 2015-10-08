using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duckhunt2.containers;
using Duckhunt2.inputs;

namespace Duckhunt2 {
    class DuringRoundState  : State{

        public void doAction(Game game) {
            InputContainer.getInstance().Add(new ShootInput(game, UnitContainer.getInstance().objects));
        }

        public State Clone() {
            return (State)this.MemberwiseClone();
        }
    }
}
