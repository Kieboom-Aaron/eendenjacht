using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Duckhunt2
{
    class ImageFactory
    {
        private static ImageFactory instance;
        public BitmapImage[,] blueDuckImages;
        public BitmapImage[,] blackDuckImages;

        private ImageFactory()
        {
            blueDuckImages = new BitmapImage[8, 3];
            blueDuckImages[Directions.TOP, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/top_1.png", UriKind.Relative));
            blueDuckImages[Directions.TOP, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/top_2.png", UriKind.Relative));
            blueDuckImages[Directions.TOP, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/top_3.png", UriKind.Relative));
            blueDuckImages[Directions.TOP_RIGHT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/top_right_1.png", UriKind.Relative));
            blueDuckImages[Directions.TOP_RIGHT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/top_right_2.png", UriKind.Relative));
            blueDuckImages[Directions.TOP_RIGHT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/top_right_3.png", UriKind.Relative));
            blueDuckImages[Directions.RIGHT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/right_1.png", UriKind.Relative));
            blueDuckImages[Directions.RIGHT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/right_2.png", UriKind.Relative));
            blueDuckImages[Directions.RIGHT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/right_3.png", UriKind.Relative));
            blueDuckImages[Directions.BOTTOM_RIGHT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/bottom_right_1.png", UriKind.Relative));
            blueDuckImages[Directions.BOTTOM_RIGHT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/bottom_right_2.png", UriKind.Relative));
            blueDuckImages[Directions.BOTTOM_RIGHT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/bottom_right_3.png", UriKind.Relative));
            blueDuckImages[Directions.LEFT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/left_1.png", UriKind.Relative));
            blueDuckImages[Directions.LEFT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/left_2.png", UriKind.Relative));
            blueDuckImages[Directions.LEFT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/left_3.png", UriKind.Relative));
            blueDuckImages[Directions.BOTTOM_LEFT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/bottom_left_1.png", UriKind.Relative));
            blueDuckImages[Directions.BOTTOM_LEFT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/bottom_left_2.png", UriKind.Relative));
            blueDuckImages[Directions.BOTTOM_LEFT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/bottom_left_3.png", UriKind.Relative));
            blueDuckImages[Directions.TOP_LEFT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/top_left_1.png", UriKind.Relative));
            blueDuckImages[Directions.TOP_LEFT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/top_left_2.png", UriKind.Relative));
            blueDuckImages[Directions.TOP_LEFT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blueduck/top_left_3.png", UriKind.Relative));
            //TODO add bottom
            blackDuckImages = new BitmapImage[8, 3];
            blackDuckImages[Directions.TOP, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/top_1.png", UriKind.Relative));
            blackDuckImages[Directions.TOP, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/top_2.png", UriKind.Relative));
            blackDuckImages[Directions.TOP, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/top_3.png", UriKind.Relative));
            blackDuckImages[Directions.TOP_RIGHT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/top_right_1.png", UriKind.Relative));
            blackDuckImages[Directions.TOP_RIGHT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/top_right_2.png", UriKind.Relative));
            blackDuckImages[Directions.TOP_RIGHT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/top_right_3.png", UriKind.Relative));
            blackDuckImages[Directions.RIGHT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/right_1.png", UriKind.Relative));
            blackDuckImages[Directions.RIGHT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/right_2.png", UriKind.Relative));
            blackDuckImages[Directions.RIGHT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/right_3.png", UriKind.Relative));
            blackDuckImages[Directions.BOTTOM_RIGHT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/bottom_right_1.png", UriKind.Relative));
            blackDuckImages[Directions.BOTTOM_RIGHT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/bottom_right_2.png", UriKind.Relative));
            blackDuckImages[Directions.BOTTOM_RIGHT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/bottom_right_3.png", UriKind.Relative));
            blackDuckImages[Directions.LEFT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/left_1.png", UriKind.Relative));
            blackDuckImages[Directions.LEFT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/left_2.png", UriKind.Relative));
            blackDuckImages[Directions.LEFT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/left_3.png", UriKind.Relative));
            blackDuckImages[Directions.BOTTOM_LEFT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/bottom_left_1.png", UriKind.Relative));
            blackDuckImages[Directions.BOTTOM_LEFT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/bottom_left_2.png", UriKind.Relative));
            blackDuckImages[Directions.BOTTOM_LEFT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/bottom_left_3.png", UriKind.Relative));
            blackDuckImages[Directions.TOP_LEFT, 0] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/top_left_1.png", UriKind.Relative));
            blackDuckImages[Directions.TOP_LEFT, 1] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/top_left_2.png", UriKind.Relative));
            blackDuckImages[Directions.TOP_LEFT, 2] = new BitmapImage(new Uri(@"/Duckhunt2;component/images/blackduck/top_left_3.png", UriKind.Relative));
            //TODO add bottom
        }

        public static ImageFactory getInstance()
        {
            if (instance == null)
            {
                instance = new ImageFactory();
            }
            return instance;
        }
    }
}
