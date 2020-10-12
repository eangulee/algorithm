using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    /// <summary>
    /// 归并排序
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// 归并排序，算法的时间复杂度为O(nlogn)，算法稳定
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            int[] temp = new int[length];//在排序前，先建好一个长度等于原数组长度的临时数组，避免递归中频繁开辟空间
            Sort(arr, 0, length - 1, temp);
        }

        /// <summary>
        /// 归并排序，算法的时间复杂度为O(nlogn)，算法稳定
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void Sort(int[] arr, int low, int high, int[] temp)
        {
            int mid = (low + high) / 2;
            if (low < high)
            {
                Sort(arr, low, mid, temp);//左边归并排序，使得左子序列有序
                Sort(arr, mid + 1, high, temp);//右边归并排序，使得右子序列有序
                Merge(arr, low, mid, high, temp);//将两个有序子数组合并操作
            }
        }

        private static void Merge(int[] arr, int low, int mid, int high, int[] temp)
        {
            int i = low;//左指针
            int j = mid + 1;//右指针
            int k = 0;//临时数组指针
            //把较小的数先移到新数组中
            while (i <= mid && j <= high)
            {
                if (arr[i] < arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }
            //两个数组之一可能存在剩余的元素
            //把左边剩余的移入新数组
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }
            //把右边剩余的移入新数组
            while (j <= high)
            {
                temp[k++] = arr[j++];
            }
            k = 0;
            //将temp中的元素全部拷贝到原数组中
            while (low <= high)
            {
                arr[low++] = temp[k++];
            }
        }
    }
}
