using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DollarsAndCents.Algorithims
{
    public class _10_Polynomial : AlgoBase
    {
        protected override void Algorithim(CancellationToken cToken)
        {
            var x = Cents;
            Results = Math.Round(9.4825853624843148e-001 * Math.Pow(x, 0)
     + 1.7656842365342129e-001 * Math.Pow(x, 1)
     + 9.0002317321954683e-003 * Math.Pow(x, 2)
     + 1.3333317758640824e-004 * Math.Pow(x, 3));
            
             

        }

        public override int DontRunForMoreThen()
        {
            return int.MaxValue;
        }
    }
}
