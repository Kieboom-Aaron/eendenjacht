using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2 {
    interface RoundState {
        void doAction(Game game);

        void spawnUnits(Round r, double delta);
        RoundState Clone();
    }
}
