﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shriek.Events
{
    public class Event : IEvent<Guid>
    {
        public Guid AggregateId { get; set; }

        public int Version;
    }

    //public class Event<TAggregateId> : Event, IEvent<TAggregateId>
    //{
    //    public new TAggregateId Id { get; private set; }

    //    public new TAggregateId AggregateId { get; set; }
    //}
}