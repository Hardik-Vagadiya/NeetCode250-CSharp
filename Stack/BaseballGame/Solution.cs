using System.Collections.Generic;
public class Solution
{
    public int CalPoints(string[] operations)
    {
        if (operations == null || operations.Length == 0) return 0;
        Stack<int> record = new Stack<int>();
        for (int i = 0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out int num)) record.Push(num);            
            else if (operations[i] == "+")
            {
                int num1 = 0 , sum = 0;
                num1 = record.Pop();
                sum = num1 + record.Peek();
                record.Push(num1);
                record.Push(sum);
            }
            else if (operations[i] == "D") record.Push(record.Peek() * 2);
            else record.Pop();
        }
        return record.Sum();
    }
}