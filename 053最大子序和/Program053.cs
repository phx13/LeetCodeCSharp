using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053最大子序和
{
    //给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。

    //示例:

    //输入: [-2,1,-3,4,-1,2,1,-5,4]
    //输出: 6
    //解释: 连续子数组[4, -1, 2, 1] 的和最大，为 6。
    //进阶:

    //如果你已经实现复杂度为 O(n) 的解法，尝试使用更为精妙的分治法求解。

    class Program053
    {
        static void Main(string[] args)
        {
            var arr = new int[] { -3, -2, 0, -1 };
            Console.WriteLine(MaxSubArray(arr));
            Console.ReadKey();
        }
        public static int MaxSubArray(int[] nums)
        {
            var res = nums[0];
            var temp = 0;
            foreach (var item in nums)
            {
                temp += item;
                if (temp > res)
                {
                    res = temp;
                }
                if (temp < 0)
                {
                    if (Array.IndexOf(nums, item) == nums.Length - 1 && res < item)
                    {
                        res = temp;
                    }
                    else
                    {
                        temp = 0;
                    }
                }
            }
            return res;
        }
    }
}
