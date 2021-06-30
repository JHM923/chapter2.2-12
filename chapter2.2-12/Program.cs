using System;
using System.Collections.Generic;
namespace chapter2._2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> enumerable = CreateSimpleIterator();
            static IEnumerable<int> CreateSimpleIterator()
            {
                yield return 10;
                for (int i = 0; i < 3; i++)
                {
                    yield return i;
                }
                yield return 20;
            }
            using (IEnumerator<int> enumerator =
                enumerable.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        int value = enumerator.Current;
                        Console.WriteLine(value);
                    }
                }
                Console.ReadKey();
        }
    }
}
