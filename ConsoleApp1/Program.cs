using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 8, 4, 0, 7 };
            int FindTotal = 10;
            //int[] rArr = 
                FindTwoNumberTotal(arr, FindTotal);

            //Console.WriteLine(rArr[0]);
            //Console.WriteLine(rArr[1]);

        }

        //public static int[] FindTwoNumberTotal(int [] arr, int t)
             public static void FindTwoNumberTotal(int[] arr, int t)
        {
            //Write your code here
            int[] tt = { 0, 0 }; //new int[2]; // 

            for (int i = 0; i <= arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if((arr[i] + arr [j]) == t)
                    {
                        tt[0] = arr[i];
                        tt[1] = arr[j];
                        //return tt;
                    }
                }
            }
            if (tt[0] == 0)
                Console.WriteLine("NULL");
            else
            {
                Console.WriteLine(tt[0]);
                Console.WriteLine(tt[1]);
            }
            Console.ReadLine();
            //return null;
        }
    }
}
