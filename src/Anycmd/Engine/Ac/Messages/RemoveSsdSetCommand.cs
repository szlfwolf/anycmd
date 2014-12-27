﻿
namespace Anycmd.Engine.Ac.Messages
{
    using Commands;
    using Model;
    using System;

    public class RemoveSsdSetCommand: RemoveEntityCommand, ISysCommand
    {
        public RemoveSsdSetCommand(Guid ssdSetId)
            : base(ssdSetId)
        {

        }
    }
}