using Duckhunt2.containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.visitors
{
    class MoveVisitor
    {
        public void Visit(Unit unit, double delta){
            unit.state.Move(unit, delta);
        }

        internal void Visit(TimedTextDisplay timedTextDisplay, double delta)
        {
            timedTextDisplay.eleapsedTime += delta;
            if (timedTextDisplay.eleapsedTime >= timedTextDisplay.maxTime)
            {
                DrawContainer.getInstance().Remove(timedTextDisplay);
                MoveContainer.getInstance().Remove(timedTextDisplay);
            }
        }

        public void Visit(Round round, double delta)
        {
            round.spawnWave(delta);
        }
    }
}
