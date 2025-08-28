public class Solution
{
     public void ReverseString(char[] s)
     {
          Stack<char> stack = new Stack<char>();

          // Push all characters to stack
          foreach (char c in s)
          {
               stack.Push(c);
          }

          // Pop from stack and overwrite array
          for (int i = 0; i < s.Length; i++)
          {
               s[i] = stack.Pop();
          }

          // Print reversed array for verification
          Console.Write("[");
          for (int i = 0; i < s.Length; i++)
          {
               Console.Write(s[i]);
               if (i < s.Length - 1) Console.Write(", ");
          }
          Console.WriteLine("]");
     }
}
