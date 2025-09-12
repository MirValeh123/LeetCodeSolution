internal class Program
{
    private static void Main(string[] args)
    {

        var solution = new Solution();
        var result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine($"[{result[0]}, {result[1]}]");

        var romanResult = solution.RomanToInt("IV");
        Console.WriteLine(romanResult);
    }


    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }



            return new int[] { -1, -1 };
        }

        public int RomanToInt(string s)  //'IX'  'XI'
        {
            var romanNumerals = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int value = romanNumerals[s[i]]; //I = 1   I = 5
                 
                if (i + 1 < s.Length && romanNumerals[s[i + 1]] > value)    //romanNumerals[V] =5   s[0 + 1] = V   5 > 1  IV
                {
                    total -= value; //0-1 = -1
                }
                else
                {
                    total += value;//-1 + 5 = 4

                }
            }
            return total;//4


        }
    }

}