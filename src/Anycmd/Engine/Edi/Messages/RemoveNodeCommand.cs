﻿
namespace Anycmd.Engine.Edi.Messages
{
    using Commands;
    using Model;
    using System;

    public class RemoveNodeCommand : RemoveEntityCommand, ISysCommand
    {
        public RemoveNodeCommand(Guid nodeId)
            : base(nodeId)
        {

        }
    }
}