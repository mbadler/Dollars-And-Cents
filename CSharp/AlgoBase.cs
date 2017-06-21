using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace DollarsAndCents
{
    public abstract class AlgoBase
    {
        public int Cycles { get; protected set; }
        public double Results { get; protected set; }
        public Stopwatch Timer { get; private set; }

        public int Quarters { get; private set; }
        public int Dimes { get; private set; }
        public int Nickels { get; private set; }

        public int Cents { get; private set; }

        
        public void Run(int cents,CancellationToken cToken)
        {
            Cycles = 0;
            Results = 0;
            Quarters = cents / 25;
            Dimes = cents / 10;
            Nickels = cents / 5;
            Cents = cents;

            Timer = new Stopwatch();
            Timer.Start();
            Algorithim(cToken);
            Timer.Stop();
        }

        protected abstract void Algorithim(CancellationToken cToken);

        public abstract int DontRunForMoreThen();
        
    }
}
