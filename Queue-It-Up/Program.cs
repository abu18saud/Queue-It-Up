using System;
using System.Collections.Generic;

namespace Queue_It_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            while (q.Count < 3)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                //your code goes here
                q.Enqueue(num);
            }

            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();


            Console.Write("Sorted: ");
            //your code goes here
            int[] arr = q.ToArray();
            Array.Sort(arr);
            foreach (int i in arr)
                Console.Write(i + " ");


            /*
            Queue<int> q = new Queue<int>();
            
            q.Enqueue(5);
            q.Enqueue(10);
            q.Enqueue(15);
            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 5  10  15
            Console.Write("\nCount: " + q.Count);  // 3
            
            Console.Write("\nDequeue: " + q.Dequeue()); // 5
            
            Console.Write("\nQueue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 10  15
            Console.Write("\nCount: " + q.Count);  // 2
             * */
        }
    }
}
