using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    /// <summary>
    /// 计数排序
    /// </summary>
    public class CountingSort
    {
        /// <summary>
        /// 计数排序，算法的时间复杂度为O(n+k)，算法稳定
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            //一：求取最大值和最小值，计算中间数组的长度：中间数组是用来记录原始数据中每个值出现的频率
            int max = arr[0], min = arr[0];
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            //二：有了最大值和最小值能够确定中间数组的长度
            //存储5-0+1 = 6
            int[] pxA = new int[max - min + 1];

            //三.循环遍历旧数组计数排序: 就是统计原始数组值出现的频率到中间数组pxA中
            for (int i = 0; i < length; i++)
            {
                pxA[arr[i] - min] += 1;//数的位置上+1
            }

            //四.遍历输出
            //创建最终数组，就是返回的数组，和原始数组长度相等，但是排序完成的
            int[] result = new int[length];
            int index = 0;//记录最终数组的下标

            //先循环每一个元素  在计数排序器的下标中
            for (int i = 0; i < pxA.Length; i++)
            {
                //循环出现的次数
                for (int j = 0; j < pxA[i]; j++)
                {//pxA[i]:这个数出现的频率
                    result[index++] = i + min;//因为原来减少了min现在加上min，值就变成了原来的值
                }
            }
            Array.Copy(result, arr, length);
        }
    }
}
