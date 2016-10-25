/*
    Given a sequence consisting of parentheses, determine whether the expression is balanced. 
    A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with 
    a closed parenthesis that occurs after the former. Also, the interval between them must be 
    balanced. You will be given three types of parentheses: (, {, and [.

        {[()]} - This is a balanced parenthesis.
        {[(])} - This is not a balanced parenthesis.

    Input Format: Each input consists of a single line, S, the sequence of parentheses.

    Constraints: 
    1 ≤ lens ≤ 1000, where lens is the length of the sequence. 
    Each character of the sequence will be one of {, }, (, ), [, ].

    Output Format: For each test case, print on a new line "YES" if the parentheses are balanced. 
    Otherwise, print "NO". Do not print the quotes.
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> parantheses = new Stack<char>();
        char previousSymbol = '@';
        bool isBalanced = true;

        for (int i = 0; i < input.Length; i++)
        {
            if ((input[i] == '}' || input[i] == ')' || input[i] == ']') && parantheses.Count == 0)
            {
                Console.WriteLine("NO");
                isBalanced = false;
                break;
            }

            if (input[i] == '}')
            {
                previousSymbol = parantheses.Peek();
                if (previousSymbol == '{')
                {
                    parantheses.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    isBalanced = false;
                    break;
                }
            }
            else if (input[i] == ')')
            {
                previousSymbol = parantheses.Peek();
                if (previousSymbol == '(')
                {
                    parantheses.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    isBalanced = false;
                    break;
                }
            }
            else if (input[i] == ']')
            {
                previousSymbol = parantheses.Peek();
                if (previousSymbol == '[')
                {
                    parantheses.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    isBalanced = false;
                    break;
                }
            }
            else
            {
                parantheses.Push(input[i]);
            }
        }

        if (isBalanced)
        {
            Console.WriteLine("YES");
        }
    }
}

