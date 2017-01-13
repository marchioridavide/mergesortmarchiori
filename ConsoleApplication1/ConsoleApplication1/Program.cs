using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            long[] times = new long[10000];
            
 
            for (int k=0;k<10000;k++)
            {
                int[] vet = new int[10000];
                random(vet);
                int num = 0;
                MergeSort m = new MergeSort();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                m.sort(vet, 0, 9999);
                times[k] = watch.ElapsedMilliseconds;
                try
                {
                    for (int i = 0; i < vet.Length; i++)
                    {
                        if (vet[i] <= vet[i + 1])
                        {
                            num++;
                        }
                        
                    }
                }
                catch { };

                if (num == 9999)
                {
                    Console.WriteLine("ok");

                }
                else 
                {
                    Console.WriteLine("nop");
                }
            }

            Console.WriteLine(Sum(times)+"ms");
            Console.ReadLine();

        }
        static void random(int[] v)
        {
            Random r = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = r.Next(1, 100000);
            }
        }

        static long Sum(long [] array)
        {
            long result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }

            return Media(result,array);
        }
        static long Media(long sum, long[] array)
        {
            int n = array.Length;
            long media = (sum / n);
            return media;
        }

      
    }
}
