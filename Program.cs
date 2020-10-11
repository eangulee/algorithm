using System;
using System.Diagnostics;
using System.Text;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100;
            int[] original = GetRandomArray(length);
            //冒泡排序
            //bubbleSort(original, length);

            //选择排序
            selectSort(original, length);

            //快速排序
            //quickSort(original, length);

            Console.ReadLine();
        }

        //冒泡排序
        public static void bubbleSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            //冒泡排序
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            BubbleSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"冒泡排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);

            //冒泡排序优化1
            Array.Copy(original, array, length);
            sw.Restart();
            BubbleSort.SortOptimized1(array);
            sw.Stop();
            Console.WriteLine($"冒泡优化1排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);

            //冒泡排序优化2
            Array.Copy(original, array, length);
            sw.Restart();
            BubbleSort.SortOptimized2(array);
            sw.Stop();
            Console.WriteLine($"冒泡优化2排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);
        }

        //选择排序
        public static void selectSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            SelectSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"选择排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);
        }

        //快速排序
        public static void quickSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            QuickSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"快速排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);
        }

        public static int[] GetRandomArray(int length)
        {
            int[] arr = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(0, length);
            }
            return arr;
        }

        public static void WriteArray(int[] arr)
        {
            int length = arr.Length > 100 ? 100 : arr.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(arr[i]);
                sb.Append(",");
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb.ToString());
        }
    }
}
