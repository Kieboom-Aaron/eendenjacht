using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Duckhunt2
{
    class Score
    {
        private TextDisplay td;
        private static Score instance;
        private int score;
        private Score()
        {

        }

        public static Score getInstance()
        {
            if (instance == null)
            {
                instance = new Score();
                instance.score = 0;
                instance.td = new TextDisplay(600, 10, "0", Colors.Yellow, 30);
            }
            return instance;
        }

        public void addPoint()
        {
            score++;
            td.setText(score+"");
        }
    }
}
