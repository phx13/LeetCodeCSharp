using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _448找到所有数组中消失的数字
{
    //给定一个范围在  1 ≤ a[i] ≤ n ( n = 数组大小 ) 的 整型数组，数组中的元素一些出现了两次，另一些只出现一次。

    //找到所有在[1, n] 范围之间没有出现在数组中的数字。

    //您能在不使用额外空间且时间复杂度为O(n)的情况下完成这个任务吗? 你可以假定返回的数组不算在额外空间内。

    //示例:

    //输入:
    //[4,3,2,7,8,2,3,1]

    //输出:
    //[5,6]

    class Program448
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var res = FindDisappearedNumbers(arr);
            foreach (var item in res)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }

        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var res = new List<int>();
            var dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                dict[item] = 1;
            }
            for (int i = 1; i < nums.Length + 1; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    res.Add(i);
                }
            }
            return res;
            //var res = new List<int>();
            //var distinct = nums.Distinct();
            //Array.Sort(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] != i + 1)
            //    {
            //        if (distinct.Contains(i + 1))
            //        {

            //        }
            //        else
            //        {
            //            res.Add(i + 1);
            //        }
            //    }
            //}
            //return res;
        }
    }
}
