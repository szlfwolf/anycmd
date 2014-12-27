﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using InOuts;
    using Model;

    public class UpdateInfoGroupCommand : UpdateEntityCommand<IInfoGroupUpdateIo>, ISysCommand
    {
        public UpdateInfoGroupCommand(IInfoGroupUpdateIo input)
            : base(input)
        {

        }
    }
}