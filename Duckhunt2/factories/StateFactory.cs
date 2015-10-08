using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.factories {
    class StateFactory {
        private Dictionary<string, State> states;

        public StateFactory() {
            states = new Dictionary<string, State>();
            fillDictionary();
        }

        private void fillDictionary() {
            states.Add("notinroundstate", new NotInRoundState());
            states.Add("duringroundstate", new DuringRoundState());
        }

        public State create(string id) {
            State proto = states[id];
            if(proto != null) {
                return proto.Clone();
            } else {
                Debug.Fail("Not a valid id: " + id);
                return null;
            }
        }

    }
}
