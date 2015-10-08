using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2 {
    class NotInRoundState  : State{
        public void doAction(Game game) {
            //DO NOTHING            
        }

        public State Clone() {
            return (State)this.MemberwiseClone();
        }
    }
}