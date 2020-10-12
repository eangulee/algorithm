using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    /// <summary>
    /// 插入排序
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        /// 插入排序，算法的时间复杂度为O(n^2)，算法稳定
        /// 升序排序
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            int temp = 0;//保存基准数
            int index = 0;//坑的位置
            for (int i = 1; i < length; i++)//外层遍历无序序列
            {
                index = i;
                temp = arr[i];
                for (int j = i - 1; j >= 0; j--) //内层遍历有序序列(从后往前)
                {
                    if (temp < arr[j])//基准数根有序序列中的元素比较
                    {
                        arr[j + 1] = arr[j];
                        index = j;
                    }
                }
                arr[index] = temp;//填坑
            }
        }

        /// <summary>
        /// /// 插入排序另外一种实现，算法的时间复杂度为O(n^2)，算法稳定
        /// 升序排序
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort1(int[] arr)
        {
            int length = arr.Length;
            int temp = 0;//保存基准数
            for (int i = 1; i < length; i++)//外层遍历无序序列
            {
                if (arr[i] < arr[i - 1])
                {
                    temp = arr[i];
                    int j = 0;
                    for (j = i - 1; j >= 0 && temp < arr[j]; j--) //内层遍历有序序列(从后往前)
                    {
                        if (temp < arr[j])//基准数根有序序列中的元素比较
                        {
                            arr[j + 1] = arr[j];
                        }
                    }
                    arr[j] = temp;//填坑
                }
            }
        }
    }
}
