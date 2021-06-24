using System;

namespace Find_the_Duplicate_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 3, 4, 2, 3 };
            Console.WriteLine(FindDuplicate(nums));
        }

        static int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[nums[0]];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
                if (slow == fast)
                {
                    fast = 0; // reset to begining of the array
                    while (slow != fast)
                    {
                        slow = nums[slow];
                        fast = nums[fast];
                    }
                    return slow;
                }
            }
            return slow;
        }
    }
}
