using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    /// <summary>
    /// 基数排序
    /// </summary>
    public class RadixSort
    {
        /// <summary>
        /// 基数排序，算法的时间复杂度为O(n*k)，算法稳定
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            //待排序列最大值
            int max = arr[0];
            int exp;//指数

            //计算最大值
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            //从个位开始，对数组进行排序
            for (exp = 1; max / exp > 0; exp *= 10)
            {
                //存储待排元素的临时数组
                int[] temp = new int[length];
                //分桶个数
                int[] buckets = new int[10];

                //将数据出现的次数存储在buckets中
                for (int i = 0; i < length; i++)
                {
                    //(value / exp) % 10 :value的最底位(个位)
                    buckets[(arr[i] / exp) % 10]++;
                }

                //更改buckets[i]，
                for (int i = 1; i < 10; i++)
                {
                    buckets[i] += buckets[i - 1];
                }

                //将数据存储到临时数组temp中
                for (int i = length - 1; i >= 0; i--)
                {
                    temp[buckets[(arr[i] / exp) % 10] - 1] = arr[i];
                    buckets[(arr[i] / exp) % 10]--;
                }

                //将有序元素temp赋给arr
                Array.Copy(temp, 0, arr, 0, length);
            }
        }
    }
}
