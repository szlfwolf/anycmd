﻿
namespace Anycmd.Engine.Ac.Messages
{
    using Commands;
    using Model;
    using System;

    public class RemoveDsdRoleCommand : RemoveEntityCommand, ISysCommand
    {
        public RemoveDsdRoleCommand(Guid dsdRoleId)
            : base(dsdRoleId)
        {

        }
    }
}