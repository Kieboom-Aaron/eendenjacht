using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.states
{
    interface UnitState
    {
        void Draw(Unit unit, double delta);
        void Move(Unit unit, double delta);

        UnitState Clone();
    }
}
