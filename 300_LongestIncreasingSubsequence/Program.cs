public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] lengthOfSubsequence = new int[nums.Length];

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            var numOfLargerNumbers = 0;
            for (var j = i; j < nums.Length; j++)
            {
                if (nums[i] < nums[j] && numOfLargerNumbers < lengthOfSubsequence[j]) numOfLargerNumbers = lengthOfSubsequence[j];
            }

            lengthOfSubsequence[i] = 1 + numOfLargerNumbers;
        }

        // Runtime: O(n^2): 106ms
        // Memory: O(n): 42.16MB
        return lengthOfSubsequence.Max();
    }
}