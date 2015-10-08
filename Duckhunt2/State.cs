using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2 {
    interface State {
        void doAction(Game game);
        State Clone();
    }
}
