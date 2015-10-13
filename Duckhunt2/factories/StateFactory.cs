using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duckhunt2.states;

namespace Duckhunt2.factories {
    class RoundStateFactory {
        private Dictionary<string, RoundState> states;

        public RoundStateFactory() {
            states = new Dictionary<string, RoundState>();
            fillDictionary();
        }

        private void fillDictionary() {
            states.Add("round-notactive", new NotInRoundState());
            states.Add("round-active", new DuringRoundState());
            states.Add("round-waiting", new WaitingRoundState());
        }

        public RoundState create(string id) {
            RoundState proto = states[id];
            if(proto != null) {
                return proto.Clone();
            } else {
                Debug.Fail("Not a valid id: " + id);
                return null;
            }
        }
    }
}
