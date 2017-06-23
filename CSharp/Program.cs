using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DollarsAndCents.Algorithims;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace DollarsAndCents
{
    class Program
    {
        static List<AlgoBase> Algorithims = new List<AlgoBase>();
        static void Main(string[] args)
        {




            Algorithims.Add(new _01_Base());
            Algorithims.Add(new _02_EarlyExitCents());
            Algorithims.Add(new _03_TightLoops());
            Algorithims.Add(new _04_NoCents());
            Algorithims.Add(new _05_NoNickles());
            Algorithims.Add(new _06_Parallel());
            Algorithims.Add(new _07_Tasks());
            Algorithims.Add(new _08_Dynamic());
            Algorithims.Add(new _09_TightDynamic());
            Algorithims.Add(new _10_Polynomial());

            
             

            Console.WriteLine("1. Run all algorithim for specific amount");
            Console.WriteLine("2. Run specific algorithim across range of amounts");
            //Console.WriteLine("2. Create Runtime Graph");
            var val = Console.ReadLine();
            if (val == "1")
            { DoAmountForAll(); }
            if (val == "2")
            {
                DoAlgorithim();
            }
            
            

        }

        private static void DoAlgorithim()
        {
            
        }



         
            
         




        private static void DoAmountForAll()
        {
            Console.Write("Amount of money? ");


            while (true)
            {
                var money = int.Parse(Console.ReadLine());
                Console.WriteLine(string.Format("{0,-20}| {1,-20}| {2,-15}| {3,-15}", "Method", "Avg Ms.", "Cycles", "Results Count"));
                Console.WriteLine(string.Join("",Enumerable.Repeat("-", 76)));
                foreach (var item in Algorithims)
                {
                    Do(item, money);
                }
                 
                Console.WriteLine("Finished...");

            }
        }

        static void Do(AlgoBase Algorithim, int Money, int numtimes = 3)
        {


            var skipped = false;
            var canceled = false;
            long Ticks = 0;
            if (Algorithim.DontRunForMoreThen() > Money)
            {
                var timeoutToken = new CancellationTokenSource();
                GC.Collect();

                
                var algoTask = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < numtimes; i++)
                    {
                        if (timeoutToken.IsCancellationRequested)
                        {
                            canceled = true;
                            return;
                        }

                        Algorithim.Run(Money, timeoutToken.Token);
                        Ticks += Algorithim.Timer.ElapsedTicks;

                    }

                }, timeoutToken.Token);

                if (!algoTask.Wait(5000))
                {
                    timeoutToken.Cancel();
                    canceled = true;
                }

            }
            else
            {
                skipped = true;
            }

            



            if (canceled)
            {
                Console.WriteLine(Algorithim.GetType().Name + " - Timed out after 5 seconds");
            }
            else if (skipped)
            {
                Console.WriteLine(Algorithim.GetType().Name + " - Skipped");
            }
            else
            {

                var avgTicks = Ticks / numtimes;
                Console.WriteLine(string.Format("{0,-20}| {1,20}| {2,15}| {3,15}",
                    Algorithim.GetType().Name
                    , avgTicks
                    , Algorithim.Cycles
                    , Algorithim.Results));
            }

        }


    }


}
