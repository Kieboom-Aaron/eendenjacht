using Duckhunt2.states;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.factories
{


    class UnitStateFactory
    {
        private Dictionary<string, UnitState> states;
        private static UnitStateFactory instance;
        public static UnitStateFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnitStateFactory();
                }
                return instance;
            }
            private set { }
        }
        private UnitStateFactory()
        {
            states = new Dictionary<string, UnitState>();
            fillDictionary();
        }

        private void fillDictionary()
        {
            states.Add("unit-alive", new AliveUnitState());
            //states.Add("unit-shot", new DuringRoundState());
            states.Add("unit-dead", new DeadUnitState());
        }

        public UnitState create(string id)
        {
            UnitState proto = states[id];
            if (proto != null)
            {
                return proto.Clone();
            }
            else
            {
                Debug.Fail("Not a valid id: " + id);
                return null;
            }
        }
    }
}
