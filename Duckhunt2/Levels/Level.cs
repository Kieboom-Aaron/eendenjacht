using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duckhunt2.Levels {
    interface Level {
        void setup();
        void cleanup();
        void start();
    }
}
