using System;

namespace Deodorant_Evaporator
{
    public class Evaporator
    {
        public static int evaporator(double content, double evap_per_day, double threshold)
        {
            var i = 0;
            threshold = (content / 100) * threshold;
            for (i = 0; content > threshold; i++)
            {
                content = content - ((content / 100) * evap_per_day);
            }
            return i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EvaporatorTests.Test(22, Evaporator.evaporator(10, 10, 10));
            EvaporatorTests.Test(29, Evaporator.evaporator(10, 10, 5));
            EvaporatorTests.Test(59, Evaporator.evaporator(100, 5, 5));
            EvaporatorTests.Test(37, Evaporator.evaporator(50, 12, 1));
            EvaporatorTests.Test(31, Evaporator.evaporator(47.5, 8, 8));
            EvaporatorTests.Test(459, Evaporator.evaporator(100, 1, 1));
            EvaporatorTests.Test(459, Evaporator.evaporator(10, 1, 1));
            EvaporatorTests.Test(299, Evaporator.evaporator(100, 1, 5));
        }
    }
    public class EvaporatorTests
    {
        public static void Test(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("Correct!");
            } else Console.WriteLine("Incorrect!");
        }
    }
}
