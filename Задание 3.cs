using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                X = 0,
                Y = 1,
                Expected = 1,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                X = 1,
                Y = 1,
                Expected = 1,
                ExpectedException = null
            };

            TestSum(testCase1);
            TestSum(testCase2);

        }
    }
}
