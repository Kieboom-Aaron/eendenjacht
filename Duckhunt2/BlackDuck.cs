using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Duckhunt2
{
    class BlackDuck : Unit
    {
        public BlackDuck(Canvas c):base(c)
        {
            setSpeed(200);
            _imageInterval = 0.25;
            _maxCollisions = 4;
            _imageSets = ImageFactory.getInstance().blackDuckImages;
            setImageDimentions(29, 29);
            generateStartPos(c);
        }
    }
}
