using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    /// <summary>
    /// 桶排序
    /// </summary>
    public class BucketSort
    {
        /// <summary>
        /// 桶排序，算法的时间复杂度为O(n+k)，算法稳定
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int length = arr.Length;
            // 计算最大值与最小值
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < length; i++)
            {
                max = Math.Max(max, arr[i]);
                min = Math.Min(min, arr[i]);
            }

            // 计算桶的数量
            int bucketNum = (max - min) / length + 1;
            List<List<int>> bucketArr = new List<List<int>>(bucketNum);
            for (int i = 0; i < bucketNum; i++)
            {
                bucketArr.Add(new List<int>());
            }

            // 将每个元素放入桶
            for (int i = 0; i < length; i++)
            {
                int num = (arr[i] - min) / (length);
                bucketArr[num].Add(arr[i]);
            }

            // 对每个桶进行排序
            for (int i = 0; i < bucketArr.Count; i++)
            {
                bucketArr[i].Sort();
            }

            // 将桶中的元素赋值到原序列
            int index = 0;
            for (int i = 0; i < bucketArr.Count; i++)
            {
                for (int j = 0; j < bucketArr[i].Count; j++)
                {
                    arr[index++] = bucketArr[i][j];
                }
            }
        }
    }
}
