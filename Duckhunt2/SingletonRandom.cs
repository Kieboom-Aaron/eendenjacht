using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2
{
    class SingletonRandom :Random
    {
        private static SingletonRandom instance;
        public static SingletonRandom getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonRandom();
            }
            return instance;
        }
    }
}
