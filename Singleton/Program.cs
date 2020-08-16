using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            //var policy = new Policy();
            var insuredName = Policy.Instance.GetInsuredName();

            Console.WriteLine(insuredName);
        }
    }
}
