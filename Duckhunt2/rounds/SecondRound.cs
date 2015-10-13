using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duckhunt2
{
    class SecondRound : Round
    {
        public SecondRound(Game g):base(g)
        {
            name = "Level 2";
            waves = new List<Dictionary<string, int>>();
            Dictionary<string, int> wave1 = new Dictionary<string, int>();
            wave1.Add("blueduck", 4);
            wave1.Add("blackduck", 4);
            waves.Add(wave1);
            Dictionary<string, int> wave2 = new Dictionary<string, int>();
            wave2.Add("blueduck", 6);
            wave2.Add("blackduck", 6);
            waves.Add(wave2);
        }
    }
}
