public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        int[] res = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (seen.ContainsKey(diff))
            {
                res[0] = seen[diff];
                res[1] = i;
                return res;
            }
            else if (!seen.ContainsKey(nums[i]))
                seen.Add(nums[i], i);
        }
        return res;
    }
}
