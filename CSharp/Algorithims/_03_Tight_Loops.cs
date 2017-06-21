using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DollarsAndCents.Algorithims
{
    public class _03_TightLoops : AlgoBase
    {
        protected override void Algorithim(CancellationToken cToken)
        {
            for (int q = 0; q < Cents +1; q+=25)
            {
                cToken.ThrowIfCancellationRequested();
                for (int d = 0; d +q< Cents+1; d+=10)
                {
                    for (int n = 0; q + d + n < Cents + 1; n += 5)
                    {
                        for (int c = 0; q + d + n + c < Cents + 1; c++)
                        {
                            Cycles++;
                            var val = q + d + n + c;
                            if (val == Cents)
                            {
                                Results++;
                                break;
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
