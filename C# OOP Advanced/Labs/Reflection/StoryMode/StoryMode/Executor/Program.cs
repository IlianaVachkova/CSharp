﻿using Executor.Network;
using Executor.IO;
using Executor.Judge;
using Executor.Repository;
using Executor.Contracts;

namespace Executor
{
    public class Program
    {
        public static void Main()
        {                  
            IContentComparer tester = new Tester();
            IDownloadManager downloadManager = new DownloadManager();
            IDirectoryManager ioManager = new IOManager();
            IDatabase repo = new StudentsRepository(new RepositorySorter(), new RepositioryFilter());

            IInterpreter currentInterpreter = new CommandInterpreter(tester, repo, downloadManager, ioManager);
            IReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}