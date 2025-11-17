using System;

namespace FileHandlingDemo
{
    public class GarbageCollectorDemo
    {
        public GarbageCollectorDemo()
        {
            Console.WriteLine("Garbage Collector Demo Initialized");
        }

        public void RunGarbageCollectorDemo()
        {
            Sample sample = new Sample();
            sample.Display();

            sample = null;

            GC.Collect();
            Console.WriteLine("Memory after first collection: " + GC.GetTotalMemory(false));

            GC.Collect();
            Console.WriteLine("Max Generation: " + GC.MaxGeneration);
        }
    }

    public class Sample
    {
        public Sample()
        {
            Console.WriteLine("Sample Class Constructor");
        }

        public void Display()
        {
            Console.WriteLine("Display Method of Sample Class");
        }

        ~Sample()
        {
            Console.WriteLine("Sample Class Destructor");
        }
    }
}
