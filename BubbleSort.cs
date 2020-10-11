using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// 冒泡排序，算法的时间复杂度为O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)//外层循环
            {
                for (int j = 0; j < length - i - 1; j++)//内层循环
                {
                    if (arr[j] > arr[j + 1]) //前后比较，交换顺序，大的往后移，小的往前移
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// 冒泡排序优化版1，算法的时间复杂度为O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        public static void SortOptimized1(int[] arr)
        {
            int length = arr.Length;
            //用于计算交换的次数
            int sum = 0;
            bool sorted = false;//记录是否已经全部为有序排列
            for (int i = 0; i < length && !sorted; i++)//外层循环
            {
                sorted = true;
                for (int j = 0; j < length - i - 1; j++)//内层循环
                {
                    if (arr[j] > arr[j + 1]) //前后比较，交换顺序，大的往后移，小的往前移
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        sorted = false;
                    }
                }
                sum++;
            }
            Console.WriteLine("大循环次数为:" + sum);
        }

        /// <summary>
        /// 冒泡排序优化版2，算法的时间复杂度为O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        public static void SortOptimized2(int[] arr)
        {
            int length = arr.Length;
            //用于计算交换的次数
            int sum = 0;
            bool sorted = false;//记录是否已经全部为有序排列
            //下次要进行交换的边界
            int sortBorder = length - 1;
            for (int i = 0; i < length && !sorted; i++)//外层循环
            {
                sorted = true;
                int pos = 0;
                for (int j = 0; j < sortBorder; j++)//内层循环
                {
                    if (arr[j] > arr[j + 1]) //前后比较，交换顺序，大的往后移，小的往前移
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        sorted = false;
                        //记录最后一次交换的位置
                        pos = j;
                    }
                }
                sortBorder = pos;
                sum++;
            }
            Console.WriteLine("大循环次数为:" + sum);
        }
    }
}
