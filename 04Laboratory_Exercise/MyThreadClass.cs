using System;
using System.Threading;

namespace _04Laboratory_Exercise
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;

                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);

                Thread.Sleep(1500);
            }
        }
    }
}
