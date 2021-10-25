using System;

namespace Taskt1
{
    class Program
    {
        static void Main()
        {
            var array = CreateArray();

            ReverseArray(array);

            InsertNewValueByIndex(array);
        }

        private static void InsertNewValueByIndex(int[] array)
        {
            var arrayWorker = new ArrayWorker.ArrayWorker();
            var result = arrayWorker.InsertIntoArrayByIndex(array, 3, 5);
            PrintArray(result);
        }

        private static void ReverseArray(int[] array)
        {
            var worker = new ArrayWorker.ArrayWorker();
            var result = worker.Reverse(array);
            PrintArray(result);
        }

        private static int[] CreateArray()
        {
            var array = new int[10];
            for (var i = 0; i < 10; i++)
            {
                array[i] = i;
            }

            return array;
        }
        private static void PrintArray(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{result[i]}");
            }
        }
    }
}
