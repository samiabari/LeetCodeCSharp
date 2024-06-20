namespace TwoSum
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> substracts = new Dictionary<int, int>();
            List<int> result =new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int substract = target - nums[i];
                if (substracts.ContainsKey(substract))
                {
                    int index = substracts[substract];
                    result.Add(index);
                    result.Add(i);
                    break;
                }
                if (!substracts.ContainsKey(nums[i]))
                {
                    substracts.Add(nums[i], i);
                }
            }
            
            
            return result.ToArray();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [2,3,4];
            int target = 6;
            int[] result= Solution.TwoSum(nums,target);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }


}
