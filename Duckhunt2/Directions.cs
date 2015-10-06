using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2
{
    class Directions
    {
        public const int TOP = 0;
        public const int TOP_RIGHT = 1;
        public const int RIGHT = 2;
        public const int BOTTOM_RIGHT = 3;
        public const int BOTTOM = 4;
        public const int BOTTOM_LEFT = 5;
        public const int LEFT = 6;
        public const int TOP_LEFT = 7;
        public static int[] TOP_DIRECTIONS = new int[3] { TOP_LEFT, TOP, TOP_RIGHT };
        public static int[] RIGHT_DIRECTIONS = new int[3] { TOP_RIGHT, RIGHT, BOTTOM_RIGHT };
        public static int[] BOTTOM_DIRECTIONS = new int[3] { BOTTOM_LEFT, LEFT, BOTTOM_RIGHT };
        public static int[] LEFT_DIRECTIONS = new int[3] { TOP_LEFT, LEFT, BOTTOM_LEFT };
    }
}
