using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    /// <summary>
    /// 希尔排序
    /// </summary>
    public class ShellSort
    {
        /// <summary>
        /// 希尔排序，算法的时间复杂度为O(n^1.3)，最好O(n)，最坏O(n^2)，算法不稳定
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            int gap = length;//步长
            while (gap > 1)
            {
                gap = gap / 3 + 1;// 步长递减公式
                for (int i = 0; i < gap; i++)//分组, 对每一组, 进行插入排序
                {
                    int temp = 0;//保存基准数
                    int index = 0;//坑的位置
                    for (int j = i + gap; j < length; j += gap)
                    {
                        index = j;
                        temp = arr[j];
                        for (int k = j - gap; k >= 0; k -= gap)//有序序列(从后往前遍历)
                        {
                            if (temp < arr[k])//基准数根有序序列中的元素比较
                            {
                                arr[k + gap] = arr[k];
                                index = k;
                            }
                            else
                            {
                                break;
                            }
                        }
                        arr[index] = temp;//填坑
                    }
                }
            }
        }
    }
}
