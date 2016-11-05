using Executor.Exceptions;
using Executor.Contracts;

namespace Executor.IO.Commands
{
    class DropDatabaseCommand : Command
    {
        public DropDatabaseCommand(string input, string[] data, IContentComparer tester, IDatabase repository, IDownloadManager downloadManager, IDirectoryManager ioManager) : base(input, data, tester, repository, downloadManager, ioManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 1)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.Repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
    }
}
