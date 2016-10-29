using System;
using System.Text;

namespace _4.EncryptTheMessage
{
    public class Startup
    {
        public static void Main()
        {
            int countMessages = 0;
            StringBuilder allMessagesInOne = new StringBuilder();

            bool canStartCounting = false;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "START" || command == "start")
                {
                    canStartCounting = true;
                    break;
                }
            }
            
            while (canStartCounting)
            {
                string command = Console.ReadLine();
                string result = string.Empty;

                if (command == "END" || command == "end")
                {
                    if (countMessages > 0)
                    {
                        Console.WriteLine("Total number of messages: {0}", countMessages);
                    }
                    else
                    {
                        Console.WriteLine("No messages sent.");
                    }

                    break;
                }

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    if ((command[i] >= 65 && command[i] <= 77) || (command[i] >= 97 && command[i] <= 109))
                    {
                        result += (char)(command[i] + 13);
                    }
                    else if ((command[i] >= 78 && command[i] <= 90) || (command[i] >= 110 && command[i] <= 122))
                    {
                        result += (char)(command[i] - 13);
                    }
                    else if (command[i] >= 48 && command[i] <= 57)
                    {
                        result += (char)command[i];
                    }
                    else
                    {
                        switch (command[i])
                        {
                            case ' ': result += '+'; break;
                            case '+': result += ' '; break;
                            case ',': result += '%'; break;
                            case '%': result += ','; break;
                            case '.': result += '&'; break;
                            case '&': result += '.'; break;
                            case '?': result += '#'; break;
                            case '#': result += '?'; break;
                            case '!': result += '$'; break;
                            case '$': result += '!'; break;
                        }
                    }
                }

                if (result != "")
                {
                    countMessages += 1;
                    allMessagesInOne.AppendLine(result);
                }
            }

            Console.WriteLine(allMessagesInOne);
        }
    }
}
