public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
            int[] n = new int[2];
            int length= nums.Length;
            for (int i = 0; i < length; i++)
            {
                for(int j=i+1;j<length;j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        n[0] = i;
                        n[1] = j;
                        
                    }
                }
            }
            
        return n;

    }
}