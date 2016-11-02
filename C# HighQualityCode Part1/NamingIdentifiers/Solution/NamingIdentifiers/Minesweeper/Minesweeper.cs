using System;
using System.Collections.Generic;

public class Minesweeper
{
    public static void Main()
    {
        string command = string.Empty;
        char[,] board = InitializeBoard();
        char[,] bombField = PutBombs();
        int playerScore = 0;
        bool isBombHit = false;
        List<Player> topScorers = new List<Player>(6);
        int fieldRow = 0;
        int fieldCol = 0;
        bool isNewGame = true;
        const int MaxScore = 35;
        bool isGameWon = false;

        do
        {
            if (isNewGame)
            {
                Console.WriteLine("Let's play Minesweeper. Try your luck finding out fields with no mines." +
                " 'top'command shows the rating, 'restart' starts a new game, 'exit' exits the game!");
                DrawBoard(board);
                isNewGame = false;
            }

            Console.Write("Enter row and column : ");
            command = Console.ReadLine().Trim();

            if (command.Length >= 3)
            {
                if (int.TryParse(command[0].ToString(), out fieldRow) &&
                int.TryParse(command[2].ToString(), out fieldCol) &&
                    fieldRow <= board.GetLength(0) && fieldCol <= board.GetLength(1))
                {
                    command = "turn";
                }
            }

            switch (command)
            {
                case "top":
                    MakeRating(topScorers);
                    break;
                case "restart":
                    board = InitializeBoard();
                    bombField = PutBombs();
                    DrawBoard(board);
                    isBombHit = false;
                    isNewGame = false;
                    break;
                case "exit":
                    Console.WriteLine("Thanks for playing!");
                    break;
                case "turn":
                    if (bombField[fieldRow, fieldCol] != '*')
                    {
                        if (bombField[fieldRow, fieldCol] == '-')
                        {
                            SetSurroundedBombsCount(board, bombField, fieldRow, fieldCol);
                            playerScore++;
                        }

                        if (MaxScore == playerScore)
                        {
                            isGameWon = true;
                        }
                        else
                        {
                            DrawBoard(board);
                        }
                    }
                    else
                    {
                        isBombHit = true;
                    }

                    break;
                default:
                    Console.WriteLine(
                        Environment.NewLine +
                        "Invalid command!" +
                        Environment.NewLine);
                    break;
            }

            if (isBombHit)
            {
                DrawBoard(bombField);
                Console.Write(Environment.NewLine + "You finished the game with {0} points. " + "Enter your name: ", playerScore);
                string name = Console.ReadLine();
                Player score = new Player(name, playerScore);

                if (topScorers.Count < 5)
                {
                    topScorers.Add(score);
                }
                else
                {
                    for (int index = 0; index < topScorers.Count; index++)
                    {
                        if (topScorers[index].Points < score.Points)
                        {
                            topScorers.Insert(index, score);
                            topScorers.RemoveAt(topScorers.Count - 1);
                            break;
                        }
                    }
                }

                topScorers.Sort((Player firstPlayer, Player secondPlayer) =>
                    secondPlayer.Name.CompareTo(firstPlayer.Name));
                topScorers.Sort((Player firstPlayer, Player secondPlayer)
                    => secondPlayer.Points.CompareTo(firstPlayer.Points));

                MakeRating(topScorers);

                board = InitializeBoard();
                bombField = PutBombs();
                playerScore = 0;
                isBombHit = false;
                isNewGame = true;
            }

            if (isGameWon)
            {
                Console.WriteLine(Environment.NewLine + "Congratulations! You won!");
                DrawBoard(bombField);
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Player score = new Player(name, playerScore);
                topScorers.Add(score);
                MakeRating(topScorers);
                board = InitializeBoard();
                bombField = PutBombs();
                playerScore = 0;
                isGameWon = false;
                isNewGame = true;
            }
        }
        while (command != "exit");
        Console.WriteLine("Made in Bulgaria!");
        Console.Read();
    }

