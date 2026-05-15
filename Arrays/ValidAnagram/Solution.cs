public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        //Returning false if length of strings mismatch!
        if (s.Length != t.Length) return false;
        Dictionary<char, int> counts = new Dictionary<char, int>();

        //Counting number of character occurances in 1st string
        foreach (char c in s)
        {
            counts[c] = counts.GetValueOrDefault(c, 0) + 1;
        }

        //Matching it with 2nd string
        foreach (char c in t)
        {
            if (!counts.ContainsKey(c) || counts[c] == 0) return false;
            counts[c]--;
        }
        return true;
    }
}
