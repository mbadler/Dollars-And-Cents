using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DollarsAndCents.Algorithims
{
    public class _04_NoCents : AlgoBase
    {
        protected override void Algorithim(CancellationToken cToken)
        {
            for (int q = 0; q < Cents +1; q+=25)
            {
                cToken.ThrowIfCancellationRequested();
                for (int d = 0; d + q < Cents + 1; d += 10)
                {
                    for (int n = 0; q + d + n < Cents + 1; n += 5)
                    {
                         
                            Cycles++;
                            Results++;
 
                    }
                }
            }

        }

        public override int DontRunForMoreThen()
        {
            return 14999;
        }
    }
}
