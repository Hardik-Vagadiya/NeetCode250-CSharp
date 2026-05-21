public class Solution
{
    public void ReverseString(char[] s)
    {
        //Base case
        if (s.Length <= 1) return;

        int i = 0, j = s.Length - 1;
        char t;
        while (i < j)
        {
            t = s[i];
            s[i] = s[j];
            s[j] = t;
            i++; j--;
        }
    }
}