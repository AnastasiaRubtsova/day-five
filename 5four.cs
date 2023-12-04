using System;
using System.IO;

class Program
{
  static void Main ()
  {
     string put = "numsTask4.txt";

     Random rnd = new Random();
     Console.WriteLine("Enter the number of numbers: ");
     int n = Convert.ToInt32(Console.ReadLine());
     int[] nums = new int[n];

     for (int i = 0; i < nums.Length; ++i)
     {
         nums[i] = rnd.Next(-10, 10);
     }

     string row = string.Join(", ", nums);
     File.AppendAllText(put, row);

     int maximum = nums[0];
    for(int i = 1; i < nums.Length; ++i)
    {
      if (nums[i] > maximum)
      {
        maximum = nums[i];
      }
    }
     Console.WriteLine("Maximum element: " + "\n" + maximum);
     string tow = maximum.ToString();
     File.AppendAllText(put,"\n" + "Maximum element: " + "\n" + tow);
    
    int result = 0;
    for(int i = 0; i < nums.Length; ++i)
    {
      if(Math.Abs(nums[i] - maximum) == 1)
      {
        result += nums[i];
      }
    }
     Console.WriteLine("The sum of the elements that differ from the maximum by 1: " + "\n" + result);
     string cow = result.ToString();
     File.AppendAllText(put,"\n" + "The sum of the elements that differ from the maximum by 1: " + "\n" + cow);

     Console.ReadKey();
     File.Delete(put);
  }
}