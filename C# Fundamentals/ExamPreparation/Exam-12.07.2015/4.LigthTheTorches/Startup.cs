using System;

namespace _4.LigthTheTorches
{
    public class Startup
    {
        public static void Main()
        {
            int rooms = int.Parse(Console.ReadLine());
            string stringOfCharacters = Console.ReadLine();
            char[] basement = new char[rooms];

            int stringPositionCounter = 0;
            for (int i = 0; i < rooms; i++)
            {
                if (i % stringOfCharacters.Length == 0)
                {
                    stringPositionCounter = 0;
                    basement[i] = stringOfCharacters[stringPositionCounter];
                }
                else
                {
                    basement[i] = stringOfCharacters[stringPositionCounter];
                }
                stringPositionCounter += 1;
            }

            int currentPosition = 0;
            int nextPosition = 0;
            if (rooms > 1)
            {
                currentPosition = rooms / 2;
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] commandAsArr = command.Split(' ');
                string direction = commandAsArr[0];
                int roomsToJump = int.Parse(commandAsArr[1]);

                if (direction == "RIGHT")
                {
                    nextPosition = (currentPosition + roomsToJump) + 1;
                    if (nextPosition > rooms - 1)
                    {
                        nextPosition = rooms - 1;
                    }

                    if (basement[nextPosition] == 'L' && nextPosition != currentPosition)
                    {
                        basement[nextPosition] = 'D';
                    }
                    else if (basement[nextPosition] == 'D' && nextPosition != currentPosition)
                    {
                        basement[nextPosition] = 'L';
                    }
                    currentPosition = nextPosition;
                }
                else if (direction == "LEFT")
                {
                    nextPosition = (currentPosition - roomsToJump) - 1;
                    if (nextPosition < 0)
                    {
                        nextPosition = 0;
                    }

                    if (basement[nextPosition] == 'L' && nextPosition != currentPosition)
                    {
                        basement[nextPosition] = 'D';
                    }
                    else if (basement[nextPosition] == 'D' && nextPosition != currentPosition)
                    {
                        basement[nextPosition] = 'L';
                    }
                    currentPosition = nextPosition;
                }
            }

            long totalNumberOfPrays = 0;
            int darkRoomsCount = 0;
            for (int i = 0; i < rooms; i++)
            {
                if (basement[i] == 'D')
                {
                    darkRoomsCount += 1;
                }
            }

            totalNumberOfPrays = darkRoomsCount * 'D';
            Console.WriteLine(totalNumberOfPrays);
        }
    }
}
