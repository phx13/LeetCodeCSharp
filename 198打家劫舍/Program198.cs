using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _198打家劫舍
{
    //你是一个专业的小偷，计划偷窃沿街的房屋。每间房内都藏有一定的现金，影响你偷窃的唯一制约因素就是相邻的房屋装有相互连通的防盗系统，如果两间相邻的房屋在同一晚上被小偷闯入，系统会自动报警。

    //给定一个代表每个房屋存放金额的非负整数数组，计算你 不触动警报装置的情况下 ，一夜之内能够偷窃到的最高金额。



    //示例 1：

    //输入：[1,2,3,1]
    //    输出：4
    //解释：偷窃 1 号房屋(金额 = 1) ，然后偷窃 3 号房屋(金额 = 3)。
    //     偷窃到的最高金额 = 1 + 3 = 4 。
    //示例 2：

    //输入：[2,7,9,3,1]
    //    输出：12
    //解释：偷窃 1 号房屋(金额 = 2), 偷窃 3 号房屋(金额 = 9)，接着偷窃 5 号房屋(金额 = 1)。
    //     偷窃到的最高金额 = 2 + 9 + 1 = 12 。


    //提示：

    //0 <= nums.length <= 100
    //0 <= nums[i] <= 400

    class Program198
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 10, 11, 3, 8, 7, 5 };
            Console.WriteLine(Rob(arr));
            Console.ReadKey();
        }
        public static int Rob(int[] nums)
        {
            //Tn = max(Tn-1, Tn-2 + Hn)递推公式

            if (nums.Length==0)
            {
                return 0;
            }
            if (nums.Length==1)
            {
                return nums[0];
            }

            var t0 = nums[0];
            var t1 = Math.Max(t0, nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                var temp = t1;
                t1 = Math.Max(t1, t0 + nums[i]);
                t0 = temp;
            }
            return t1;

            //var res = 0;
            //if (nums.Length == 0)
            //{
            //    return res;
            //}
            //var reslist = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    reslist.Add(0);
            //}
            //while (true)
            //{
            //    if (nums.Max() == 0)
            //    {
            //        break;
            //    }
            //    var pos = Array.IndexOf(nums, nums.Max());
            //    if (reslist[pos] == 0)
            //    {
            //        reslist[pos] = 2;
            //        if (pos != 0)
            //        {
            //            reslist[pos - 1] = 1;
            //        }
            //        if (pos != nums.Length - 1)
            //        {
            //            reslist[pos + 1] = 1;
            //        }

            //        res += nums.Max();
            //        Array.Clear(nums, pos, 1);
            //    }
            //    else
            //    {
            //        Array.Clear(nums, pos, 1);
            //    }
            //}
            //return res;
        }
    }
}
