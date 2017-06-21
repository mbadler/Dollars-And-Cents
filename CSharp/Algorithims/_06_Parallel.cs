using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DollarsAndCents.Algorithims
{
    public class _06_Parallel : AlgoBase
    {
        protected override void Algorithim(CancellationToken cToken)
        {
            Results = Enumerable.Range(0, Quarters+1).AsParallel()
                .Select(x =>
                    {
                        cToken.ThrowIfCancellationRequested();
                        double localResults = 0;
                        for (int d = x*25; d < Cents + 1; d += 10)
                        {

                            localResults += ((Cents - d) / 5) + 1;




                        }
                        return localResults;
                    }).Sum();
           

        }

        public override int DontRunForMoreThen()
        {
            return 10000;
        }
    }
}
