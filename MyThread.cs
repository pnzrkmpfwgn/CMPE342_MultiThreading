using System;
using System.Threading;

namespace ConsoleApp2
{
    public class MyThread
    {
        public static void Thread1()
        {
            Thread t = Thread.CurrentThread;
            
                Console.WriteLine(t.Name + " is running.");
                
            
        }

        static void Main(string[] args)
        {

            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t3 = new Thread(new ThreadStart(MyThread.Thread1));

            t1.Name = "Player 1";
            t2.Name = "Player 2";
            t3.Name = "Player 3";

            t3.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t1.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