    private static void MakeRating(List<Player> scoreList)
    {
        Console.WriteLine(Environment.NewLine +
            "Score:");
        if (scoreList.Count > 0)
        {
            for (int index = 0; index < scoreList.Count; index++)
            {
                Console.WriteLine("{0}. {1} --> {2} cells", index + 1, scoreList[index].Name, scoreList[index].Points);
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(
                "No players in the rating!" +
                Environment.NewLine);
        }
    }

    private static void SetSurroundedBombsCount(
        char[,] board, char[,] bombs, int row, int col)
    {
        char surroundedBombsCount = GetSurroundedBombsCount(bombs, row, col);
        bombs[row, col] = surroundedBombsCount;
        board[row, col] = surroundedBombsCount;
    }

    private static void DrawBoard(char[,] board)
    {
        int boardRows = board.GetLength(0);
        int boardColumns = board.GetLength(1);

        Console.WriteLine(Environment.NewLine + "    0 1 2 3 4 5 6 7 8 9");
        Console.WriteLine("   ---------------------");

        for (int row = 0; row < boardRows; row++)
        {
            Console.Write("{0} | ", row);
            for (int col = 0; col < boardColumns; col++)
            {
                Console.Write(string.Format("{0} ", board[row, col]));
            }

            Console.Write("|");
            Console.WriteLine();
        }

        Console.WriteLine(
            "   ---------------------" +
            Environment.NewLine);
    }

    private static char[,] InitializeBoard()
    {
        int boardRows = 5;
        int boardColumns = 10;
        char[,] board = new char[boardRows, boardColumns];

        for (int row = 0; row < boardRows; row++)
        {
            for (int col = 0; col < boardColumns; col++)
            {
                board[row, col] = '?';
            }
        }

        return board;
    }

    private static char[,] PutBombs()
    {
        int rows = 5;
        int cols = 10;
        char[,] board = new char[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                board[row, col] = '-';
            }
        }

        List<int> bombs = new List<int>();

        while (bombs.Count < 15)
        {
            Random randomGenerator = new Random();
            int rand = randomGenerator.Next(50);
            if (!bombs.Contains(rand))
            {
                bombs.Add(rand);
            }
        }

        foreach (int bomb in bombs)
        {
            int row = bomb / cols;
            int col = bomb % cols;

            if (col == 0 && bomb != 0)
            {
                row--;
                col = cols;
            }
            else
            {
                col++;
            }

            board[row, col - 1] = '*';
        }

        return board;
    }

    private static void PutSurroundedBombsCount(char[,] board)
    {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (board[row, col] != '*')
                {
                    char surroundedBombsCount = GetSurroundedBombsCount(board, row, col);
                    board[row, col] = surroundedBombsCount;
                }
            }
        }
    }

    private static char GetSurroundedBombsCount(char[,] board, int row, int col)
    {
        int surroundedBombsCount = 0;
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        if (row - 1 >= 0)
        {
            if (board[row - 1, col] == '*')
            {
                surroundedBombsCount++;
            }
        }

        if (row + 1 < rows)
        {
            if (board[row + 1, col] == '*')
            {
                surroundedBombsCount++;
            }
        }

        if (col - 1 >= 0)
        {
            if (board[row, col - 1] == '*')
            {
                surroundedBombsCount++;
            }
        }

        if (col + 1 < cols)
        {
            if (board[row, col + 1] == '*')
            {
                surroundedBombsCount++;
            }
        }

        if ((row - 1 >= 0) && (col - 1 >= 0))
        {
            if (board[row - 1, col - 1] == '*')
            {
                surroundedBombsCount++;
            }
        }

        if ((row - 1 >= 0) && (col + 1 < cols))
        {
            if (board[row - 1, col + 1] == '*')
            {
                surroundedBombsCount++;
            }
        }

        if ((row + 1 < rows) && (col - 1 >= 0))
        {
            if (board[row + 1, col - 1] == '*')
            {
                surroundedBombsCount++;
            }
        }

        if ((row + 1 < rows) && (col + 1 < cols))
        {
            if (board[row + 1, col + 1] == '*')
            {
                surroundedBombsCount++;
            }
        }

        return char.Parse(surroundedBombsCount.ToString());
    }
}