using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DollarsAndCents.Algorithims
{
    public class _05_NoNickles : AlgoBase
    {
        protected override void Algorithim(CancellationToken cToken)
        {
            for (int q = 0; q < Cents +1; q+=25)
            {
                cToken.ThrowIfCancellationRequested();
                for (int d = q; d < Cents +1; d += 10)
                {

                    Results += ((Cents - d) / 5) + 1;  
                            Cycles++;
                            
 
                   
                }
            }

        }

        public override int DontRunForMoreThen()
        {
            return 199999;
        }
    }
}
