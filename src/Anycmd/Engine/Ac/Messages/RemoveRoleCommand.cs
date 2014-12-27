﻿
namespace Anycmd.Engine.Ac.Messages
{
    using Commands;
    using Model;
    using System;

    public class RemoveRoleCommand : RemoveEntityCommand, ISysCommand
    {
        public RemoveRoleCommand(Guid roleId)
            : base(roleId)
        {

        }
    }
}