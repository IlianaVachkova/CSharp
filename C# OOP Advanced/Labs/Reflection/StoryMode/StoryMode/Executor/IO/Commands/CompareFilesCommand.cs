﻿using Executor.Exceptions;
using Executor.Contracts;
using Executor.Attributes;

namespace Executor.IO.Commands
{
    [Alias("cmp")]
    public class CompareFilesCommand : Command
    {
        [Inject]
        private IContentComparer tester;

        public CompareFilesCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 3)
            {
                throw new InvalidCommandException(this.Input);
            }

            string firstPath = this.Data[1];
            string secondPath = this.Data[2];

            this.tester.CompareContent(firstPath, secondPath);
        }
    }
}
