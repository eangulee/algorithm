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
        /// 快速排序，算法的时间复杂度为O(nlogn)，算法不稳定
        /// 挖坑法+分治算法
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            Sort(arr, 0, length - 1);
        }

        /// <summary>
        /// 快速排序，算法的时间复杂度为O(nlogn)，算法不稳定
        /// 挖坑法+分治算法
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void Sort(int[] arr, int low, int high)
        {
            int l = low, h = high;
            int k = arr[low];//arr[low]即arr[l]就是第一个坑
            while (l < h)
            {
                while (l < h && arr[h] >= k) //从右向左找第一个小于k的数
                {
                    h--;
                }
                if (l < h)
                {
                    int temp = arr[h];
                    arr[h] = arr[l];
                    arr[l] = temp;
                    l++;//填坑，进行过一次替换后，没必要将替换后的两值再次比较，所以l++直接下一位与k对比
                }
                while (l < h && arr[l] < k)//从左向右找第一个大于等于k的数
                {
                    l++;
                }
                if (l < h)
                {
                    int temp = arr[h];
                    arr[h] = arr[l];
                    arr[l] = temp;
                    h--;//填坑，进行过一次替换后，没必要将替换后的两值再次比较，所以h--直接上一位与k对比
                }
            }
            //先判断i > left再次进行左边排序
            if (l > low)
                Sort(arr, low, l - 1);// 左边序列。第一个索引位置到关键值索引-1
            //左边依次排序执行完递归后，弹栈进行右边排序
            if (h < high)
                Sort(arr, l + 1, high);// 右边序列。从关键值索引+1到最后一个
        }
    }
}
