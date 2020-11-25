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
            if (low < high)
            {
                int l = low, r = high;
                int k = arr[l];//比较基数
                while (l < r)
                {
                    while (l < r && arr[r] >= k)//从右往左查找第一个小于基数k的数，并放到左边
                        r--;
                    if (l < r)
                        arr[l++] = arr[r];//将arr[r]填到arr[l]中，arr[r]就形成了一个新的坑
                    while (l < r && arr[l] < k)//从左往右查找第一个大于基数k的数，并放到右边
                        l++;
                    if (l < r)
                        arr[r--] = arr[l];//将arr[l]填到arr[r]中，arr[l]就形成了一个新的坑
                }
                //退出时，l等于r。将k填到这个坑中。
                arr[l] = k;
                Sort(arr, low, l - 1);
                Sort(arr, l + 1, high);
            }
        }

        /// <summary>
        /// 快速排序，算法的时间复杂度为O(nlogn)，算法不稳定
        /// 挖坑法+分治算法
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void Sort2(int[] arr, int low, int high)
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
                Sort2(arr, low, l - 1);// 左边序列。第一个索引位置到关键值索引-1
            //左边依次排序执行完递归后，弹栈进行右边排序
            if (h < high)
                Sort2(arr, l + 1, high);// 右边序列。从关键值索引+1到最后一个
        }

        public static void Sort1(int[] arr, int low, int high)
        {
            int l = low;
            int h = high;
            int k = arr[l];//比较的数
            while (l < h)
            {
                while (l < h && arr[h] >= k) //从右往左查找右边第一个小于k的数
                {
                    h--;
                }
                if (l < h)//交换，将
                {
                    int temp = arr[h];
                    arr[h] = arr[l];
                    arr[l] = temp;
                    l++;//往右移一位，避免再次比较
                }
                while (l < h && arr[l] <= k)//从左往右查找第一个大于k的数
                {
                    l++;
                }
                if (l < h)
                {
                    int temp = arr[h];
                    arr[h] = arr[l];
                    arr[l] = temp;
                    h--;
                }

                if (l > low)
                    Sort1(arr, low, l - 1);
                if (h < high)
                    Sort1(arr, l + 1, high);
            }
        }
    }
}
