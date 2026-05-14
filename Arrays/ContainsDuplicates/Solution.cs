public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> duplicates = new HashSet<int>();
        foreach (int n in nums)
        {
            if (!(duplicates.Add(n)))
            {
                return true;
            }
        }
        return false;
    }
}