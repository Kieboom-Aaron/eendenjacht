using Duckhunt2.containers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using Duckhunt2.factories;
using System.Windows.Media;
using Duckhunt2.rounds;

namespace Duckhunt2 {
    class Game {
        BackgroundWorker bw;
        Stopwatch stopwatch;
        public Canvas canvas { get; private set; }
        public InputHandler inputHandler { get; private set; }
        bool isRunning;
        double delta;
        const int frameDelay = 17;
        public Round currentRound { get; set; }
        public UnitFactory unitFactory { get; private set; }
        public RoundStateFactory stateFactory { get; private set; }

        public Game(Canvas canvas) {
            this.canvas = canvas;
            isRunning = true;
            unitFactory = new UnitFactory(canvas);
            stateFactory = new RoundStateFactory();
            Score.getInstance();
            inputHandler = new InputHandler(this, InputContainer.getInstance());

            //create rounds
            createRounds();

            bw = new BackgroundWorker();
            bw.ProgressChanged += bw_ProgressChanged;
            bw.WorkerReportsProgress = true;
            bw.DoWork += bw_DoWork;
            stopwatch = new Stopwatch();
            bw.RunWorkerAsync();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e) {
            int lastElapsed = frameDelay;
            while(isRunning) {
                
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                
                delta = elapsedMilliseconds / 1000.0;
                stopwatch.Reset();
                stopwatch.Start();
                InputContainer.getInstance().Execute();
                MoveContainer.getInstance().Move(delta);
                CollisionContainer.getInstance().CheckCollision();
                bw.ReportProgress(1);
                int elapsed = (int)Math.Ceiling((decimal)elapsedMilliseconds);
                
                //The time the thread sleeps should be less if the tick took longer to run
                int sleepTime = Math.Min(frameDelay, frameDelay - (lastElapsed - frameDelay));
                //Can't wait less then 0 time
                if(sleepTime < 0) {
                    sleepTime = 0;
                }
                lastElapsed = elapsed;
                Thread.Sleep(sleepTime);
            }
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            DrawContainer.getInstance().Draw(canvas, delta);
        }

        private void createRounds()
        {
            Round r1 = new FirstRound(this);
            Round r2 = new SecondRound(this);
            r1.nextRound = r2;
            r1.start();
        }
    }
}
