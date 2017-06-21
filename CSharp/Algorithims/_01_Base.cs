using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DollarsAndCents.Algorithims
{
    public class _01_Base:AlgoBase
    {
        protected override void Algorithim(CancellationToken cToken)
        {
            for (int q = 0; q < Quarters + 1; q++)
            {
                cToken.ThrowIfCancellationRequested();
                for (int d = 0; d < Dimes + 1; d++)
                {
                    for (int n = 0; n < Nickels + 1; n++)
                    {
                        for (int c = 0; c < Cents + 1; c++)
                        {
                            Cycles++;
                            if (q * 25 + d * 10 + n * 5 + c == Cents)
                            {
                                Results++;
                            }
                        }
                    }
                }
            }

        }

     

        public override int DontRunForMoreThen()
        {
            return 499;
        }
    }
}
