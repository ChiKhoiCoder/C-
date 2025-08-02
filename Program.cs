using System;
using System.Transactions;
using ZstdSharp.Unsafe;


namespace programing
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[n];
            for(int i =  0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
           
            var number = from i in arr
                         where i % 2 == 0
                         select i;
          foreach(int i in number)
            {
                Console.WriteLine(i);
            }
        }
    }
   
}

