public class Solution
{
    public bool IsPalindrome(string s)
    {
        //Trivial case
        if (s.Length == 0 || s.Length == 1) return true;
        int i = 0, j = s.Length - 1;
        while (i <= j)
        {
            //Ignoring non-alphanumeric characters
            if (!char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }

            //Checking for equality in palindrome
            if (char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }
            else
            {
                i++; j--;
            }
        }
        return true;
    }
}