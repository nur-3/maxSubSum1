using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxSubSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Kaç elemanlı");
            int m = Convert.ToInt32(Console.ReadLine());
            int maxSum = 0;

            int[] dizi = new int[10];
            Random rastgele = new Random();
            for ( m = 0; m < 10;m++ )
            {
                dizi[m] = rastgele.Next(1, 50);
            }
            sw.Start();
            
            for ( int i = 0; i < 10; i++)
            {
                for ( int j = i; j < 10; j++)
                {
                    int thisSum = 0;

                    for (int k = i; k <= j; k++)
                    {
                        thisSum += dizi[k];
                    }
                    if (thisSum > maxSum)
                    {
                        maxSum = thisSum;
                    }
                }


            }

            TimeSpan toplamSure = sw.Elapsed;
            string sure = String.Format("{0}:{1}:{2}.{3}", toplamSure.Hours, toplamSure.Minutes, toplamSure.Seconds, toplamSure.TotalMilliseconds * 1000000);
            Console.WriteLine("gerekli süre: "+ sure);
            Console.ReadLine();








        }
    }
}
