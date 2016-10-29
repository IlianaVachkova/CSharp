using System;

namespace _2.DetectiveBoev
{
    public class Startup
    {
        public static void Main()
        {
            string secretWord = Console.ReadLine();
            string encryptedMessage = Console.ReadLine();

            int maskEncrypted = 0;
            for (int i = 0; i < secretWord.Length; i++)
            {
                maskEncrypted += secretWord[i];
            }

            int mask = 0;
            while (true)
            {
                if (maskEncrypted < 10)
                {
                    break;
                }
                else
                {
                    mask = 0;
                    while (maskEncrypted / 10 > 0)
                    {
                        mask += maskEncrypted % 10;
                        maskEncrypted = maskEncrypted / 10;
                    }
                    mask += maskEncrypted;
                    maskEncrypted = mask;
                }
            }

            string result = string.Empty;
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if (encryptedMessage[i] % mask == 0)
                {
                    result = (char)(encryptedMessage[i] + mask) + result;
                }
                else if (encryptedMessage[i] % mask != 0)
                {
                    result = (char)(encryptedMessage[i] - mask) + result;
                }
            }

            Console.WriteLine(result);
        }
    }
}
