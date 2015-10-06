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

namespace Duckhunt2
{
    class Game
    {
        BackgroundWorker bw;
        Stopwatch s;
        Canvas c;
        bool isRunning;
        double delta;
        public Game(Canvas canvas)
        {
            c = canvas;
            isRunning = true;
            new BlueDuck(c);
            new BlackDuck(c);
            bw = new BackgroundWorker();
            bw.ProgressChanged += bw_ProgressChanged;
            bw.WorkerReportsProgress = true;
            bw.DoWork += bw_DoWork;
            s = new Stopwatch();
            bw.RunWorkerAsync();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (isRunning)
            {
                delta = s.ElapsedMilliseconds / 1000.0;
                s.Reset();
                s.Start();
                MoveContainer.getInstance().Move(delta);
                CollisionContainer.getInstance().CheckCollision();
                bw.ReportProgress(1);
                Thread.Sleep(20);
            }
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DrawContainer.getInstance().Draw(c, delta);
        }
    }
}
