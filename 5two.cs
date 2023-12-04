using System;
using System.IO;

class Program
{
    static void Main()
    {
        string put = "numsTask2.txt";

        Random rnd = new Random();

        Console.WriteLine("Enter the number of numbers: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] nums = new double[n];

        for (int i = 0; i < nums.Length; ++i)
        {
            nums[i] = rnd.NextDouble() * (10 - (-10)) + (-10);
        }

        string row = string.Join("; ", nums);
        File.AppendAllText(put, row + "\n");

        for (int i = 0; i < nums.Length - 1; ++i)
        {
            for (int j = i + 1; j < nums.Length; ++j)
            {
                if (nums[i] > nums[j])
                {
                    double temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
      Console.WriteLine("Sorted numbers in ascending order: ");
        for (int i = 0; i < nums.Length; ++i)
        {
            Console.WriteLine(nums[i] + " ");
        }

        string сow = string.Join("; ", nums);
        File.AppendAllText(put, "\n" + "Sorted numbers in ascending order: ");
        File.AppendAllText(put, "\n" + сow);

        Console.ReadKey();
        File.Delete(put);
    }
}