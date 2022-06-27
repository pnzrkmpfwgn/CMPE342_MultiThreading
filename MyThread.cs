using System;
using System.Threading;

namespace ConsoleApp2
{
    public class MyThread
    {
        public static void Thread1()
        {
            Thread t = Thread.CurrentThread;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(t.Name + " " + i);
                Thread.Sleep(200);
            }
        }

        static void Main(string[] args)
        {

            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t3 = new Thread(new ThreadStart(MyThread.Thread1));

            t1.Name = "T1";
            t2.Name = "T2";
            t3.Name = "T3";

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
