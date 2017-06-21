using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DollarsAndCents.Algorithims
{
    public class _07_Tasks : AlgoBase
    {
        protected override void Algorithim(CancellationToken cToken)
        {
            //List<long> l = new List<long>();
            long l = 0;
            Parallel.For<long>(0, Quarters + 1
                , () => 0, (cQ, state, sum) =>
                {
                    cToken.ThrowIfCancellationRequested();
                    long localResults = sum;
                    for (int d = (int)cQ * 25; d < Cents + 1; d += 10)
                    {

                        localResults += ((Cents - d) / 5) + 1;
                    }
                    return localResults;

                },
                (mySum) =>
                {
                    Interlocked.Add(ref l, mySum);
                });
            Results = l;
        }

        public override int DontRunForMoreThen()
        {
            return 499999;
        }
    }
}
