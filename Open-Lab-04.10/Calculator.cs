using System;
using System.Linq;
namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float sum = nums.Sum();
            float avg = sum / nums.Length;
            return avg;
        }
    }
}
