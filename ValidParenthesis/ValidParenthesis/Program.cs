using System.Collections;

namespace ValidParenthesis
{
    public static class Program
    {
        public static bool IsValid(string s)
        {
            bool r=true;
            Stack<char> b = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    b.Push(s[i]);
                }
                else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
                {
                    if (b.Count == 0)
                    {
                        r = false;
                        break;
                    }
                    char top = b.Peek();
                    if (top == '(' && s[i] == ')')
                    {
                        b.Pop();
                    }
                    else if (top == '{' && s[i] == '}')
                    {
                        b.Pop();
                    }
                    else if (top == '[' && s[i] == ']')
                    {
                        b.Pop();
                    }
                    else
                    {
                        r = false;
                        break;
                    }
                }
               
            }

            if (b.Count != 0)
            {
                r = false;
            }
            return r;
        }
        static void Main(string[] args)
        {
            bool r=Program.IsValid("[");
            Console.WriteLine(r);
        }
    }
}
