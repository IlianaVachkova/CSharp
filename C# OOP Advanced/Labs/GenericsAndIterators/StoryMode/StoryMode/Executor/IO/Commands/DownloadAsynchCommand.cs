using Executor.Exceptions;
using Executor.Contracts;

namespace Executor.IO.Commands
{
    public class DownloadAsynchCommand : Command
    {
        public DownloadAsynchCommand(string input, string[] data, IContentComparer tester,
            IDatabase repository, IDownloadManager downloadManager, IDirectoryManager ioManager)
            : base(input, data, tester, repository, downloadManager, ioManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string url = this.Data[1];
            this.DownloadManager.DownloadAsync(url);
        }
    }
}
