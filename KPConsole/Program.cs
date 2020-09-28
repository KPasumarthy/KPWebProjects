using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KP : Hello World!");

            /////KP : Question : 1
            //int a, b = 0;
            //a = 5;
            //b += a;     //b = b+a; b = 0+5 = 5
            //Console.WriteLine("Opeartion : b += a");
            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);

            ///KP : Question : 2
            var arr = new List<int>() { 33, 34, -1, 10, 81, 9, -1, 33, -4, 12, 100, -25, 125, 98, 1, 15, 10, 90, 1, 22, 33, 55 }.ToArray();
            ////{ 33, 34, -1, 10, 81, 9, -1, 33, -4, 12, 100, -25, 125, 98, 1, 15, 10, 90, 1, 22, 33, 55 }
            ////{-25, -4, - 1, - 1, 1, 9, 10, 10, 12, 15, 22, 33, 33, 33, 34, 55, 81, 90, 98, 100, 125 }

            int target = 100;
            IList<IList<int>> triplets = ThreeSum(arr, target);

            foreach (var item in triplets)
            {
                Console.WriteLine(item[0].ToString() + "," + item[1].ToString() + "," + item[2].ToString());
            }
            Console.ReadLine();
        }
        public static IList<IList<int>> ThreeSum(int[] nums, int target)
        {
            IList<IList<int>> triplets = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return triplets;
            Array.Sort(nums);

            //Sorted Array
            foreach (var item in nums)
            {
                Console.WriteLine(item.ToString());
            }

            //implementation goes here
            int i = 0, j = nums.Length-1;

            for (i = 0, j = nums.Length - 1; i < j; i++, j--)
            {
                int tmp = nums[i];
                tmp = tmp + nums[j];

                for (int k = 0; k < nums.Length; k++)
                {
                    tmp = tmp + nums[k];

                    if (tmp == target)
                    {

                        List<int> tripletItem = new List<int>();
                        tripletItem.Add(nums[i]);
                        tripletItem.Add(nums[k]);
                        tripletItem.Add(nums[j]);

                        Console.WriteLine(nums[i].ToString() + "," + nums[k].ToString() + "," + nums[j].ToString());

                        triplets.Add(tripletItem);

                    }
                }
            }
            return triplets;
        }


    }
}


//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace Solution
//{
//    class Solution
//    {
//        static void Main(string[] args)
//        {
//            var arr = new List<int>() { 33, 34, -1, 10, 81, 9, -1, 33, -4, 12, 100, -25, 125, 98, 1, 15, 10, 90, 1, 22, 33, 55 }.ToArray();
//            int target = 100;
//            IList<IList<int>> triplets = ThreeSum(arr, target);

//            foreach (var item in triplets)
//            {
//                Console.WriteLine(item[0].ToString() + "," + item[1].ToString() + "," + item[2].ToString());
//            }
//            Console.ReadLine();
//        }


//        public static IList<IList<int>> ThreeSum(int[] nums, int target)
//        {
//            IList<IList<int>> triplets = new List<IList<int>>();
//            if (nums == null || nums.Length == 0)
//                return triplets;
//            Array.Sort(nums);

//            //implementation goes here
//            triplets = Array.Sort(nums).T;



//            return triplets;
//        }
//    }