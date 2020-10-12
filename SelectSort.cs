using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    /// <summary>
    /// 选择排序
    /// </summary>
    public class SelectSort
    {
        /// <summary>
        /// 选择排序，算法的时间复杂度为O(n^2)，算法不稳定
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            int min = 0;    // 指向最小的元素的位置
            for (int i = 0; i < length - 1; i++)// 外层循环
            {
                min = i;
                for (int j = i + 1; j < length; j++)// 内存循环
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;//保存最小位置
                    }
                }
                if (min != i)
                {
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}
