using System;
using System.Diagnostics;
using System.IO;

public class Program
{
    public static void Main()
    {
        // The file is deleted because it is too big
        var reader = new StreamReader("../../100MB.txt");
        var trie = new Trie();

        trie.Insert(reader.ReadToEnd());
        Stopwatch timer = new Stopwatch();
        timer.Start();

        trie.Search("game");
        
        timer.Stop();
        // 00:00:00.0005717 for 10MB file
        // if we put bigger file we we have OutOfMemoryException
        // we cannot put a bigger file in the memory
        Console.WriteLine(timer.Elapsed);
        reader.Close();
    }
}