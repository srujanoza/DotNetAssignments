using System;
using System.Collections.Generic;

namespace Practical5
{
    class Program
    {
        static void Main(string[] args)
        {
			String infix;
			Console.WriteLine("Enter infix");
			infix = Console.ReadLine();
			String postfix = infixToPostfix(infix);
			Console.WriteLine("Postfix");
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

			string result = "";


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
					while (stack.Peek() != '(')
					{
						result += stack.Pop();

					}

					stack.Pop();
				}
				else
				{
					if (stack.Count == 0)
					{
						stack.Push(c);
					}
					else if (priority(stack.Peek()) < priority(exp[i]))
						stack.Push(exp[i]);
					else
					{
						try
						{
							while (priority(c) <= priority(stack.Peek()))
							{
								result += stack.Pop();
							}
						}
						catch(Exception e)
						{

						}
						stack.Push(c);
					}
					
				}

			}
			while (stack.Count!= 0)
			{
				result += stack.Pop();
			}

			return result;
		}


		
	}


}

