using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DollarsAndCents.Algorithims
{
    public class _02_EarlyExitCents : AlgoBase
    {
        protected override void Algorithim(CancellationToken cToken)
        {
            for (int q = 0; q < Quarters +1; q++)
            {
                cToken.ThrowIfCancellationRequested();
                for (int d = 0; d < Dimes+1; d++)
                {
                    for (int n = 0; n < Nickels+1; n++)
                    {
                        for (int c = 0; c < Cents+1; c++)
                        {
                            Cycles++;
                            var val = q * 25 + d * 10 + n * 5 + c  ;
                            if (val == Cents)
                            {
                                Results++;
                                break;
                            }
                            else
                            {
                                if (val > Cents)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }

        }

        public override int DontRunForMoreThen()
        {
            return 999;
        }
    }
}
