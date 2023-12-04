using System;
using System.IO;

class Program 
{
  static void Main ()
  {
    string put = "numsTask1.txt";

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

    int minIndex = 0, minValue = int.MaxValue;

    for (int i = 0; i < nums.Length; ++i)
    {
      if(nums[i] < minValue)
      {
        minValue = nums[i];
        minIndex = i;
      }
    }

    int result = 1;
    for (int i = minIndex + 1; i < nums.Length; ++i)
    {
     result *= nums[i]; 
    }

     Console.WriteLine("The product of the elements after the minimum: " + "\n" + result);
     string cow = result.ToString();
     File.AppendAllText(put,"\n" + "The product of the elements after the minimum: " + "\n" + cow);

     Console.ReadKey();
     File.Delete(put);
  }
}