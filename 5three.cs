using System;
using System.IO;

class Program 
{
  static void Main ()
  {
    string put = "numsTask3.txt";

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

    int minIndex = 0, minValue = nums[0];
     for(int i = 1; i < nums.Length; ++i)
    {
      if(nums[i] < minValue)
      {
       minIndex = i;
       minValue = nums[i];
      }
    }
    int sum = 0, count = 0;
    for(int i = 0; i < nums.Length; ++i)
    {
      sum += nums[i];
      ++count;
    }

     double result = (double)sum/count;
     Console.WriteLine("The average of the elements before the minimum: " + "\n" + result);
     string cow = result.ToString();
     File.AppendAllText(put,"\n" + "The average of the elements before the minimum: " + "\n" + cow);

     Console.ReadKey();
     File.Delete(put);
  }
}