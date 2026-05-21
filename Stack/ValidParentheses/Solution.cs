public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length == 0) return true;
        if (s.Length == 1) return false;
        if (s[0] == ')' || s[0] == '}' || s[0] == ']') return false;

        Stack<char> stk = new Stack<char>();
        char t;
        for (int i = 0; i < s.Length; i++)
        {
            if (stk.Count == 0) stk.Push(s[i]);
            else
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[') stk.Push(s[i]);
                else
                {
                    if (s[i] == ')' && stk.Peek() == '(') stk.Pop();
                    else if (s[i] == '}' && stk.Peek() == '{') stk.Pop();
                    else if (s[i] == ']' && stk.Peek() == '[') stk.Pop();
                    else return false;
                }
            }
        }
        if (stk.Count == 0) return true;
        else return false;
    }
}
