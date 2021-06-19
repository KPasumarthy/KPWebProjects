using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;

<<<<<<< HEAD

=======
>>>>>>> origin/kpDevBranch
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
<<<<<<< HEAD
            /////KP : Question : 1

            ////////KP : Question : 2
            //var arr = new List<int>() { 33, 34, -1, 10, 81, 9, -1, 33, -4, 12, 100, -25, 125, 98, 1, 15, 10, 90, 1, 22, 33, 55 }.ToArray();
            //////{ 33, 34, -1, 10, 81, 9, -1, 33, -4, 12, 100, -25, 125, 98, 1, 15, 10, 90, 1, 22, 33, 55 }
            //////{-25, -4, - 1, - 1, 1, 9, 10, 10, 12, 15, 22, 33, 33, 33, 34, 55, 81, 90, 98, 100, 125 }

            //int target = 100;
            //IList<IList<int>> triplets = ThreeSum(arr, target);

            //foreach (var item in triplets)
            //{
            //    Console.WriteLine(item[0].ToString() + "," + item[1].ToString() + "," + item[2].ToString());
            //}
            //Console.ReadLine();
            ///////KP : Question : 2

            /////KP : Question : 3
            Int64 n = 15;
            //PrintFizzBuzz(n);
            FizzBuzz.PrintFizzBuzz(n);
            FizzBuzz.PrintFizzBuzzComplex(n);
            /////KP : Question : 3
            ///

            /////KP : Question : 4
            //Write a Funtion to Rotate the given array by K times

            //Input  : arr[] = { 1, 2, 3, 4, 5 }
            //K = 3
            //Output: { 4, 5, 1, 2, 3}
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 3;
            int[] arrNew = rotateArray(arr, k);
            Console.Write("[");
            arrNew.ToList().ForEach(i => Console.Write(i.ToString() + ", "));
            Console.WriteLine("]");


            /////KP : Question : 4
        }




        public static int[] rotateArray(int[] arr, int k)
        {

            //HashTable ht = new HashTable();
            //for (int i=0; i < arr.length(); i++){
            //    ht.key = i;
            //    ht.value = arr[i];
            //}

            int[] arrNew = new int[arr.Length];

            //HashTable ht2 = new HashTable();
            for (int i = 0; i < arr.Length; i++)
            {
                //ht.key = i + k;
                //int j = i-k - 1; // If i = 4, j = 0; or i = 5, j =1;
                int j = 0;

                if (i >= k)
                {

                    j = i - k; // If i = 4, j = 0; or i = 5, j =1;

                    //ht.key = j;
                    //ht.value = arr[i];

                    arrNew[j] = arr[i];

                }

                //if (i == k)
                //{
                //    j = i-k; // If i = 3, j = 3; 

                //    arrNew[j] = arr[i];
                //}


                if (i < k)
                {
                    j = i + k - 1; // If i = 0, j = 2; or i = 1, j = 3;  i = 2, j = 4;

                    arrNew[j] = arr[i];

                    //ht.key = j;
                    //ht.value = arr[i];
                }

            }

            return arrNew;
        }


        public static void PrintFizzBuzz(Int64 n)
        {
            Int64 x = 1;
            while (x <= n)
            {
                Int64 r3 = (Int64)x % 3;
                Int64 r5 = (Int64)x % 5;
                Console.Write(x + " ");
                if (r3 == 0)
                    Console.Write("Fizz");

                if (r5 == 0)
                    Console.Write("Buzz");

                Console.WriteLine();
                x++;
            }
        }

        public static void PrintFizzBuzzComplex(Int64 n)
        {

            Int64 x = 1;
            while (x <= n)
            {
                if (x % 3 == 0 && x % 5 == 0)
                    Console.WriteLine(x + " FizzBuzz");
                else
                {
                    if (x % 3 == 0 && x % 5 != 0)
                        Console.WriteLine(x + " Fizz");
                    else
                    {
                        if (x % 3 != 0 && x % 5 == 0)
                            Console.WriteLine(x + " Buzz");
                        else
                            Console.WriteLine(x);
                    }
                }

                x++;
            }

        }

=======

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
>>>>>>> origin/kpDevBranch
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
<<<<<<< HEAD
            int i = 0, j = nums.Length - 1;
=======
            int i = 0, j = nums.Length-1;
>>>>>>> origin/kpDevBranch

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
<<<<<<< HEAD
=======


>>>>>>> origin/kpDevBranch
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