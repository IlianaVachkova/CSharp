using System;
using System.IO;
using System.Collections.Generic;

public class Folder
{
    public string Name { get; set; }
    public long Size { get; set; }
    public List<File> Files { get; set; }
    public List<Folder> ChildFolders { get; set; }

    public Folder(string name)
    {
        this.Name = name;
        this.Files = new List<File>();
        this.ChildFolders = new List<Folder>();
    }

    public void TraverseFolderDFS(DirectoryInfo root)
    {
        try
        {
            var directories = root.GetDirectories();
            foreach (var dir in directories)
            {
                Folder currentFolder = new Folder(dir.Name);
                this.ChildFolders.Add(currentFolder);

                var files = dir.GetFiles();
                foreach (var file in files)
                {
                    File currentFile = new File(file.Name, file.Length);
                    this.Files.Add(currentFile);
                    currentFolder.Size += file.Length;
                }
                Console.WriteLine("Folder: {0}, Size: {1}",
                    currentFolder.Name, currentFolder.Size);
                TraverseFolderDFS(dir);
            }
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
    }
}