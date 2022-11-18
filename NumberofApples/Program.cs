using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NumberofApples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, max = 0,Q=0,NumMar=0;                          // max Indicates The Total Number of Fruits that Martket Have ,, Q and NumMar Indicates just count purpose for Showing  in Console like '1 Query,2 Query' ....and ' Enter the Number of Fruits that  market 1 have ' 
            Console.WriteLine("Enter the Number of shops :");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the NUmeber of  Apples have evry shop: ");
            int[] arr1 = new int[N];
            for (int i = 0; i < N; i++)
            {
                NumMar++;
                Console.Write("Enter the number of Fruits that" +NumMar +" Market Have: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                max += arr1[i];
            }
            Console.WriteLine("Enter the Number Of Query");
            int K = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[K];
            for (int i = 0; i < K; i++)
            {
                Q++;
                Console.Write(Q+" Query: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Total Number of Fruit Market:" + max+"\n\n");  
            for (int z = 0; z < K; z++)
            {
                for (int i = 1; i <= max; i++)
                {
                    sum = 0;
                    for (int j = 0; j < N; j++)
                    {
                        if (arr1[j] <= i)
                        {
                            sum += arr1[j];
                        }
                        else
                        {
                            sum += i;
                        }
                    }
                    if (sum >= arr[z] || (sum >= max))
                    {
                        if (sum >= max)
                        {

                            Console.WriteLine("-1");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
