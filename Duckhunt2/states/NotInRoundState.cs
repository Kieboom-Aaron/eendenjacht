using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2 {
    class NotInRoundState  : RoundState{
        public void doAction(Game game) {
            //DO NOTHING            
        }

        public void spawnUnits(Round r, double delta)
        {
            r.passedTime += delta;
            if (r.passedTime > 3)
            {
                r.state = r.game.stateFactory.create("round-waiting");
            }
        }

        public RoundState Clone() {
            return (RoundState)this.MemberwiseClone();
        }
    }
}