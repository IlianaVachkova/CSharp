/*
    Description:
    You are given a text. Write a program that changes the text in all regions 
    surrounded by the tags <upcase> and </upcase> to upper-case.
    
    Input:
    On the only line you will receive a string - the text

    Output:
    Print the changed string on one line
*/

using System;
using System.Text;

public class Startup
{
    public static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder modifiedText = new StringBuilder();

        int startIndex = text.IndexOf("<upcase>", 0);
        if (startIndex == -1)
        {
            modifiedText.Append(text);
        }
        else
        {
            modifiedText.Append(text.Substring(0, startIndex));
            int endIndex = text.IndexOf("</upcase>", startIndex + 8);

            while (true)
            {
                modifiedText.Append(text.Substring(startIndex + 8, endIndex - (startIndex + 8)).ToUpper());

                startIndex = text.IndexOf("<upcase>", endIndex + 9);

                if (startIndex != -1)
                {
                    modifiedText.Append(text.Substring(endIndex + 9, startIndex - (endIndex + 9)));
                    endIndex = text.IndexOf("</upcase>", startIndex + 8);
                }
                else
                {
                    break;
                }
            }

            modifiedText.Append(text.Substring(endIndex + 9));
        }

        Console.WriteLine(modifiedText.ToString());
    }
}

