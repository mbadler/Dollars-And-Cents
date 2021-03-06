﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DollarsAndCents.Algorithims
{
    //from https://rosettacode.org/wiki/Count_the_coins#C.23
    public class _08_Dynamic:AlgoBase
    {
        


        protected override void Algorithim(System.Threading.CancellationToken cToken)
        {
            var Coin = new int[] { 1, 5, 10, 25 };
            var table = new long[this.Cents+1];
            table[0] = 1;
            for (int i = 0; i < 4; i++)
            {cToken.ThrowIfCancellationRequested();
                
                var cval = Coin[i];
                for (int j = cval; j <= this.Cents; j++)
                {
                    this.Cycles++;
                    table[j] += table[j - cval];
                }
            }
            this.Results = table[this.Cents];

        }

        public override int DontRunForMoreThen()
        {
            return 100000000;
        }
    }
}
