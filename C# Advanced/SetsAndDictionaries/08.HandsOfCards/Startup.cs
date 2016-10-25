/*
    You are given a sequence of people and for every person what cards he draws from the deck. 
    The input will be separate lines in the format: {personName}: {PT, PT, PT,… PT}
    Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) 
    is the type. The input ends when a "JOKER" is drawn. The name can contain any ASCII symbol 
    except ':'. The input will always be valid and in the format described, there is no need to check it.
    A single person cannot have more than one card with the same power and type, if he draws such a 
    card he discards it. The people are playing with multiple decks. Each card has a value that is 
    calculated by the power multiplied by the type. Powers 2 to 10 have the same value and J to A 
    are 11 to 14. Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).
    Finally print out the total value each player has in his hand in the format: {personName}: {value}
    
        Input:	                                Output:
        Pesho: 2C, 4H, 9H, AS, QS               Pesho: 167
        Slav: 3H, 10S, JC, KD, 5S, 10S          Slav: 175
        Peshoslav: QH, QC, QS, QD               Peshoslav: 197
        Slav: 6H, 7S, KC, KD, 5S, 10C 
        Peshoslav: QH, QC, JS, JD, JC
        Pesho: JD, JD, JD, JD, JD, JD
        JOKER	
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string line = Console.ReadLine();
        Dictionary<string, HashSet<int>> namesResults = new Dictionary<string, HashSet<int>>();
        string name = string.Empty;
        int type = 0;
        int power = 0;
        long points = 0;

        while (line != "JOKER")
        {
            string[] nameCards = line.Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries);
            string[] cards = nameCards[1].Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            name = nameCards[0];

            if (!namesResults.ContainsKey(name))
            {
                namesResults.Add(name, new HashSet<int>());
            }

            for (int i = 0; i < cards.Length; i++)
            {
                type = CardType(cards[i][cards[i].Length - 1]);

                if (cards[i].Length > 2)
                {
                    power = 10;
                }
                else
                {
                    power = CardPower(cards[i][0]);
                }

                namesResults[name].Add(type * power);
            }

            line = Console.ReadLine();
        }

        foreach (var kvp in namesResults)
        {
            points = 0;

            foreach (var value in kvp.Value)
            {
                points += value;
            }

            Console.WriteLine($"{kvp.Key}: {points}");
        }
    }

    public static int CardType(char type)
    {
        int result = 0;

        switch (type)
        {
            case 'S': result = 4; break;
            case 'H': result = 3; break;
            case 'D': result = 2; break;
            case 'C': result = 1; break;
        }

        return result;
    }

    public static int CardPower(char power)
    {
        int result = 0;
        int typeAsInt = power -'0';

        if (typeAsInt >= 2 && typeAsInt <= 9)
        {
            result = typeAsInt;
        }

        switch (power)
        {
            case 'J': result = 11; break;
            case 'Q': result = 12; break;
            case 'K': result = 13; break;
            case 'A': result = 14; break;
        }

        return result;
    }
}

