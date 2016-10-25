/*
    You are given an empty text. Your task is to implement 4 commands related to manipulating the text
        •	1 str - appends str to the end of the text
        •	2 count - erases the last count elements from the text
        •	3 index - returns the element at position index from the text
        •	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation

    Input format: The first line contains n, the number of operations. 
    Each of the following n lines contains the name of the operation followed by 
    the command argument, if any, separated by space in the following format CommandName Argument. 
    
    Output Format: For each operation of type 3 print a single line with the returned character of that operation. 
*/

using System;
using System.Collections.Generic;
using System.Text;

public class Startup
{
    public static void Main()
    {
        StringBuilder text = new StringBuilder();
        Stack<string> operationsToUndo = new Stack<string>();
        Stack<string> erasedElements = new Stack<string>();
        int numOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numOfCommands; i++)
        {
            string command = Console.ReadLine();
            string[] commandInfo = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            switch (commandInfo[0])
            {
                case "1":
                    operationsToUndo.Push(command);
                    text.Append(commandInfo[1]);
                    break;
                case "2":
                    operationsToUndo.Push(command);
                    int countToErase = int.Parse(commandInfo[1]);
                    string erasedEl = text.ToString().Substring(text.Length-countToErase);
                    text.Remove(text.Length - countToErase, countToErase).ToString();
                    erasedElements.Push(erasedEl);
                    break;
                case "3":
                    int indexToReturn = int.Parse(commandInfo[1]);
                    Console.WriteLine(text.ToString()[indexToReturn - 1]);
                    break;
                case "4":
                    string lastOperation = operationsToUndo.Pop();
                    string[] lastOpInfo = lastOperation.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (lastOpInfo[0] == "1")
                    {
                        text.Remove(text.Length - lastOpInfo[1].Length, lastOpInfo[1].Length);
                    }
                    else if (lastOpInfo[0] == "2")
                    {
                        text.Append(erasedElements.Pop());
                    }
                    break;
            }
        }
    }
}

