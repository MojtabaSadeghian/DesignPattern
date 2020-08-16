using Iterator.Aggregate;
using Iterator.Iterator;
using System;

namespace Iterator
{
    class Program
    {
        static void Main()
        {
            INewspaper nyp = new NYPaper();
            INewspaper lap = new LAPaper();

            IIterator nypIterator = nyp.CreateIterator();
            IIterator lapIterator = lap.CreateIterator();

            Console.WriteLine("--------   NYPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("--------   LAPaper");
            PrintReporters(lapIterator);

            Console.ReadLine();
        }

        static void PrintReporters(IIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
