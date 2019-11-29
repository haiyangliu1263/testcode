using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcitcSkillsCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch();
            Console.Read();
        }

        static void BinarySearch()
        {
            int[] arr = { 1, 1, 1, 2, 2, 6, 7, 8, 8, 9, 10, 27, 33, 33, 33, 57, 69, 82, 82, 82, 93, 93, 93, 93, 93, 106, 106, 106, 111, 111, 133, 133, 133, 133, 133 };

            //Console.WriteLine(arr.Length);
            int target = 93;
            int num = ResultNum(arr, 0, arr.Length, target);
            //Console.WriteLine(num);

            if (num != -1)
            {
                int y = ResultNum(arr, 0, arr.Length, 93);
                var sum = arr.Where(x => x == target).ToList().Count;
                if (y != -1)
                {
                    Console.WriteLine("[" + (num - 1).ToString() + "," + (y + sum - 2).ToString() + "]");
                }
                else
                {
                    Console.WriteLine("[" + (num - 1).ToString() + "," + (num - 1).ToString() + "]");
                }
            }
            else
            {
                Console.WriteLine("[-1,-1]");
            }
        }
        static int ResultNum(int[] arr, int first, int last, int index)
        {
            int mid = (first + last) / 2;
            if (first > last)
            {
                return -1;
            }
            else
            {
                if (arr[mid] == index)
                    return mid;
                if (arr[mid] == index)
                    return mid;
                else if (arr[mid] > index)
                    return ResultNum(arr, first, mid - 1, index);
                else
                    return ResultNum(arr, mid + 1, last, index);


            }
            return mid;
        }
    }
}
