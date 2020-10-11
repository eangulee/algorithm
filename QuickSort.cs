using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// 快速排序，算法的时间复杂度为O(nlogn)
        /// 挖坑法+分治算法
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            Sort(arr, 0, length - 1);
        }

        private static void Sort(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int k = arr[left];//arr[left]即arr[i]就是第一个坑
            while (i < j)
            {
                while (i < j && arr[j] >= k) //从右向左找第一个小于k的数
                {
                    j--;
                }
                if (i < j)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;//填坑，进行过一次替换后，没必要将替换后的两值再次比较，所以i++直接下一位与k对比
                }
                while (i < j && arr[i] < k)//从左向右找第一个大于等于k的数
                {
                    i++;
                }
                if (i < j)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    j--;//填坑，进行过一次替换后，没必要将替换后的两值再次比较，所以j--直接上一位与k对比
                }
            }
            //先判断i > left再次进行左边排序
            if (i > left)
                Sort(arr, left, i - 1);// 左边序列。第一个索引位置到关键值索引-1
            //左边依次排序执行完递归后，弹栈进行右边排序
            if (j < right)
                Sort(arr, i + 1, right);// 右边序列。从关键值索引+1到最后一个
        }
    }
}
