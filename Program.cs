using System;
using System.Threading;

namespace ConsoleApp2
{
    public class MyThread
    {
        public static void Thread1()
        {
            Console.WriteLine("Task one");
            Thread.Sleep(500);
            Console.WriteLine("Task one");
            Thread.Sleep(500);
        }

        public static void Thread2()
        {
            Console.WriteLine("Task Two");
            Thread.Sleep(500);
            Console.WriteLine("Task Two");
            Thread.Sleep(500);

        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));

            t1.Start();
            t2.Start();
        }
    }
}
