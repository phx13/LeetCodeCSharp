﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136只出现一次的数字
{
    //给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。

    //说明：

    //你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？

    //示例 1:

    //输入: [2,2,1]
    //输出: 1
    //示例 2:

    //输入: [4,1,2,1,2]
    //输出: 4

    class Program136
    {
        static void Main(string[] args)
        {
            var arr1 = new int[] { 2, 2, 1 };
            Console.WriteLine(SingleNumber(arr1));
            var arr2 = new int[] { 4, 1, 2, 1, 2 };
            Console.WriteLine(SingleNumber(arr2));
            Console.ReadKey();
        }

        public static int SingleNumber(int[] nums)
        {
            //异或运算，a^a=0,a^0=a,满足交换律和结合律
            int ret = 0;
            foreach (int e in nums) ret ^= e;
            return ret;
            //var res = 0;
            //Array.Sort(nums);
            //if (nums.Length == 1)
            //{
            //    res = nums[0];
            //}
            //else
            //{
            //    for (int i = 0; i < nums.Length - 1; i += 2)
            //    {
            //        if (nums[i] - nums[i + 1] == 0)
            //        {
            //            if (i == nums.Length - 3)
            //            {
            //                res = nums[nums.Length - 1];
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            res = nums[i];
            //            break;
            //        }
            //    }
            //}
            //return res;
        }
    }
}
