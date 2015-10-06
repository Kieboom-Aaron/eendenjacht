using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Duckhunt2
{
    class BlueDuck : Unit
    {
        public BlueDuck(Canvas c) : base(c)
        {
            setSpeed(500);
            _imageInterval = 0.25;
            _maxCollisions = 1;
            _imageSets = ImageFactory.getInstance().blueDuckImages;
            setImageDimentions(29, 29);
            generateStartPos(c);
        }
    }
}
