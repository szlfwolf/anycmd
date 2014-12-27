﻿
namespace Anycmd.Engine.Ac.Messages
{
    using Commands;
    using InOuts;
    using Model;

    public class UpdatePositionCommand : UpdateEntityCommand<IPositionUpdateIo>, ISysCommand
    {
        public UpdatePositionCommand(IPositionUpdateIo input)
            : base(input)
        {

        }
    }
}