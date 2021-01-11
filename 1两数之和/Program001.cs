using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1两数之和
{
    //给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。

    //你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。

    //示例:

    //给定 nums = [2, 7, 11, 15], target = 9

    //因为 nums[0] + nums[1] = 2 + 7 = 9
    //所以返回[0, 1]
    class Program001
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 7, 11, 15 };
            var target = 9;
            foreach (var item in TwoSum(arr, target))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var res = new int[2];
            var dic = new Dictionary<int, int>();//建立一个字典，key是值，value是下标
            for (int i = 0; i < nums.Length; i++)//遍历原始数组
            {
                var temp = target - nums[i];//记录当前值与目标值之间的差值
                if (dic.ContainsKey(temp))//如果字典key中已存在差值，说明已经记录的某一key值与当前值之和满足条件
                {
                    res[0] = dic[temp];//第一个下标是已记录key值的value
                    res[1] = i;//第二个下标是当前i
                    return res;
                }
                else
                {
                    if (dic.ContainsKey(nums[i]))//如果字典key中已存在当前值，覆盖下标（规避key值重复）
                    {
                        dic[nums[i]] = i;
                    }
                    else//如果字典key中未存在当前值，将（当前值，当前值下标）加入字典
                    {
                        dic.Add(nums[i], i);
                    }
                }
            }
            return null;
        }
    }
}
