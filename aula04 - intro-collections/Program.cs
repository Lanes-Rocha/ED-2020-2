using System;
using System.Diagnostics;
namespace aula04___intro_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[1000];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BuildArray(nums);
            DislplayArray(nums);  
            sw.Stop();
            Console.WriteLine($"Runtime = {sw.Elapsed.ToString()}"); 
                        
        }
        public static void  BuildArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }
        public static void  DislplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
        }
    }
}
