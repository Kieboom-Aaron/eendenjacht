using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.rounds
{
    class FirstRound : Round
    {
        public FirstRound(Game g)
            : base(g)
        {
            name = "Level 1";
            waves = new List<Dictionary<string, int>>();
            Dictionary<string, int> wave1 = new Dictionary<string, int>();
            wave1.Add("blueduck", 3);
            waves.Add(wave1);
            Dictionary<string, int> wave2 = new Dictionary<string, int>();
            wave2.Add("blackduck", 4);
            waves.Add(wave2);
        }

    }
}
