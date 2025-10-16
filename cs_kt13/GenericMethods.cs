using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt13
{
    internal static class GenericMethods
    {
        public static T Max<T>(T x, T y) where T : IComparable<T>
        {
            return x.CompareTo(y) >= 0 ? x : y;
        }

        public static void SwapClasses<T>(ref T x, ref T y) where T : class
        {
            (x, y) = (y, x);
        }

        public static void SwapStructs<T>(ref T x, ref T y) where T : struct
        {
            (x, y) = (y, x);
        }

        public static void Print<T>(T[] array) where T : class
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Массив пуст");
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]?.ToString() ?? "null");
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
