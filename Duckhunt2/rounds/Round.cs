using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Duckhunt2.containers;
using Duckhunt2.factories;
using Duckhunt2.objects;

namespace Duckhunt2 {
    class Round : MoveableObject{
        public string name {get; protected set;}
        private UnitFactory unitFactory;
        public Game game { get; private set; }
        public double passedTime;
        private List<Unit> activeUnits;
        public int currentWave;
        public Round nextRound;
        public List<Dictionary<string, int>>waves {get; protected set;}
        public RoundState state { get; set; }
        public Round(Game game) {
            passedTime = 0;
            this.game = game;
            currentWave = 0;
            this.unitFactory = game.unitFactory;
            activeUnits = new List<Unit>();
        }

        public void start() {
            game.currentRound = this;
            new TimedTextDisplay(270, 150, name, Colors.Yellow, 30, 3);
            passedTime = 0;
            state = game.stateFactory.create("round-notactive");
            MoveContainer.getInstance().Add(this);
        }

        public void spawnWave(double delta)
        {
            state.spawnUnits(this, delta);
        }

        public void endRound() {
            if (nextRound != null)
                nextRound.start();
            else
                new TextDisplay(270, 150, "Finish", Colors.Yellow, 30);
            
        }

        public void registerUnit(Unit u)
        {
            activeUnits.Add(u);
        }

        public void removeUnit(Unit u)
        {
            activeUnits.Remove(u);
            if (activeUnits.Count <= 0)
            {
                state = game.stateFactory.create("round-waiting");
            }
        }



        public void Accept(visitors.MoveVisitor mv, double delta)
        {
            mv.Visit(this, delta);
        }
    }
}
