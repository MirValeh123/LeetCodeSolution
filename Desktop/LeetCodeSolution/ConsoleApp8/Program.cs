namespace ConsoleApp8
{
     class Program
    {
        public class Solution
        {
            public int SearchInsert(int[] nums ,int target)
            {
             int left = 0;
                int right = nums.Length-1;
                while (left <= right) 
                {
                    int mid = (left+right)/2;
                    if (nums[mid] == target)
                    {  
                        return mid; 
                    }
                    else if (nums[mid] < target) 
                    {
                        left = mid+1;
                    }
                    else 
                    {
                        right = mid-1;
                    }

                }
                return left;
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int target = 5;

            Solution solution = new Solution();
            int result = solution.SearchInsert(nums, target); 

            Console.WriteLine("Output: " + result);
        }
    }
}