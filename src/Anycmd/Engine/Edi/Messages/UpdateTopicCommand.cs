﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using InOuts;
    using Model;

    public class UpdateTopicCommand : UpdateEntityCommand<ITopicUpdateIo>, ISysCommand
    {
        public UpdateTopicCommand(ITopicUpdateIo input)
            : base(input)
        {

        }
    }
}