﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011盛最多水的容器
{
    //给你 n 个非负整数 a1，a2，...，an，每个数代表坐标中的一个点 (i, ai) 。在坐标内画 n 条垂直线，垂直线 i 的两个端点分别为 (i, ai) 和 (i, 0) 。找出其中的两条线，使得它们与 x 轴共同构成的容器可以容纳最多的水。

    //说明：你不能倾斜容器。



    //示例 1：



    //输入：[1,8,6,2,5,4,8,3,7]
    //输出：49 
    //解释：图中垂直线代表输入数组 [1,8,6,2,5,4,8,3,7]。在此情况下，容器能够容纳水（表示为蓝色部分）的最大值为 49。
    //示例 2：

    //输入：height = [1,1]
    //输出：1
    //示例 3：

    //输入：height = [4,3,2,1,4]
    //输出：16
    //示例 4：

    //输入：height = [1,2,1]
    //输出：2


    //提示：

    //n = height.length
    //2 <= n <= 3 * 104
    //0 <= height[i] <= 3 * 104

    class Program011
    {
        static void Main(string[] args)
        {
            var height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(MaxArea(height));
            Console.ReadKey();
        }

        public static int MaxArea(int[] height)
        {
            var res = 0;
            if (height == null || height.Length == 0 || height.Length == 1)
            {
                return res;
            }

            ////暴力
            //for (int i = 0; i < height.Length; i++)
            //{
            //    for (int j = i+1; j < height.Length; j++)
            //    {
            //        var high = height[i] > height[j] ? height[j] : height[i];
            //        res = Math.Max((j - i) * high, res);
            //    }
            //}

            //双指针
            var left = 0;
            var right = height.Length - 1;

            while (left < right)
            {
                var high = height[left] > height[right] ? height[right] : height[left];
                res = Math.Max((right - left) * high, res);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return res;
        }
    }
}
