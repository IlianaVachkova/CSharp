﻿using Executor.Exceptions;
using Executor.Attributes;

namespace Executor.IO.Commands
{
    [Alias("mkdir")]
    public class MakeDirectoryCommand : Command
    {
        [Inject]
        private IOManager inputOutputManager;

        public MakeDirectoryCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string folderName = this.Data[1];
            this.inputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
}
