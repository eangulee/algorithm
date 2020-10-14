using System;
using System.Diagnostics;
using System.Text;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 50000;//随机条数
            int[] original = GetRandomArray(length);
            //冒泡排序
            bubbleSort(original, length);

            //选择排序
            selectSort(original, length);

            //插入排序
            insertionSort(original, length);

            //希尔排序
            shellSort(original, length);

            //快速排序
            quickSort(original, length);

            //归并排序
            mergeSort(original, length);

            //堆排序
            heapSort(original, length);

            //计数排序
            countingSort(original, length);

            //桶排序
            bucketSort(original, length);

            //基数排序
            radixSort(original, length);

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

        //插入排序
        public static void insertionSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            InsertionSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"插入排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);
        }

        //希尔排序
        public static void shellSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            ShellSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"希尔排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
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

        //归并排序
        public static void mergeSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            MergeSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"归并排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);
        }


        //堆排序
        public static void heapSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            HeapSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"堆排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);
        }

        //计数排序
        public static void countingSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            CountingSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"计数排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);
        }


        //桶排序
        public static void bucketSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            BucketSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"桶排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);
        }


        //基数排序
        public static void radixSort(int[] original, int length)
        {
            Stopwatch sw = new Stopwatch();
            int[] array = new int[length];
            Array.Copy(original, array, length);

            sw.Restart();
            RadixSort.Sort(array);
            sw.Stop();
            Console.WriteLine($"基数排序{length}条数据耗时：{sw.ElapsedMilliseconds}毫秒");
            WriteArray(array);
        }

        /// <summary>
        /// 获取随机数组
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] GetRandomArray(int length, int max = 1000000)
        {
            int[] arr = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(0, max);
            }
            return arr;
        }

        public static void WriteArray(int[] arr)
        {
            //return;
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
