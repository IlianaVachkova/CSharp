using System;
using System.IO;

public class FilesAndFolders
{
    public static void Main()
    {
        // We print the result in file -> Look up in the folder where the project file is.
        var writer = new StreamWriter("..\\..\\ouput.txt");
        Console.SetOut(writer);

        var rootFolder = new Folder("Windows");
        var pathToRoot = new DirectoryInfo("C:\\" + rootFolder.Name);
        rootFolder.TraverseFolderDFS(pathToRoot);

        writer.Close();
    }
}