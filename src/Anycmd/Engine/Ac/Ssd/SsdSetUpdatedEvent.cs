﻿
namespace Anycmd.Engine.Ac.Ssd
{
    using Events;

    public class SsdSetUpdatedEvent: DomainEvent
    {
        public SsdSetUpdatedEvent(IAcSession acSession, SsdSetBase source, ISsdSetUpdateIo output)
            : base(acSession, source)
        {
            if (output == null)
            {
                throw new System.ArgumentNullException("output");
            }
            this.Output = output;
        }

        public ISsdSetUpdateIo Output { get; private set; }
    }
}