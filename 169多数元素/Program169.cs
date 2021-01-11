using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169多数元素
{
    //给定一个大小为 n 的数组，找到其中的多数元素。多数元素是指在数组中出现次数 大于 ⌊ n/2 ⌋ 的元素。

    //你可以假设数组是非空的，并且给定的数组总是存在多数元素。



    //示例 1：

    //输入：[3,2,3]
    //    输出：3
    //示例 2：

    //输入：[2,2,1,1,1,2,2]
    //    输出：2


    //进阶：

    //尝试设计时间复杂度为 O(n)、空间复杂度为 O(1) 的算法解决此问题。
    class Program169
    {
        static void Main(string[] args)
        {
            var arr1 = new int[] { 3, 2, 3 };
            Console.WriteLine(MajorityElement(arr1));
            var arr2 = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement(arr2));
            Console.ReadKey();
        }

        public static int MajorityElement(int[] nums)
        {
            //注意条件n/2，说明是众数，只需要找最中间位置的即可
            Array.Sort(nums);
            return nums[nums.Length / 2];

            //var res = 0;
            //Array.Sort(nums);
            //var start = 0;
            //var end = 0;
            //if (nums.Distinct().Count() == 1)
            //{
            //    res = nums[0];
            //}
            //else
            //{
            //    for (int i = 0; i < nums.Length - 1; i++)
            //    {
            //        if (nums[i] == nums[i + 1])
            //        {
            //            end = i + 2 - start;
            //        }
            //        else
            //        {
            //            start = i;
            //            end = 0;
            //        }

            //        if (end > nums.Length / 2)
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
