using System;
using System.IO;

class Program
{
    public static void Main () 
    {
        string put = "numsTask5.txt";

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

        int minIndex = 0, maxIndex = 0;
        for(int i = 1; i < nums.Length; ++i)
        {
            if(nums[i] < nums[minIndex])
            {
                minIndex = i;
            }
            if(nums[i] > nums[maxIndex])
            {
                maxIndex = i;
            }
        }
        int start = Math.Min(minIndex,maxIndex) + 1;
        int end = Math.Max(minIndex,maxIndex) - 1;
        int sum = 0, count = 0;
        for(int i = start; i < end; ++i)
        {
            sum += nums[i];
            ++count;
        }

        double result = (double)sum/count;
        Console.WriteLine("The arithmetic mean of the elements between the minimum and maximum: " + "\n" + result);
        string cow = result.ToString();
        File.AppendAllText(put,"\n" + "The arithmetic mean of the elements between the minimum and maximum: " + "\n" + cow);

        Console.ReadKey();
        File.Delete(put);
    }
}