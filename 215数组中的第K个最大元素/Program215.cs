using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215数组中的第K个最大元素
{
    //在未排序的数组中找到第 k 个最大的元素。请注意，你需要找的是数组排序后的第 k 个最大的元素，而不是第 k 个不同的元素。

    //示例 1:

    //输入: [3,2,1,5,6,4]
    //    和 k = 2
    //输出: 5
    //示例 2:

    //输入: [3,2,3,1,2,4,5,5,6]
    //    和 k = 4
    //输出: 4
    //说明:

    //你可以假设 k 总是有效的，且 1 ≤ k ≤ 数组的长度。

    class Program215
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            var k = 3;
            Console.WriteLine(FindKthLargest(nums, k));
            Console.ReadKey();
        }
        public static int FindKthLargest(int[] nums, int k)
        {
            //快排，索引值
            //Array.Sort(nums);
            //return nums[nums.Length - k];

            //堆排序（重要）
            if (nums.Length == 0 || nums == null)
            {
                return 0;
            }

            BuildBigHeap(nums);

            var len = nums.Length - 1;
            for (int i = len; i >len-k ; i--)
            {
                // 交换堆顶与堆尾，把当前最大值“沉”到最下面
                Swap(nums, 0, i);
                // 因为每重构一次，当前最大值都会被“沉”到 当前的最后一层
                // 所以每重构一次，要 len--，防止最大值又被重构到最顶层
                Heapify(nums, 0, len--);
            }
            return nums[nums.Length - k];
        }

        /// <summary>
        /// 构建大顶堆
        /// </summary>
        /// <param name="nums">数组</param>
        private static void BuildBigHeap(int[] nums)
        {
            var start = nums.Length / 2 - 1;
            for (int i = start; i >= 0; i--)
            {
                Heapify(nums, i, nums.Length);
            }
        }

        /// <summary>
        /// 堆排序
        /// </summary>
        /// <param name="nums">数组</param>
        /// <param name="i">当前位置</param>
        private static void Heapify(int[] nums, int i, int len)
        {
            //当前位置的左右节点
            var left = i * 2 + 1;
            var right = i * 2 + 2;

            //默认当前位置是最大值的位置
            var largest = i;
            //如果左节点比当前位置大，交换
            if (left<nums.Length&&nums[left]>nums[largest])
            {
                largest = left;
            }
            //如果右节点比当前位置大，交换
            if (right<nums.Length&&nums[right]>nums[largest])
            {
                largest = right;
            }

            //如果交换过
            if (largest!=i)
            {
                //交换
                Swap(nums, largest, i);
                //递归
                Heapify(nums, largest,len);
            }
        }

        /// <summary>
        /// 交换
        /// </summary>
        /// <param name="nums">数组</param>
        /// <param name="largest">大的位置</param>
        /// <param name="i">当前位置</param>
        private static void Swap(int[] nums, int largest, int i)
        {
            var temp = nums[largest];
            nums[largest] = nums[i];
            nums[i] = temp;
        }
    }
}
