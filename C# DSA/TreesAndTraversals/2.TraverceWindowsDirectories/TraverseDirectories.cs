using System;
using System.IO;

public class TraverseDirectories
{
    public static void Main()
    {
        var root = new DirectoryInfo("C:\\WINDOWS");
        TraverseDirectoriesDFS(root);
    }

    public static void TraverseDirectoriesDFS(DirectoryInfo root)
    {
        var directories = root.GetDirectories();
        foreach (var dir in directories)
        {
            try
            {
                var files = dir.GetFiles("*.exe");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
                TraverseDirectoriesDFS(dir);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }

        }
    }
}