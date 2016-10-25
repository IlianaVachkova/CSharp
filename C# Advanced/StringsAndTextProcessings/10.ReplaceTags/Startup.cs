/*
    Description:
    Write a program that replaces in a HTML document given as string all the tags 
    <a href="…">…</a> with corresponding tags [URL=…](…/URL).
    
    Input:
    On the only input line you will receive a string
    
    Output:
    Print the string with replaced tags
*/

using System;
using System.Text;

public class Startup
{
    public static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder modifiedText = new StringBuilder();
        string url = string.Empty;
        string info = string.Empty;

        int startIndex = text.IndexOf("<a href=\"", 0);
        if (startIndex == -1)
        {
            modifiedText.Append(text);
        }
        else
        {
            modifiedText.Append(text.Substring(0, startIndex));
            int middleIndex = text.IndexOf("\">", startIndex + 9);
            int endIndex = text.IndexOf("</a>", middleIndex + 2);

            while (true)
            {
                url = "(" + text.Substring(startIndex + 9, middleIndex - (startIndex + 9)) + ")";
                info = "[" + text.Substring(middleIndex + 2, endIndex - (middleIndex + 2)) + "]";

                modifiedText.Append(info);
                modifiedText.Append(url);

                startIndex = text.IndexOf("<a href=\"", endIndex + 4);

                if (startIndex != -1)
                {
                    modifiedText.Append(text.Substring(endIndex + 4, startIndex - (endIndex + 4)));
                    middleIndex = text.IndexOf("\">", startIndex + 9);
                    endIndex = text.IndexOf("</a>", middleIndex + 2);
                }
                else
                {
                    break;
                }
            }

            modifiedText.Append(text.Substring(endIndex + 4));
        }

        Console.WriteLine(modifiedText.ToString());
    }
}

