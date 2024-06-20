using TwoSum;

namespace TwoSumTest
{
    public class TwoSumTest
    {
        [Fact]
        public void Test_1()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result= Solution.TwoSum(nums,target);
            int[] expected = { 0, 1 };
            Assert.Equal(expected, result);

        }


        [Fact]
        public void Test_2()
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] result = Solution.TwoSum(nums, target);
            int[] expected = { 1, 2};
            Assert.Equal(expected, result);

        }

        [Fact]
        public void Test_3()
        {
            int[] nums = { 3, 3 };
            int target = 6;
            int[] result = Solution.TwoSum(nums, target);
            int[] expected = { 0, 1 };
            Assert.Equal(expected, result);

        }
    }
}