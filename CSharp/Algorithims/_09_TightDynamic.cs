using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DollarsAndCents.Algorithims
{
    //from https://rosettacode.org/wiki/Count_the_coins#C.23
    public class _09_TightDynamic:AlgoBase
    {
        


        protected override void Algorithim(System.Threading.CancellationToken cToken)
        {
            var Coin = new int[] { 1, 5, 10, 25 };
            var table = new long[(this.Cents/5)+1];
            table[0] = 1;

            //first set up the base 25 
            for (int i = 0; i < 4; i++)

            
            {
                cToken.ThrowIfCancellationRequested();
                var cval = Coin[i]==1?1:Coin[i]/5;
                for (int j = cval; j <= this.Cents/5; j++)
                {
                    this.Cycles++;
                    table[j] += table[j - cval];
                }
            }
            this.Results = table[this.Cents/5];

        }

        public override int DontRunForMoreThen()
        {
            return 100000000;
        }
    }
}
