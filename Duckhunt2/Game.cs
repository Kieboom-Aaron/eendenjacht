﻿using Duckhunt2.containers;
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

namespace Duckhunt2 {
    class Game {
        BackgroundWorker bw;
        Stopwatch stopwatch;
        public Canvas canvas { get; private set; }
        public InputHandler inputHandler { get; private set; }
        bool isRunning;
        double delta;
        const int frameDelay = 17;

        public UnitFactory unitFactory { get; private set; }
        public StateFactory stateFactory { get; private set; }

        public Game(Canvas canvas) {
            this.canvas = canvas;
            isRunning = true;
            unitFactory = new UnitFactory(canvas);
            stateFactory = new StateFactory();
            Score.getInstance();
            inputHandler = new InputHandler(this, InputContainer.getInstance());

            Dictionary<string, int> units = new Dictionary<string,int>();
            units.Add("blueduck", 5);
            units.Add("blackduck", 5);
            Round round = new Round("Ronde 1", units, this);
            round.start();

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
    }
}
