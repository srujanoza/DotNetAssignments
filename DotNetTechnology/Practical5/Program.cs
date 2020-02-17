using System;
using System.Collections.Generic;

namespace Practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            String infix = "a+b*c";
			String postfix = infixToPostfix(infix);
			Console.WriteLine(postfix);
			Console.Read();
        }



		internal static int priority(char ch)
		{
			switch (ch)
			{
				case '(':
					return 0;
				case '+':
				case '-':
					return 1;

				case '*':
				case '/':
					return 2;

				case '^':
					return 3;
			}
			return -1;
		}


		public static string infixToPostfix(string exp)
		{

			string result =null;


			Stack<char> stack = new Stack<char>();

			for (int i = 0; i < exp.Length; ++i)
			{
				char c = exp[i];


				if (char.IsLetterOrDigit(c))
				{
					result += c;
				}


				else if (c == '(')
				{
					stack.Push(c);
				}


				else if (c == ')')
				{
					while (stack.Count > 0 && stack.Peek() != '(')
					{
						result += stack.Pop();

					}

					stack.Pop();
				}

				{
					while (stack.Count > 0 && priority(c) <= priority(stack.Peek()))
					{
						result += stack.Pop();
					}
					stack.Push(c);
				}

			}
			while (stack.Count > 0)
			{
				result += stack.Pop();
			}

			return result;
		}


		
	}


}

