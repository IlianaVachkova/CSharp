/*
    Description:
    Write a program to check if in a given expression the ( and ) brackets are put correctly.
    
    Input:
    On the only line you will receive an expression

    Output:
    Print Correct if the brackets are correct
        Incorrect otherwise
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string expression = Console.ReadLine();
        Stack<char> brackets = new Stack<char>();
        char previousSymbol = '@';
        bool isBalanced = true;
        int countOpening = 0;
        int countClosing = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == ')' && brackets.Count == 0)
            {
                isBalanced = false;
                countClosing++;
                break;
            }


            if (expression[i] == ')')
            {
                previousSymbol = brackets.Peek();
                if (previousSymbol == '(')
                {
                    brackets.Pop();
                    countClosing++;
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }
            else if (expression[i] == '(')
            {
                brackets.Push(expression[i]);
                countOpening++;
            }
        }

        if (isBalanced && countClosing == countOpening)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}

