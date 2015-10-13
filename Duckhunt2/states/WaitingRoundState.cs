using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.states
{
    class WaitingRoundState : RoundState
    {
        public void doAction(Game game)
        {
            //Do NOTHING
        }

        public void spawnUnits(Round r, double delta)
        {
            r.state = r.game.stateFactory.create("round-active");
            if (r.passedTime > 3)
            {
                if (r.waves.Count > r.currentWave)
                {

                    foreach (KeyValuePair<string, int> entry in r.waves[r.currentWave])
                    {
                        for (int i = 0; i < entry.Value; i++)
                        {
                            Unit unit = r.game.unitFactory.Create(entry.Key, r);
                            unit.subscribe();
                        }
                    }
                    r.currentWave++;
                }
                else
                {
                    r.endRound();
                }
            }
        }

        public RoundState Clone()
        {
            return (RoundState)this.MemberwiseClone();
        }
    }
}
